<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXuat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lsvXuat = New System.Windows.Forms.ListView()
        Me.lsvTenhang = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvMaLaptop = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvSoluong = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvGia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvTenKh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvDiachi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvSdt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lsvXuat
        '
        Me.lsvXuat.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lsvTenhang, Me.lsvMaLaptop, Me.lsvSoluong, Me.lsvGia, Me.lsvTenKh, Me.lsvDiachi, Me.lsvSdt, Me.lsvEmail})
        Me.lsvXuat.Location = New System.Drawing.Point(12, 21)
        Me.lsvXuat.Name = "lsvXuat"
        Me.lsvXuat.Size = New System.Drawing.Size(921, 439)
        Me.lsvXuat.TabIndex = 2
        Me.lsvXuat.UseCompatibleStateImageBehavior = False
        Me.lsvXuat.View = System.Windows.Forms.View.Details
        '
        'lsvTenhang
        '
        Me.lsvTenhang.Text = "Tên Hãng"
        Me.lsvTenhang.Width = 109
        '
        'lsvMaLaptop
        '
        Me.lsvMaLaptop.Text = "Mã Laptop"
        Me.lsvMaLaptop.Width = 99
        '
        'lsvSoluong
        '
        Me.lsvSoluong.Text = "Số lượng"
        Me.lsvSoluong.Width = 84
        '
        'lsvGia
        '
        Me.lsvGia.Text = "Giá tiền"
        Me.lsvGia.Width = 107
        '
        'lsvTenKh
        '
        Me.lsvTenKh.Text = "Tên Khách Hàng"
        Me.lsvTenKh.Width = 130
        '
        'lsvDiachi
        '
        Me.lsvDiachi.Text = "Địa chỉ"
        Me.lsvDiachi.Width = 125
        '
        'lsvSdt
        '
        Me.lsvSdt.Text = "Số điện thoại"
        Me.lsvSdt.Width = 107
        '
        'lsvEmail
        '
        Me.lsvEmail.Text = "Email"
        Me.lsvEmail.Width = 141
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lsvXuat)
        Me.GroupBox2.Location = New System.Drawing.Point(-2, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(948, 471)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin"
        '
        'frmXuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(947, 474)
        Me.Controls.Add(Me.GroupBox2)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmXuat"
        Me.Text = "Lịch sử bán hàng"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsvXuat As System.Windows.Forms.ListView
    Friend WithEvents lsvTenhang As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvMaLaptop As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvSoluong As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvGia As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvTenKh As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvDiachi As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvSdt As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvEmail As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
