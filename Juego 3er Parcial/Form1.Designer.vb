<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.playbtn = New System.Windows.Forms.Button()
        Me.aboutbtn = New System.Windows.Forms.Button()
        Me.salirbtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'playbtn
        '
        Me.playbtn.BackColor = System.Drawing.Color.Brown
        Me.playbtn.FlatAppearance.BorderColor = System.Drawing.Color.Brown
        Me.playbtn.FlatAppearance.BorderSize = 0
        Me.playbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.playbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.playbtn.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playbtn.ForeColor = System.Drawing.Color.White
        Me.playbtn.Location = New System.Drawing.Point(200, 150)
        Me.playbtn.Name = "playbtn"
        Me.playbtn.Size = New System.Drawing.Size(100, 37)
        Me.playbtn.TabIndex = 0
        Me.playbtn.Text = "¡JUGAR!"
        Me.playbtn.UseVisualStyleBackColor = False
        Me.playbtn.Visible = False
        '
        'aboutbtn
        '
        Me.aboutbtn.BackColor = System.Drawing.Color.Brown
        Me.aboutbtn.FlatAppearance.BorderColor = System.Drawing.Color.Brown
        Me.aboutbtn.FlatAppearance.BorderSize = 0
        Me.aboutbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.aboutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aboutbtn.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aboutbtn.ForeColor = System.Drawing.Color.White
        Me.aboutbtn.Location = New System.Drawing.Point(200, 200)
        Me.aboutbtn.Name = "aboutbtn"
        Me.aboutbtn.Size = New System.Drawing.Size(100, 37)
        Me.aboutbtn.TabIndex = 1
        Me.aboutbtn.Text = "Acerca de"
        Me.aboutbtn.UseVisualStyleBackColor = False
        Me.aboutbtn.Visible = False
        '
        'salirbtn
        '
        Me.salirbtn.BackColor = System.Drawing.Color.Brown
        Me.salirbtn.FlatAppearance.BorderColor = System.Drawing.Color.Brown
        Me.salirbtn.FlatAppearance.BorderSize = 0
        Me.salirbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.salirbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.salirbtn.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salirbtn.ForeColor = System.Drawing.Color.White
        Me.salirbtn.Location = New System.Drawing.Point(200, 250)
        Me.salirbtn.Name = "salirbtn"
        Me.salirbtn.Size = New System.Drawing.Size(100, 37)
        Me.salirbtn.TabIndex = 2
        Me.salirbtn.Text = "Salir"
        Me.salirbtn.UseVisualStyleBackColor = False
        Me.salirbtn.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Juego_3er_Parcial.My.Resources.Resources.menu_fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(500, 300)
        Me.Controls.Add(Me.salirbtn)
        Me.Controls.Add(Me.aboutbtn)
        Me.Controls.Add(Me.playbtn)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BlackJack"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents playbtn As Button
    Friend WithEvents aboutbtn As Button
    Friend WithEvents salirbtn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
