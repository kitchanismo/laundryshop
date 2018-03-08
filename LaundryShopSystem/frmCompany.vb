Public Class frmCompany
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
    Private Sub frmCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AuthenticateUser()
        PopulateCompany(lvcompany)
        btndelete.Enabled = DisableEnableDelete(GetUserPosition(uname))
        btnedit.Enabled = DisableEnableDelete(GetUserPosition(uname))
    End Sub

    Private Sub lvcompany_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvcompany.MouseClick
        With lvcompany.SelectedItems(0)
            id = .SubItems(0).Text
            tbtin.Text = .SubItems(1).Text
            tbcn.Text = .SubItems(2).Text
            tbca.Text = .SubItems(3).Text
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
            btnedit.Enabled = DisableEnableDelete(GetUserPosition(uname))
        Else
            If id = "0" Then
                notif("*Select from Company List!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            End If
            If tbtin.Text = "" Then
                notif("*TIN is missing!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            ElseIf tbcn.Text = "" Then
                notif("*Company Name is missing!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            ElseIf tbca.Text = "" Then
                notif("*Company Address is missing!", Color.FromArgb(255, 128, 128), True)
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
            tbtin.SelectAll()
            tbtin.Focus()
            btnedit.Enabled = True
        Else
            If tbtin.Text = "" Then
                notif("*TIN is missing!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            ElseIf tbcn.Text = "" Then
                notif("*Company Name is missing!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            ElseIf tbca.Text = "" Then
                notif("*Company Address is missing!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            End If
            SaveData()
            notif("*Saved Data!", Color.LimeGreen, True)
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        DeleteData()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        ClearData()
        PopulateCompany(lvcompany)
        notif("", Color.LimeGreen, False)

    End Sub

    Sub EditData()
        Connected()
        sql = "UPDATE tblcompany SET tin = '" & tbtin.Text & "', com_name = '" & tbcn.Text.ToLower & "', com_add = '" & tbca.Text.ToLower & "' where id = " & id & ""
        CommandDB()
        cmd.ExecuteNonQuery()
        PopulateCompany(lvcompany)
    End Sub


    Sub SaveData()
        Connected()
        sql = "INSERT INTO tblcompany (tin, com_name, com_add) VALUES ('" & tbtin.Text.ToLower & "','" & tbcn.Text.ToLower & "','" & tbca.Text.ToLower & "')"
        CommandDB()
        dr = cmd.ExecuteReader()
        PopulateCompany(lvcompany)
    End Sub

    Sub DeleteData()
        Connected()
        Dim i As Integer
        sql = "DELETE FROM tblcompany WHERE id = " & id & ""
        'validattion
        If id = "0" Then
            notif("*Select from Company List!", Color.FromArgb(255, 128, 128), True)
            Exit Sub
        End If
        CommandDB()
        i = MsgBox("Are you sure you want to delete " & tbcn.Text.ToUpper & "?", MsgBoxStyle.YesNo)
        If i = MsgBoxResult.Yes Then
            'execute delete query
            cmd.ExecuteNonQuery()
            notif("*Deleted Data!", Color.LimeGreen, True)
            PopulateCompany(lvcompany)
            ClearData()
        End If
    End Sub
    Sub ClearData()
        id = "0"
        tbtin.Text = ""
        tbcn.Text = ""
        tbca.Text = ""
    End Sub

    Sub notif(ByVal str As String, ByVal col As Color, ByVal bool As Boolean)
        lblnotif.Text = str
        lblnotif.ForeColor = col
        lblnotif.Visible = bool
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    Private Sub tbsearch_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbsearch.MouseClick
        tbsearch.Text = ""
        tbsearch.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        tbsearch.ForeColor = Color.White
    End Sub

    Private Sub tbsearch_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbsearch.MouseEnter
        If tbsearch.Text <> "Search Company or Tin Here" Then
            Exit Sub
        End If
        PopulateCompany(lvcompany)
        tbsearch.Text = ""
        tbsearch.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

    End Sub


    Private Sub tbsearch_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbsearch.MouseLeave
        If tbsearch.Text <> "" Then
            Exit Sub
        End If
        tbsearch.Text = "Search Company or Tin Here"
        tbsearch.ForeColor = Color.Silver
        tbsearch.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PopulateCompany(lvcompany)
    End Sub

    Private Sub tbsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbsearch.TextChanged
        SearchComapany(lvcompany, tbsearch.Text)
    End Sub
End Class