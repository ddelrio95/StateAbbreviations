Public Class Form1
    Private this As Object

    Private Sub Button1_virginia_Click(sender As Object, e As EventArgs) Handles Button1_virginia.Click
        lbl.Text = "VA"
    End Sub

    Private Sub Button4_georgia_Click(sender As Object, e As EventArgs) Handles Button4_georgia.Click
        lbl.Text = "GA"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_northCarolina_Click(sender As Object, e As EventArgs) Handles Button2_northCarolina.Click
        lbl.Text = "NC"
    End Sub

    Private Sub Button3_southcarolina_Click(sender As Object, e As EventArgs) Handles Button3_southcarolina.Click
        lbl.Text = "SC"
    End Sub

    Private Sub Button5_alabama_Click(sender As Object, e As EventArgs) Handles Button5_alabama.Click
        lbl.Text = "AL"
    End Sub

    Private Sub Button6_florida_Click(sender As Object, e As EventArgs) Handles Button6_florida.Click
        lbl.Text = "FL"
    End Sub

    Private Sub ext_Click(sender As Object, e As EventArgs) Handles ext.Click
        this.Close()
    End Sub

End Class

