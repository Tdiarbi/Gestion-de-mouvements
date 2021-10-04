Imports System.IO
Imports System.Data.SqlClient
Public Class Liste_Agent
    Sub dgv_styleRow()

        For i As Integer = 0 To DataGridView1.RowCount - 1

            If i Mod 2 = 0 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.AliceBlue

            Else
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
            End If
        Next

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        afficher()
             dgv_styleRow()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chercher.Click
        Try
            Dim cmd1 As New SqlCommand("select * from Recrut.Adm where DATE_ENT like '%'+@parm1+ '%' ", con)
            cmd1.Parameters.AddWithValue("@parm1", txtch.Text)
            Dim da As New SqlDataAdapter

            da.SelectCommand = cmd1
            Dim table1 As New DataTable
            table1.Clear()
            da.Fill(table1)
            DataGridView1.DataSource = table1
            dgv_styleRow()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)
            Pointage.txtMatricule.Text = selectedRow.Cells(0).Value.ToString()
            Pointage.txtSA.Text = selectedRow.Cells(1).Value.ToString()
            Pointage.txtNom.Text = selectedRow.Cells(2).Value.ToString()
            Pointage.txtPrenom.Text = selectedRow.Cells(3).Value.ToString()
            Pointage.txtFonction.Text = selectedRow.Cells(9).Value.ToString()
            Pointage.txtService.Text = selectedRow.Cells(17).Value.ToString()
            Pointage.txtInitial.Text = selectedRow.Cells(17).Value.ToString()
            Pointage.txtStr.Text = selectedRow.Cells(18).Value.ToString()
            Pointage.cmbStatut.Text = selectedRow.Cells(6).Value.ToString()
            Pointage.dateR.Text = selectedRow.Cells(13).Value.ToString()
            Pointage.DateF.Text = selectedRow.Cells(14).Value.ToString()
           
            If Not IsDBNull(selectedRow.Cells(42).Value) Then
                Dim picture() As Byte = CType(selectedRow.Cells(42).Value, Byte())
                Dim ms As New MemoryStream(picture)
                Pointage.txtphoto.Image = Image.FromStream(ms)
            Else
                '   MsgBox("il ne y'a pas de photo", MsgBoxStyle.Exclamation, "remarque")
                Pointage.txtphoto.Image = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("erreur")
        End Try
    End Sub

    Public Sub afficher()
        Try
            Dim cmd1 As New SqlCommand("select * from Recrut.Adm ", con)

            Dim da As New SqlDataAdapter

            da.SelectCommand = cmd1
            Dim table1 As New DataTable
            da.Fill(table1)
            DataGridView1.DataSource = table1
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class