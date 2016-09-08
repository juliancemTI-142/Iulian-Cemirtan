Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = Val(TextBox1.Text) - Val(TextBox2.Text)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox3.Text = Val(TextBox1.Text) / Val(TextBox2.Text)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox("Write any thing you like :D ")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        End
    End Sub
End Class
