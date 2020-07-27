Option Strict Off

Public Class PersonInsertModel

    Public Property FirstName As String
    Public Property LastName As String
    Public Property Birthdate As String
    Public Property IsAsian As Boolean

    Public Shared Function GetPersonInsertModel(person As Person) As PersonInsertModel
        If person Is Nothing Then Return New PersonInsertModel
        Return New PersonInsertModel() With
            {
                .FirstName = person.FirstName,
                .LastName = person.LastName,
                .Birthdate = person.Birthdate,
                .IsAsian = person.IsAsian
            }
    End Function
End Class