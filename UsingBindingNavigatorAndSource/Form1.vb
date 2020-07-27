Imports UsingBindingNavigatorAndSource

Public Class Form1
    Private _viewModel As Form1ViewModel

    Public Sub New()
        InitializeComponent()
        _viewModel = New Form1ViewModel()
        InitializeBinding()
        AddHandler ToolStripButtonSave.Click, AddressOf SaveItem
    End Sub

    Private Sub SaveItem(sender As Object, e As EventArgs)
        Dim item As Person = BindingSource1.Current
        If item.Birthdate Is Nothing And Not String.IsNullOrEmpty(DateTimePicker1.Value) Then
            item.Birthdate = DateTimePicker1.Value
        End If
        If item.Id = 0 Then
            _viewModel.InsertRecord(PersonInsertModel.GetPersonInsertModel(item))
        End If
    End Sub

    Private Sub InitializeBinding()
        BindingSource1.DataSource = _viewModel.People
        DataGridView1.DataSource = BindingSource1

    End Sub
End Class
