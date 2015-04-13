Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmHoadon

    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=ps01896.mssql.somee.com;packet size=4096;user id=ps01896;pwd=lamhieu123;data source=ps01896.mssql.somee.com;persist security info=False;initial catalog=ps01896"
    Public Sub loadData()
        Dim ketnoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from Hoadon", ketnoi)
        Try

            ketnoi.Open()
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        ketnoi.Close()

    End Sub

    Private Sub frmHoadon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtMahoadon.Text = DataGridView1.Item(0, index).Value
        txtTongtien.Text = DataGridView1.Item(1, index).Value
        txtNgaythanhlap.Text = DataGridView1.Item(2, index).Value
        txtSoluong.Text = DataGridView1.Item(3, index).Value
        txtDongia.Text = DataGridView1.Item(4, index).Value
        txtNgaygiaohang.Text = DataGridView1.Item(4, index).Value

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim ketnoi As New SqlConnection(connectstr)


        ketnoi.Open()

        Dim stradd As String = "INSERT INTO Hoadon VALUES (@Mahoadon , @Tongtien,@Ngaythanhlap ,@Soluong ,@Dongia,@Ngaygiaohang) "
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@Mahoadon", txtMahoadon.Text)
            com.Parameters.AddWithValue("@Tongtien", txtTongtien.Text)
            com.Parameters.AddWithValue("@Ngaythanhlap", txtNgaythanhlap.Text)
            com.Parameters.AddWithValue("@Soluong", txtSoluong.Text)
            com.Parameters.AddWithValue("@Dongia", txtDongia.Text)
            com.Parameters.AddWithValue("@Ngaygiaohang", txtNgaygiaohang.Text)

            com.ExecuteNonQuery()


            ketnoi.Close()


        Catch ex As Exception
            MessageBox.Show("kết nối không thành công")

        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        loadData()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "UPDATE Hoadon SET  Tongtien = @Tongtien , Ngaythanhlap = @Ngaythanhlap , Soluong = @Soluong ,Dongia = @Dongia,Ngaygiaohang =@Ngaygiaohang WHERE Mahoadon = @Mahoadon  "
        Dim com As New SqlCommand(stradd, ketnoi)

        Try
            com.Parameters.AddWithValue("@Mahoadon", txtMahoadon.Text)
            com.Parameters.AddWithValue("@Tongtien", txtTongtien.Text)
            com.Parameters.AddWithValue("@Ngaythanhlap", txtNgaythanhlap.Text)
            com.Parameters.AddWithValue("@Soluong", txtSoluong.Text)
            com.Parameters.AddWithValue("@Dongia", txtDongia.Text)
            com.Parameters.AddWithValue("@Ngaygiaohang", txtNgaygiaohang.Text)
            com.ExecuteNonQuery()


            ketnoi.Close()


        Catch ex As Exception
            MessageBox.Show("kết nối không thành công")

        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        loadData()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "Delete from Hoadon WHERE Mahoadon = @Mahoadon"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@Mahoadon", txtMahoadon.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()

        Catch ex As Exception
            MessageBox.Show("ket noi k thanh cong")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        loadData()
    End Sub
End Class