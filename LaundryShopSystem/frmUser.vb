Public Class frmUser
    Dim id As String = "0"



    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnTitle.MouseDown, lbltitle.MouseDown
        xpos = Cursor.Position.X - Me.Location.X
        ypos = Cursor.Position.Y - Me.Location.Y
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnTitle.MouseMove, lbltitle.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            pos = MousePosition
            pos.X = pos.X - xpos
            pos.Y = pos.Y - ypos
            Me.Location = pos
        End If
    End Sub

    Private Sub frmUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AuthenticateUser()
        PopulateUser(lvuser)
    End Sub

    Private Sub lvcompany_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvuser.MouseClick
        With lvuser.SelectedItems(0)
            id = .SubItems(0).Text
            tbuname.Text = .SubItems(1).Text
            tbpword.Text = .SubItems(2).Text
            cbopos.Text = .SubItems(3).Text
        End With
        notif("", Color.LimeGreen, False)
        gbcom.Enabled = True
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If btnedit.Text = "Cancel" Then
            btnadd.Text = "Add"
            btnedit.Text = "Edit"
            btndelete.Visible = True
            btnclear.Visible = True
            gbcom.Enabled = False
            notif("", Color.LimeGreen, False)
        Else
            If id = "0" Then
                notif("*Select from User List!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            End If
            If tbuname.Text = "" Then
                notif("*Username is missing!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            ElseIf tbpword.Text = "" Then
                notif("*Password is missing!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            ElseIf cbopos.Text = "" Then
                notif("*Position is missing!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            End If
            EditData()
            notif("*Updated Data!", Color.LimeGreen, True)
        End If
    End Sub


    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If btnadd.Text = "Add" Then
            btnadd.Text = "Save"
            btnedit.Text = "Cancel"
            btndelete.Visible = False
            btnclear.Visible = False
            gbcom.Enabled = True
            ClearData()
            notif("*Enter Data and Click Save", Color.FromArgb(0, 192, 192), True)
            tbuname.SelectAll()
            tbuname.Focus()
        Else
            If tbuname.Text = "" Then
                notif("*Username is missing!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            ElseIf tbpword.Text = "" Then
                notif("*Password is missing!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            ElseIf cbopos.Text = "" Then
                notif("*Position is missing!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            End If
            'validation if username is existing
            If DoesExist("tbluser", "uname", tbuname.Text) = True Then
                lblnotif.Visible = True
                MessageNotif(3, "*Existing Username " & tbuname.Text.ToUpper & "!")
                Exit Sub
            End If
            SaveData()

            MessageNotif(2, "*Saved Data!")
            End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        DeleteData()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        ClearData()
        PopulateUser(lvuser)
        MessageNotif(0, "")

    End Sub

    Sub EditData()
        Connected()
        sql = "UPDATE tbluser SET uname = '" & tbuname.Text & "', upword = '" & tbpword.Text.ToLower & "', uposition = '" & cbopos.Text.ToLower & "' where id = " & id & ""
        CommandDB()
        cmd.ExecuteNonQuery()
        PopulateUser(lvuser)
    End Sub


    Sub SaveData()
        Connected()
        sql = "INSERT INTO tbluser (uname, upword, uposition) VALUES ('" & tbuname.Text.ToLower & "','" & tbpword.Text.ToLower & "','" & cbopos.Text.ToLower & "')"
        CommandDB()
        dr = cmd.ExecuteReader()
        PopulateUser(lvuser)
    End Sub

    Sub DeleteData()
        Connected()
        Dim i As Integer
        sql = "DELETE FROM tbluser WHERE id = " & id & ""
        'validattion
        If id = "0" Then
            'notif("*Select from User List!", Color.FromArgb(255, 128, 128), True)
            MessageNotif(3, "*Select from User List!")
            Exit Sub
        End If
        CommandDB()
        i = MsgBox("Are you sure you want to delete " & tbuname.Text.ToUpper & "?", MsgBoxStyle.YesNo)
        If i = MsgBoxResult.Yes Then
            'execute delete query
            cmd.ExecuteNonQuery()
            notif("*Deleted Data!", Color.LimeGreen, True)
            PopulateUser(lvuser)
        End If
    End Sub
    Sub ClearData()
        id = "0"
        tbuname.Text = ""
        tbpword.Text = ""
        cbopos.Text = ""
    End Sub

    Sub notif(ByVal str As String, ByVal col As Color, ByVal bool As Boolean) '(message, font color, is message visible)
        lblnotif.Text = str
        lblnotif.ForeColor = col
        lblnotif.Visible = bool
    End Sub

    Sub MessageNotif(ByVal i As Integer, ByVal s As String)
        If i = 1 Then 'info
            notif(s, Color.FromArgb(0, 192, 192), True)
        ElseIf i = 2 Then 'success
            notif(s, Color.LimeGreen, True)
        ElseIf i = 3 Then 'error
            notif(s, Color.FromArgb(255, 128, 128), True)
        ElseIf i = 0 Then 'blanc
            notif(s, Color.White, False)
        Else
            MsgBox("0-3 Only")
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub chpword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chpword.CheckedChanged
        If chpword.Checked = False Then
            tbpword.UseSystemPasswordChar = True
        Else
            tbpword.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub tbsearch_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbsearch.MouseClick
        tbsearch.Text = ""
        tbsearch.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        tbsearch.ForeColor = Color.White
    End Sub

    Private Sub tbsearch_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbsearch.MouseEnter
        If tbsearch.Text <> "Search User Here" Then
            Exit Sub
        End If
        PopulateUser(lvuser)
        tbsearch.Text = ""
        tbsearch.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub tbsearch_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbsearch.MouseLeave
        If tbsearch.Text <> "" Then
            Exit Sub
        End If
        tbsearch.Text = "Search User Here"
        tbsearch.ForeColor = Color.Silver
        tbsearch.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PopulateUser(lvuser)
    End Sub

    Private Sub tbsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbsearch.TextChanged
        SearchUser(lvuser, tbsearch.Text)
    End Sub

End Class