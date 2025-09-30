<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        BtnDangNhap = New Button()
        Label1 = New Label()
        TxtTenDangNhap = New TextBox()
        Label2 = New Label()
        TxtMatKhau = New TextBox()
        BtnDangXuat = New Button()
        SuspendLayout()
        ' 
        ' BtnDangNhap
        ' 
        BtnDangNhap.Location = New Point(273, 291)
        BtnDangNhap.Name = "BtnDangNhap"
        BtnDangNhap.Size = New Size(94, 29)
        BtnDangNhap.TabIndex = 0
        BtnDangNhap.Text = "Đăng Nhập"
        BtnDangNhap.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(219, 123)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 20)
        Label1.TabIndex = 1
        Label1.Text = "Tên Đăng Nhập"
        ' 
        ' TxtTenDangNhap
        ' 
        TxtTenDangNhap.Location = New Point(337, 123)
        TxtTenDangNhap.Name = "TxtTenDangNhap"
        TxtTenDangNhap.Size = New Size(226, 27)
        TxtTenDangNhap.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(232, 229)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 20)
        Label2.TabIndex = 1
        Label2.Text = "Mật Khẩu"
        ' 
        ' TxtMatKhau
        ' 
        TxtMatKhau.Location = New Point(335, 222)
        TxtMatKhau.Name = "TxtMatKhau"
        TxtMatKhau.Size = New Size(228, 27)
        TxtMatKhau.TabIndex = 2
        ' 
        ' BtnDangXuat
        ' 
        BtnDangXuat.Location = New Point(459, 291)
        BtnDangXuat.Name = "BtnDangXuat"
        BtnDangXuat.Size = New Size(94, 29)
        BtnDangXuat.TabIndex = 0
        BtnDangXuat.Text = "Đăng Xuất"
        BtnDangXuat.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TxtMatKhau)
        Controls.Add(TxtTenDangNhap)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnDangXuat)
        Controls.Add(BtnDangNhap)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnDangNhap As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtTenDangNhap As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtMatKhau As TextBox
    Friend WithEvents BtnDangXuat As Button
End Class
