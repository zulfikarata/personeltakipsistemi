Public Class perCıkıs
    Private this As Object
    Public Property ErrorProvider1 As Object

    Private Sub frm3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCıkıs_Click(sender As Object, e As EventArgs) Handles btnCıkıs.Click
        Application.Exit()
    End Sub

    Private Sub dgKayıtlar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgKayıtlar.CellContentClick
        dgKayıtlar.Rows.Add();
            dgKayıtlar.Rows[0].Cells[0].Value = 1;
            dgKayıtlar.Rows[0].Cells[1].Value = "Ali";
            dgKayıtlar.Rows[0].Cells[2].Value = "Can";
            dgKayıtlar.Rows[1].Cells[0].Value = 2;
            dgKayıtlar.Rows[1].Cells[1].Value = "Veli";
            dgKayıtlar.Rows[1].Cells[2].Value = "Yurt";
    End Sub

    Private Sub btnKayıt_Click(sender As Object, e As EventArgs) Handles btnKayıt.Click
        perKayıt.Show()
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        this.BindingContext[perKayıt.dtst, "personel"].Position = 0;
            texteyaz();
    End Sub

    Private Sub btnSol_Click(sender As Object, e As EventArgs) Handles btnSol.Click
        this.BindingContext[perKayıt.dtst, "personel"].Position -= 1;
            texteyaz();
    End Sub

    Private Sub texteyaz()
        Throw New NotImplementedException()
    End Sub

    Private Sub btnSag_Click(sender As Object, e As EventArgs) Handles btnSag.Click
        this.BindingContext[perKayıt.dtst, "personel"].Position += 1;
            texteyaz();
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        this.BindingContext[perKayıt.dtst, "personel"].Position = this.BindingContext[frm1.dtst, "personel"].Count;
            texteyaz();
    End Sub

    Private Sub cmbMaas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMaas.SelectedIndexChanged
        cmbMaas.Items.Add("ayşe");
        cmbMaas.Items.Add("Fatma");

    End Sub

    Private Sub btnPerCıkıs_Click(sender As Object, e As EventArgs) Handles btnPerCıkıs.Click
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
End Class