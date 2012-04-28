<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicTacToe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TicTacToe))
        Me.picBox1 = New System.Windows.Forms.PictureBox()
        Me.picBox2 = New System.Windows.Forms.PictureBox()
        Me.picBox3 = New System.Windows.Forms.PictureBox()
        Me.picBox6 = New System.Windows.Forms.PictureBox()
        Me.picBox5 = New System.Windows.Forms.PictureBox()
        Me.picBox4 = New System.Windows.Forms.PictureBox()
        Me.picBox9 = New System.Windows.Forms.PictureBox()
        Me.picBox8 = New System.Windows.Forms.PictureBox()
        Me.picBox7 = New System.Windows.Forms.PictureBox()
        Me.mnuToolbar = New System.Windows.Forms.MenuStrip()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bP1Wins = New System.Windows.Forms.Button()
        Me.bP2Wins = New System.Windows.Forms.Button()
        Me.bCatWins = New System.Windows.Forms.Button()
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuToolbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBox1
        '
        Me.picBox1.Image = CType(resources.GetObject("picBox1.Image"), System.Drawing.Image)
        Me.picBox1.InitialImage = CType(resources.GetObject("picBox1.InitialImage"), System.Drawing.Image)
        Me.picBox1.Location = New System.Drawing.Point(13, 27)
        Me.picBox1.Name = "picBox1"
        Me.picBox1.Size = New System.Drawing.Size(200, 150)
        Me.picBox1.TabIndex = 0
        Me.picBox1.TabStop = False
        '
        'picBox2
        '
        Me.picBox2.Image = CType(resources.GetObject("picBox2.Image"), System.Drawing.Image)
        Me.picBox2.InitialImage = CType(resources.GetObject("picBox2.InitialImage"), System.Drawing.Image)
        Me.picBox2.Location = New System.Drawing.Point(217, 27)
        Me.picBox2.Name = "picBox2"
        Me.picBox2.Size = New System.Drawing.Size(200, 150)
        Me.picBox2.TabIndex = 1
        Me.picBox2.TabStop = False
        '
        'picBox3
        '
        Me.picBox3.Image = CType(resources.GetObject("picBox3.Image"), System.Drawing.Image)
        Me.picBox3.InitialImage = CType(resources.GetObject("picBox3.InitialImage"), System.Drawing.Image)
        Me.picBox3.Location = New System.Drawing.Point(421, 27)
        Me.picBox3.Name = "picBox3"
        Me.picBox3.Size = New System.Drawing.Size(200, 150)
        Me.picBox3.TabIndex = 2
        Me.picBox3.TabStop = False
        '
        'picBox6
        '
        Me.picBox6.Image = CType(resources.GetObject("picBox6.Image"), System.Drawing.Image)
        Me.picBox6.InitialImage = CType(resources.GetObject("picBox6.InitialImage"), System.Drawing.Image)
        Me.picBox6.Location = New System.Drawing.Point(421, 183)
        Me.picBox6.Name = "picBox6"
        Me.picBox6.Size = New System.Drawing.Size(200, 150)
        Me.picBox6.TabIndex = 5
        Me.picBox6.TabStop = False
        '
        'picBox5
        '
        Me.picBox5.Image = CType(resources.GetObject("picBox5.Image"), System.Drawing.Image)
        Me.picBox5.InitialImage = CType(resources.GetObject("picBox5.InitialImage"), System.Drawing.Image)
        Me.picBox5.Location = New System.Drawing.Point(217, 183)
        Me.picBox5.Name = "picBox5"
        Me.picBox5.Size = New System.Drawing.Size(200, 150)
        Me.picBox5.TabIndex = 4
        Me.picBox5.TabStop = False
        '
        'picBox4
        '
        Me.picBox4.Image = CType(resources.GetObject("picBox4.Image"), System.Drawing.Image)
        Me.picBox4.InitialImage = CType(resources.GetObject("picBox4.InitialImage"), System.Drawing.Image)
        Me.picBox4.Location = New System.Drawing.Point(13, 183)
        Me.picBox4.Name = "picBox4"
        Me.picBox4.Size = New System.Drawing.Size(200, 150)
        Me.picBox4.TabIndex = 3
        Me.picBox4.TabStop = False
        '
        'picBox9
        '
        Me.picBox9.Image = CType(resources.GetObject("picBox9.Image"), System.Drawing.Image)
        Me.picBox9.InitialImage = CType(resources.GetObject("picBox9.InitialImage"), System.Drawing.Image)
        Me.picBox9.Location = New System.Drawing.Point(421, 339)
        Me.picBox9.Name = "picBox9"
        Me.picBox9.Size = New System.Drawing.Size(200, 150)
        Me.picBox9.TabIndex = 8
        Me.picBox9.TabStop = False
        '
        'picBox8
        '
        Me.picBox8.Image = CType(resources.GetObject("picBox8.Image"), System.Drawing.Image)
        Me.picBox8.InitialImage = CType(resources.GetObject("picBox8.InitialImage"), System.Drawing.Image)
        Me.picBox8.Location = New System.Drawing.Point(217, 339)
        Me.picBox8.Name = "picBox8"
        Me.picBox8.Size = New System.Drawing.Size(200, 150)
        Me.picBox8.TabIndex = 7
        Me.picBox8.TabStop = False
        '
        'picBox7
        '
        Me.picBox7.Image = CType(resources.GetObject("picBox7.Image"), System.Drawing.Image)
        Me.picBox7.InitialImage = CType(resources.GetObject("picBox7.InitialImage"), System.Drawing.Image)
        Me.picBox7.Location = New System.Drawing.Point(13, 339)
        Me.picBox7.Name = "picBox7"
        Me.picBox7.Size = New System.Drawing.Size(200, 150)
        Me.picBox7.TabIndex = 6
        Me.picBox7.TabStop = False
        '
        'mnuToolbar
        '
        Me.mnuToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuToolbar.Location = New System.Drawing.Point(0, 0)
        Me.mnuToolbar.Name = "mnuToolbar"
        Me.mnuToolbar.Size = New System.Drawing.Size(634, 24)
        Me.mnuToolbar.TabIndex = 9
        Me.mnuToolbar.Text = "MenuStrip1"
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.GameToolStripMenuItem.Text = "&Game"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.NewGameToolStripMenuItem.Text = "&New Game"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'bP1Wins
        '
        Me.bP1Wins.Enabled = False
        Me.bP1Wins.Location = New System.Drawing.Point(250, 1)
        Me.bP1Wins.Name = "bP1Wins"
        Me.bP1Wins.Size = New System.Drawing.Size(120, 23)
        Me.bP1Wins.TabIndex = 10
        Me.bP1Wins.Text = "Player 1 Wins: 0"
        Me.bP1Wins.UseVisualStyleBackColor = True
        '
        'bP2Wins
        '
        Me.bP2Wins.Enabled = False
        Me.bP2Wins.Location = New System.Drawing.Point(376, 1)
        Me.bP2Wins.Name = "bP2Wins"
        Me.bP2Wins.Size = New System.Drawing.Size(120, 23)
        Me.bP2Wins.TabIndex = 11
        Me.bP2Wins.Text = "Player 2 Wins: 0"
        Me.bP2Wins.UseVisualStyleBackColor = True
        '
        'bCatWins
        '
        Me.bCatWins.Enabled = False
        Me.bCatWins.Location = New System.Drawing.Point(502, 1)
        Me.bCatWins.Name = "bCatWins"
        Me.bCatWins.Size = New System.Drawing.Size(120, 23)
        Me.bCatWins.TabIndex = 12
        Me.bCatWins.Text = "Cat's Games: 0"
        Me.bCatWins.UseVisualStyleBackColor = True
        '
        'TicTacToe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 500)
        Me.Controls.Add(Me.bCatWins)
        Me.Controls.Add(Me.bP2Wins)
        Me.Controls.Add(Me.bP1Wins)
        Me.Controls.Add(Me.picBox9)
        Me.Controls.Add(Me.picBox8)
        Me.Controls.Add(Me.picBox7)
        Me.Controls.Add(Me.picBox6)
        Me.Controls.Add(Me.picBox5)
        Me.Controls.Add(Me.picBox4)
        Me.Controls.Add(Me.picBox3)
        Me.Controls.Add(Me.picBox2)
        Me.Controls.Add(Me.picBox1)
        Me.Controls.Add(Me.mnuToolbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.mnuToolbar
        Me.MaximizeBox = False
        Me.Name = "TicTacToe"
        Me.Text = "Tic-Tac-Toe"
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuToolbar.ResumeLayout(False)
        Me.mnuToolbar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents mnuToolbar As System.Windows.Forms.MenuStrip
    Friend WithEvents bP1Wins As System.Windows.Forms.Button
    Friend WithEvents bP2Wins As System.Windows.Forms.Button
    Friend WithEvents bCatWins As System.Windows.Forms.Button
    Friend WithEvents GameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
