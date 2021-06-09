Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim A, B, C, D As Integer
        Dim A1, A2, A3, A4, A5, A6 As Integer
        Dim M1, M2, M3, M4, M5, M6 As Integer

        A = TextBox1.Text
        B = TextBox2.Text
        C = TextBox3.Text
        D = TextBox4.Text

        A1 = A + B
        A2 = A + C
        A3 = A + D
        A4 = B + C
        A5 = B + D
        A6 = C + D

        M1 = A * B
        M2 = A * C
        M3 = A * D
        M4 = B * C
        M5 = B * D
        M6 = C * D

        Label1.Text = A1
        Label2.Text = A2
        Label3.Text = A3
        Label4.Text = A4
        Label5.Text = A5
        Label6.Text = A6

        Label7.Text = M1
        Label8.Text = M2
        Label9.Text = M3
        Label10.Text = M4
        Label11.Text = M5
        Label12.Text = M6

    End Sub
End Class
