<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangnhap
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTen = New System.Windows.Forms.TextBox()
        Me.txtMatkhau = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNhaplai = New System.Windows.Forms.Button()
        Me.btnDangnhap = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Password"
        '
        'txtTen
        '
        Me.txtTen.Location = New System.Drawing.Point(237, 51)
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(206, 22)
        Me.txtTen.TabIndex = 1
        '
        'txtMatkhau
        '
        Me.txtMatkhau.Location = New System.Drawing.Point(237, 108)
        Me.txtMatkhau.Name = "txtMatkhau"
        Me.txtMatkhau.Size = New System.Drawing.Size(206, 22)
        Me.txtMatkhau.TabIndex = 2
        Me.txtMatkhau.UseSystemPasswordChar = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnNhaplai)
        Me.GroupBox1.Controls.Add(Me.btnDangnhap)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtMatkhau)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtTen)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 242)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Đăng nhập hệ thống"
        '
        'btnNhaplai
        '
        Me.btnNhaplai.Location = New System.Drawing.Point(329, 176)
        Me.btnNhaplai.Name = "btnNhaplai"
        Me.btnNhaplai.Size = New System.Drawing.Size(114, 36)
        Me.btnNhaplai.TabIndex = 4
        Me.btnNhaplai.Text = "Nhập lại"
        Me.btnNhaplai.UseVisualStyleBackColor = True
        '
        'btnDangnhap
        '
        Me.btnDangnhap.Location = New System.Drawing.Point(127, 176)
        Me.btnDangnhap.Name = "btnDangnhap"
        Me.btnDangnhap.Size = New System.Drawing.Size(114, 36)
        Me.btnDangnhap.TabIndex = 3
        Me.btnDangnhap.Text = "Đăng nhập"
        Me.btnDangnhap.UseVisualStyleBackColor = True
        '
        'frmDangnhap
        '
        Me.AcceptButton = Me.btnDangnhap
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(588, 266)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDangnhap"
        Me.Text = "Đăng Nhập Hệ Thống"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTen As System.Windows.Forms.TextBox
    Friend WithEvents txtMatkhau As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDangnhap As System.Windows.Forms.Button
    Friend WithEvents btnNhaplai As System.Windows.Forms.Button
End Class
