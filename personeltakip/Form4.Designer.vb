<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.lbAd = New System.Windows.Forms.Label()
        Me.lbSifre = New System.Windows.Forms.Label()
        Me.txtAd = New System.Windows.Forms.TextBox()
        Me.txtSifre = New System.Windows.Forms.TextBox()
        Me.txtGiris = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbAd
        '
        Me.lbAd.AutoSize = True
        Me.lbAd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbAd.Location = New System.Drawing.Point(147, 77)
        Me.lbAd.Name = "lbAd"
        Me.lbAd.Size = New System.Drawing.Size(103, 19)
        Me.lbAd.TabIndex = 0
        Me.lbAd.Text = "Kullanıcı Adı"
        '
        'lbSifre
        '
        Me.lbSifre.AutoSize = True
        Me.lbSifre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbSifre.Location = New System.Drawing.Point(206, 135)
        Me.lbSifre.Name = "lbSifre"
        Me.lbSifre.Size = New System.Drawing.Size(44, 19)
        Me.lbSifre.TabIndex = 0
        Me.lbSifre.Text = "Şifre"
        '
        'txtAd
        '
        Me.txtAd.Location = New System.Drawing.Point(268, 76)
        Me.txtAd.Name = "txtAd"
        Me.txtAd.Size = New System.Drawing.Size(134, 20)
        Me.txtAd.TabIndex = 1
        '
        'txtSifre
        '
        Me.txtSifre.Location = New System.Drawing.Point(268, 134)
        Me.txtSifre.Name = "txtSifre"
        Me.txtSifre.Size = New System.Drawing.Size(134, 20)
        Me.txtSifre.TabIndex = 1
        '
        'txtGiris
        '
        Me.txtGiris.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtGiris.ImageKey = "kayıt1.jpg"
        Me.txtGiris.ImageList = Me.ımageList1
        Me.txtGiris.Location = New System.Drawing.Point(235, 192)
        Me.txtGiris.Name = "txtGiris"
        Me.txtGiris.Size = New System.Drawing.Size(101, 47)
        Me.txtGiris.TabIndex = 2
        Me.txtGiris.Text = "Giriş"
        Me.txtGiris.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtGiris.UseVisualStyleBackColor = True
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "kayıt1.jpg")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(189, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 31)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Personel Yönetici"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(608, 304)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtGiris)
        Me.Controls.Add(Me.txtSifre)
        Me.Controls.Add(Me.txtAd)
        Me.Controls.Add(Me.lbSifre)
        Me.Controls.Add(Me.lbAd)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbAd As Label
    Friend WithEvents lbSifre As Label
    Friend WithEvents txtAd As TextBox
    Friend WithEvents txtSifre As TextBox
    Friend WithEvents txtGiris As Button
    Friend WithEvents ımageList1 As ImageList
    Friend WithEvents Label3 As Label
End Class
