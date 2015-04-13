
Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmNhanvien
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=ps01896.mssql.somee.com;packet size=4096;user id=ps01896;pwd=lamhieu123;data source=ps01896.mssql.somee.com;persist security info=False;initial catalog=ps01896"
    Public Sub loadData()
        Dim ketnoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from Nhanvien", ketnoi)
        Try

            ketnoi.Open()
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        ketnoi.Close()

    End Sub
    Private Sub frmNhanvien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtManv.Text = DataGridView1.Item(0, index).Value
        txtTennv.Text = DataGridView1.Item(1, index).Value
        txtSDT.Text = DataGridView1.Item(2, index).Value
        cbbGioitinh.Text = DataGridView1.Item(3, index).Value
        txtNgaysinh.Text = DataGridView1.Item(4, index).Value
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim ketnoi As New SqlConnection(connectstr)


        ketnoi.Open()

        Dim stradd As String = "INSERT INTO Nhanvien VALUES (@Manv,@Tennv,@SDT,@Gioitinh,@Ngaysinh)"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@Manv", txtManv.Text)
            com.Parameters.AddWithValue("@Tennv", txtTennv.Text)
            com.Parameters.AddWithValue("@SDT", txtSDT.Text)
            com.Parameters.AddWithValue("@Gioitinh", cbbGioitinh.Text)
            com.Parameters.AddWithValue("@Ngaysinh", txtNgaysinh.Text)

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
        Dim stradd As String = "UPDATE Nhanvien SET  Tennv = @Tennv , SDT = @SDT , Gioitinh = @Gioitinh ,Ngaysinh = @Ngaysinh WHERE Manv = @Manv  "
        Dim com As New SqlCommand(stradd, ketnoi)

        Try
            com.Parameters.AddWithValue("@Manv", txtManv.Text)
            com.Parameters.AddWithValue("@Tennv", txtTennv.Text)
            com.Parameters.AddWithValue("@SDT", txtSDT.Text)
            com.Parameters.AddWithValue("@Gioitinh", cbbGioitinh.Text)
            com.Parameters.AddWithValue("@Ngaysinh", txtNgaysinh.Text)
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
        Dim stradd As String = "Delete from Nhanvien WHERE Manv =@Manv"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@Manv", txtManv.Text)
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