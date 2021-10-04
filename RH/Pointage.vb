Imports System.IO
Imports System.Data.SqlClient
Public Class Pointage
    Private Sub supp()

    End Sub
    Dim con As SqlConnection = New SqlConnection("Data Source=DELL-SERV7;Initial Catalog=RH;Integrated Security=True")
    Dim conn As SqlConnection = New SqlConnection("Data Source=DELL-SERV7;Initial Catalog=FPPM;Integrated Security=True")
    Public cmd As New SqlCommand

    Dim index As Integer = 0
    Dim table As New DataTable()
    Dim table1 As New DataTable()

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Label43.Text = MonthName(Now.Month)
            Label46.Text = Now.Year
            Label47.Text = Now.Date
            LabelAnnée.Text = Now.Year
            LabelMois.Text = Now.Month


            showData(index)
            afficher()
            dgv_styleRow()
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Public Sub showData(ByVal position As Integer)
        Try
            Dim command As New SqlCommand(" select * from Recrut.Adm  where CODE_STRUC = '" & role & "' ", con)
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(table)

            txtMatricule.Text = table.Rows(position)(0).ToString()
            txtSA.Text = table.Rows(position)(1).ToString()
            txtNcontrat.Text = table.Rows(position)(15).ToString()
            txtNom.Text = table.Rows(position)(2).ToString()
            txtPrenom.Text = table.Rows(position)(3).ToString()
            txtFonction.Text = table.Rows(position)(9).ToString()
            txtService.Text = table.Rows(position)(17).ToString()
            txtInitial.Text = table.Rows(position)(17).ToString()
            txtStr.Text = table.Rows(position)(18).ToString()
            cmbStatut.Text = table.Rows(position)(6).ToString()
            dateR.Text = table.Rows(position)(13).ToString()
            DateF.Text = table.Rows(position)(14).ToString()

            If Not IsDBNull(table.Rows(position)(42)) Then
                Dim picture() As Byte = CType(table.Rows(position)(42), Byte())
                Dim ms As New MemoryStream(picture)
                txtphoto.Image = Image.FromStream(ms)
            Else
                '   MsgBox("il ne y'a pas de photo", MsgBoxStyle.Exclamation, "remarque")
                txtphoto.Image = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            index = 0
            showData(index)
            afficher()
            afficher1()
            dgv_styleRow()
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub BTN_previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_previous.Click
        Try
            index -= 1

            If index < 0 Then
                index = 0
            End If

            showData(index)
            afficher()
            dgv_styleRow()
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub BTN_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_next.Click
        Try
            index += 1

            If index > table.Rows.Count() - 1 Then

                index = table.Rows.Count() - 1
            End If

            showData(index)
            afficher()
            dgv_styleRow()
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub BTN_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_last.Click
        Try
            index = table.Rows.Count() - 1
            showData(index)
            afficher()
            dgv_styleRow()
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        supp()
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim firstday As DateTime = New Date(DateTime.Now.Year, DateTime.Now.Month, 1)

        MsgBox(firstday.ToString())

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Liste_Agent.Show()
    End Sub

   
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
               For i As Integer = 0 To DataGridView1.Rows.Count() - 2
                Dim cmd1 As SqlCommand = New SqlCommand(" select Annule from  Common.V_Union_Aff_Str where Code_Affaire = '" & DataGridView1.Rows(i).Cells(0).Value & "' ", conn)

                Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd1)
                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)

                If dt.Rows(0).Item(0).ToString = "C" Then
                    affect = affect + 1
                Else

                End If

                If affect > 0 Then
                    MessageBox.Show("Code Affaire Cloturé")
                    affect = 0
                    'End If

                ElseIf MsgBox("voulez vous vraiment Enregistrer ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then

                    con1.Open()
                    cmd.CommandText = "insert into Analytic.Pointage values('" & DataGridView1.Rows(i).Cells(1).Value & "','" & DataGridView1.Rows(i).Cells(0).Value & "','" & DataGridView1.Rows(i).Cells(3).Value & "','" & DataGridView1.Rows(i).Cells(5).Value & "','" & LoginForm1.txtuser.Text & "','" & Now.Date & "')"
                    cmd.Connection = con1
                    cmd.ExecuteNonQuery()
                    MsgBox("Enregistrer avec succès :)")
                    con1.Close()
                    dgv_styleRow()

                    'supp()
                    'Next
                End If

            Next

        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Public Sub afficher()
        Try
            Dim cmd1 As New SqlCommand("select * from Gestion.V_ControleAcces where Matricule = '" & txtMatricule.Text & "' and day(Date) between '" & Now.Day - 15 & "' and '" & Now.Day & "' and month(Date) = '" & Now.Month & "' and year(Date) = '" & Now.Year & "'", con)

            Dim da As New SqlDataAdapter
           da.SelectCommand = cmd1
            Dim table1 As New DataTable
            da.Fill(table1)
            DataGridView1.DataSource = table1
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
    Sub dgv_styleRow()

        For i As Integer = 0 To DataGridView1.RowCount - 1

            If i Mod 2 = 0 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.AliceBlue

            Else
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
            End If

        Next
    End Sub

    Public Sub afficher1()
        Try
            For i As Integer = 0 To DataGridView1.Rows.Count() - 2
                Dim cmd1 As New SqlCommand("select Code_Struc from Analytic.Pointage where Matricule = '" & txtMatricule.Text & "' and day(Date_Saisie) between '" & Now.Day - 15 & "' and '" & Now.Day - 7 & "' and Month(Date_Saisie) = '" & Now.Month & "' and year(Date_Saisie) = '" & Now.Year & "'", con1)

                Dim da As New SqlDataAdapter
                da.SelectCommand = cmd1
                Dim table1 As New DataTable
                da.Fill(table1)
                DataGridView1.DataSource.Rows(i).Cells(9) = table1
                ' DataGridView1.DataSource = table1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class