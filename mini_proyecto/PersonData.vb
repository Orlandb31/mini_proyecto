Public Class PersonData
    Private gID As Integer
    Private gName As String = ""
    Private gDOB As String = ""
    Private gSSN As String = ""

    Public Property ID As Integer
        Get
            Return gID
        End Get
        Set(ByVal value As Integer)
            gID = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return gName
        End Get
        Set(ByVal value As String)
            gName = value
        End Set
    End Property

    Public Property DOB As String
        Get
            Return gDOB
        End Get
        Set(ByVal value As String)
            gDOB = value
        End Set
    End Property

    Public Property SSN As String
        Get
            Return gSSN
        End Get
        Set(ByVal value As String)
            gSSN = value
        End Set
    End Property
End Class
