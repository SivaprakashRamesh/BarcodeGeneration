<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CFL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CFL))
        Me.dgvfill = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.pnltop = New System.Windows.Forms.Panel()
        CType(Me.dgvfill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnltop.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvfill
        '
        Me.dgvfill.AllowUserToAddRows = False
        Me.dgvfill.AllowUserToDeleteRows = False
        Me.dgvfill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvfill.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvfill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvfill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvfill.Location = New System.Drawing.Point(5, 43)
        Me.dgvfill.Name = "dgvfill"
        Me.dgvfill.ReadOnly = True
        Me.dgvfill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvfill.Size = New System.Drawing.Size(524, 263)
        Me.dgvfill.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.Label1.Size = New System.Drawing.Size(150, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search By GRN.No"
        '
        'txtsearch
        '
        Me.txtsearch.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtsearch.Location = New System.Drawing.Point(155, 10)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(280, 20)
        Me.txtsearch.TabIndex = 1
        '
        'pnltop
        '
        Me.pnltop.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnltop.Controls.Add(Me.txtsearch)
        Me.pnltop.Controls.Add(Me.Label1)
        Me.pnltop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnltop.Location = New System.Drawing.Point(5, 5)
        Me.pnltop.Name = "pnltop"
        Me.pnltop.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
        Me.pnltop.Size = New System.Drawing.Size(524, 38)
        Me.pnltop.TabIndex = 0
        '
        'CFL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(534, 311)
        Me.Controls.Add(Me.dgvfill)
        Me.Controls.Add(Me.pnltop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "CFL"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "CFL GRN"
        CType(Me.dgvfill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnltop.ResumeLayout(False)
        Me.pnltop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvfill As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents pnltop As System.Windows.Forms.Panel
End Class
