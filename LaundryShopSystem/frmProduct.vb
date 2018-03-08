Public Class frmProduct
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
        PopulateProduct(lvProduct)
        btndelete.Enabled = DisableEnableDelete(GetUserPosition(uname))
        btnedit.Enabled = DisableEnableDelete(GetUserPosition(uname))
    End Sub


    Private Sub lvcustomer_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvProduct.MouseClick
        With lvProduct.SelectedItems(0)
            id = .SubItems(0).Text
            tbname.Text = .SubItems(1).Text
            tbprice.Text = .SubItems(2).Text
            tbpiece.Text = .SubItems(3).Text
        End With
        notif("", Color.LimeGreen, False)
        gbepr.Enabled = True
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If btnedit.Text = "Cancel" Then
            btnadd.Text = "Add"
            btnedit.Text = "Edit"
            btndelete.Visible = True
            btnclear.Visible = True
            gbepr.Enabled = False
            notif("", Color.LimeGreen, False)
            btnedit.Enabled = DisableEnableDelete(GetUserPosition(uname))
        Else
            If id = "0" Then
                notif("*Select from Product List!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            End If
            If tbname.Text = "" Then
                notif("*Name/Description is missing!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            ElseIf tbprice.Text = "" Then
                notif("*Price Per Kilo is missing!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            ElseIf tbpiece.Text = "" Then
                notif("*Price Per Piece is missing!", Color.FromArgb(255, 128, 128), True)
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
            gbepr.Enabled = True
            btnedit.Enabled = True
            ClearData()
            notif("*Enter Data and Click Save", Color.FromArgb(0, 192, 192), True)
            tbname.SelectAll()
            tbname.Focus()
        Else
            If tbname.Text = "" Then
                notif("*Name/Description is missing!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            ElseIf tbprice.Text = "" Then
                notif("*Price per kilo is missing!", Color.FromArgb(255, 128, 128), True)
                Exit Sub
            ElseIf tbpiece.Text = "" Then
                notif("*Price Per Piece is missing!", Color.FromArgb(255, 128, 128), True)
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
        PopulateProduct(lvProduct)
        notif("", Color.LimeGreen, False)

    End Sub

    'put [] if fieldname is less than 2

    Sub EditData()
        Connected()
        sql = "UPDATE tblproduct SET [desc] = '" & tbname.Text & "', [price_k] = '" & tbprice.Text & "', [price_p] = '" & tbpiece.Text & "' where id = " & id & ""
        CommandDB()
        cmd.ExecuteNonQuery()
        PopulateProduct(lvProduct)
    End Sub

    Sub SaveData()
        Connected()
        sql = "INSERT INTO tblproduct ([desc], [price_k],[price_p]) VALUES ('" & tbname.Text.ToLower & "','" & tbprice.Text & "','" & tbpiece.Text & "')"
        CommandDB()
        dr = cmd.ExecuteReader()
        PopulateProduct(lvProduct)
    End Sub

    Sub DeleteData()
        Connected()
        Dim i As Integer
        sql = "DELETE FROM tblproduct WHERE id = " & id & ""
        'validattion
        If id = "0" Then
            notif("*Select from Product List!", Color.FromArgb(255, 128, 128), True)
            Exit Sub
        End If
        CommandDB()
        i = MsgBox("Are you sure you want to delete " & tbname.Text.ToUpper & "?", MsgBoxStyle.YesNo)
        If i = MsgBoxResult.Yes Then

            'execute delete query
            cmd.ExecuteNonQuery()
            notif("*Deleted Data!", Color.LimeGreen, True)
            PopulateProduct(lvProduct)
            ClearData()
        End If
    End Sub
    Sub ClearData()
        id = "0"
        tbname.Text = ""
        tbprice.Text = ""
        tbpiece.Text = ""
    End Sub

    Sub notif(ByVal str As String, ByVal col As Color, ByVal bool As Boolean)
        lblnotif.Text = str
        lblnotif.ForeColor = col
        lblnotif.Visible = bool
    End Sub

    'validation for enter number only in price
    Private Sub tbprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbprice.KeyPress, tbpiece.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
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
        If tbsearch.Text <> "Search Product Here" Then
            Exit Sub
        End If
        PopulateProduct(lvProduct)
        tbsearch.Text = ""
        tbsearch.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

    End Sub


    Private Sub tbsearch_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbsearch.MouseLeave
        If tbsearch.Text <> "" Then
            Exit Sub
        End If
        tbsearch.Text = "Search Product Here"
        tbsearch.ForeColor = Color.Silver
        tbsearch.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PopulateProduct(lvProduct)
    End Sub


    Private Sub tbsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbsearch.TextChanged
        SearchProduct(lvProduct, tbsearch.Text)
    End Sub

End Class