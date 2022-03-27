Public Class perBilgi
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgBilgi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBilgi.CellContentClick
        dgBilgi.Rows.Add();
            dgBilgi.Rows[0].Cells[0].Value = 1;
            dgBilgi.Rows[0].Cells[1].Value = "Ali";
            dgBilgi.Rows[0].Cells[2].Value = "Can";
            dgBilgi.Rows[1].Cells[0].Value = 2;
            dgBilgi.Rows[1].Cells[1].Value = "Veli";
            dgBilgi.Rows[1].Cells[2].Value = "Yurt";

    End Sub

    Private Sub btnCıkıs_Click(sender As Object, e As EventArgs) Handles btnCıkıs.Click
        Me.Close()
    End Sub

    Private Sub btnKayıt_Click(sender As Object, e As EventArgs) Handles btnKayıt.Click
        perKayıt.Show()
    End Sub
End Class