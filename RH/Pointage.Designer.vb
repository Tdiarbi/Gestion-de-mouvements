<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pointage
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LabelMois = New System.Windows.Forms.Label
        Me.LabelAnnée = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.LabelMoi = New System.Windows.Forms.Label
        Me.LabelAnné = New System.Windows.Forms.Label
        Me.LabelDate = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.BTN_next = New System.Windows.Forms.Button
        Me.txtid = New System.Windows.Forms.TextBox
        Me.BTN_last = New System.Windows.Forms.Button
        Me.BTN_previous = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtphoto = New System.Windows.Forms.PictureBox
        Me.DateF = New System.Windows.Forms.DateTimePicker
        Me.dateR = New System.Windows.Forms.DateTimePicker
        Me.LabelDF = New System.Windows.Forms.Label
        Me.txtStr = New System.Windows.Forms.TextBox
        Me.LabelStr = New System.Windows.Forms.Label
        Me.txtInitial = New System.Windows.Forms.TextBox
        Me.Labelinitial = New System.Windows.Forms.Label
        Me.txtSA = New System.Windows.Forms.TextBox
        Me.LabelSA = New System.Windows.Forms.Label
        Me.LabelDR = New System.Windows.Forms.Label
        Me.txtService = New System.Windows.Forms.TextBox
        Me.txtDepartement = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbStatut = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtNcontrat = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDirection = New System.Windows.Forms.TextBox
        Me.txtFonction = New System.Windows.Forms.TextBox
        Me.txtPrenom = New System.Windows.Forms.TextBox
        Me.txtNom = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtMatricule = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Code_Affaire = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtphoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LabelMois)
        Me.Panel2.Controls.Add(Me.LabelAnnée)
        Me.Panel2.Controls.Add(Me.Label47)
        Me.Panel2.Controls.Add(Me.LabelMoi)
        Me.Panel2.Controls.Add(Me.LabelAnné)
        Me.Panel2.Controls.Add(Me.LabelDate)
        Me.Panel2.Location = New System.Drawing.Point(789, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(188, 117)
        Me.Panel2.TabIndex = 1
        '
        'LabelMois
        '
        Me.LabelMois.AutoSize = True
        Me.LabelMois.Location = New System.Drawing.Point(67, 93)
        Me.LabelMois.Name = "LabelMois"
        Me.LabelMois.Size = New System.Drawing.Size(45, 13)
        Me.LabelMois.TabIndex = 5
        Me.LabelMois.Text = "Label49"
        '
        'LabelAnnée
        '
        Me.LabelAnnée.AutoSize = True
        Me.LabelAnnée.Location = New System.Drawing.Point(67, 51)
        Me.LabelAnnée.Name = "LabelAnnée"
        Me.LabelAnnée.Size = New System.Drawing.Size(45, 13)
        Me.LabelAnnée.TabIndex = 4
        Me.LabelAnnée.Text = "Label48"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(67, 13)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(45, 13)
        Me.Label47.TabIndex = 3
        Me.Label47.Text = "Label47"
        '
        'LabelMoi
        '
        Me.LabelMoi.AutoSize = True
        Me.LabelMoi.Location = New System.Drawing.Point(14, 94)
        Me.LabelMoi.Name = "LabelMoi"
        Me.LabelMoi.Size = New System.Drawing.Size(35, 13)
        Me.LabelMoi.TabIndex = 2
        Me.LabelMoi.Text = "Mois :"
        '
        'LabelAnné
        '
        Me.LabelAnné.AutoSize = True
        Me.LabelAnné.Location = New System.Drawing.Point(13, 51)
        Me.LabelAnné.Name = "LabelAnné"
        Me.LabelAnné.Size = New System.Drawing.Size(44, 13)
        Me.LabelAnné.TabIndex = 1
        Me.LabelAnné.Text = "Année :"
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Location = New System.Drawing.Point(13, 12)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(36, 13)
        Me.LabelDate.TabIndex = 0
        Me.LabelDate.Text = "Date :"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BTN_next)
        Me.Panel3.Controls.Add(Me.txtid)
        Me.Panel3.Controls.Add(Me.BTN_last)
        Me.Panel3.Controls.Add(Me.BTN_previous)
        Me.Panel3.Controls.Add(Me.Button8)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Location = New System.Drawing.Point(789, 188)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(191, 159)
        Me.Panel3.TabIndex = 2
        '
        'BTN_next
        '
        Me.BTN_next.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_next.Location = New System.Drawing.Point(120, 133)
        Me.BTN_next.Name = "BTN_next"
        Me.BTN_next.Size = New System.Drawing.Size(33, 23)
        Me.BTN_next.TabIndex = 5
        Me.BTN_next.Text = ">"
        Me.BTN_next.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(70, 135)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(50, 20)
        Me.txtid.TabIndex = 89
        Me.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtid.Visible = False
        '
        'BTN_last
        '
        Me.BTN_last.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_last.Location = New System.Drawing.Point(154, 133)
        Me.BTN_last.Name = "BTN_last"
        Me.BTN_last.Size = New System.Drawing.Size(33, 23)
        Me.BTN_last.TabIndex = 4
        Me.BTN_last.Text = ">|"
        Me.BTN_last.UseVisualStyleBackColor = True
        '
        'BTN_previous
        '
        Me.BTN_previous.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_previous.Location = New System.Drawing.Point(38, 133)
        Me.BTN_previous.Name = "BTN_previous"
        Me.BTN_previous.Size = New System.Drawing.Size(33, 23)
        Me.BTN_previous.TabIndex = 3
        Me.BTN_previous.Text = "<"
        Me.BTN_previous.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(3, 133)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(33, 23)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "|<"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(58, 81)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Recherche"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(58, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Fermer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtphoto)
        Me.GroupBox2.Controls.Add(Me.DateF)
        Me.GroupBox2.Controls.Add(Me.dateR)
        Me.GroupBox2.Controls.Add(Me.LabelDF)
        Me.GroupBox2.Controls.Add(Me.txtStr)
        Me.GroupBox2.Controls.Add(Me.LabelStr)
        Me.GroupBox2.Controls.Add(Me.txtInitial)
        Me.GroupBox2.Controls.Add(Me.Labelinitial)
        Me.GroupBox2.Controls.Add(Me.txtSA)
        Me.GroupBox2.Controls.Add(Me.LabelSA)
        Me.GroupBox2.Controls.Add(Me.LabelDR)
        Me.GroupBox2.Controls.Add(Me.txtService)
        Me.GroupBox2.Controls.Add(Me.txtDepartement)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cmbStatut)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtNcontrat)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtDirection)
        Me.GroupBox2.Controls.Add(Me.txtFonction)
        Me.GroupBox2.Controls.Add(Me.txtPrenom)
        Me.GroupBox2.Controls.Add(Me.txtNom)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtMatricule)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(768, 317)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ID AGENT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Nom"
        '
        'txtphoto
        '
        Me.txtphoto.Location = New System.Drawing.Point(622, 34)
        Me.txtphoto.Name = "txtphoto"
        Me.txtphoto.Size = New System.Drawing.Size(127, 136)
        Me.txtphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.txtphoto.TabIndex = 88
        Me.txtphoto.TabStop = False
        '
        'DateF
        '
        Me.DateF.CustomFormat = "yyyy/MM/dd"
        Me.DateF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateF.Location = New System.Drawing.Point(505, 106)
        Me.DateF.Name = "DateF"
        Me.DateF.Size = New System.Drawing.Size(100, 20)
        Me.DateF.TabIndex = 87
        '
        'dateR
        '
        Me.dateR.CustomFormat = "yyyy/MM/dd"
        Me.dateR.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateR.Location = New System.Drawing.Point(505, 64)
        Me.dateR.Name = "dateR"
        Me.dateR.Size = New System.Drawing.Size(100, 20)
        Me.dateR.TabIndex = 86
        '
        'LabelDF
        '
        Me.LabelDF.AutoSize = True
        Me.LabelDF.Location = New System.Drawing.Point(408, 103)
        Me.LabelDF.Name = "LabelDF"
        Me.LabelDF.Size = New System.Drawing.Size(62, 13)
        Me.LabelDF.TabIndex = 79
        Me.LabelDF.Text = "Date Fin de"
        '
        'txtStr
        '
        Me.txtStr.Location = New System.Drawing.Point(635, 270)
        Me.txtStr.Name = "txtStr"
        Me.txtStr.Size = New System.Drawing.Size(100, 20)
        Me.txtStr.TabIndex = 85
        '
        'LabelStr
        '
        Me.LabelStr.AutoSize = True
        Me.LabelStr.Location = New System.Drawing.Point(585, 273)
        Me.LabelStr.Name = "LabelStr"
        Me.LabelStr.Size = New System.Drawing.Size(20, 13)
        Me.LabelStr.TabIndex = 84
        Me.LabelStr.Text = "Str"
        '
        'txtInitial
        '
        Me.txtInitial.Location = New System.Drawing.Point(500, 270)
        Me.txtInitial.Name = "txtInitial"
        Me.txtInitial.Size = New System.Drawing.Size(50, 20)
        Me.txtInitial.TabIndex = 83
        '
        'Labelinitial
        '
        Me.Labelinitial.AutoSize = True
        Me.Labelinitial.Location = New System.Drawing.Point(427, 273)
        Me.Labelinitial.Name = "Labelinitial"
        Me.Labelinitial.Size = New System.Drawing.Size(37, 13)
        Me.Labelinitial.TabIndex = 82
        Me.Labelinitial.Text = "Initial :"
        '
        'txtSA
        '
        Me.txtSA.Location = New System.Drawing.Point(505, 150)
        Me.txtSA.Name = "txtSA"
        Me.txtSA.Size = New System.Drawing.Size(100, 20)
        Me.txtSA.TabIndex = 81
        '
        'LabelSA
        '
        Me.LabelSA.AutoSize = True
        Me.LabelSA.Location = New System.Drawing.Point(406, 153)
        Me.LabelSA.Name = "LabelSA"
        Me.LabelSA.Size = New System.Drawing.Size(91, 13)
        Me.LabelSA.TabIndex = 80
        Me.LabelSA.Text = "Strcucture/Affaire"
        '
        'LabelDR
        '
        Me.LabelDR.AutoSize = True
        Me.LabelDR.Location = New System.Drawing.Point(406, 64)
        Me.LabelDR.Name = "LabelDR"
        Me.LabelDR.Size = New System.Drawing.Size(94, 13)
        Me.LabelDR.TabIndex = 78
        Me.LabelDR.Text = "Date Recrutement"
        '
        'txtService
        '
        Me.txtService.Location = New System.Drawing.Point(108, 266)
        Me.txtService.Name = "txtService"
        Me.txtService.Size = New System.Drawing.Size(236, 20)
        Me.txtService.TabIndex = 77
        '
        'txtDepartement
        '
        Me.txtDepartement.Location = New System.Drawing.Point(108, 225)
        Me.txtDepartement.Name = "txtDepartement"
        Me.txtDepartement.Size = New System.Drawing.Size(362, 20)
        Me.txtDepartement.TabIndex = 76
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 273)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Service"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Departement"
        '
        'cmbStatut
        '
        Me.cmbStatut.FormattingEnabled = True
        Me.cmbStatut.Items.AddRange(New Object() {"C", "M"})
        Me.cmbStatut.Location = New System.Drawing.Point(505, 19)
        Me.cmbStatut.Name = "cmbStatut"
        Me.cmbStatut.Size = New System.Drawing.Size(45, 21)
        Me.cmbStatut.TabIndex = 73
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(449, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Statut"
        '
        'txtNcontrat
        '
        Me.txtNcontrat.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtNcontrat.Location = New System.Drawing.Point(315, 19)
        Me.txtNcontrat.Name = "txtNcontrat"
        Me.txtNcontrat.Size = New System.Drawing.Size(88, 20)
        Me.txtNcontrat.TabIndex = 71
        Me.txtNcontrat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(240, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "N°Contrat"
        '
        'txtDirection
        '
        Me.txtDirection.Location = New System.Drawing.Point(111, 185)
        Me.txtDirection.Name = "txtDirection"
        Me.txtDirection.Size = New System.Drawing.Size(362, 20)
        Me.txtDirection.TabIndex = 69
        '
        'txtFonction
        '
        Me.txtFonction.Location = New System.Drawing.Point(108, 143)
        Me.txtFonction.Name = "txtFonction"
        Me.txtFonction.Size = New System.Drawing.Size(236, 20)
        Me.txtFonction.TabIndex = 68
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(108, 99)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(236, 20)
        Me.txtPrenom.TabIndex = 67
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(108, 60)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(236, 20)
        Me.txtNom.TabIndex = 66
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Direction"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Fonction"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Prenom"
        '
        'txtMatricule
        '
        Me.txtMatricule.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtMatricule.ForeColor = System.Drawing.Color.Red
        Me.txtMatricule.Location = New System.Drawing.Point(108, 19)
        Me.txtMatricule.Name = "txtMatricule"
        Me.txtMatricule.Size = New System.Drawing.Size(100, 20)
        Me.txtMatricule.TabIndex = 62
        Me.txtMatricule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Matricule"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Location = New System.Drawing.Point(786, 361)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 270)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Controle"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(61, 115)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 35)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Enregistrer"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(114, 6)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(216, 29)
        Me.Label44.TabIndex = 1
        Me.Label44.Text = "Pointage du Mois"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label45.Location = New System.Drawing.Point(497, 6)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(87, 29)
        Me.Label45.TabIndex = 9
        Me.Label45.Text = "Année"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label43.Location = New System.Drawing.Point(362, 6)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(134, 29)
        Me.Label43.TabIndex = 0
        Me.Label43.Text = "LabelMois"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(595, 6)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(152, 29)
        Me.Label46.TabIndex = 10
        Me.Label46.Text = "LabelAnnée"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Code_Affaire})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 363)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(768, 270)
        Me.DataGridView1.TabIndex = 11
        '
        'Code_Affaire
        '
        Me.Code_Affaire.HeaderText = "Code Affaire"
        Me.Code_Affaire.Name = "Code_Affaire"
        '
        'Pointage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 645)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Pointage"
        Me.Text = "POINTAGE"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtphoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LabelMoi As System.Windows.Forms.Label
    Friend WithEvents LabelAnné As System.Windows.Forms.Label
    Friend WithEvents LabelDate As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BTN_next As System.Windows.Forms.Button
    Friend WithEvents BTN_last As System.Windows.Forms.Button
    Friend WithEvents BTN_previous As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtphoto As System.Windows.Forms.PictureBox
    Friend WithEvents DateF As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateR As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtStr As System.Windows.Forms.TextBox
    Friend WithEvents LabelStr As System.Windows.Forms.Label
    Friend WithEvents txtInitial As System.Windows.Forms.TextBox
    Friend WithEvents Labelinitial As System.Windows.Forms.Label
    Friend WithEvents txtSA As System.Windows.Forms.TextBox
    Friend WithEvents LabelSA As System.Windows.Forms.Label
    Friend WithEvents LabelDF As System.Windows.Forms.Label
    Friend WithEvents LabelDR As System.Windows.Forms.Label
    Friend WithEvents txtService As System.Windows.Forms.TextBox
    Friend WithEvents txtDepartement As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbStatut As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNcontrat As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDirection As System.Windows.Forms.TextBox
    Friend WithEvents txtFonction As System.Windows.Forms.TextBox
    Friend WithEvents txtPrenom As System.Windows.Forms.TextBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMatricule As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents LabelMois As System.Windows.Forms.Label
    Friend WithEvents LabelAnnée As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Code_Affaire As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
