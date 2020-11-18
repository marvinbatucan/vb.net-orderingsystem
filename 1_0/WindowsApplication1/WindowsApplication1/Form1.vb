Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtUser.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String
        Dim password As String
        username = TxtUser.Text
        password = TxtPass.Text
        If (username.Equals("admin") And password.Equals("admin")) Then
            MessageBox.Show("Login Success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Form2.Show()
        Else
            MessageBox.Show("Login Failed", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
