Public Class Form1
    Public Const EU_TO_US As Single = 1.11
    Public Const US_TO_TL As Single = 5.93
    Public Const EU_TO_TL As Single = 6.59
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            TextBox2.Text = Val(TextBox1.Text) / EU_TO_TL
            TextBox3.Text = Val(TextBox1.Text) / US_TO_TL
            Exit Sub
        End If
        If TextBox2.Text <> "" Then
            TextBox1.Text = Val(TextBox2.Text) * EU_TO_TL
            TextBox3.Text = Val(TextBox2.Text) * EU_TO_US
            Exit Sub
        End If
        If TextBox3.Text <> "" Then
            TextBox1.Text = Val(TextBox3.Text) * US_TO_TL
            TextBox2.Text = Val(TextBox3.Text) / EU_TO_US
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
End Class

