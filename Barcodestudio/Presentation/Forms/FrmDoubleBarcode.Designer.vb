<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDoubleBarcode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDoubleBarcode))
        Me.menuMain = New System.Windows.Forms.MenuStrip()
        Me.menutoolfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.menustnew = New System.Windows.Forms.ToolStripMenuItem()
        Me.menustclose = New System.Windows.Forms.ToolStripMenuItem()
        Me.menutoolbarcode = New System.Windows.Forms.ToolStripMenuItem()
        Me.menustdouble = New System.Windows.Forms.ToolStripMenuItem()
        Me.menustsingle = New System.Windows.Forms.ToolStripMenuItem()
        Me.menutoolprinter = New System.Windows.Forms.ToolStripMenuItem()
        Me.menustprinter = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColumnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menusthelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlmenu = New System.Windows.Forms.Panel()
        Me.pnlmain = New System.Windows.Forms.Panel()
        Me.pnldouble = New System.Windows.Forms.Panel()
        Me.pnlline = New System.Windows.Forms.Panel()
        Me.dgvgrnline = New System.Windows.Forms.DataGridView()
        Me.pnlbtm = New System.Windows.Forms.Panel()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.pnlspace1 = New System.Windows.Forms.Panel()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.pnlspace2 = New System.Windows.Forms.Panel()
        Me.pnlheader = New System.Windows.Forms.Panel()
        Me.pnlsearch = New System.Windows.Forms.Panel()
        Me.txtdocentry = New System.Windows.Forms.TextBox()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.lblsearchitem = New System.Windows.Forms.Label()
        Me.pnlsubdate = New System.Windows.Forms.Panel()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.txtdate = New System.Windows.Forms.TextBox()
        Me.txtsupplier = New System.Windows.Forms.TextBox()
        Me.lblsupplier = New System.Windows.Forms.Label()
        Me.pnlfullgrn = New System.Windows.Forms.Panel()
        Me.lblgrnno = New System.Windows.Forms.Label()
        Me.txtgrndocentry = New System.Windows.Forms.TextBox()
        Me.pnlcfl = New System.Windows.Forms.Panel()
        Me.btncfl = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.dropfullpartial = New System.Windows.Forms.ComboBox()
        Me.lblfullpartial = New System.Windows.Forms.Label()
        Me.pnldate = New System.Windows.Forms.Panel()
        Me.lbltodate = New System.Windows.Forms.Label()
        Me.dateto = New System.Windows.Forms.DateTimePicker()
        Me.datefrom = New System.Windows.Forms.DateTimePicker()
        Me.lblfromdate = New System.Windows.Forms.Label()
        Me.menuMain.SuspendLayout()
        Me.pnlmenu.SuspendLayout()
        Me.pnlmain.SuspendLayout()
        Me.pnldouble.SuspendLayout()
        Me.pnlline.SuspendLayout()
        CType(Me.dgvgrnline, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlbtm.SuspendLayout()
        Me.pnlheader.SuspendLayout()
        Me.pnlsearch.SuspendLayout()
        Me.pnlsubdate.SuspendLayout()
        Me.pnlfullgrn.SuspendLayout()
        Me.pnlcfl.SuspendLayout()
        Me.pnldate.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuMain
        '
        Me.menuMain.BackColor = System.Drawing.Color.DodgerBlue
        Me.menuMain.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menutoolfile, Me.menutoolbarcode, Me.menutoolprinter})
        Me.menuMain.Location = New System.Drawing.Point(0, 0)
        Me.menuMain.Name = "menuMain"
        Me.menuMain.Padding = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.menuMain.Size = New System.Drawing.Size(1048, 24)
        Me.menuMain.TabIndex = 19
        Me.menuMain.Text = "menumain"
        '
        'menutoolfile
        '
        Me.menutoolfile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menustnew, Me.menustclose})
        Me.menutoolfile.ForeColor = System.Drawing.Color.Black
        Me.menutoolfile.Name = "menutoolfile"
        Me.menutoolfile.Size = New System.Drawing.Size(43, 20)
        Me.menutoolfile.Text = "&File"
        '
        'menustnew
        '
        Me.menustnew.BackColor = System.Drawing.Color.DodgerBlue
        Me.menustnew.ForeColor = System.Drawing.Color.White
        Me.menustnew.Name = "menustnew"
        Me.menustnew.Size = New System.Drawing.Size(109, 22)
        Me.menustnew.Text = "&New"
        '
        'menustclose
        '
        Me.menustclose.BackColor = System.Drawing.Color.DodgerBlue
        Me.menustclose.ForeColor = System.Drawing.Color.White
        Me.menustclose.Name = "menustclose"
        Me.menustclose.Size = New System.Drawing.Size(109, 22)
        Me.menustclose.Text = "&Close"
        '
        'menutoolbarcode
        '
        Me.menutoolbarcode.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menustdouble, Me.menustsingle})
        Me.menutoolbarcode.ForeColor = System.Drawing.Color.Black
        Me.menutoolbarcode.Name = "menutoolbarcode"
        Me.menutoolbarcode.Size = New System.Drawing.Size(72, 20)
        Me.menutoolbarcode.Text = "&Barcode"
        '
        'menustdouble
        '
        Me.menustdouble.BackColor = System.Drawing.Color.DodgerBlue
        Me.menustdouble.ForeColor = System.Drawing.Color.White
        Me.menustdouble.Name = "menustdouble"
        Me.menustdouble.Size = New System.Drawing.Size(206, 22)
        Me.menustdouble.Text = "&Print Barcode"
        '
        'menustsingle
        '
        Me.menustsingle.BackColor = System.Drawing.Color.DodgerBlue
        Me.menustsingle.ForeColor = System.Drawing.Color.White
        Me.menustsingle.Name = "menustsingle"
        Me.menustsingle.Size = New System.Drawing.Size(206, 22)
        Me.menustsingle.Text = "&Single Print Barcode"
        '
        'menutoolprinter
        '
        Me.menutoolprinter.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menustprinter, Me.ColumnToolStripMenuItem, Me.menusthelp})
        Me.menutoolprinter.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menutoolprinter.ForeColor = System.Drawing.Color.Black
        Me.menutoolprinter.Name = "menutoolprinter"
        Me.menutoolprinter.Size = New System.Drawing.Size(72, 20)
        Me.menutoolprinter.Text = "&Settings"
        '
        'menustprinter
        '
        Me.menustprinter.BackColor = System.Drawing.Color.DodgerBlue
        Me.menustprinter.ForeColor = System.Drawing.Color.White
        Me.menustprinter.Name = "menustprinter"
        Me.menustprinter.Size = New System.Drawing.Size(176, 22)
        Me.menustprinter.Text = "&Printer Settings"
        '
        'ColumnToolStripMenuItem
        '
        Me.ColumnToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue
        Me.ColumnToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ColumnToolStripMenuItem.Name = "ColumnToolStripMenuItem"
        Me.ColumnToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ColumnToolStripMenuItem.Text = "Column"
        '
        'menusthelp
        '
        Me.menusthelp.BackColor = System.Drawing.Color.DodgerBlue
        Me.menusthelp.ForeColor = System.Drawing.Color.White
        Me.menusthelp.Name = "menusthelp"
        Me.menusthelp.Size = New System.Drawing.Size(176, 22)
        Me.menusthelp.Text = "&Help"
        '
        'pnlmenu
        '
        Me.pnlmenu.Controls.Add(Me.menuMain)
        Me.pnlmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlmenu.Location = New System.Drawing.Point(5, 0)
        Me.pnlmenu.Name = "pnlmenu"
        Me.pnlmenu.Size = New System.Drawing.Size(1048, 24)
        Me.pnlmenu.TabIndex = 3
        '
        'pnlmain
        '
        Me.pnlmain.Controls.Add(Me.pnldouble)
        Me.pnlmain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlmain.Location = New System.Drawing.Point(5, 24)
        Me.pnlmain.Name = "pnlmain"
        Me.pnlmain.Size = New System.Drawing.Size(1048, 532)
        Me.pnlmain.TabIndex = 4
        '
        'pnldouble
        '
        Me.pnldouble.BackColor = System.Drawing.Color.White
        Me.pnldouble.Controls.Add(Me.pnlline)
        Me.pnldouble.Controls.Add(Me.pnlbtm)
        Me.pnldouble.Controls.Add(Me.pnlheader)
        Me.pnldouble.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnldouble.Location = New System.Drawing.Point(0, 0)
        Me.pnldouble.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnldouble.Name = "pnldouble"
        Me.pnldouble.Size = New System.Drawing.Size(1048, 532)
        Me.pnldouble.TabIndex = 18
        '
        'pnlline
        '
        Me.pnlline.Controls.Add(Me.dgvgrnline)
        Me.pnlline.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlline.Location = New System.Drawing.Point(0, 155)
        Me.pnlline.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlline.Name = "pnlline"
        Me.pnlline.Size = New System.Drawing.Size(1048, 337)
        Me.pnlline.TabIndex = 16
        '
        'dgvgrnline
        '
        Me.dgvgrnline.AllowUserToAddRows = False
        Me.dgvgrnline.AllowUserToDeleteRows = False
        Me.dgvgrnline.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvgrnline.BackgroundColor = System.Drawing.Color.White
        Me.dgvgrnline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvgrnline.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvgrnline.Location = New System.Drawing.Point(0, 0)
        Me.dgvgrnline.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgvgrnline.Name = "dgvgrnline"
        Me.dgvgrnline.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvgrnline.Size = New System.Drawing.Size(1048, 337)
        Me.dgvgrnline.TabIndex = 10
        '
        'pnlbtm
        '
        Me.pnlbtm.Controls.Add(Me.btncancel)
        Me.pnlbtm.Controls.Add(Me.pnlspace1)
        Me.pnlbtm.Controls.Add(Me.btnnext)
        Me.pnlbtm.Controls.Add(Me.pnlspace2)
        Me.pnlbtm.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlbtm.Location = New System.Drawing.Point(0, 492)
        Me.pnlbtm.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlbtm.Name = "pnlbtm"
        Me.pnlbtm.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlbtm.Size = New System.Drawing.Size(1048, 40)
        Me.pnlbtm.TabIndex = 17
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btncancel.FlatAppearance.BorderSize = 0
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.White
        Me.btncancel.Location = New System.Drawing.Point(661, 5)
        Me.btncancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(156, 30)
        Me.btncancel.TabIndex = 8
        Me.btncancel.Text = "&CANCEL"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'pnlspace1
        '
        Me.pnlspace1.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlspace1.Location = New System.Drawing.Point(817, 5)
        Me.pnlspace1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlspace1.Name = "pnlspace1"
        Me.pnlspace1.Size = New System.Drawing.Size(35, 30)
        Me.pnlspace1.TabIndex = 16
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnnext.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnnext.Enabled = False
        Me.btnnext.FlatAppearance.BorderSize = 0
        Me.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.ForeColor = System.Drawing.Color.White
        Me.btnnext.Location = New System.Drawing.Point(852, 5)
        Me.btnnext.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(156, 30)
        Me.btnnext.TabIndex = 9
        Me.btnnext.Text = "&NEXT"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'pnlspace2
        '
        Me.pnlspace2.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlspace2.Location = New System.Drawing.Point(1008, 5)
        Me.pnlspace2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlspace2.Name = "pnlspace2"
        Me.pnlspace2.Size = New System.Drawing.Size(35, 30)
        Me.pnlspace2.TabIndex = 14
        '
        'pnlheader
        '
        Me.pnlheader.Controls.Add(Me.pnlsearch)
        Me.pnlheader.Controls.Add(Me.pnlsubdate)
        Me.pnlheader.Controls.Add(Me.pnlfullgrn)
        Me.pnlheader.Controls.Add(Me.pnldate)
        Me.pnlheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlheader.Location = New System.Drawing.Point(0, 0)
        Me.pnlheader.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlheader.Name = "pnlheader"
        Me.pnlheader.Size = New System.Drawing.Size(1048, 155)
        Me.pnlheader.TabIndex = 15
        '
        'pnlsearch
        '
        Me.pnlsearch.Controls.Add(Me.txtdocentry)
        Me.pnlsearch.Controls.Add(Me.txtsearch)
        Me.pnlsearch.Controls.Add(Me.lblsearchitem)
        Me.pnlsearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlsearch.Location = New System.Drawing.Point(0, 113)
        Me.pnlsearch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlsearch.Name = "pnlsearch"
        Me.pnlsearch.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlsearch.Size = New System.Drawing.Size(1048, 36)
        Me.pnlsearch.TabIndex = 14
        '
        'txtdocentry
        '
        Me.txtdocentry.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtdocentry.Enabled = False
        Me.txtdocentry.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdocentry.Location = New System.Drawing.Point(843, 5)
        Me.txtdocentry.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtdocentry.Name = "txtdocentry"
        Me.txtdocentry.Size = New System.Drawing.Size(200, 23)
        Me.txtdocentry.TabIndex = 8
        Me.txtdocentry.Visible = False
        '
        'txtsearch
        '
        Me.txtsearch.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtsearch.Enabled = False
        Me.txtsearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(135, 5)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(200, 23)
        Me.txtsearch.TabIndex = 7
        '
        'lblsearchitem
        '
        Me.lblsearchitem.AutoSize = True
        Me.lblsearchitem.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblsearchitem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsearchitem.Location = New System.Drawing.Point(5, 5)
        Me.lblsearchitem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsearchitem.Name = "lblsearchitem"
        Me.lblsearchitem.Padding = New System.Windows.Forms.Padding(0, 0, 25, 0)
        Me.lblsearchitem.Size = New System.Drawing.Size(130, 16)
        Me.lblsearchitem.TabIndex = 5
        Me.lblsearchitem.Text = "SEARCH ITEM"
        '
        'pnlsubdate
        '
        Me.pnlsubdate.Controls.Add(Me.lbldate)
        Me.pnlsubdate.Controls.Add(Me.txtdate)
        Me.pnlsubdate.Controls.Add(Me.txtsupplier)
        Me.pnlsubdate.Controls.Add(Me.lblsupplier)
        Me.pnlsubdate.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlsubdate.Location = New System.Drawing.Point(0, 78)
        Me.pnlsubdate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlsubdate.Name = "pnlsubdate"
        Me.pnlsubdate.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlsubdate.Size = New System.Drawing.Size(1048, 35)
        Me.pnlsubdate.TabIndex = 13
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbldate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(733, 5)
        Me.lbldate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Padding = New System.Windows.Forms.Padding(0, 0, 32, 0)
        Me.lbldate.Size = New System.Drawing.Size(110, 16)
        Me.lbldate.TabIndex = 12
        Me.lbldate.Text = "GRN DATE"
        '
        'txtdate
        '
        Me.txtdate.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtdate.Enabled = False
        Me.txtdate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdate.Location = New System.Drawing.Point(843, 5)
        Me.txtdate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(200, 23)
        Me.txtdate.TabIndex = 6
        '
        'txtsupplier
        '
        Me.txtsupplier.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtsupplier.Enabled = False
        Me.txtsupplier.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsupplier.Location = New System.Drawing.Point(137, 5)
        Me.txtsupplier.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtsupplier.Name = "txtsupplier"
        Me.txtsupplier.Size = New System.Drawing.Size(200, 23)
        Me.txtsupplier.TabIndex = 5
        '
        'lblsupplier
        '
        Me.lblsupplier.AutoSize = True
        Me.lblsupplier.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblsupplier.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsupplier.Location = New System.Drawing.Point(5, 5)
        Me.lblsupplier.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsupplier.Name = "lblsupplier"
        Me.lblsupplier.Padding = New System.Windows.Forms.Padding(0, 0, 55, 0)
        Me.lblsupplier.Size = New System.Drawing.Size(132, 16)
        Me.lblsupplier.TabIndex = 5
        Me.lblsupplier.Text = "SUPPLIER"
        '
        'pnlfullgrn
        '
        Me.pnlfullgrn.Controls.Add(Me.lblgrnno)
        Me.pnlfullgrn.Controls.Add(Me.txtgrndocentry)
        Me.pnlfullgrn.Controls.Add(Me.pnlcfl)
        Me.pnlfullgrn.Controls.Add(Me.dropfullpartial)
        Me.pnlfullgrn.Controls.Add(Me.lblfullpartial)
        Me.pnlfullgrn.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlfullgrn.Location = New System.Drawing.Point(0, 43)
        Me.pnlfullgrn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlfullgrn.Name = "pnlfullgrn"
        Me.pnlfullgrn.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlfullgrn.Size = New System.Drawing.Size(1048, 35)
        Me.pnlfullgrn.TabIndex = 12
        '
        'lblgrnno
        '
        Me.lblgrnno.AutoSize = True
        Me.lblgrnno.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblgrnno.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgrnno.Location = New System.Drawing.Point(733, 5)
        Me.lblgrnno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblgrnno.Name = "lblgrnno"
        Me.lblgrnno.Padding = New System.Windows.Forms.Padding(0, 0, 50, 0)
        Me.lblgrnno.Size = New System.Drawing.Size(110, 16)
        Me.lblgrnno.TabIndex = 19
        Me.lblgrnno.Text = "GRN No"
        '
        'txtgrndocentry
        '
        Me.txtgrndocentry.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtgrndocentry.Enabled = False
        Me.txtgrndocentry.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtgrndocentry.Location = New System.Drawing.Point(843, 5)
        Me.txtgrndocentry.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtgrndocentry.Name = "txtgrndocentry"
        Me.txtgrndocentry.Size = New System.Drawing.Size(175, 25)
        Me.txtgrndocentry.TabIndex = 3
        '
        'pnlcfl
        '
        Me.pnlcfl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlcfl.Controls.Add(Me.btncfl)
        Me.pnlcfl.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlcfl.Location = New System.Drawing.Point(1018, 5)
        Me.pnlcfl.Name = "pnlcfl"
        Me.pnlcfl.Padding = New System.Windows.Forms.Padding(3)
        Me.pnlcfl.Size = New System.Drawing.Size(25, 25)
        Me.pnlcfl.TabIndex = 17
        '
        'btncfl
        '
        Me.btncfl.Activecolor = System.Drawing.Color.White
        Me.btncfl.BackColor = System.Drawing.Color.White
        Me.btncfl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncfl.BorderRadius = 0
        Me.btncfl.ButtonText = ""
        Me.btncfl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncfl.DisabledColor = System.Drawing.Color.Gray
        Me.btncfl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btncfl.ForeColor = System.Drawing.Color.White
        Me.btncfl.Iconcolor = System.Drawing.Color.Transparent
        Me.btncfl.Iconimage = Nothing
        Me.btncfl.Iconimage_right = Nothing
        Me.btncfl.Iconimage_right_Selected = Nothing
        Me.btncfl.Iconimage_Selected = Nothing
        Me.btncfl.IconMarginLeft = 0
        Me.btncfl.IconMarginRight = 0
        Me.btncfl.IconRightVisible = True
        Me.btncfl.IconRightZoom = 0.0R
        Me.btncfl.IconVisible = True
        Me.btncfl.IconZoom = 90.0R
        Me.btncfl.IsTab = False
        Me.btncfl.Location = New System.Drawing.Point(3, 3)
        Me.btncfl.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.btncfl.Name = "btncfl"
        Me.btncfl.Normalcolor = System.Drawing.Color.White
        Me.btncfl.OnHovercolor = System.Drawing.Color.WhiteSmoke
        Me.btncfl.OnHoverTextColor = System.Drawing.Color.Black
        Me.btncfl.selected = False
        Me.btncfl.Size = New System.Drawing.Size(17, 17)
        Me.btncfl.TabIndex = 4
        Me.btncfl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncfl.Textcolor = System.Drawing.Color.Black
        Me.btncfl.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'dropfullpartial
        '
        Me.dropfullpartial.Dock = System.Windows.Forms.DockStyle.Left
        Me.dropfullpartial.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropfullpartial.FormattingEnabled = True
        Me.dropfullpartial.Items.AddRange(New Object() {"Full", "Partial"})
        Me.dropfullpartial.Location = New System.Drawing.Point(138, 5)
        Me.dropfullpartial.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dropfullpartial.Name = "dropfullpartial"
        Me.dropfullpartial.Size = New System.Drawing.Size(200, 24)
        Me.dropfullpartial.TabIndex = 2
        '
        'lblfullpartial
        '
        Me.lblfullpartial.AutoSize = True
        Me.lblfullpartial.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblfullpartial.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfullpartial.Location = New System.Drawing.Point(5, 5)
        Me.lblfullpartial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfullpartial.Name = "lblfullpartial"
        Me.lblfullpartial.Padding = New System.Windows.Forms.Padding(0, 0, 13, 0)
        Me.lblfullpartial.Size = New System.Drawing.Size(133, 16)
        Me.lblfullpartial.TabIndex = 5
        Me.lblfullpartial.Text = "PARTIAL / FULL"
        '
        'pnldate
        '
        Me.pnldate.Controls.Add(Me.lbltodate)
        Me.pnldate.Controls.Add(Me.dateto)
        Me.pnldate.Controls.Add(Me.datefrom)
        Me.pnldate.Controls.Add(Me.lblfromdate)
        Me.pnldate.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnldate.Location = New System.Drawing.Point(0, 0)
        Me.pnldate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnldate.Name = "pnldate"
        Me.pnldate.Padding = New System.Windows.Forms.Padding(5, 15, 5, 5)
        Me.pnldate.Size = New System.Drawing.Size(1048, 43)
        Me.pnldate.TabIndex = 11
        '
        'lbltodate
        '
        Me.lbltodate.AutoSize = True
        Me.lbltodate.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbltodate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltodate.Location = New System.Drawing.Point(735, 15)
        Me.lbltodate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltodate.Name = "lbltodate"
        Me.lbltodate.Padding = New System.Windows.Forms.Padding(0, 0, 40, 0)
        Me.lbltodate.Size = New System.Drawing.Size(108, 16)
        Me.lbltodate.TabIndex = 15
        Me.lbltodate.Text = "TO DATE"
        '
        'dateto
        '
        Me.dateto.CustomFormat = "dd-MM-yyyy"
        Me.dateto.Dock = System.Windows.Forms.DockStyle.Right
        Me.dateto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateto.Location = New System.Drawing.Point(843, 15)
        Me.dateto.Name = "dateto"
        Me.dateto.Size = New System.Drawing.Size(200, 23)
        Me.dateto.TabIndex = 1
        '
        'datefrom
        '
        Me.datefrom.CustomFormat = "dd-MM-yyyy"
        Me.datefrom.Dock = System.Windows.Forms.DockStyle.Left
        Me.datefrom.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datefrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datefrom.Location = New System.Drawing.Point(140, 15)
        Me.datefrom.Name = "datefrom"
        Me.datefrom.Size = New System.Drawing.Size(200, 23)
        Me.datefrom.TabIndex = 0
        '
        'lblfromdate
        '
        Me.lblfromdate.AutoSize = True
        Me.lblfromdate.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblfromdate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfromdate.Location = New System.Drawing.Point(5, 15)
        Me.lblfromdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfromdate.Name = "lblfromdate"
        Me.lblfromdate.Padding = New System.Windows.Forms.Padding(0, 0, 45, 0)
        Me.lblfromdate.Size = New System.Drawing.Size(135, 16)
        Me.lblfromdate.TabIndex = 5
        Me.lblfromdate.Text = "FROM DATE"
        '
        'FrmDoubleBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1058, 561)
        Me.Controls.Add(Me.pnlmain)
        Me.Controls.Add(Me.pnlmenu)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(1, 1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmDoubleBarcode"
        Me.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vasan Barcode"
        Me.menuMain.ResumeLayout(False)
        Me.menuMain.PerformLayout()
        Me.pnlmenu.ResumeLayout(False)
        Me.pnlmenu.PerformLayout()
        Me.pnlmain.ResumeLayout(False)
        Me.pnldouble.ResumeLayout(False)
        Me.pnlline.ResumeLayout(False)
        CType(Me.dgvgrnline, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlbtm.ResumeLayout(False)
        Me.pnlheader.ResumeLayout(False)
        Me.pnlsearch.ResumeLayout(False)
        Me.pnlsearch.PerformLayout()
        Me.pnlsubdate.ResumeLayout(False)
        Me.pnlsubdate.PerformLayout()
        Me.pnlfullgrn.ResumeLayout(False)
        Me.pnlfullgrn.PerformLayout()
        Me.pnlcfl.ResumeLayout(False)
        Me.pnldate.ResumeLayout(False)
        Me.pnldate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents menuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents menutoolfile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menustnew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menustclose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menutoolbarcode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menustdouble As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menustsingle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menutoolprinter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlmenu As System.Windows.Forms.Panel
    Friend WithEvents pnlmain As System.Windows.Forms.Panel
    Friend WithEvents pnldouble As System.Windows.Forms.Panel
    Friend WithEvents pnlline As System.Windows.Forms.Panel
    Friend WithEvents dgvgrnline As System.Windows.Forms.DataGridView
    Friend WithEvents pnlbtm As System.Windows.Forms.Panel
    Friend WithEvents pnlheader As System.Windows.Forms.Panel
    Friend WithEvents pnlsearch As System.Windows.Forms.Panel
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents lblsearchitem As System.Windows.Forms.Label
    Friend WithEvents pnlsubdate As System.Windows.Forms.Panel
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents txtdate As System.Windows.Forms.TextBox
    Friend WithEvents txtsupplier As System.Windows.Forms.TextBox
    Friend WithEvents lblsupplier As System.Windows.Forms.Label
    Friend WithEvents pnlfullgrn As System.Windows.Forms.Panel
    Friend WithEvents dropfullpartial As System.Windows.Forms.ComboBox
    Friend WithEvents lblfullpartial As System.Windows.Forms.Label
    Friend WithEvents pnldate As System.Windows.Forms.Panel
    Friend WithEvents lbltodate As System.Windows.Forms.Label
    Friend WithEvents dateto As System.Windows.Forms.DateTimePicker
    Friend WithEvents datefrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblfromdate As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents pnlspace1 As System.Windows.Forms.Panel
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents pnlspace2 As System.Windows.Forms.Panel
    Friend WithEvents txtdocentry As System.Windows.Forms.TextBox
    Friend WithEvents lblgrnno As System.Windows.Forms.Label
    Friend WithEvents txtgrndocentry As System.Windows.Forms.TextBox
    Friend WithEvents pnlcfl As System.Windows.Forms.Panel
    Friend WithEvents btncfl As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents menustprinter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menusthelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
