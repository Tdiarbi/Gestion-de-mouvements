Imports System.Data.SqlClient
Public Class LoginForm1

    ' TODO : insérez le code pour effectuer une authentification personnalisée à l'aide du nom d'utilisateur et du mot de passe fournis 
    ' (Voir http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' L'objet Principal personnalisé peut ensuite être associé à l'objet Principal du thread actuel comme suit : 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' CustomPrincipal est l'implémentation IPrincipal utilisée pour effectuer l'authentification. 
    ' Par la suite, My.User retournera les informations d'identité encapsulées dans l'objet CustomPrincipal
    ' telles que le nom d'utilisateur, le nom complet, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=DELL-SERV7;Initial Catalog=RH;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from Recrut.Adm  where Nom = '" & txtuser.Text & "' and prenom = '" & txtpass.Text & "'", con)

        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then

            role = dt.Rows(0).Item(1).ToString


            'MsgBox(role)

            Principale.ShowDialog()

            Me.Hide()

           
        Else
            MessageBox.Show("erreur")
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        With CheckBox1
            If .Checked Then
                txtpass.UseSystemPasswordChar = False
            Else
                txtpass.UseSystemPasswordChar = True
            End If
        End With
    End Sub
End Class