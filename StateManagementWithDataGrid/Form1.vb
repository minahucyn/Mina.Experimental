Option Strict Off

Imports Newtonsoft.Json
Imports StateManagementWithDataGrid

Public Class Form1
    Private _viewModel As Form1ViewModel

    Public Sub New()

        InitializeComponent()
        _viewModel = New Form1ViewModel
        Me.DataGridView1.DataSource = _viewModel._dataSet.Tables(0)

        'events
        AddHandler DataGridView1.RowsAdded, AddressOf OnRowAdded
        AddHandler DataGridView1.RowValidated, AddressOf OnRowValidated
        AddHandler DataGridView1.CellValueChanged, AddressOf OnCellValueChanged
        AddHandler DataGridView1.CurrentCellDirtyStateChanged, AddressOf ManageCheckBoxCells
        AddHandler DataGridView1.DataError, AddressOf OnDataError


    End Sub

    Private Sub OnDataError(sender As Object, e As DataGridViewDataErrorEventArgs)
        'handle invalid birthdate
        If e.Exception.Message.Contains("DateTime") Then
            MsgBox("The bithdate entered is invalid. Please correct it and try again!")
        End If
    End Sub

    Private Sub ManageCheckBoxCells(sender As Object, e As EventArgs)

        If DataGridView1.Columns("IsAsian").Index <> DataGridView1.CurrentCell.ColumnIndex Then Return

        If DataGridView1.IsCurrentCellDirty Then
            DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub OnCellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
        Dim ColumnCount = _viewModel._dataSet.Tables(0).Columns.Count
        Try
            Dim allData = _viewModel._dataSet.Tables(0).Rows(e.RowIndex)

            _viewModel.UpdateRecord(New Person() With {
                                    .Id = allData.ItemArray(0),
                                    .FirstName = allData.ItemArray(1),
                                    .LastName = allData.ItemArray(2),
                                    .Birthdate = allData.ItemArray(3),
                                    .IsAsian = allData.ItemArray(4)})

        Catch ex As IndexOutOfRangeException
        Catch ex As Exception

        End Try

    End Sub

    Private Sub OnRowValidated(sender As Object, e As DataGridViewCellEventArgs)
        Dim newRowInfo = JsonConvert.SerializeObject(e)
        Debug.WriteLine($"New Row Validated: {newRowInfo}")

        Try
            Dim allData = _viewModel._dataSet.Tables(0).Rows(e.RowIndex)

            If allData.RowState = DataRowState.Added Then
                Dim person = New PersonInsertModel() With {
                .FirstName = allData.ItemArray(1),
                .LastName = allData.ItemArray(2),
                .Birthdate = allData.ItemArray(3),
                .IsAsian = allData.ItemArray(4)}

                _viewModel.InsertRecord(person)
            End If
        Catch ex As InvalidCastException
        Catch ex As Exception
        End Try


    End Sub

    Private Sub OnRowAdded(sender As Object, e As DataGridViewRowsAddedEventArgs)
        Dim newRowInfo = JsonConvert.SerializeObject(e)
        Debug.WriteLine($"New Row Added: {newRowInfo}")
    End Sub
End Class

