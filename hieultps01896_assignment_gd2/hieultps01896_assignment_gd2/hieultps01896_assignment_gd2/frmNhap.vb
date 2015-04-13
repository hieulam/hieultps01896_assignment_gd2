Imports System.IO
Public Class frm_chinh
    Dim items As ListViewItem
    Dim i As Integer

    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
        'ghi dữ liệu

        Dim tenhang As String() = {"Asus", "Hp", "Dell", "Sony"}
        Dim mahang As String() = {"Asus-01", "Hp-02", "Dell-03", "Sony-04"}
        Dim ghi As StreamWriter

        ghi = New StreamWriter("tam1.txt", True)
        ghi.WriteLine(cbbTenhang.Text + ControlChars.Tab + cbbMasp.Text + ControlChars.Tab & NumericUpDown1.Value & ControlChars.Tab + txtGiatien.Text + ControlChars.Tab + txtTenkh.Text + ControlChars.Tab + txtDiachi.Text + ControlChars.Tab + txtSDT.Text + ControlChars.Tab + txtEmail.Text + ControlChars.Tab)

        ghi.Close()
        ' xu ly su kien listview
        items = New ListViewItem(cbbTenhang.Text)
        items.SubItems.Add(cbbMasp.Text)
        items.SubItems.Add(NumericUpDown1.Value)
        items.SubItems.Add(txtGiatien.Text)
        items.SubItems.Add(txtTenkh.Text)
        items.SubItems.Add(txtDiachi.Text)
        items.SubItems.Add(txtSDT.Text)
        items.SubItems.Add(txtEmail.Text)
        lsvXuat.Items.Add(items)

    End Sub

   

    Private Sub lsvXuat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvXuat.SelectedIndexChanged
       

    End Sub

    Private Sub frm_chinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub XuấtHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XuấtHóaĐơnToolStripMenuItem.Click



        frmXuat.IsMdiContainer = True
        frmXuat.Show()



    End Sub

    
    Private Sub ChứcNăngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChứcNăngToolStripMenuItem.Click
        frmNhanvien.IsMdiContainer = True
        frmNhanvien.Show()

    End Sub

    Private Sub NhậpHàngToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NhậpHàngToolStripMenuItem1.Click
        frmthemsanpham.IsMdiContainer = True
        frmthemsanpham.Show()
    End Sub

    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NhậpHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhậpHàngToolStripMenuItem.Click
        frmDangnhap.Show()
    End Sub
End Class