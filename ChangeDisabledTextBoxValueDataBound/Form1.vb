Imports System.ComponentModel

Public Class Form1
    Private _viewModel As Form1ViewModel = New Form1ViewModel()
    Public Sub New()

        InitializeComponent()
        InitializeBinding()

        AddHandler ButtonChangeUnderlyingValue.Click, AddressOf ChangeUnderlyingValue

    End Sub

    Private Sub ChangeUnderlyingValue(sender As Object, e As EventArgs)
        _viewModel.ChangeTextBoxUnderlyingValue()
    End Sub

    Private Sub InitializeBinding()
        TextBoxTestDisabled.DataBindings.Add(New Binding("Text", _viewModel, NameOf(_viewModel.TextBoxValue)))
    End Sub
End Class

Public Class Form1ViewModel
    Implements INotifyPropertyChanged

    Private _textBoxValue As String
    Dim defaultUnderlyingValue As Integer = 1000
    Public Property TextBoxValue() As String
        Get
            Return _textBoxValue
        End Get
        Set(ByVal value As String)
            _textBoxValue = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(TextBoxValue)))
        End Set
    End Property

    Public Sub ChangeTextBoxUnderlyingValue()
        TextBoxValue = DefaultUnderlyingValue
        DefaultUnderlyingValue += 100

    End Sub

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
