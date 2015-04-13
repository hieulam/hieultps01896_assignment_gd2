Imports System.IO
Public Class frmthemsanpham
    Dim items As ListViewItem ' khai báo biến kiểu listview
    Dim nhap As StreamWriter
    Dim xuat As StreamReader
    Dim i As Integer
    

    Private Sub frmthemsanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        ' ghi vào filt txt và xuất ra listview
        nhap = New StreamWriter("sanpham.txt", True)
        nhap.WriteLine(cbbTenhang.Text + ControlChars.Tab + cbbMasp.Text + ControlChars.Tab & DateTimePicker1.Text & ControlChars.Tab & txtGia.Text + ControlChars.Tab & NumericUpDown1.Value)

        nhap.Close()

        items = New ListViewItem(cbbTenhang.Text)
        items.SubItems.Add(cbbMasp.Text)
        items.SubItems.Add(DateTimePicker1.Text)
        items.SubItems.Add(txtGia.Text)
        items.SubItems.Add(NumericUpDown1.Text)

        lsvSp.Items.Add(items)

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' nút xóa
        lsvSp.Items(i).Remove()
        cbbTenhang.Text = ""
        cbbMasp.Text = ""
        DateTimePicker1.Text = ""
        txtGia.Text = ""




    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' thêm hình ảnh cho form
        If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then

            Dim formpath As String = OpenFileDialog1.FileName
            Dim topath As String = "Hinhsp\" & OpenFileDialog1.SafeFileName
            File.Copy(formpath, topath, True)
            PictureBox1.ImageLocation = topath



        End If
    End Sub
End Class