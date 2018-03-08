Public Class frmSales

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Sub viewdatetime()
        Dim datefrom As Date = dtpfrom.Value.ToShortDateString & " " & dtpfromtime.Value.TimeOfDay.ToString
        Dim dateto As Date = dtpto.Value.ToShortDateString & " " & dtptotime.Value.TimeOfDay.ToString
        PopulateSales(lvsales, datefrom, dateto)
    End Sub

    Private Sub dtpfrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpfrom.ValueChanged, dtpto.ValueChanged, dtptotime.ValueChanged, dtpfromtime.ValueChanged
        If dtptotime.Value.ToShortTimeString = "12:00 PM" Then
            MsgBox("Time must not exceed to 12:00 PM! ") ' if time exceeded sales report will not view
            Exit Sub
        End If
        viewdatetime()
        tbtotal.Text = "Php. " & FormatNumber(ComputeCollumn(8, lvsales))
        'lblT.Text = "Transaction List - " & Rows() & " Item/s"
    End Sub

    Private Sub tbsearch_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbsearch.MouseClick
        tbsearch.Text = ""
        tbsearch.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        tbsearch.ForeColor = Color.White
    End Sub

    Private Sub tbsearch_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbsearch.MouseEnter
        If tbsearch.Text <> "Search SlipNo/Product/ReceivedBy Here" Then
            Exit Sub
        End If
        PopulateTransaction(lvsales)
        tbsearch.Text = ""
        tbsearch.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

    End Sub


    Private Sub tbsearch_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbsearch.MouseLeave
        If tbsearch.Text <> "" Then
            Exit Sub
        End If
        tbsearch.Text = "Search SlipNo/Product/ReceivedBy Here"
        tbsearch.ForeColor = Color.Silver
        tbsearch.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PopulateTransaction(lvsales)
    End Sub

    Private Sub tbsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbsearch.TextChanged
        SearchTransaction(lvsales, tbsearch.Text)
        tbtotal.Text = "Php. 00.00"
    End Sub
    Private Sub frmSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AuthenticateUser()
        GetDateNow()
        PopulateTransaction(lvsales)
        'lblT.Text = "Transaction List - " & Rows() & " Item/s"
    End Sub
    Sub GetDateNow()
        dtpfrom.Value = Format(Now, "long date")
        dtpto.Value = Format(Now, "long date")
    End Sub
    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        datefrom = dtpfrom.Value.ToShortDateString & " " & dtpfromtime.Value.TimeOfDay.ToString
        dateto = dtpto.Value.ToShortDateString & " " & dtptotime.Value.TimeOfDay.ToString
        Me.Hide()
        frmTransparent.Show()
        frmPrintPreview.Show()

    End Sub

    Function Rows() As Integer
        Return lvsales.Items.Count
    End Function
 
End Class