Public Class frmMain


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AuthenticateUser()
        lblUser.Text = "| " & uname & " | " & GetUserPosition(uname)
        GrantAccess()
        Credit(Label4)
    End Sub

    Private Sub CompanyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanyToolStripMenuItem.Click
        frmCompany.Show()
        frmCompany.TopMost = True
    End Sub

    Private Sub lbllog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbllog.Click
        Me.TopMost = True
        Dim i As Integer = MsgBox("Logout Now?", MsgBoxStyle.YesNo)
        If i = MsgBoxResult.Yes Then
            frmCompany.Close()
            frmCustomer.Close()
            frmProduct.Close()
            frmEmployee.Close()
            frmUser.Close()
            frmSales.Close()
            frmClaimOrder.Close()
            Me.Close()
            frmLogin.Show()
        End If
        Me.TopMost = False
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        frmCustomer.Show()
        frmCustomer.TopMost = True
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeToolStripMenuItem.Click
        frmEmployee.Show()
        frmEmployee.TopMost = True
    End Sub

    Private Sub UserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserToolStripMenuItem.Click
        frmUser.Show()
        frmUser.TopMost = True
    End Sub

    Private Sub tmrDate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDate.Tick
        lbldate.Text = Format(Now, "long date")
        lblTime.Text = TimeOfDay
    End Sub

    Private Sub ProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductToolStripMenuItem.Click
        frmProduct.Show()
        frmProduct.TopMost = True
    End Sub

    Sub GrantAccess()
        If Not GetUserPosition(uname) = "manager" Then
            UserToolStripMenuItem.Visible = False
            ToolStripSeparator1.Visible = False
            ReportsToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub ClaimOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClaimOrderToolStripMenuItem.Click
        frmClaimOrder.Show()
        frmClaimOrder.TopMost = True
    End Sub


    Private Sub SalesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesReportToolStripMenuItem.Click
        frmSales.Show()
        frmSales.TopMost = True
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Process.Start("www.facebook.com/kitchanismo")
    End Sub
End Class
