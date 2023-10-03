Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filePath As String = "D:\sv.txt"
        Dim content As String = TextBox1.Text
        Dim ba As String = TextBox2.Text
        Dim ba2 As String = TextBox3.Text
        Using writer As New System.IO.StreamWriter(filePath)
            writer.Write(content)
            writer.WriteLine()
            writer.Write(ba)
            writer.WriteLine()
            writer.Write(ba2)
        End Using
        MsgBox("Đã lưu vào file thành công!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim content1 As String = TextBox1.Text
        Dim content2 As String = TextBox2.Text
        Dim content3 As String = TextBox3.Text
        TextBox4.Text = content1
        TextBox5.Text = content2
        TextBox6.Text = content3
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New MAN_HINH_CHUC_NANG()
        frm.Show()
    End Sub
End Class
