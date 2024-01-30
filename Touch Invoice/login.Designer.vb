<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.passwd = New System.Windows.Forms.TextBox()
        Me.analyt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pricelist = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'passwd
        '
        Me.passwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwd.Location = New System.Drawing.Point(148, 56)
        Me.passwd.Name = "passwd"
        Me.passwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.passwd.Size = New System.Drawing.Size(195, 45)
        Me.passwd.TabIndex = 1
        Me.passwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'analyt
        '
        Me.analyt.BackColor = System.Drawing.Color.Coral
        Me.analyt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.analyt.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.analyt.ForeColor = System.Drawing.Color.White
        Me.analyt.Location = New System.Drawing.Point(12, 135)
        Me.analyt.Name = "analyt"
        Me.analyt.Size = New System.Drawing.Size(160, 83)
        Me.analyt.TabIndex = 4
        Me.analyt.Text = "Analytics"
        Me.analyt.UseVisualStyleBackColor = False
        Me.analyt.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(118, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 40)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter Password"
        '
        'pricelist
        '
        Me.pricelist.BackColor = System.Drawing.Color.DarkCyan
        Me.pricelist.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.pricelist.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pricelist.ForeColor = System.Drawing.Color.White
        Me.pricelist.Location = New System.Drawing.Point(317, 135)
        Me.pricelist.Name = "pricelist"
        Me.pricelist.Size = New System.Drawing.Size(160, 83)
        Me.pricelist.TabIndex = 4
        Me.pricelist.Text = "Price List"
        Me.pricelist.UseVisualStyleBackColor = False
        Me.pricelist.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(440, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 27)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(178, 107)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 118)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(489, 230)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pricelist)
        Me.Controls.Add(Me.analyt)
        Me.Controls.Add(Me.passwd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Login"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents passwd As TextBox
    Friend WithEvents analyt As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pricelist As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
