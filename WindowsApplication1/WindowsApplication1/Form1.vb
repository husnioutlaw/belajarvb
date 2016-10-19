Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox3.Text = Len(TextBox1.Text)
        TextBox4.Text = Val(TextBox2.Text)
        TextBox4.Text = Len(TextBox4.Text)

        'For i As Integer = 0 To Val(TextBox2.Text) - 1
        '    ListBox1.Items.Add(TextBox1.Text & i + 2)
        'Next
    End Sub
End Class
