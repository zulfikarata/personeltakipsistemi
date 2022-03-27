<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class perKayıt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(perKayıt))
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
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.cmbGiris = New System.Windows.Forms.TextBox()
        Me.cmbMaas = New System.Windows.Forms.ComboBox()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCıkıs = New System.Windows.Forms.Button()
        Me.btnPerCıkıs = New System.Windows.Forms.Button()
        Me.btnBilgi = New System.Windows.Forms.Button()
        Me.btnKayıt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Elephant", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(180, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Personel Kayıt Formu"
        '
        'lbTc
        '
        Me.lbTc.AutoSize = True
        Me.lbTc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbTc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbTc.Location = New System.Drawing.Point(12, 79)
        Me.lbTc.Name = "lbTc"
        Me.lbTc.Size = New System.Drawing.Size(150, 19)
        Me.lbTc.TabIndex = 1
        Me.lbTc.Text = "Personel Tc Kimlik"
        '
        'lbAd
        '
        Me.lbAd.AutoSize = True
        Me.lbAd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbAd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbAd.Location = New System.Drawing.Point(128, 143)
        Me.lbAd.Name = "lbAd"
        Me.lbAd.Size = New System.Drawing.Size(34, 19)
        Me.lbAd.TabIndex = 1
        Me.lbAd.Text = "Adı"
        '
        'lbSoyad
        '
        Me.lbSoyad.AutoSize = True
        Me.lbSoyad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbSoyad.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbSoyad.Location = New System.Drawing.Point(100, 207)
        Me.lbSoyad.Name = "lbSoyad"
        Me.lbSoyad.Size = New System.Drawing.Size(62, 19)
        Me.lbSoyad.TabIndex = 1
        Me.lbSoyad.Text = "Soyadı"
        '
        'lbTel
        '
        Me.lbTel.AutoSize = True
        Me.lbTel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbTel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbTel.Location = New System.Drawing.Point(20, 272)
        Me.lbTel.Name = "lbTel"
        Me.lbTel.Size = New System.Drawing.Size(142, 19)
        Me.lbTel.TabIndex = 1
        Me.lbTel.Text = "Telefon Numarası"
        '
        'lbMaas
        '
        Me.lbMaas.AutoSize = True
        Me.lbMaas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbMaas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbMaas.Location = New System.Drawing.Point(364, 79)
        Me.lbMaas.Name = "lbMaas"
        Me.lbMaas.Size = New System.Drawing.Size(96, 19)
        Me.lbMaas.TabIndex = 1
        Me.lbMaas.Text = "Maaş Tutarı"
        '
        'lbGiris
        '
        Me.lbGiris.AutoSize = True
        Me.lbGiris.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbGiris.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbGiris.Location = New System.Drawing.Point(370, 133)
        Me.lbGiris.Name = "lbGiris"
        Me.lbGiris.Size = New System.Drawing.Size(90, 19)
        Me.lbGiris.TabIndex = 1
        Me.lbGiris.Text = "Giriş Tarihi"
        '
        'txtTc
        '
        Me.txtTc.Location = New System.Drawing.Point(173, 78)
        Me.txtTc.Name = "txtTc"
        Me.txtTc.Size = New System.Drawing.Size(127, 20)
        Me.txtTc.TabIndex = 2
        '
        'txtAd
        '
        Me.txtAd.Location = New System.Drawing.Point(173, 142)
        Me.txtAd.Name = "txtAd"
        Me.txtAd.Size = New System.Drawing.Size(127, 20)
        Me.txtAd.TabIndex = 2
        '
        'txtSoyad
        '
        Me.txtSoyad.Location = New System.Drawing.Point(173, 208)
        Me.txtSoyad.Name = "txtSoyad"
        Me.txtSoyad.Size = New System.Drawing.Size(127, 20)
        Me.txtSoyad.TabIndex = 2
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(173, 273)
        Me.txtTel.Multiline = True
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(127, 20)
        Me.txtTel.TabIndex = 2
        '
        'cmbGiris
        '
        Me.cmbGiris.Location = New System.Drawing.Point(483, 132)
        Me.cmbGiris.Name = "cmbGiris"
        Me.cmbGiris.Size = New System.Drawing.Size(140, 20)
        Me.cmbGiris.TabIndex = 2
        '
        'cmbMaas
        '
        Me.cmbMaas.FormattingEnabled = True
        Me.cmbMaas.Location = New System.Drawing.Point(483, 75)
        Me.cmbMaas.Name = "cmbMaas"
        Me.cmbMaas.Size = New System.Drawing.Size(140, 21)
        Me.cmbMaas.TabIndex = 3
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "per kayıt.png")
        Me.ımageList1.Images.SetKeyName(1, "per bilgi.png")
        Me.ımageList1.Images.SetKeyName(2, "per kayıt sil.jpg")
        Me.ımageList1.Images.SetKeyName(3, "Çıkış per.jpg")
        Me.ımageList1.Images.SetKeyName(4, "kayıt2.png")
        '
        'btnCıkıs
        '
        Me.btnCıkıs.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnCıkıs.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnCıkıs.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnCıkıs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCıkıs.ImageKey = "Çıkış per.jpg"
        Me.btnCıkıs.ImageList = Me.ımageList1
        Me.btnCıkıs.Location = New System.Drawing.Point(525, 338)
        Me.btnCıkıs.Name = "btnCıkıs"
        Me.btnCıkıs.Size = New System.Drawing.Size(107, 48)
        Me.btnCıkıs.TabIndex = 4
        Me.btnCıkıs.Text = "Çıkış"
        Me.btnCıkıs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCıkıs.UseVisualStyleBackColor = False
        '
        'btnPerCıkıs
        '
        Me.btnPerCıkıs.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnPerCıkıs.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnPerCıkıs.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnPerCıkıs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPerCıkıs.ImageKey = "per kayıt sil.jpg"
        Me.btnPerCıkıs.ImageList = Me.ımageList1
        Me.btnPerCıkıs.Location = New System.Drawing.Point(368, 338)
        Me.btnPerCıkıs.Name = "btnPerCıkıs"
        Me.btnPerCıkıs.Size = New System.Drawing.Size(123, 48)
        Me.btnPerCıkıs.TabIndex = 4
        Me.btnPerCıkıs.Text = "Personel Çıkış"
        Me.btnPerCıkıs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPerCıkıs.UseVisualStyleBackColor = False
        '
        'btnBilgi
        '
        Me.btnBilgi.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnBilgi.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnBilgi.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnBilgi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBilgi.ImageKey = "kayıt2.png"
        Me.btnBilgi.ImageList = Me.ımageList1
        Me.btnBilgi.Location = New System.Drawing.Point(214, 338)
        Me.btnBilgi.Name = "btnBilgi"
        Me.btnBilgi.Size = New System.Drawing.Size(132, 48)
        Me.btnBilgi.TabIndex = 4
        Me.btnBilgi.Text = "Personel Bilgileri"
        Me.btnBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBilgi.UseVisualStyleBackColor = False
        '
        'btnKayıt
        '
        Me.btnKayıt.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnKayıt.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKayıt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnKayıt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKayıt.ImageKey = "per kayıt.png"
        Me.btnKayıt.ImageList = Me.ımageList1
        Me.btnKayıt.Location = New System.Drawing.Point(56, 338)
        Me.btnKayıt.Name = "btnKayıt"
        Me.btnKayıt.Size = New System.Drawing.Size(125, 48)
        Me.btnKayıt.TabIndex = 4
        Me.btnKayıt.Text = "Personel Kayıt"
        Me.btnKayıt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKayıt.UseVisualStyleBackColor = False
        '
        'perKayıt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(762, 426)
        Me.Controls.Add(Me.btnCıkıs)
        Me.Controls.Add(Me.btnPerCıkıs)
        Me.Controls.Add(Me.btnBilgi)
        Me.Controls.Add(Me.btnKayıt)
        Me.Controls.Add(Me.cmbMaas)
        Me.Controls.Add(Me.cmbGiris)
        Me.Controls.Add(Me.txtTel)
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
        Me.Name = "perKayıt"
        Me.Text = "Personel Kayıt"
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
    Friend WithEvents txtTel As TextBox
    Friend WithEvents cmbGiris As TextBox
    Friend WithEvents cmbMaas As ComboBox
    Friend WithEvents btnKayıt As Button
    Friend WithEvents btnBilgi As Button
    Friend WithEvents btnPerCıkıs As Button
    Friend WithEvents btnCıkıs As Button
    Friend WithEvents ımageList1 As ImageList
End Class
