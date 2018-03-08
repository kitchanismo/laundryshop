<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClaimOrder
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
        Me.gbemp = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbprodname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbrem = New System.Windows.Forms.TextBox()
        Me.tbrec = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbslip = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbqty = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbpiece = New System.Windows.Forms.RadioButton()
        Me.tbprice = New System.Windows.Forms.TextBox()
        Me.rbkilo = New System.Windows.Forms.RadioButton()
        Me.tbchange = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbcash = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btndis = New System.Windows.Forms.Button()
        Me.tbDis = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbtotalN = New System.Windows.Forms.TextBox()
        Me.tbtotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.lvProduct = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblnotif = New System.Windows.Forms.Label()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.pnTitle = New System.Windows.Forms.Panel()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.tmrload = New System.Windows.Forms.Timer(Me.components)
        Me.tbsearch = New System.Windows.Forms.TextBox()
        Me.gbemp.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbemp
        '
        Me.gbemp.Controls.Add(Me.Label8)
        Me.gbemp.Controls.Add(Me.tbprodname)
        Me.gbemp.Controls.Add(Me.Label5)
        Me.gbemp.Controls.Add(Me.tbrem)
        Me.gbemp.Controls.Add(Me.tbrec)
        Me.gbemp.Controls.Add(Me.Label1)
        Me.gbemp.Controls.Add(Me.Label2)
        Me.gbemp.Controls.Add(Me.tbslip)
        Me.gbemp.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbemp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbemp.Location = New System.Drawing.Point(445, 61)
        Me.gbemp.Name = "gbemp"
        Me.gbemp.Size = New System.Drawing.Size(293, 310)
        Me.gbemp.TabIndex = 17
        Me.gbemp.TabStop = False
        Me.gbemp.Text = "Claim Order Details"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(20, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 21)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Product Name"
        '
        'tbprodname
        '
        Me.tbprodname.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbprodname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbprodname.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbprodname.ForeColor = System.Drawing.Color.DarkGray
        Me.tbprodname.Location = New System.Drawing.Point(25, 123)
        Me.tbprodname.Name = "tbprodname"
        Me.tbprodname.ReadOnly = True
        Me.tbprodname.Size = New System.Drawing.Size(226, 31)
        Me.tbprodname.TabIndex = 15
        Me.tbprodname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(20, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 21)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Remarks"
        '
        'tbrem
        '
        Me.tbrem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbrem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbrem.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbrem.ForeColor = System.Drawing.Color.DarkGray
        Me.tbrem.Location = New System.Drawing.Point(25, 255)
        Me.tbrem.Name = "tbrem"
        Me.tbrem.Size = New System.Drawing.Size(226, 31)
        Me.tbrem.TabIndex = 13
        Me.tbrem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbrec
        '
        Me.tbrec.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbrec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbrec.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbrec.ForeColor = System.Drawing.Color.DarkGray
        Me.tbrec.Location = New System.Drawing.Point(26, 192)
        Me.tbrec.Name = "tbrec"
        Me.tbrec.Size = New System.Drawing.Size(226, 31)
        Me.tbrec.TabIndex = 6
        Me.tbrec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Slip No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(21, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 21)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Received By"
        '
        'tbslip
        '
        Me.tbslip.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbslip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbslip.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbslip.ForeColor = System.Drawing.Color.DarkGray
        Me.tbslip.Location = New System.Drawing.Point(25, 61)
        Me.tbslip.Name = "tbslip"
        Me.tbslip.ReadOnly = True
        Me.tbslip.Size = New System.Drawing.Size(226, 31)
        Me.tbslip.TabIndex = 8
        Me.tbslip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(302, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 21)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Quantity"
        '
        'tbqty
        '
        Me.tbqty.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbqty.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbqty.ForeColor = System.Drawing.Color.DarkGray
        Me.tbqty.Location = New System.Drawing.Point(306, 72)
        Me.tbqty.Name = "tbqty"
        Me.tbqty.Size = New System.Drawing.Size(216, 31)
        Me.tbqty.TabIndex = 12
        Me.tbqty.Text = "0"
        Me.tbqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbpiece)
        Me.GroupBox1.Controls.Add(Me.tbprice)
        Me.GroupBox1.Controls.Add(Me.rbkilo)
        Me.GroupBox1.Controls.Add(Me.tbchange)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.tbqty)
        Me.GroupBox1.Controls.Add(Me.tbcash)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btndis)
        Me.GroupBox1.Controls.Add(Me.tbDis)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tbtotalN)
        Me.GroupBox1.Controls.Add(Me.tbtotal)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 387)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(809, 207)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment Details"
        '
        'rbpiece
        '
        Me.rbpiece.AutoSize = True
        Me.rbpiece.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbpiece.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.rbpiece.Location = New System.Drawing.Point(209, 50)
        Me.rbpiece.Name = "rbpiece"
        Me.rbpiece.Size = New System.Drawing.Size(87, 21)
        Me.rbpiece.TabIndex = 27
        Me.rbpiece.Text = "per piece"
        Me.rbpiece.UseVisualStyleBackColor = True
        '
        'tbprice
        '
        Me.tbprice.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbprice.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbprice.ForeColor = System.Drawing.Color.DarkGray
        Me.tbprice.Location = New System.Drawing.Point(63, 72)
        Me.tbprice.Name = "tbprice"
        Me.tbprice.ReadOnly = True
        Me.tbprice.Size = New System.Drawing.Size(225, 31)
        Me.tbprice.TabIndex = 18
        Me.tbprice.Text = "0"
        Me.tbprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbkilo
        '
        Me.rbkilo.AutoSize = True
        Me.rbkilo.Checked = True
        Me.rbkilo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbkilo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.rbkilo.Location = New System.Drawing.Point(138, 50)
        Me.rbkilo.Name = "rbkilo"
        Me.rbkilo.Size = New System.Drawing.Size(73, 21)
        Me.rbkilo.TabIndex = 26
        Me.rbkilo.TabStop = True
        Me.rbkilo.Text = "per kilo"
        Me.rbkilo.UseVisualStyleBackColor = True
        '
        'tbchange
        '
        Me.tbchange.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbchange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbchange.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbchange.ForeColor = System.Drawing.Color.DarkGray
        Me.tbchange.Location = New System.Drawing.Point(543, 137)
        Me.tbchange.Name = "tbchange"
        Me.tbchange.ReadOnly = True
        Me.tbchange.Size = New System.Drawing.Size(175, 31)
        Me.tbchange.TabIndex = 27
        Me.tbchange.Text = "0"
        Me.tbchange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(59, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 21)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Price"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(537, 113)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 21)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Change"
        '
        'tbcash
        '
        Me.tbcash.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbcash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbcash.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcash.ForeColor = System.Drawing.Color.DarkGray
        Me.tbcash.Location = New System.Drawing.Point(543, 72)
        Me.tbcash.Name = "tbcash"
        Me.tbcash.Size = New System.Drawing.Size(175, 31)
        Me.tbcash.TabIndex = 25
        Me.tbcash.Text = "0"
        Me.tbcash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(538, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 21)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Cash Rendered"
        '
        'btndis
        '
        Me.btndis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btndis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndis.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btndis.Location = New System.Drawing.Point(165, 136)
        Me.btndis.Name = "btndis"
        Me.btndis.Size = New System.Drawing.Size(36, 31)
        Me.btndis.TabIndex = 23
        Me.btndis.Text = "..."
        Me.btndis.UseVisualStyleBackColor = True
        '
        'tbDis
        '
        Me.tbDis.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbDis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbDis.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDis.ForeColor = System.Drawing.Color.DarkGray
        Me.tbDis.Location = New System.Drawing.Point(63, 136)
        Me.tbDis.Name = "tbDis"
        Me.tbDis.ReadOnly = True
        Me.tbDis.Size = New System.Drawing.Size(74, 31)
        Me.tbDis.TabIndex = 16
        Me.tbDis.Text = "5"
        Me.tbDis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(59, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 21)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Discount"
        '
        'tbtotalN
        '
        Me.tbtotalN.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbtotalN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbtotalN.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbtotalN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbtotalN.Location = New System.Drawing.Point(383, 137)
        Me.tbtotalN.Name = "tbtotalN"
        Me.tbtotalN.ReadOnly = True
        Me.tbtotalN.Size = New System.Drawing.Size(141, 31)
        Me.tbtotalN.TabIndex = 12
        Me.tbtotalN.Text = "0"
        Me.tbtotalN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbtotal
        '
        Me.tbtotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbtotal.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbtotal.ForeColor = System.Drawing.Color.DarkGray
        Me.tbtotal.Location = New System.Drawing.Point(222, 137)
        Me.tbtotal.Name = "tbtotal"
        Me.tbtotal.ReadOnly = True
        Me.tbtotal.Size = New System.Drawing.Size(141, 31)
        Me.tbtotal.TabIndex = 6
        Me.tbtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(218, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(379, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Net Total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkGray
        Me.Label10.Location = New System.Drawing.Point(140, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 21)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "%"
        '
        'btnclose
        '
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnclose.Location = New System.Drawing.Point(755, 179)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(72, 48)
        Me.btnclose.TabIndex = 20
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnsave.Location = New System.Drawing.Point(755, 71)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(72, 48)
        Me.btnsave.TabIndex = 19
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'lvProduct
        '
        Me.lvProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvProduct.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvProduct.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvProduct.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lvProduct.FullRowSelect = True
        Me.lvProduct.GridLines = True
        Me.lvProduct.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvProduct.Location = New System.Drawing.Point(18, 108)
        Me.lvProduct.Name = "lvProduct"
        Me.lvProduct.Size = New System.Drawing.Size(409, 262)
        Me.lvProduct.TabIndex = 21
        Me.lvProduct.UseCompatibleStateImageBehavior = False
        Me.lvProduct.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Name/Decription"
        Me.ColumnHeader4.Width = 209
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Price Kilo"
        Me.ColumnHeader2.Width = 94
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Price Piece"
        Me.ColumnHeader3.Width = 105
        '
        'lblnotif
        '
        Me.lblnotif.AutoSize = True
        Me.lblnotif.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnotif.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblnotif.Location = New System.Drawing.Point(15, 606)
        Me.lblnotif.Name = "lblnotif"
        Me.lblnotif.Size = New System.Drawing.Size(137, 17)
        Me.lblnotif.TabIndex = 23
        Me.lblnotif.Text = "*Password is missing"
        Me.lblnotif.Visible = False
        '
        'btnclear
        '
        Me.btnclear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnclear.Location = New System.Drawing.Point(755, 125)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(72, 48)
        Me.btnclear.TabIndex = 24
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'pnTitle
        '
        Me.pnTitle.BackColor = System.Drawing.Color.Teal
        Me.pnTitle.Controls.Add(Me.lbltitle)
        Me.pnTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnTitle.Name = "pnTitle"
        Me.pnTitle.Size = New System.Drawing.Size(845, 41)
        Me.pnTitle.TabIndex = 25
        '
        'lbltitle
        '
        Me.lbltitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.White
        Me.lbltitle.Location = New System.Drawing.Point(344, 9)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(134, 24)
        Me.lbltitle.TabIndex = 19
        Me.lbltitle.Text = "Claim Order"
        '
        'tmrload
        '
        Me.tmrload.Interval = 1000
        '
        'tbsearch
        '
        Me.tbsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbsearch.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbsearch.ForeColor = System.Drawing.Color.DarkGray
        Me.tbsearch.Location = New System.Drawing.Point(18, 71)
        Me.tbsearch.Name = "tbsearch"
        Me.tbsearch.Size = New System.Drawing.Size(409, 31)
        Me.tbsearch.TabIndex = 26
        Me.tbsearch.Text = "Search Product Here"
        Me.tbsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmClaimOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(844, 630)
        Me.Controls.Add(Me.tbsearch)
        Me.Controls.Add(Me.pnTitle)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.lblnotif)
        Me.Controls.Add(Me.lvProduct)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.gbemp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmClaimOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "0"
        Me.gbemp.ResumeLayout(False)
        Me.gbemp.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnTitle.ResumeLayout(False)
        Me.pnTitle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbemp As System.Windows.Forms.GroupBox
    Friend WithEvents tbqty As System.Windows.Forms.TextBox
    Friend WithEvents tbrec As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbslip As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbtotalN As System.Windows.Forms.TextBox
    Friend WithEvents tbtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbrem As System.Windows.Forms.TextBox
    Friend WithEvents tbDis As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lvProduct As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbprodname As System.Windows.Forms.TextBox
    Friend WithEvents tbprice As System.Windows.Forms.TextBox
    Friend WithEvents tbchange As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbcash As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btndis As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblnotif As System.Windows.Forms.Label
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents pnTitle As System.Windows.Forms.Panel
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents tmrload As System.Windows.Forms.Timer
    Friend WithEvents rbpiece As System.Windows.Forms.RadioButton
    Friend WithEvents rbkilo As System.Windows.Forms.RadioButton
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tbsearch As System.Windows.Forms.TextBox
End Class
