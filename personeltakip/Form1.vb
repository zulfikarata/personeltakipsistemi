Imports System.Windows.Forms

Public Class perKayıt
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        combo();
    End Sub

    Private Sub combo()
        Throw New NotImplementedException()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox4_(sender As Object, e As EventArgs) Handles txtTel.TextChanged

    End Sub

    Private Sub btnBilgi_Click(sender As Object, e As EventArgs) Handles btnBilgi.Click
        perBilgi.Show()

    End Sub

    Private Sub btnKayıt_Click(sender As Object, e As EventArgs) Handles btnKayıt.Click
        perKayıt.Show()
    End Sub

    If txtTc Then .Text = Nothing Or txtAd.Text = Nothing Or txtSoyad.Text = Nothing Then
        ErrorProvider.SetError(txtTc, "Gerekli alanlar boş geçilemez !!!")
        ErrorProvider1.SetError(txtAd, "Gerekli alanlar boş geçilemez !!!")
        ErrorProvider1.SetError(txtSoyad, "Gerekli alanlar boş geçilemez !!!")
        Else
        Dim soru As DialogResult
        soru = MessageBox.Show("Mesajınız gönderiliyor, işlemi onaylıyor musunuz ?", "Bilgileri Onaylama", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If soru = Windows.Forms.DialogResult.Yes Then
            mesajgonder()
        End If
    End Sub

    Private Sub btnCıkıs_Click(sender As Object, e As EventArgs) Handles btnCıkıs.Click
        Application.Exit();    
End Sub

    Private Sub btnPerCıkıs_Click(sender As Object, e As EventArgs) Handles btnPerCıkıs.Click
        perCıkıs.Show()
    End Sub

    Private Sub cmbMaas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMaas.SelectedIndexChanged
        cmbMaas.Items.Add("ayşe");
        cmbMaas.Items.Add("Fatma");

    End Sub
End Class
