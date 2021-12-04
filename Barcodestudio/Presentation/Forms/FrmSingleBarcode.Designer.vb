<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSingleBarcode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSingleBarcode))
        Me.pnlsingle = New System.Windows.Forms.Panel()
        Me.pnlsinglebttm = New System.Windows.Forms.Panel()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.pnlgap2 = New System.Windows.Forms.Panel()
        Me.pnlsinglemid = New System.Windows.Forms.Panel()
        Me.rptviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.pnlsingletop = New System.Windows.Forms.Panel()
        Me.pnlsearch = New System.Windows.Forms.Panel()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.lblsearchbarcode = New System.Windows.Forms.Label()
        Me.pnlsingle.SuspendLayout()
        Me.pnlsinglebttm.SuspendLayout()
        Me.pnlsinglemid.SuspendLayout()
        Me.pnlsingletop.SuspendLayout()
        Me.pnlsearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlsingle
        '
        Me.pnlsingle.BackColor = System.Drawing.Color.White
        Me.pnlsingle.Controls.Add(Me.pnlsinglebttm)
        Me.pnlsingle.Controls.Add(Me.pnlsinglemid)
        Me.pnlsingle.Controls.Add(Me.pnlsingletop)
        Me.pnlsingle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlsingle.Location = New System.Drawing.Point(0, 0)
        Me.pnlsingle.Name = "pnlsingle"
        Me.pnlsingle.Padding = New System.Windows.Forms.Padding(30)
        Me.pnlsingle.Size = New System.Drawing.Size(1058, 561)
        Me.pnlsingle.TabIndex = 0
        '
        'pnlsinglebttm
        '
        Me.pnlsinglebttm.Controls.Add(Me.btnprint)
        Me.pnlsinglebttm.Controls.Add(Me.pnlgap2)
        Me.pnlsinglebttm.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlsinglebttm.Location = New System.Drawing.Point(30, 491)
        Me.pnlsinglebttm.Name = "pnlsinglebttm"
        Me.pnlsinglebttm.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlsinglebttm.Size = New System.Drawing.Size(998, 40)
        Me.pnlsinglebttm.TabIndex = 2
        '
        'btnprint
        '
        Me.btnprint.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnprint.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnprint.Enabled = False
        Me.btnprint.FlatAppearance.BorderSize = 0
        Me.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.ForeColor = System.Drawing.Color.White
        Me.btnprint.Location = New System.Drawing.Point(610, 5)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(116, 30)
        Me.btnprint.TabIndex = 4
        Me.btnprint.Text = "&Print"
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'pnlgap2
        '
        Me.pnlgap2.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlgap2.Location = New System.Drawing.Point(726, 5)
        Me.pnlgap2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlgap2.Name = "pnlgap2"
        Me.pnlgap2.Size = New System.Drawing.Size(267, 30)
        Me.pnlgap2.TabIndex = 3
        '
        'pnlsinglemid
        '
        Me.pnlsinglemid.Controls.Add(Me.rptviewer)
        Me.pnlsinglemid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlsinglemid.Location = New System.Drawing.Point(30, 81)
        Me.pnlsinglemid.Name = "pnlsinglemid"
        Me.pnlsinglemid.Size = New System.Drawing.Size(998, 450)
        Me.pnlsinglemid.TabIndex = 1
        '
        'rptviewer
        '
        Me.rptviewer.ActiveViewIndex = -1
        Me.rptviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptviewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.rptviewer.DisplayToolbar = False
        Me.rptviewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptviewer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rptviewer.Location = New System.Drawing.Point(0, 0)
        Me.rptviewer.Name = "rptviewer"
        Me.rptviewer.Size = New System.Drawing.Size(998, 450)
        Me.rptviewer.TabIndex = 0
        Me.rptviewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'pnlsingletop
        '
        Me.pnlsingletop.Controls.Add(Me.pnlsearch)
        Me.pnlsingletop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlsingletop.Location = New System.Drawing.Point(30, 30)
        Me.pnlsingletop.Name = "pnlsingletop"
        Me.pnlsingletop.Size = New System.Drawing.Size(998, 51)
        Me.pnlsingletop.TabIndex = 0
        '
        'pnlsearch
        '
        Me.pnlsearch.Controls.Add(Me.txtsearch)
        Me.pnlsearch.Controls.Add(Me.lblsearchbarcode)
        Me.pnlsearch.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlsearch.Location = New System.Drawing.Point(0, 15)
        Me.pnlsearch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlsearch.Name = "pnlsearch"
        Me.pnlsearch.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlsearch.Size = New System.Drawing.Size(998, 36)
        Me.pnlsearch.TabIndex = 10
        '
        'txtsearch
        '
        Me.txtsearch.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtsearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(169, 5)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(428, 23)
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
        'FrmSingleBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1058, 561)
        Me.Controls.Add(Me.pnlsingle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSingleBarcode"
        Me.Text = "FrmSingleBarcode"
        Me.pnlsingle.ResumeLayout(False)
        Me.pnlsinglebttm.ResumeLayout(False)
        Me.pnlsinglemid.ResumeLayout(False)
        Me.pnlsingletop.ResumeLayout(False)
        Me.pnlsearch.ResumeLayout(False)
        Me.pnlsearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlsingle As System.Windows.Forms.Panel
    Friend WithEvents pnlsinglebttm As System.Windows.Forms.Panel
    Friend WithEvents pnlsinglemid As System.Windows.Forms.Panel
    Friend WithEvents pnlsingletop As System.Windows.Forms.Panel
    Friend WithEvents rptviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents pnlgap2 As System.Windows.Forms.Panel
    Friend WithEvents pnlsearch As System.Windows.Forms.Panel
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents lblsearchbarcode As System.Windows.Forms.Label
End Class
