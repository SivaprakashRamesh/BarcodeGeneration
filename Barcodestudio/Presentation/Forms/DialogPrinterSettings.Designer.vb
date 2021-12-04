<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dialogprinter
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
        Me.pnltop = New System.Windows.Forms.Panel()
        Me.lblprintsingle = New System.Windows.Forms.Label()
        Me.picbox = New System.Windows.Forms.PictureBox()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.pnlfill = New System.Windows.Forms.Panel()
        Me.lblprinter = New System.Windows.Forms.Label()
        Me.cmbprinter = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnok = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.pnltop.SuspendLayout()
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlfill.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnltop
        '
        Me.pnltop.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnltop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnltop.Controls.Add(Me.lblprintsingle)
        Me.pnltop.Controls.Add(Me.picbox)
        Me.pnltop.Controls.Add(Me.btnclose)
        Me.pnltop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnltop.Location = New System.Drawing.Point(0, 0)
        Me.pnltop.Name = "pnltop"
        Me.pnltop.Padding = New System.Windows.Forms.Padding(5)
        Me.pnltop.Size = New System.Drawing.Size(536, 28)
        Me.pnltop.TabIndex = 1
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
        Me.lblprintsingle.Size = New System.Drawing.Size(126, 16)
        Me.lblprintsingle.TabIndex = 5
        Me.lblprintsingle.Text = "Printer Settings"
        '
        'picbox
        '
        Me.picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picbox.Dock = System.Windows.Forms.DockStyle.Left
        Me.picbox.Location = New System.Drawing.Point(5, 5)
        Me.picbox.Name = "picbox"
        Me.picbox.Size = New System.Drawing.Size(25, 14)
        Me.picbox.TabIndex = 4
        Me.picbox.TabStop = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.White
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Location = New System.Drawing.Point(509, 5)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(18, 14)
        Me.btnclose.TabIndex = 3
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.pnltop
        Me.BunifuDragControl1.Vertical = True
        '
        'pnlfill
        '
        Me.pnlfill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlfill.Controls.Add(Me.lblprinter)
        Me.pnlfill.Controls.Add(Me.cmbprinter)
        Me.pnlfill.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlfill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlfill.Location = New System.Drawing.Point(0, 28)
        Me.pnlfill.Name = "pnlfill"
        Me.pnlfill.Size = New System.Drawing.Size(536, 121)
        Me.pnlfill.TabIndex = 2
        '
        'lblprinter
        '
        Me.lblprinter.AutoSize = True
        Me.lblprinter.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprinter.Location = New System.Drawing.Point(5, 26)
        Me.lblprinter.Name = "lblprinter"
        Me.lblprinter.Size = New System.Drawing.Size(166, 16)
        Me.lblprinter.TabIndex = 6
        Me.lblprinter.Text = "SET DEFAULT PRINTER"
        '
        'cmbprinter
        '
        Me.cmbprinter.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbprinter.FormattingEnabled = True
        Me.cmbprinter.Location = New System.Drawing.Point(174, 23)
        Me.cmbprinter.Name = "cmbprinter"
        Me.cmbprinter.Size = New System.Drawing.Size(357, 24)
        Me.cmbprinter.TabIndex = 5
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnok, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btncancel, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(376, 67)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'btnok
        '
        Me.btnok.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnok.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnok.FlatAppearance.BorderSize = 0
        Me.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnok.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.ForeColor = System.Drawing.Color.White
        Me.btnok.Location = New System.Drawing.Point(3, 3)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(67, 23)
        Me.btnok.TabIndex = 0
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncancel.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancel.FlatAppearance.BorderSize = 0
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.White
        Me.btncancel.Location = New System.Drawing.Point(76, 3)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(67, 23)
        Me.btncancel.TabIndex = 1
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'dialogprinter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(536, 149)
        Me.Controls.Add(Me.pnlfill)
        Me.Controls.Add(Me.pnltop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dialogprinter"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DialogPrinterSettings"
        Me.pnltop.ResumeLayout(False)
        Me.pnltop.PerformLayout()
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlfill.ResumeLayout(False)
        Me.pnlfill.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnltop As System.Windows.Forms.Panel
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents lblprintsingle As System.Windows.Forms.Label
    Friend WithEvents picbox As System.Windows.Forms.PictureBox
    Friend WithEvents pnlfill As System.Windows.Forms.Panel
    Friend WithEvents lblprinter As System.Windows.Forms.Label
    Friend WithEvents cmbprinter As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button

End Class
