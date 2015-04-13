Imports System.IO
Public Class frmNhanvien
    Dim items As ListViewItem
    Dim nhap As StreamWriter
    Dim xuat As StreamReader
    Dim i As Integer

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        ' ghi vào file txt và xuất ra listview
        nhap = New StreamWriter("nhanvien.txt", True)
        nhap.WriteLine(txtTen.Text + ControlChars.Tab + txtManv.Text + ControlChars.Tab + txtSDT.Text + ControlChars.Tab + txtDiachi.Text)

        nhap.Close()

        items = New ListViewItem(txtTen.Text)
        items.SubItems.Add(txtManv.Text)
        items.SubItems.Add(txtSDT.Text)
        items.SubItems.Add(txtDiachi.Text)
        lsvNhanvien.Items.Add(items)


    End Sub


    Private Sub lsvNhanvien_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvNhanvien.SelectedIndexChanged
       

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        '  i = lsvNhanvien.FocusedItem.Index
        ' nút xóa cho form
        txtTen.Clear()
        txtManv.Clear()
        txtSDT.Clear()
        txtDiachi.Clear()
        lsvNhanvien.Items(i).Remove()
    End Sub

    

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' thêm hình ảnh vào form
        If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then

            Dim formpath As String = OpenFileDialog1.FileName
            Dim topath As String = "Hinh\" & OpenFileDialog1.SafeFileName
            File.Copy(formpath, topath, True)
            PictureBox1.ImageLocation = topath



        End If
    End Sub

    Private Sub frmNhanvien_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class