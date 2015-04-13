Imports System.IO
Public Class frmXuat
    Dim xuat As StreamReader
    Dim dong As String
    Dim ketqua As String()
    Dim xem As ListViewItem = New ListViewItem
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xuat = New StreamReader("tam1.txt", True)
        Do Until xuat.EndOfStream
            dong = xuat.ReadLine()
            ketqua = dong.Split(ControlChars.Tab)
            xem = New ListViewItem(ketqua(0))
            xem.SubItems.Add(ketqua(1))
            xem.SubItems.Add(ketqua(2))
            xem.SubItems.Add(ketqua(3))
            xem.SubItems.Add(ketqua(4))
            xem.SubItems.Add(ketqua(5))
            xem.SubItems.Add(ketqua(6))
            xem.SubItems.Add(ketqua(7))
            lsvXuat.Items.Add(xem)




        Loop

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        ' Dim tam As String

        ' Dim arrmang As String()
        ' Dim dulieu As StreamReader
        ' dulieu = New StreamReader("tam.txt")
        'Do While dulieu.EndOfStream

        'tam = dulieu.ReadLine()
        'arrmang = tam.Split(",")
        ' Dim lstluumoi As ListViewItem
        ' lstluumoi = New ListViewItem(arrmang(0))


        '  Loop
        ' dulieu.Close()


    End Sub


    Private Sub lsvXuat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvXuat.SelectedIndexChanged

    End Sub
End Class