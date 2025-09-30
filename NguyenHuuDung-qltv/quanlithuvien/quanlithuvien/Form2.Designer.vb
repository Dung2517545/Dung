<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        cboQuyen = New ComboBox()
        btnDangKy = New Button()
        Label1 = New Label()
        TxtTenDangNhap = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TxtMatKhau = New TextBox()
        BtnDangNhap = New Button()
        SuspendLayout()
        ' 
        ' cboQuyen
        ' 
        cboQuyen.FormattingEnabled = True
        cboQuyen.Location = New Point(321, 201)
        cboQuyen.Name = "cboQuyen"
        cboQuyen.Size = New Size(211, 28)
        cboQuyen.TabIndex = 0
        ' 
        ' btnDangKy
        ' 
        btnDangKy.Location = New Point(254, 338)
        btnDangKy.Name = "btnDangKy"
        btnDangKy.Size = New Size(94, 29)
        btnDangKy.TabIndex = 1
        btnDangKy.Text = "Đăng ký"
        btnDangKy.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(172, 128)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 20)
        Label1.TabIndex = 2
        Label1.Text = "Tên Đăng Nhập"
        ' 
        ' TxtTenDangNhap
        ' 
        TxtTenDangNhap.Location = New Point(321, 121)
        TxtTenDangNhap.Name = "TxtTenDangNhap"
        TxtTenDangNhap.Size = New Size(211, 27)
        TxtTenDangNhap.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(172, 201)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 20)
        Label2.TabIndex = 2
        Label2.Text = "Quyền"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(172, 273)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 20)
        Label3.TabIndex = 2
        Label3.Text = "Mật Khẩu"
        ' 
        ' TxtMatKhau
        ' 
        TxtMatKhau.Location = New Point(321, 266)
        TxtMatKhau.Name = "TxtMatKhau"
        TxtMatKhau.Size = New Size(211, 27)
        TxtMatKhau.TabIndex = 3
        ' 
        ' BtnDangNhap
        ' 
        BtnDangNhap.Location = New Point(504, 338)
        BtnDangNhap.Name = "BtnDangNhap"
        BtnDangNhap.Size = New Size(129, 29)
        BtnDangNhap.TabIndex = 1
        BtnDangNhap.Text = "Đăng Nhập"
        BtnDangNhap.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TxtMatKhau)
        Controls.Add(TxtTenDangNhap)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnDangNhap)
        Controls.Add(btnDangKy)
        Controls.Add(cboQuyen)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboQuyen As ComboBox
    Friend WithEvents btnDangKy As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtTenDangNhap As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtMatKhau As TextBox
    Friend WithEvents BtnDangNhap As Button
End Class
