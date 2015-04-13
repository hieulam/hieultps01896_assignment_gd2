Public Class frmDangnhap



    Private Sub btnDangnhap_Click(sender As Object, e As EventArgs) Handles btnDangnhap.Click, MyBase.Enter, btnDangnhap.Enter
        If txtTen.Text = "" OrElse txtMatkhau.Text = "" Then
            MessageBox.Show("Bạn cần nhập username và password", "Đăng nhập không thành công",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        Else

            If txtTen.Text = "admin" AndAlso txtMatkhau.Text = "1234" Then
                MessageBox.Show("Welcome admin today", "Đăng nhập thành công", MessageBoxButtons.OK,
                MessageBoxIcon.Information)


                frm_chinh.Show()

                Me.Hide()
            Else


                If txtTen.Text = "user" AndAlso txtMatkhau.Text = "1234" Then
                    MessageBox.Show("Welcome user today", "Ðang nhập thành công", MessageBoxButtons.OK,
                    MessageBoxIcon.Information)
                    'hi?n th? form chính
                    frm_chinh.Show()
                    '?n form dang nh?p khi vào du?c form chính
                    Me.Hide()
                Else
                    'thông báo là m?t kh?u ho?c tên name sai
                    MessageBox.Show("Login failed", "đăng nhập không thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
        End If
        txtTen.Text = ""
        txtMatkhau.Text = ""
        'dua con tr? lên form nh?p user 
        txtTen.Focus()
    End Sub

    Private Sub btnNhaplai_Click(sender As Object, e As EventArgs) Handles btnNhaplai.Click
        txtTen.Text = ""
        txtMatkhau.Text = ""
    End Sub
End Class
