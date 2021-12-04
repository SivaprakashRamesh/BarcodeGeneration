Imports System.IO
Public Class DialogHelp

#Region "Declaration"
    Dim count As Integer = 1
#End Region

#Region "Events"
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DialogHelp_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()
        End If
    End Sub

    Private Sub FrmHelp_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnclose.BackgroundImage = Image.FromFile(Application.StartupPath + "\images\closebtn.png")
        picbox.BackgroundImage = Image.FromFile(Application.StartupPath + "\images\logo.png")
        treemenu.SelectedNode = treemenu.Nodes(0)
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs)
        pnlinfill.BackgroundImage = Image.FromFile(Application.StartupPath + "\images\help" + count.ToString() + ".png")
        If count = 3 Then
            count = 0
        End If
        count += 1
    End Sub

#End Region

    Private Sub treemenu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles treemenu.AfterSelect
        If treemenu.SelectedNode.Name = "nabout" Then
            pnlinfill.Controls.Clear()
            Dim pnl As New Panel
            Dim picbox As PictureBox = New PictureBox
            Try
                picbox.BackgroundImage = Image.FromFile(Application.StartupPath + "\images\forby.jpg")
            Catch ex As Exception

            End Try
            picbox.BackgroundImageLayout = ImageLayout.Stretch
            picbox.Height = 290
            picbox.Dock = DockStyle.Fill
            pnl.Dock = DockStyle.Fill
            pnl.Controls.Add(picbox)
            pnlinfill.Controls.Add(pnl)
        ElseIf treemenu.SelectedNode.Name = "ngeneral" Then
            pnlinfill.Controls.Clear()
            Dim pnl As New Panel
            Dim picbox() As PictureBox
            ReDim picbox(3)
            picbox(0) = New PictureBox
            picbox(1) = New PictureBox
            picbox(2) = New PictureBox
            picbox(2).BackgroundImage = Image.FromFile(Application.StartupPath + "\images\help3.png")
            picbox(1).BackgroundImage = Image.FromFile(Application.StartupPath + "\images\help2.png")
            picbox(0).BackgroundImage = Image.FromFile(Application.StartupPath + "\images\help1.png")
            picbox(0).BackgroundImageLayout = ImageLayout.Stretch
            picbox(1).BackgroundImageLayout = ImageLayout.Stretch
            picbox(2).BackgroundImageLayout = ImageLayout.Stretch
            picbox(0).Height = 290
            picbox(1).Height = 290
            picbox(2).Height = 250
            picbox(2).Dock = DockStyle.Top
            picbox(1).Dock = DockStyle.Top
            picbox(0).Dock = DockStyle.Top
            pnl.Dock = DockStyle.Fill
            pnl.AutoScroll = True
            pnl.Controls.Add(picbox(2))
            pnl.Controls.Add(picbox(1))
            pnl.Controls.Add(picbox(0))
            pnlinfill.Controls.Add(pnl)
        ElseIf treemenu.SelectedNode.Name = "nmenu" Then
            pnlinfill.Controls.Clear()
            Dim pnl As New Panel
            Dim picbox As PictureBox = New PictureBox
            Try
                picbox.BackgroundImage = Image.FromFile(Application.StartupPath + "\images\menuhelp.png")
            Catch ex As Exception

            End Try
            picbox.BackgroundImageLayout = ImageLayout.Stretch
            picbox.Dock = DockStyle.Fill
            pnl.Dock = DockStyle.Fill
            pnl.Controls.Add(picbox)
            pnlinfill.Controls.Add(pnl)
        ElseIf treemenu.SelectedNode.Name = "nshortcuts" Then
            pnlinfill.Controls.Clear()
            Dim pnl As New Panel
            Dim picbox As PictureBox = New PictureBox
            Try
                picbox.BackgroundImage = Image.FromFile(Application.StartupPath + "\images\shortcuts.png")
            Catch ex As Exception

            End Try
            picbox.BackgroundImageLayout = ImageLayout.Stretch
            picbox.Dock = DockStyle.Fill
            pnl.Dock = DockStyle.Fill
            pnl.Controls.Add(picbox)
            pnlinfill.Controls.Add(pnl)
        End If
    End Sub
End Class