<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class perBilgi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(perBilgi))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgBilgi = New System.Windows.Forms.DataGridView()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCıkıs = New System.Windows.Forms.Button()
        Me.btnKayıt = New System.Windows.Forms.Button()
        Me.Ad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Maaş = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgBilgi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Elephant", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(152, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Personel Bilgi formu"
        '
        'dgBilgi
        '
        Me.dgBilgi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgBilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBilgi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ad, Me.Tc, Me.Maaş, Me.Column1, Me.Column2, Me.Column3})
        Me.dgBilgi.Location = New System.Drawing.Point(25, 79)
        Me.dgBilgi.Name = "dgBilgi"
        Me.dgBilgi.Size = New System.Drawing.Size(647, 192)
        Me.dgBilgi.TabIndex = 1
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "per kayıt.png")
        Me.ımageList1.Images.SetKeyName(1, "Çıkış per.jpg")
        '
        'btnCıkıs
        '
        Me.btnCıkıs.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnCıkıs.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnCıkıs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCıkıs.ImageKey = "Çıkış per.jpg"
        Me.btnCıkıs.ImageList = Me.ımageList1
        Me.btnCıkıs.Location = New System.Drawing.Point(392, 308)
        Me.btnCıkıs.Name = "btnCıkıs"
        Me.btnCıkıs.Size = New System.Drawing.Size(176, 58)
        Me.btnCıkıs.TabIndex = 2
        Me.btnCıkıs.Text = "Programdan Çık"
        Me.btnCıkıs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCıkıs.UseVisualStyleBackColor = False
        '
        'btnKayıt
        '
        Me.btnKayıt.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnKayıt.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKayıt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKayıt.ImageKey = "per kayıt.png"
        Me.btnKayıt.ImageList = Me.ımageList1
        Me.btnKayıt.Location = New System.Drawing.Point(71, 308)
        Me.btnKayıt.Name = "btnKayıt"
        Me.btnKayıt.Size = New System.Drawing.Size(159, 58)
        Me.btnKayıt.TabIndex = 2
        Me.btnKayıt.Text = "Kayıt İşlemleri"
        Me.btnKayıt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKayıt.UseVisualStyleBackColor = False
        '
        'Ad
        '
        Me.Ad.HeaderText = "Tc"
        Me.Ad.Name = "Ad"
        '
        'Tc
        '
        Me.Tc.HeaderText = "Ad"
        Me.Tc.Name = "Tc"
        '
        'Maaş
        '
        Me.Maaş.HeaderText = "Soyad"
        Me.Maaş.Name = "Maaş"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Tel"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Maaş"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Giriş"
        Me.Column3.Name = "Column3"
        '
        'perBilgi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(716, 388)
        Me.Controls.Add(Me.btnCıkıs)
        Me.Controls.Add(Me.btnKayıt)
        Me.Controls.Add(Me.dgBilgi)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "perBilgi"
        Me.Text = "Personel Bilgi"
        CType(Me.dgBilgi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgBilgi As DataGridView
    Friend WithEvents btnKayıt As Button
    Friend WithEvents ımageList1 As ImageList
    Friend WithEvents btnCıkıs As Button
    Friend WithEvents Ad As DataGridViewTextBoxColumn
    Friend WithEvents Tc As DataGridViewTextBoxColumn
    Friend WithEvents Maaş As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
