Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Newtonsoft.Json

Public Class Form1ViewModel
    Public _dataSet As DataSet
    Dim _connection As SqlConnection
    Dim _dataAdapter As SqlDataAdapter
    Public Sub New()
        People = New BindingList(Of Person)
        _dataSet = New DataSet()
        _connection = New SqlConnection("Server=(LocalDB)\MSSQLLocalDB;Database=ExperimentalData;Trusted_Connection=True;")
        _dataAdapter = New SqlDataAdapter()

        AddHandler People.AddingNew, AddressOf OnAddingNew
        AddHandler People.ListChanged, AddressOf OnListChanged
        QueryAllPeople()
    End Sub

    Private Sub OnListChanged(sender As Object, e As ListChangedEventArgs)
        Debug.WriteLine("OnListChanged: " & JsonConvert.SerializeObject(e))
    End Sub

    Private Sub OnAddingNew(sender As Object, e As AddingNewEventArgs)
        Debug.WriteLine("OnListChanged: " & JsonConvert.SerializeObject(e.NewObject))
    End Sub

    Public Property People As BindingList(Of Person)
    Private Sub QueryAllPeople()
        _dataAdapter.SelectCommand = New SqlCommand("[dbo].[usp_SelectAllPeople]", _connection) With {.CommandType = CommandType.StoredProcedure}
        _dataSet.Clear()
        _dataAdapter.Fill(_dataSet)
        UpdatePeopleList()
    End Sub

    Private Sub UpdatePeopleList()
        People.Clear()
        Dim dataTable = _dataSet.Tables(0)
        For Each item In dataTable.AsEnumerable
            Dim person As New Person() With {
                .Id = item.ItemArray(0),
                .FirstName = item.ItemArray(1),
                .LastName = item.ItemArray(2),
                .Birthdate = item.ItemArray(3),
                .IsAsian = item.ItemArray(4)
            }
            People.Add(person)
        Next
    End Sub
    Public Sub InsertRecord(person As PersonInsertModel)
        _dataAdapter.InsertCommand = New SqlCommand("usp_InsertPerson", _connection) With {
            .CommandType = CommandType.StoredProcedure}
        _dataAdapter.InsertCommand.Parameters.Add(New SqlParameter("FirstName", person.FirstName))
        _dataAdapter.InsertCommand.Parameters.Add(New SqlParameter("LastName", person.LastName))
        _dataAdapter.InsertCommand.Parameters.Add(New SqlParameter("Birthdate", person.Birthdate))
        _dataAdapter.InsertCommand.Parameters.Add(New SqlParameter("IsAsian", person.IsAsian))

        Try
            _connection.Open()
            _dataAdapter.InsertCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            _connection.Close()
            QueryAllPeople()

        End Try
    End Sub

    Public Sub UpdateRecord(person As Person)
        _dataAdapter.UpdateCommand = New SqlCommand("usp_UpdatePerson", _connection) With {
            .CommandType = CommandType.StoredProcedure}

        _dataAdapter.UpdateCommand.Parameters.Add(New SqlParameter("Id", person.Id))
        _dataAdapter.UpdateCommand.Parameters.Add(New SqlParameter("FirstName", person.FirstName))
        _dataAdapter.UpdateCommand.Parameters.Add(New SqlParameter("LastName", person.LastName))
        _dataAdapter.UpdateCommand.Parameters.Add(New SqlParameter("Birthdate", person.Birthdate))
        _dataAdapter.UpdateCommand.Parameters.Add(New SqlParameter("IsAsian", person.IsAsian))

        Try
            _connection.Open()
            _dataAdapter.UpdateCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            _connection.Close()
            QueryAllPeople()

        End Try
    End Sub
End Class
