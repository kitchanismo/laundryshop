Public Class frmEmployee
    Dim id As String = "0"
    Dim img As String = ""
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
        PopulateEmployee(lvEmployee)
        btndelete.Enabled = DisableEnableDelete(GetUserPosition(uname))
        btnedit.Enabled = DisableEnableDelete(GetUserPosition(uname))
    End Sub

    Private Sub lvcustomer_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvEmployee.MouseClick
        With lvEmployee.SelectedItems(0)
            id = .SubItems(0).Text
            tbname.Text = .SubItems(1).Text
            tbnum.Text = .SubItems(2).Text
            tbadd.Text = .SubItems(3).Text
            cbogender.Text = .SubItems(4).Text
            cbostatus.Text = .SubItems(5).Text
            img = .SubItems(6).Text
            pic.ImageLocation = appstart & "employee\" & img
        End With
        notif("", Color.LimeGreen, False)
        gbemp.Enabled = True
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If btnedit.Text = "Cancel" Then
            btnadd.Text = "Add"
            btnedit.Text = "Edit"
            btndelete.Visible = True
            btnclear.Visible = True
            gbemp.Enabled = False
            notif("", Color.LimeGreen, False)
            btnedit.Enabled = DisableEnableDelete(GetUserPosition(uname))
        Else
            If id = "0" Then
                notif("*Select from Employee List!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            End If
            If tbname.Text = "" Then
                notif("*Name is missing!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            ElseIf tbnum.Text = "" Then
                notif("*Number is missing!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            ElseIf tbadd.Text = "" Then
                notif("*Address is missing!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            ElseIf cbogender.Text = "" Then
                notif("*Gender is missing!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            ElseIf cbostatus.Text = "" Then
                notif("*Status is missing!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            ElseIf img = "" Then
                img = "user.png"
            End If
            EditData()
            ImageSave()
            notif("*Updated Data!", Color.LimeGreen, True)
        End If
    End Sub


    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If btnadd.Text = "Add" Then
            btnadd.Text = "Save"
            btnedit.Text = "Cancel"
            btndelete.Visible = False
            btnclear.Visible = False
            gbemp.Enabled = True
            ClearData()
            notif("*Enter Data and Click Save", Color.FromArgb(0, 192, 192), True)
            tbname.SelectAll()
            tbname.Focus()
            btnedit.Enabled = True
        Else
            If tbname.Text = "" Then
                notif("*Name is missing!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            ElseIf tbnum.Text = "" Then
                notif("*Number is missing!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            ElseIf tbadd.Text = "" Then
                notif("*Address is missing!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            ElseIf cbogender.Text = "" Then
                notif("*Gender is missing!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            ElseIf cbostatus.Text = "" Then
                notif("*Status is missing!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            ElseIf img = "" Then
                img = "user.png"
            End If

            SaveData()
            ImageSave()
            notif("*Saved Data!", Color.LimeGreen, True)
        End If
    End Sub
    Sub ImageSave()
        If img <> "" Then
            SaveImageToFolder(imgpath, appstart & "employee\" & img)
        Else
            SaveImageToFolder(appstart & "employee\user.png", appstart & "employee\user.png")
        End If
    End Sub
    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        DeleteData()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        ClearData()
        PopulateEmployee(lvEmployee)
        notif("", Color.LimeGreen, False)

    End Sub

  

    Sub EditData()
        Connected()
        sql = "UPDATE tblemployee SET emp_name = '" & tbname.Text & "', emp_num = '" & tbnum.Text.ToLower & "', emp_add = '" & tbadd.Text.ToLower & "' , emp_gender = '" & cbogender.Text.ToLower & "', emp_pic = '" & img & "', emp_status = '" & cbostatus.Text & "' where id = " & id & ""
        CommandDB()
        cmd.ExecuteNonQuery()
        PopulateEmployee(lvEmployee)
    End Sub


    Sub SaveData()
        Connected()
        sql = "INSERT INTO tblemployee (emp_name, emp_num, emp_add, emp_gender, emp_pic, emp_status) VALUES ('" & tbname.Text.ToLower & "','" & tbnum.Text.ToLower & "','" & tbadd.Text.ToLower & "','" & cbogender.Text.ToLower & "','" & img & "','" & cbostatus.Text & "')"
        CommandDB()
        dr = cmd.ExecuteReader()
        PopulateEmployee(lvEmployee)
    End Sub

    Sub DeleteData()
        Connected()
        Dim i As Integer
        sql = "DELETE FROM tblemployee WHERE id = " & id & ""
        'validattion
        If id = "0" Then
            notif("*Select from Employee List!", Color.FromArgb(255, 128, 128), True)
            Exit Sub
        End If
        CommandDB()
        i = MsgBox("Are you sure you want to delete " & tbname.Text.ToUpper & "?", MsgBoxStyle.YesNo)
        If i = MsgBoxResult.Yes Then
            'execute delete query
            cmd.ExecuteNonQuery()
            notif("*Deleted Data!", Color.LimeGreen, True)
            PopulateEmployee(lvEmployee)
            ClearData()
        End If
    End Sub
    Sub ClearData()
        id = "0"
        tbname.Text = ""
        tbnum.Text = ""
        tbadd.Text = ""
        imgpath = ""
        img = ""
        tbsearch.Text = ""
        cbogender.Text = ""
        pic.ImageLocation = appstart & "employee\user.png"
    End Sub

    Sub notif(ByVal str As String, ByVal col As Color, ByVal bool As Boolean)
        lblnotif.Text = str
        lblnotif.ForeColor = col
        lblnotif.Visible = bool
    End Sub

    Private Sub tbsearch_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbsearch.MouseClick
        tbsearch.Text = ""
        tbsearch.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        tbsearch.ForeColor = Color.White
    End Sub

    Private Sub tbsearch_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbsearch.MouseEnter
        If tbsearch.Text <> "Search Employee Here" Then
            Exit Sub
        End If
        PopulateEmployee(lvEmployee)
        tbsearch.Text = ""
        tbsearch.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub tbsearch_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbsearch.MouseLeave
        If tbsearch.Text <> "" Then
            Exit Sub
        End If
        tbsearch.Text = "Search Employee Here"
        tbsearch.ForeColor = Color.Silver
        tbsearch.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PopulateEmployee(lvEmployee)
    End Sub

    Private Sub tbsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbsearch.TextChanged
        Searchemployee(lvEmployee, tbsearch.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Dim ofd As New OpenFileDialog

    Dim imgpath As String = ""
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            ofd.Filter = "JPEG (*.jpg) |*.jpg|PNG (*.png) |*.png|(*.*) |*.*"
            ofd.ShowDialog()
            Dim FileName As String
            imgpath = ofd.FileName
            FileName = ofd.FileName.Substring(ofd.FileName.LastIndexOf("\"))
            Dim ImageFileName As String = FileName.Replace("\", "")
            img = ImageFileName.ToLower
            pic.ImageLocation = imgpath
        Catch
        End Try
    End Sub
End Class