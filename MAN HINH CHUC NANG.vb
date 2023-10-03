Public Class MAN_HINH_CHUC_NANG
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bt As Integer
        Dim kt As Integer
        Dim chia5 As String
        chia5 = " "
        bt = Integer.Parse(txtbd.Text)
        kt = Integer.Parse(txtkt.Text)
        Dim tong, tich, nguyento As Double
        tong = 0
        tich = 1
        chia5 = 0
        nguyento = 0
        Dim i As Integer
        For i = bt To kt
            tong = tong + i
            tich = tich * i
            tich *= i
            If i Mod 5 = 0 Then
                chia5 = chia5 & i & " "
            End If
        Next
        txttong.Text = tong
        txttich.Text = tich
        txtchia5.Text = chia5
        txtnguyento.Text = nguyento
    End Sub
End Class