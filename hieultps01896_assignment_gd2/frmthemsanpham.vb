
Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmthemsanpham
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=ps01896.mssql.somee.com;packet size=4096;user id=ps01896;pwd=lamhieu123;data source=ps01896.mssql.somee.com;persist security info=False;initial catalog=ps01896"
    Public Sub loadData()
        Dim ketnoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from Sanpham", ketnoi)
        Try

            ketnoi.Open()
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        ketnoi.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtTenma.Text = DataGridView1.Item(0, index).Value
        txtTenHang.Text = DataGridView1.Item(1, index).Value
        txtGia.Text = DataGridView1.Item(2, index).Value
        txtSoluong.Text = DataGridView1.Item(3, index).Value
        txtChitietsp.Text = DataGridView1.Item(4, index).Value
      
    End Sub

    Private Sub frmthemsanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click

        Dim ketnoi As New SqlConnection(connectstr)


        ketnoi.Open()

        Dim stradd As String = "INSERT INTO Sanpham VALUES (@Masp , @Tensp,@Dongia ,@Soluong ,@Chitetsp,@Maloaisp) "
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@Masp", txtTenma.Text)
            com.Parameters.AddWithValue("@Tensp", txtTenHang.Text)
            com.Parameters.AddWithValue("@Dongia", txtGia.Text)
            com.Parameters.AddWithValue("@Soluong", txtSoluong.Text)
            com.Parameters.AddWithValue("@Chitetsp", txtChitietsp.Text)
            com.Parameters.AddWithValue("@Maloaisp", txtMaloaisp.Text)

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "UPDATE Sanpham SET  Tensp = @Tensp , Dongia = @Dongia , Soluong = @Soluong ,Chitetsp = @chitetsp,Maloaisp = @Maloaisp WHERE Masp = @Masp  "
        Dim com As New SqlCommand(stradd, ketnoi)

        Try
            com.Parameters.AddWithValue("@Masp", txtTenma.Text)
            com.Parameters.AddWithValue("@Tensp", txtTenHang.Text)
            com.Parameters.AddWithValue("@Dongia", txtGia.Text)
            com.Parameters.AddWithValue("@Soluong", txtSoluong.Text)
            com.Parameters.AddWithValue("@Chitetsp", txtChitietsp.Text)
            com.Parameters.AddWithValue("@Maloaisp", txtMaloaisp.Text)
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
        Dim stradd As String = "Delete from Sanpham WHERE Masp =@Masp"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@Masp", txtTenma.Text)
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