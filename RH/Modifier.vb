Imports System.IO
Imports System.Data.SqlClient
Public Class Modifier

   
    Dim index As Integer = 0
    Dim table As New DataTable()
    Private Sub Modifier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            showData(index)
            afficher()
            d_styleRow()
            Label43.Text = MonthName(Now.Month)
            Label46.Text = Now.Year
            Label47.Text = Now.Date
            LabelAnnée.Text = Now.Year
            LabelMois.Text = Now.Month
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

    Private Sub BTN_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_next.Click
        Try
            index += 1

            If index > table.Rows.Count() - 1 Then

                index = table.Rows.Count() - 1
            End If

            showData(index)
            afficher()
            d_styleRow()
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
            d_styleRow()
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub BTN_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_last.Click
        Try
            index = table.Rows.Count() - 1
            showData(index)
            afficher()
            d_styleRow()
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            index = 0
            showData(index)
            afficher()
            d_styleRow()
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

   
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            If MsgBox("voulez vous vraiment Supprimer ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
               
                con1.Open()
                cmd.CommandText = " delete from Analytic.Pointage where Matricule = '" & txtMatricule.Text & "' and Date_Ptg = '" & txtid.Text & "'"
                cmd.Connection = con1
                cmd.ExecuteNonQuery()
                MsgBox("supprimer avec succès :)")
                con1.Close()
               
                afficher()
                d_styleRow()
            End If

        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Liste_Agent.Show()
    End Sub
    Public Sub afficher()
        Try
            Dim cmd1 As New SqlCommand("select * from Analytic.Pointage where Matricule = '" & txtMatricule.Text & "' and day(Date_Saisie) between '" & Now.Day - 15 & "' and '" & Now.Day & "' and Month(Date_Saisie) = '" & Now.Month & "' and year(Date_Saisie) = '" & Now.Year & "'", con1)

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd1
            Dim table1 As New DataTable
            da.Fill(table1)
            DataGridView1.DataSource = table1

        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try

            If MsgBox("voulez vous vraiment modifier ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
              

                con1.Open()
                For i As Integer = 0 To DataGridView1.Rows.Count() - 2

                    cmd.CommandText = "update Analytic.Pointage set Code_Struc = '" & DataGridView1.Rows(i).Cells(1).Value & "' where Date_Ptg = '" & txtid.Text & "'"
                    cmd.Connection = con1
                    cmd.ExecuteNonQuery()
                    MsgBox("Modifier avec succès :)")
                    con1.Close()
                    afficher()
                    d_styleRow()
                Next

            End If

        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
   
    Sub d_styleRow()

        For i As Integer = 0 To DataGridView1.RowCount - 1

            If i Mod 2 = 0 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.AliceBlue

            Else
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
            End If


        Next
    End Sub

    Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim index1 As Integer
            index1 = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index1)

            txtid.Text = selectedRow.Cells(3).Value.ToString
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
 
End Class