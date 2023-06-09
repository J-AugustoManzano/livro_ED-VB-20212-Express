Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim HT, VH, PD, SB, TD, SL As Double
        HT = TextBox1.Text
        VH = TextBox2.Text
        PD = TextBox3.Text
        SB = HT * VH
        TD = (PD / 100) * SB
        SL = SB - TD
        Label4.Text = SL
    End Sub
End Class
