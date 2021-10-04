Imports System.Data.SqlClient
Module Module1
    Public user, role, role1 As String
    Public affect As Integer
    Public premier_jour_cal As String
    Public mois_cal As Integer
    Public annee_cal As Integer
    Public txtid As String
    Public con As SqlConnection = New SqlConnection("Data Source=DELL-SERV7;Initial Catalog=RH;Integrated Security=True")
    Public connn As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=Pointage;Integrated Security=True")
    Public con1 As SqlConnection = New SqlConnection("Data Source=DELL-SERV7;Initial Catalog=Analytique;Integrated Security=True")

    Public cmd As New SqlCommand
    Public cmd1 As New SqlCommand
End Module
