Public Class frmPrintPreview


    Private Sub frmPrintPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AuthenticateUser()
        viewdatetime()
        lblfrom.Text = datefrom
        lblto.Text = dateto
        lbltotal.Text = frmSales.tbtotal.Text
        ' MsgBox(Rows)
        AdjustRows(160)
        lblT.Text = "Transaction List - " & Rows() & " Item/s"
    End Sub
    Sub viewdatetime()
        ' MsgBox(datefrom)
        PopulateSales(lvsales, datefrom, dateto)
    End Sub
    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        isenable(False)
        Print()
        'preview()
        isenable(True)
    End Sub

    Sub AdjustRows(ByVal ctr As Integer)
        If Rows() >= 20 Then
            lvsales.Height += ctr
            Me.Height += ctr
        End If
    End Sub

    Function Rows() As Integer
        Return lvsales.Items.Count
    End Function

    Sub isenable(ByVal bool As Boolean)
        Me.TopMost = bool
        btnprint.Visible = bool
        btncancel.Visible = bool
    End Sub

    Private Sub Print()
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(50, 50, 30, 10)
        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        frmSales.Show()
        frmTransparent.Close()
        Me.Close()
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        xpos = Cursor.Position.X - Me.Location.X
        ypos = Cursor.Position.Y - Me.Location.Y
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            pos = MousePosition
            pos.X = pos.X - xpos
            pos.Y = pos.Y - ypos
            Me.Location = pos
        End If
    End Sub
End Class