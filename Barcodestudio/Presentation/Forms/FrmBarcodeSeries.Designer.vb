<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBarcodeSeries
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBarcodeSeries))
        Me.pnlbseries = New System.Windows.Forms.Panel()
        Me.pnlfill = New System.Windows.Forms.Panel()
        Me.rptviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.dgvbseries = New System.Windows.Forms.DataGridView()
        Me.pnlbtm = New System.Windows.Forms.Panel()
        Me.btnexexcel = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnpreview = New System.Windows.Forms.Button()
        Me.pnlgap2 = New System.Windows.Forms.Panel()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnback = New System.Windows.Forms.Button()
        Me.pnltop = New System.Windows.Forms.Panel()
        Me.pnlsearch = New System.Windows.Forms.Panel()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.lblsearchbarcode = New System.Windows.Forms.Label()
        Me.pnlfullpartial = New System.Windows.Forms.Panel()
        Me.dropfullpartial = New System.Windows.Forms.ComboBox()
        Me.lblfullpartial = New System.Windows.Forms.Label()
        Me.pnlbseries.SuspendLayout()
        Me.pnlfill.SuspendLayout()
        CType(Me.dgvbseries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlbtm.SuspendLayout()
        Me.pnltop.SuspendLayout()
        Me.pnlsearch.SuspendLayout()
        Me.pnlfullpartial.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlbseries
        '
        Me.pnlbseries.BackColor = System.Drawing.Color.White
        Me.pnlbseries.Controls.Add(Me.pnlfill)
        Me.pnlbseries.Controls.Add(Me.pnlbtm)
        Me.pnlbseries.Controls.Add(Me.pnltop)
        Me.pnlbseries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlbseries.Location = New System.Drawing.Point(0, 0)
        Me.pnlbseries.Name = "pnlbseries"
        Me.pnlbseries.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlbseries.Size = New System.Drawing.Size(1058, 561)
        Me.pnlbseries.TabIndex = 0
        '
        'pnlfill
        '
        Me.pnlfill.Controls.Add(Me.rptviewer)
        Me.pnlfill.Controls.Add(Me.dgvbseries)
        Me.pnlfill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlfill.Location = New System.Drawing.Point(5, 80)
        Me.pnlfill.Name = "pnlfill"
        Me.pnlfill.Size = New System.Drawing.Size(1048, 436)
        Me.pnlfill.TabIndex = 2
        '
        'rptviewer
        '
        Me.rptviewer.ActiveViewIndex = -1
        Me.rptviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptviewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.rptviewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptviewer.Enabled = False
        Me.rptviewer.Location = New System.Drawing.Point(636, 0)
        Me.rptviewer.Name = "rptviewer"
        Me.rptviewer.ShowPrintButton = False
        Me.rptviewer.Size = New System.Drawing.Size(412, 436)
        Me.rptviewer.TabIndex = 1
        Me.rptviewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'dgvbseries
        '
        Me.dgvbseries.AllowUserToAddRows = False
        Me.dgvbseries.AllowUserToDeleteRows = False
        Me.dgvbseries.BackgroundColor = System.Drawing.Color.White
        Me.dgvbseries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbseries.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvbseries.Location = New System.Drawing.Point(0, 0)
        Me.dgvbseries.Name = "dgvbseries"
        Me.dgvbseries.Size = New System.Drawing.Size(636, 436)
        Me.dgvbseries.TabIndex = 0
        '
        'pnlbtm
        '
        Me.pnlbtm.Controls.Add(Me.btnexexcel)
        Me.pnlbtm.Controls.Add(Me.Panel1)
        Me.pnlbtm.Controls.Add(Me.btnpreview)
        Me.pnlbtm.Controls.Add(Me.pnlgap2)
        Me.pnlbtm.Controls.Add(Me.btnprint)
        Me.pnlbtm.Controls.Add(Me.Panel2)
        Me.pnlbtm.Controls.Add(Me.btnback)
        Me.pnlbtm.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlbtm.Location = New System.Drawing.Point(5, 516)
        Me.pnlbtm.Name = "pnlbtm"
        Me.pnlbtm.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlbtm.Size = New System.Drawing.Size(1048, 40)
        Me.pnlbtm.TabIndex = 1
        '
        'btnexexcel
        '
        Me.btnexexcel.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnexexcel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnexexcel.FlatAppearance.BorderSize = 0
        Me.btnexexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexexcel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexexcel.ForeColor = System.Drawing.Color.White
        Me.btnexexcel.Location = New System.Drawing.Point(470, 5)
        Me.btnexexcel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnexexcel.Name = "btnexexcel"
        Me.btnexexcel.Size = New System.Drawing.Size(156, 30)
        Me.btnexexcel.TabIndex = 18
        Me.btnexexcel.Text = "&EXPORT TO EXCEL"
        Me.btnexexcel.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(626, 5)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(35, 30)
        Me.Panel1.TabIndex = 17
        '
        'btnpreview
        '
        Me.btnpreview.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnpreview.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnpreview.FlatAppearance.BorderSize = 0
        Me.btnpreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpreview.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpreview.ForeColor = System.Drawing.Color.White
        Me.btnpreview.Location = New System.Drawing.Point(661, 5)
        Me.btnpreview.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnpreview.Name = "btnpreview"
        Me.btnpreview.Size = New System.Drawing.Size(156, 30)
        Me.btnpreview.TabIndex = 16
        Me.btnpreview.Text = "PRE&VIEW"
        Me.btnpreview.UseVisualStyleBackColor = False
        '
        'pnlgap2
        '
        Me.pnlgap2.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlgap2.Location = New System.Drawing.Point(817, 5)
        Me.pnlgap2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlgap2.Name = "pnlgap2"
        Me.pnlgap2.Size = New System.Drawing.Size(35, 30)
        Me.pnlgap2.TabIndex = 15
        '
        'btnprint
        '
        Me.btnprint.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnprint.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnprint.FlatAppearance.BorderSize = 0
        Me.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.ForeColor = System.Drawing.Color.White
        Me.btnprint.Location = New System.Drawing.Point(852, 5)
        Me.btnprint.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(156, 30)
        Me.btnprint.TabIndex = 12
        Me.btnprint.Text = "&PRINT"
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1008, 5)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(35, 30)
        Me.Panel2.TabIndex = 11
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnback.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnback.FlatAppearance.BorderSize = 0
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnback.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.White
        Me.btnback.Location = New System.Drawing.Point(5, 5)
        Me.btnback.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(156, 30)
        Me.btnback.TabIndex = 4
        Me.btnback.Text = "&BACK"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'pnltop
        '
        Me.pnltop.Controls.Add(Me.pnlsearch)
        Me.pnltop.Controls.Add(Me.pnlfullpartial)
        Me.pnltop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnltop.Location = New System.Drawing.Point(5, 5)
        Me.pnltop.Name = "pnltop"
        Me.pnltop.Size = New System.Drawing.Size(1048, 75)
        Me.pnltop.TabIndex = 0
        '
        'pnlsearch
        '
        Me.pnlsearch.Controls.Add(Me.txtsearch)
        Me.pnlsearch.Controls.Add(Me.lblsearchbarcode)
        Me.pnlsearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlsearch.Location = New System.Drawing.Point(0, 36)
        Me.pnlsearch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlsearch.Name = "pnlsearch"
        Me.pnlsearch.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlsearch.Size = New System.Drawing.Size(1048, 36)
        Me.pnlsearch.TabIndex = 13
        '
        'txtsearch
        '
        Me.txtsearch.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtsearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(169, 5)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(200, 23)
        Me.txtsearch.TabIndex = 9
        '
        'lblsearchbarcode
        '
        Me.lblsearchbarcode.AutoSize = True
        Me.lblsearchbarcode.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblsearchbarcode.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsearchbarcode.Location = New System.Drawing.Point(5, 5)
        Me.lblsearchbarcode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsearchbarcode.Name = "lblsearchbarcode"
        Me.lblsearchbarcode.Padding = New System.Windows.Forms.Padding(0, 0, 25, 0)
        Me.lblsearchbarcode.Size = New System.Drawing.Size(164, 16)
        Me.lblsearchbarcode.TabIndex = 5
        Me.lblsearchbarcode.Text = "SEARCH BARCODE"
        '
        'pnlfullpartial
        '
        Me.pnlfullpartial.Controls.Add(Me.dropfullpartial)
        Me.pnlfullpartial.Controls.Add(Me.lblfullpartial)
        Me.pnlfullpartial.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlfullpartial.Location = New System.Drawing.Point(0, 0)
        Me.pnlfullpartial.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlfullpartial.Name = "pnlfullpartial"
        Me.pnlfullpartial.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlfullpartial.Size = New System.Drawing.Size(1048, 36)
        Me.pnlfullpartial.TabIndex = 12
        '
        'dropfullpartial
        '
        Me.dropfullpartial.Dock = System.Windows.Forms.DockStyle.Left
        Me.dropfullpartial.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropfullpartial.FormattingEnabled = True
        Me.dropfullpartial.Items.AddRange(New Object() {"Full", "Partial"})
        Me.dropfullpartial.Location = New System.Drawing.Point(170, 5)
        Me.dropfullpartial.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dropfullpartial.Name = "dropfullpartial"
        Me.dropfullpartial.Size = New System.Drawing.Size(200, 24)
        Me.dropfullpartial.TabIndex = 15
        '
        'lblfullpartial
        '
        Me.lblfullpartial.AutoSize = True
        Me.lblfullpartial.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblfullpartial.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfullpartial.Location = New System.Drawing.Point(5, 5)
        Me.lblfullpartial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfullpartial.Name = "lblfullpartial"
        Me.lblfullpartial.Padding = New System.Windows.Forms.Padding(0, 0, 45, 0)
        Me.lblfullpartial.Size = New System.Drawing.Size(165, 16)
        Me.lblfullpartial.TabIndex = 14
        Me.lblfullpartial.Text = "PARTIAL / FULL"
        '
        'FrmBarcodeSeries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1058, 561)
        Me.Controls.Add(Me.pnlbseries)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmBarcodeSeries"
        Me.Text = "FrmBarcodeSeries"
        Me.pnlbseries.ResumeLayout(False)
        Me.pnlfill.ResumeLayout(False)
        CType(Me.dgvbseries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlbtm.ResumeLayout(False)
        Me.pnltop.ResumeLayout(False)
        Me.pnlsearch.ResumeLayout(False)
        Me.pnlsearch.PerformLayout()
        Me.pnlfullpartial.ResumeLayout(False)
        Me.pnlfullpartial.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlbseries As System.Windows.Forms.Panel
    Friend WithEvents pnlfill As System.Windows.Forms.Panel
    Friend WithEvents pnlbtm As System.Windows.Forms.Panel
    Friend WithEvents pnltop As System.Windows.Forms.Panel
    Friend WithEvents dgvbseries As System.Windows.Forms.DataGridView
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents btnpreview As System.Windows.Forms.Button
    Friend WithEvents pnlgap2 As System.Windows.Forms.Panel
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnlfullpartial As System.Windows.Forms.Panel
    Friend WithEvents dropfullpartial As System.Windows.Forms.ComboBox
    Friend WithEvents lblfullpartial As System.Windows.Forms.Label
    Friend WithEvents pnlsearch As System.Windows.Forms.Panel
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents lblsearchbarcode As System.Windows.Forms.Label
    Friend WithEvents btnexexcel As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents rptviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
