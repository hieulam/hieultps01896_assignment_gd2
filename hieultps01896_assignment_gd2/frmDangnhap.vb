Imports System.Data.SqlClient
Public Class frmDangnhap



    Private Sub btnDangnhap_Click(sender As Object, e As EventArgs) Handles btnDangnhap.Click, MyBase.Enter, btnDangnhap.Enter

        Dim chuoiketnoi As String = "workstation id=ps01896.mssql.somee.com;packet size=4096;user id=ps01896;pwd=lamhieu123;data source=ps01896.mssql.somee.com;persist security info=False;initial catalog=ps01896"

        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from Taikhoan where TenDangnhap='" & txtTen.Text & "' and Matkhau='" & txtMatkhau.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("ket nối thành công")
                frmthemsanpham.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai Tai Khoan hoac Mat Khau")
            End If

        Catch ex As Exception

        End Try
    End Sub



    Private Sub btnNhaplai_Click(sender As Object, e As EventArgs) Handles btnNhaplai.Click
        txtTen.Text = ""
        txtMatkhau.Text = ""
    End Sub

    Private Sub frmDangnhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
