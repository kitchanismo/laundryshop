Public Class frmClaimOrder
    Dim id As String = "0"
    Dim pkilo As Integer
    Dim ppiece As Integer
    Dim price As Integer
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

    Private Sub frmClaimOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AuthenticateUser() 'Check if the user is in the database
        PopulateProduct(lvProduct) 'Load product list from database
        tbslip.Text = GenerateSlipNo() 'auto generate of slip no
    End Sub

    Private Sub lvProduct_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvProduct.MouseClick
        With lvProduct.SelectedItems(0)
            id = .SubItems(0).Text
            tbprodname.Text = .SubItems(1).Text
            pkilo = .SubItems(2).Text
            ppiece = .SubItems(3).Text
            If IsPriceKilo() = True Then
                price = .SubItems(2).Text
            Else
                price = .SubItems(3).Text
            End If
            tbprice.Text = price
        End With
        ComputeTotal()
        tbchange.Text = ComputeChange()
        MessageNotif(0, "")
    End Sub

    Private Sub tbqty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbqty.KeyDown, tbcash.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub


    Private Sub tbqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbqty.TextChanged
        ComputeTotal()
        tbchange.Text = ComputeChange()
    End Sub

    Private Sub btndis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndis.Click
        Me.TopMost = False
        InputDiscount()
        Me.TopMost = True
        ComputeTotal()
        tbchange.Text = ComputeChange()
    End Sub

    Private Sub tbcash_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbcash.KeyPress, tbqty.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbcash_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbcash.TextChanged
        tbchange.Text = ComputeChange()
    End Sub
    Private Sub tbrec_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrec.TextChanged, tbrem.TextChanged, tbqty.TextChanged, tbcash.TextChanged
        MessageNotif(0, "")
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        PopulateProduct(lvProduct)
        Clear()
        tbslip.Text = GenerateSlipNo()
        MessageNotif(0, "")
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

        If id = "0" Then
            MessageNotif(3, "Please Select Product on Product List!")
            Exit Sub
        End If

        If tbrec.Text = "" Then
            notif("*Received by is missing!", Color.FromArgb(255, 128, 128), True)
            Exit Sub
        ElseIf tbrem.Text = "" Then
            notif("*Remarks is missing!", Color.FromArgb(255, 128, 128), True)
            Exit Sub
        ElseIf tbqty.Text = 0 Then
            notif("*Quantity is missing!", Color.FromArgb(255, 128, 128), True)
            Exit Sub
        ElseIf tbcash.Text = 0 Then
            notif("*Cash Rendered is missing!", Color.FromArgb(255, 128, 128), True)
            Exit Sub
        End If

        Dim cash As Double = Val(tbcash.Text)
        Dim totalnet As Double = Val(tbtotalN.Text)

        If cash < totalnet Then
            notif("*Insufficient Cash!", Color.FromArgb(255, 128, 128), True)
            Exit Sub
        End If

        SaveData()
        Clear()
        MessageNotif(2, "Saved Data!")
        tbslip.Text = GenerateSlipNo()
    End Sub

    Function ComputeChange() As Double
        Dim res As Double
        Dim cash As Double = Val(tbcash.Text)
        Dim totalnet As Double = Val(tbtotalN.Text)
        If cash >= totalnet Then
            res = cash - totalnet
        Else
            res = 0
        End If
        Return res
    End Function

    Sub ComputeTotal()
        tbtotal.Text = Val(tbqty.Text) * Val(tbprice.Text) 'quantity * price = total
        tbtotalN.Text = Val(tbtotal.Text) - Val(GetDiscount(Val(tbDis.Text), tbtotal.Text)) 'total - discounted price = net total
    End Sub

    Function GetDiscount(ByVal dis As Integer, ByVal total As Integer) As Double ' get discount amount
        Dim res As Double
        res = (dis * 0.01) * total
        Return res
    End Function

    Sub InputDiscount()
        Try
            Dim i As Integer
            i = InputBox("Enter Desire Discount", "Discount", tbDis.Text)
            If i = 0 Then
                i = 0
            End If
            tbDis.Text = i
            MessageNotif(0, "")
        Catch
            MessageNotif(3, "Enter Number Only!")
        End Try
    End Sub

    Sub SaveData()
        Connected()
        Dim dateby As String = FormatDateTime(Now, DateFormat.GeneralDate).ToString
        sql = "INSERT INTO tbltransaction (slipno, prod_name, rec_by, remarks, price, qty, discount, net_total, date_by) VALUES ('" & tbslip.Text.ToLower & "','" & tbprodname.Text & "','" & tbrec.Text & "','" & tbrem.Text & "','" & tbprice.Text & "','" & tbqty.Text & "','" & tbDis.Text & "','" & tbtotalN.Text & "', '" & dateby & "')"
        CommandDB()
        dr = cmd.ExecuteReader()
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

    Sub Clear()
        id = "0"
        tbprodname.Text = ""
        tbrec.Text = ""
        tbrem.Text = ""
        tbprice.Text = 0
        tbqty.Text = 0
        tbtotal.Text = 0
        tbtotalN.Text = 0
        tbcash.Text = 0
        tbchange.Text = 0
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

    Function IsPriceKilo() As Boolean
        If rbkilo.Checked = True Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub rbkilo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbkilo.CheckedChanged, rbpiece.CheckedChanged
        If IsPriceKilo() = True Then
            tbprice.Text = pkilo
        Else
            tbprice.Text = ppiece
        End If
        ComputeTotal()
        tbchange.Text = ComputeChange()
    End Sub
End Class