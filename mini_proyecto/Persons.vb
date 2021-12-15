Public Class Persons
    Private gListOfPerson As List(Of PersonData)

    Public Property All As List(Of PersonData)
        Get

            If gListOfPerson Is Nothing Then
                gListOfPerson = New List(Of PersonData)()
            End If

            Return gListOfPerson
        End Get
        Set(ByVal value As List(Of PersonData))
            gListOfPerson = value
        End Set
    End Property
End Class
