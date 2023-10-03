<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MAN_HINH_CHUC_NANG
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbd = New System.Windows.Forms.TextBox()
        Me.txtkt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txttong = New System.Windows.Forms.TextBox()
        Me.txttich = New System.Windows.Forms.TextBox()
        Me.txtchia5 = New System.Windows.Forms.TextBox()
        Me.txtnguyento = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(145, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(516, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TÍNH TOÁN TRÊN DÃY SỐ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(119, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nhập số bắt đầu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(117, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nhập số kết thúc"
        '
        'txtbd
        '
        Me.txtbd.Location = New System.Drawing.Point(279, 86)
        Me.txtbd.Multiline = True
        Me.txtbd.Name = "txtbd"
        Me.txtbd.Size = New System.Drawing.Size(340, 27)
        Me.txtbd.TabIndex = 3
        '
        'txtkt
        '
        Me.txtkt.Location = New System.Drawing.Point(279, 127)
        Me.txtkt.Multiline = True
        Me.txtkt.Name = "txtkt"
        Me.txtkt.Size = New System.Drawing.Size(340, 27)
        Me.txtkt.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(106, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 53)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "TÍNH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(234, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tổng các số"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(234, 365)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tích các số"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(234, 410)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Tổng các số chia hết cho 5"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(234, 462)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Tổng các số là số nguyên tố"
        '
        'txttong
        '
        Me.txttong.Location = New System.Drawing.Point(326, 321)
        Me.txttong.Multiline = True
        Me.txttong.Name = "txttong"
        Me.txttong.Size = New System.Drawing.Size(234, 27)
        Me.txttong.TabIndex = 10
        '
        'txttich
        '
        Me.txttich.Location = New System.Drawing.Point(326, 364)
        Me.txttich.Multiline = True
        Me.txttich.Name = "txttich"
        Me.txttich.Size = New System.Drawing.Size(234, 27)
        Me.txttich.TabIndex = 11
        '
        'txtchia5
        '
        Me.txtchia5.Location = New System.Drawing.Point(427, 409)
        Me.txtchia5.Multiline = True
        Me.txtchia5.Name = "txtchia5"
        Me.txtchia5.Size = New System.Drawing.Size(234, 27)
        Me.txtchia5.TabIndex = 12
        '
        'txtnguyento
        '
        Me.txtnguyento.Location = New System.Drawing.Point(427, 461)
        Me.txtnguyento.Multiline = True
        Me.txtnguyento.Name = "txtnguyento"
        Me.txtnguyento.Size = New System.Drawing.Size(234, 27)
        Me.txtnguyento.TabIndex = 13
        '
        'MAN_HINH_CHUC_NANG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(771, 570)
        Me.Controls.Add(Me.txtnguyento)
        Me.Controls.Add(Me.txtchia5)
        Me.Controls.Add(Me.txttich)
        Me.Controls.Add(Me.txttong)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtkt)
        Me.Controls.Add(Me.txtbd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MAN_HINH_CHUC_NANG"
        Me.Text = "MAN HINH CHUC NANG"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbd As TextBox
    Friend WithEvents txtkt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txttong As TextBox
    Friend WithEvents txttich As TextBox
    Friend WithEvents txtchia5 As TextBox
    Friend WithEvents txtnguyento As TextBox
End Class
