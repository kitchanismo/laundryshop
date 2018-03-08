<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MaintenancceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.CompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClaimOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.VoidTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TransactionListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceivableListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SummaryReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndividualLedgerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lbllog = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.tmrDate = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaintenancceToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1001, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MaintenancceToolStripMenuItem
        '
        Me.MaintenancceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductToolStripMenuItem, Me.ToolStripSeparator4, Me.CompanyToolStripMenuItem, Me.EmployeeToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.ToolStripSeparator1, Me.UserToolStripMenuItem})
        Me.MaintenancceToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MaintenancceToolStripMenuItem.Name = "MaintenancceToolStripMenuItem"
        Me.MaintenancceToolStripMenuItem.Size = New System.Drawing.Size(129, 25)
        Me.MaintenancceToolStripMenuItem.Text = "Maintenance"
        '
        'ProductToolStripMenuItem
        '
        Me.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        Me.ProductToolStripMenuItem.Size = New System.Drawing.Size(158, 26)
        Me.ProductToolStripMenuItem.Text = "Product"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(155, 6)
        '
        'CompanyToolStripMenuItem
        '
        Me.CompanyToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.CompanyToolStripMenuItem.Name = "CompanyToolStripMenuItem"
        Me.CompanyToolStripMenuItem.Size = New System.Drawing.Size(158, 26)
        Me.CompanyToolStripMenuItem.Text = "Company"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(158, 26)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(158, 26)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(155, 6)
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(158, 26)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClaimOrderToolStripMenuItem, Me.ToolStripSeparator2, Me.VoidTransactionToolStripMenuItem})
        Me.TransactionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(119, 25)
        Me.TransactionToolStripMenuItem.Text = "Transactions"
        '
        'ClaimOrderToolStripMenuItem
        '
        Me.ClaimOrderToolStripMenuItem.Name = "ClaimOrderToolStripMenuItem"
        Me.ClaimOrderToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.ClaimOrderToolStripMenuItem.Text = "Claim Order"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(207, 6)
        '
        'VoidTransactionToolStripMenuItem
        '
        Me.VoidTransactionToolStripMenuItem.Name = "VoidTransactionToolStripMenuItem"
        Me.VoidTransactionToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.VoidTransactionToolStripMenuItem.Text = "Void Transaction"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesReportToolStripMenuItem, Me.ToolStripSeparator3, Me.TransactionListToolStripMenuItem, Me.ReceivableListToolStripMenuItem, Me.ToolStripSeparator5, Me.SummaryReportToolStripMenuItem, Me.IndividualLedgerToolStripMenuItem})
        Me.ReportsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(81, 25)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'SalesReportToolStripMenuItem
        '
        Me.SalesReportToolStripMenuItem.Name = "SalesReportToolStripMenuItem"
        Me.SalesReportToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.SalesReportToolStripMenuItem.Text = "Sales Report"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(212, 6)
        '
        'TransactionListToolStripMenuItem
        '
        Me.TransactionListToolStripMenuItem.Name = "TransactionListToolStripMenuItem"
        Me.TransactionListToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.TransactionListToolStripMenuItem.Text = "Transaction List"
        '
        'ReceivableListToolStripMenuItem
        '
        Me.ReceivableListToolStripMenuItem.Name = "ReceivableListToolStripMenuItem"
        Me.ReceivableListToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.ReceivableListToolStripMenuItem.Text = "Receivable List"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(212, 6)
        '
        'SummaryReportToolStripMenuItem
        '
        Me.SummaryReportToolStripMenuItem.Name = "SummaryReportToolStripMenuItem"
        Me.SummaryReportToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.SummaryReportToolStripMenuItem.Text = "Summary Report"
        '
        'IndividualLedgerToolStripMenuItem
        '
        Me.IndividualLedgerToolStripMenuItem.Name = "IndividualLedgerToolStripMenuItem"
        Me.IndividualLedgerToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.IndividualLedgerToolStripMenuItem.Text = "Individual Ledger"
        '
        'lblUser
        '
        Me.lblUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUser.Location = New System.Drawing.Point(74, 595)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(42, 21)
        Me.lblUser.TabIndex = 4
        Me.lblUser.Text = "User"
        '
        'lbllog
        '
        Me.lbllog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbllog.AutoSize = True
        Me.lbllog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbllog.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbllog.Location = New System.Drawing.Point(13, 595)
        Me.lbllog.Name = "lbllog"
        Me.lbllog.Size = New System.Drawing.Size(65, 21)
        Me.lbllog.TabIndex = 5
        Me.lbllog.Text = "Logout"
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Century Gothic", 33.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Gray
        Me.lblTime.Location = New System.Drawing.Point(7, 514)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(0, 55)
        Me.lblTime.TabIndex = 6
        '
        'lbldate
        '
        Me.lbldate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.Gray
        Me.lbldate.Location = New System.Drawing.Point(13, 569)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(0, 21)
        Me.lbldate.TabIndex = 7
        '
        'tmrDate
        '
        Me.tmrDate.Enabled = True
        Me.tmrDate.Interval = 1000
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(126, 271)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(757, 42)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Automated Monitoring System Of Star Wash"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(1059, 596)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = " coded by kitchanismo"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1001, 625)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lbllog)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblUser)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MaintenancceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompanyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lbllog As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents tmrDate As System.Windows.Forms.Timer
    Friend WithEvents ClaimOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VoidTransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TransactionListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReceivableListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SummaryReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndividualLedgerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SalesReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
