<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UIConfig
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
        Me.txt_path = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_path = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_path
        '
        Me.txt_path.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_path.Location = New System.Drawing.Point(68, 24)
        Me.txt_path.Name = "txt_path"
        Me.txt_path.Size = New System.Drawing.Size(153, 26)
        Me.txt_path.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Path :"
        '
        'btn_path
        '
        Me.btn_path.Location = New System.Drawing.Point(227, 24)
        Me.btn_path.Name = "btn_path"
        Me.btn_path.Size = New System.Drawing.Size(40, 26)
        Me.btn_path.TabIndex = 2
        Me.btn_path.Text = "..."
        Me.btn_path.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(192, 56)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 3
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'UIConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 111)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_path)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_path)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UIConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Config"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_path As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_path As Button
    Friend WithEvents btn_save As Button
End Class
