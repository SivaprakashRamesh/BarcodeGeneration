<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogHelp
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
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("About")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("General")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Shortcuts")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogHelp))
        Me.pnltop = New System.Windows.Forms.Panel()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.lblprintsingle = New System.Windows.Forms.Label()
        Me.picbox = New System.Windows.Forms.PictureBox()
        Me.pnlfill = New System.Windows.Forms.Panel()
        Me.pnlinfill = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.treemenu = New System.Windows.Forms.TreeView()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.pnltop.SuspendLayout()
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlfill.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnltop
        '
        Me.pnltop.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnltop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnltop.Controls.Add(Me.btnclose)
        Me.pnltop.Controls.Add(Me.lblprintsingle)
        Me.pnltop.Controls.Add(Me.picbox)
        Me.pnltop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnltop.Location = New System.Drawing.Point(0, 0)
        Me.pnltop.Name = "pnltop"
        Me.pnltop.Padding = New System.Windows.Forms.Padding(5)
        Me.pnltop.Size = New System.Drawing.Size(750, 28)
        Me.pnltop.TabIndex = 2
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.White
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Location = New System.Drawing.Point(723, 5)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(18, 14)
        Me.btnclose.TabIndex = 10
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'lblprintsingle
        '
        Me.lblprintsingle.AutoSize = True
        Me.lblprintsingle.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblprintsingle.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprintsingle.ForeColor = System.Drawing.Color.White
        Me.lblprintsingle.Location = New System.Drawing.Point(30, 5)
        Me.lblprintsingle.Name = "lblprintsingle"
        Me.lblprintsingle.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblprintsingle.Size = New System.Drawing.Size(50, 16)
        Me.lblprintsingle.TabIndex = 9
        Me.lblprintsingle.Text = "HELP"
        '
        'picbox
        '
        Me.picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picbox.Dock = System.Windows.Forms.DockStyle.Left
        Me.picbox.Location = New System.Drawing.Point(5, 5)
        Me.picbox.Name = "picbox"
        Me.picbox.Size = New System.Drawing.Size(25, 14)
        Me.picbox.TabIndex = 8
        Me.picbox.TabStop = False
        '
        'pnlfill
        '
        Me.pnlfill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlfill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlfill.Controls.Add(Me.pnlinfill)
        Me.pnlfill.Controls.Add(Me.Panel1)
        Me.pnlfill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlfill.Location = New System.Drawing.Point(0, 28)
        Me.pnlfill.Name = "pnlfill"
        Me.pnlfill.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlfill.Size = New System.Drawing.Size(750, 422)
        Me.pnlfill.TabIndex = 3
        '
        'pnlinfill
        '
        Me.pnlinfill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlinfill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlinfill.Location = New System.Drawing.Point(156, 15)
        Me.pnlinfill.Name = "pnlinfill"
        Me.pnlinfill.Size = New System.Drawing.Size(577, 390)
        Me.pnlinfill.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.treemenu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(15, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(141, 390)
        Me.Panel1.TabIndex = 1
        '
        'treemenu
        '
        Me.treemenu.BackColor = System.Drawing.Color.DodgerBlue
        Me.treemenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treemenu.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.treemenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.treemenu.Location = New System.Drawing.Point(0, 0)
        Me.treemenu.Name = "treemenu"
        TreeNode1.Name = "nabout"
        TreeNode1.Text = "About"
        TreeNode2.Name = "ngeneral"
        TreeNode2.Text = "General"
        TreeNode3.Name = "nshortcuts"
        TreeNode3.Text = "Shortcuts"
        Me.treemenu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Me.treemenu.Size = New System.Drawing.Size(141, 390)
        Me.treemenu.TabIndex = 0
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.pnltop
        Me.BunifuDragControl1.Vertical = True
        '
        'DialogHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(750, 450)
        Me.Controls.Add(Me.pnlfill)
        Me.Controls.Add(Me.pnltop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "DialogHelp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmHelp"
        Me.pnltop.ResumeLayout(False)
        Me.pnltop.PerformLayout()
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlfill.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnltop As System.Windows.Forms.Panel
    Friend WithEvents pnlfill As System.Windows.Forms.Panel
    Friend WithEvents lblprintsingle As System.Windows.Forms.Label
    Friend WithEvents picbox As System.Windows.Forms.PictureBox
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents pnlinfill As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents treemenu As System.Windows.Forms.TreeView
End Class
