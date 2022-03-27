<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class perCıkıs
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(perCıkıs))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbTc = New System.Windows.Forms.Label()
        Me.lbAd = New System.Windows.Forms.Label()
        Me.lbSoyad = New System.Windows.Forms.Label()
        Me.lbTel = New System.Windows.Forms.Label()
        Me.lbMaas = New System.Windows.Forms.Label()
        Me.lbGiris = New System.Windows.Forms.Label()
        Me.txtTc = New System.Windows.Forms.TextBox()
        Me.txtAd = New System.Windows.Forms.TextBox()
        Me.txtSoyad = New System.Windows.Forms.TextBox()
        Me.textTel = New System.Windows.Forms.TextBox()
        Me.txtGiris = New System.Windows.Forms.TextBox()
        Me.cmbMaas = New System.Windows.Forms.ComboBox()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.dgKayıtlar = New System.Windows.Forms.DataGridView()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.btnSol = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btnSag = New System.Windows.Forms.Button()
        Me.btnCıkıs = New System.Windows.Forms.Button()
        Me.btnKayıt = New System.Windows.Forms.Button()
        Me.btnPerCıkıs = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgKayıtlar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label1.Font = New System.Drawing.Font("Elephant", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(196, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Personel Çıkış İşlemleri"
        '
        'lbTc
        '
        Me.lbTc.AutoSize = True
        Me.lbTc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbTc.Location = New System.Drawing.Point(4, 85)
        Me.lbTc.Name = "lbTc"
        Me.lbTc.Size = New System.Drawing.Size(150, 19)
        Me.lbTc.TabIndex = 0
        Me.lbTc.Text = "Personel Tc Kimlik"
        '
        'lbAd
        '
        Me.lbAd.AutoSize = True
        Me.lbAd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbAd.Location = New System.Drawing.Point(120, 145)
        Me.lbAd.Name = "lbAd"
        Me.lbAd.Size = New System.Drawing.Size(34, 19)
        Me.lbAd.TabIndex = 0
        Me.lbAd.Text = "Adı"
        '
        'lbSoyad
        '
        Me.lbSoyad.AutoSize = True
        Me.lbSoyad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbSoyad.Location = New System.Drawing.Point(92, 203)
        Me.lbSoyad.Name = "lbSoyad"
        Me.lbSoyad.Size = New System.Drawing.Size(62, 19)
        Me.lbSoyad.TabIndex = 0
        Me.lbSoyad.Text = "Soyadı"
        '
        'lbTel
        '
        Me.lbTel.AutoSize = True
        Me.lbTel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbTel.Location = New System.Drawing.Point(12, 266)
        Me.lbTel.Name = "lbTel"
        Me.lbTel.Size = New System.Drawing.Size(142, 19)
        Me.lbTel.TabIndex = 0
        Me.lbTel.Text = "Telefon Numarası"
        '
        'lbMaas
        '
        Me.lbMaas.AutoSize = True
        Me.lbMaas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMaas.Location = New System.Drawing.Point(391, 88)
        Me.lbMaas.Name = "lbMaas"
        Me.lbMaas.Size = New System.Drawing.Size(57, 19)
        Me.lbMaas.TabIndex = 0
        Me.lbMaas.Text = "Maaşı "
        '
        'lbGiris
        '
        Me.lbGiris.AutoSize = True
        Me.lbGiris.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGiris.Location = New System.Drawing.Point(358, 142)
        Me.lbGiris.Name = "lbGiris"
        Me.lbGiris.Size = New System.Drawing.Size(90, 19)
        Me.lbGiris.TabIndex = 0
        Me.lbGiris.Text = "Giriş Tarihi"
        '
        'txtTc
        '
        Me.txtTc.Location = New System.Drawing.Point(181, 86)
        Me.txtTc.Name = "txtTc"
        Me.txtTc.Size = New System.Drawing.Size(137, 20)
        Me.txtTc.TabIndex = 1
        '
        'txtAd
        '
        Me.txtAd.Location = New System.Drawing.Point(181, 144)
        Me.txtAd.Name = "txtAd"
        Me.txtAd.Size = New System.Drawing.Size(137, 20)
        Me.txtAd.TabIndex = 1
        '
        'txtSoyad
        '
        Me.txtSoyad.Location = New System.Drawing.Point(181, 204)
        Me.txtSoyad.Name = "txtSoyad"
        Me.txtSoyad.Size = New System.Drawing.Size(137, 20)
        Me.txtSoyad.TabIndex = 1
        '
        'textTel
        '
        Me.textTel.Location = New System.Drawing.Point(181, 265)
        Me.textTel.Name = "textTel"
        Me.textTel.Size = New System.Drawing.Size(137, 20)
        Me.textTel.TabIndex = 1
        '
        'txtGiris
        '
        Me.txtGiris.Location = New System.Drawing.Point(460, 141)
        Me.txtGiris.Name = "txtGiris"
        Me.txtGiris.Size = New System.Drawing.Size(140, 20)
        Me.txtGiris.TabIndex = 1
        '
        'cmbMaas
        '
        Me.cmbMaas.FormattingEnabled = True
        Me.cmbMaas.Location = New System.Drawing.Point(460, 86)
        Me.cmbMaas.Name = "cmbMaas"
        Me.cmbMaas.Size = New System.Drawing.Size(140, 21)
        Me.cmbMaas.TabIndex = 2
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "per kayıt sil.jpg")
        Me.ımageList1.Images.SetKeyName(1, "per kayıt.png")
        Me.ımageList1.Images.SetKeyName(2, "Çıkış per.jpg")
        '
        'dgKayıtlar
        '
        Me.dgKayıtlar.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgKayıtlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgKayıtlar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.ad, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgKayıtlar.Location = New System.Drawing.Point(8, 375)
        Me.dgKayıtlar.Name = "dgKayıtlar"
        Me.dgKayıtlar.Size = New System.Drawing.Size(630, 143)
        Me.dgKayıtlar.TabIndex = 4
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(229, 343)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(59, 20)
        Me.TextBox6.TabIndex = 5
        '
        'btnSol
        '
        Me.btnSol.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnSol.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSol.Location = New System.Drawing.Point(150, 338)
        Me.btnSol.Name = "btnSol"
        Me.btnSol.Size = New System.Drawing.Size(58, 26)
        Me.btnSol.TabIndex = 6
        Me.btnSol.Text = "<"
        Me.btnSol.UseVisualStyleBackColor = False
        '
        'btn0
        '
        Me.btn0.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btn0.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn0.Location = New System.Drawing.Point(71, 338)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(60, 26)
        Me.btn0.TabIndex = 6
        Me.btn0.Text = "|<"
        Me.btn0.UseVisualStyleBackColor = False
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.SystemColors.Window
        Me.btn1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn1.Location = New System.Drawing.Point(386, 337)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(62, 27)
        Me.btn1.TabIndex = 6
        Me.btn1.Text = ">|"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btnSag
        '
        Me.btnSag.BackColor = System.Drawing.SystemColors.Window
        Me.btnSag.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSag.Location = New System.Drawing.Point(308, 337)
        Me.btnSag.Name = "btnSag"
        Me.btnSag.Size = New System.Drawing.Size(60, 27)
        Me.btnSag.TabIndex = 6
        Me.btnSag.Text = ">"
        Me.btnSag.UseVisualStyleBackColor = False
        '
        'btnCıkıs
        '
        Me.btnCıkıs.BackColor = System.Drawing.SystemColors.Window
        Me.btnCıkıs.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnCıkıs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCıkıs.ImageKey = "Çıkış per.jpg"
        Me.btnCıkıs.ImageList = Me.ımageList1
        Me.btnCıkıs.Location = New System.Drawing.Point(644, 375)
        Me.btnCıkıs.Name = "btnCıkıs"
        Me.btnCıkıs.Size = New System.Drawing.Size(122, 58)
        Me.btnCıkıs.TabIndex = 3
        Me.btnCıkıs.Text = "Çıkış"
        Me.btnCıkıs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCıkıs.UseVisualStyleBackColor = False
        '
        'btnKayıt
        '
        Me.btnKayıt.BackColor = System.Drawing.SystemColors.Window
        Me.btnKayıt.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKayıt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKayıt.ImageKey = "per kayıt.png"
        Me.btnKayıt.ImageList = Me.ımageList1
        Me.btnKayıt.Location = New System.Drawing.Point(644, 284)
        Me.btnKayıt.Name = "btnKayıt"
        Me.btnKayıt.Size = New System.Drawing.Size(122, 57)
        Me.btnKayıt.TabIndex = 3
        Me.btnKayıt.Text = "Kayıt İşlemleri"
        Me.btnKayıt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKayıt.UseVisualStyleBackColor = False
        '
        'btnPerCıkıs
        '
        Me.btnPerCıkıs.BackColor = System.Drawing.SystemColors.Window
        Me.btnPerCıkıs.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnPerCıkıs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPerCıkıs.ImageKey = "per kayıt sil.jpg"
        Me.btnPerCıkıs.ImageList = Me.ımageList1
        Me.btnPerCıkıs.Location = New System.Drawing.Point(644, 184)
        Me.btnPerCıkıs.Name = "btnPerCıkıs"
        Me.btnPerCıkıs.Size = New System.Drawing.Size(122, 59)
        Me.btnPerCıkıs.TabIndex = 3
        Me.btnPerCıkıs.Text = "Personel Çıkışını Yap"
        Me.btnPerCıkıs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPerCıkıs.UseVisualStyleBackColor = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Tc"
        Me.Column1.Name = "Column1"
        '
        'ad
        '
        Me.ad.HeaderText = "Ad"
        Me.ad.Name = "ad"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Soyad"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Tel"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Maaş"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Giriş"
        Me.Column5.Name = "Column5"
        '
        'perCıkıs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(812, 545)
        Me.Controls.Add(Me.btnSag)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btnSol)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.dgKayıtlar)
        Me.Controls.Add(Me.btnCıkıs)
        Me.Controls.Add(Me.btnKayıt)
        Me.Controls.Add(Me.btnPerCıkıs)
        Me.Controls.Add(Me.cmbMaas)
        Me.Controls.Add(Me.txtGiris)
        Me.Controls.Add(Me.textTel)
        Me.Controls.Add(Me.txtSoyad)
        Me.Controls.Add(Me.txtAd)
        Me.Controls.Add(Me.txtTc)
        Me.Controls.Add(Me.lbGiris)
        Me.Controls.Add(Me.lbMaas)
        Me.Controls.Add(Me.lbTel)
        Me.Controls.Add(Me.lbSoyad)
        Me.Controls.Add(Me.lbAd)
        Me.Controls.Add(Me.lbTc)
        Me.Controls.Add(Me.Label1)
        Me.Name = "perCıkıs"
        Me.Text = "Personel Çıkış"
        CType(Me.dgKayıtlar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbTc As Label
    Friend WithEvents lbAd As Label
    Friend WithEvents lbSoyad As Label
    Friend WithEvents lbTel As Label
    Friend WithEvents lbMaas As Label
    Friend WithEvents lbGiris As Label
    Friend WithEvents txtTc As TextBox
    Friend WithEvents txtAd As TextBox
    Friend WithEvents txtSoyad As TextBox
    Friend WithEvents textTel As TextBox
    Friend WithEvents txtGiris As TextBox
    Friend WithEvents cmbMaas As ComboBox
    Friend WithEvents btnPerCıkıs As Button
    Friend WithEvents btnKayıt As Button
    Friend WithEvents btnCıkıs As Button
    Friend WithEvents dgKayıtlar As DataGridView
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents btnSol As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btnSag As Button
    Friend WithEvents ımageList1 As ImageList
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents ad As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
