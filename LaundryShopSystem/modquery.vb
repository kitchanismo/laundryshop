Module modquery

    'functions and methods

    Public Sub CheckLogin(ByVal u As String, ByVal p As String)
        Connected()
        sql = "SELECT * FROM tbluser WHERE uname = '" & u & "' AND upword = '" & p & "' "
        CommandDB()
        dr = cmd.ExecuteReader()
    End Sub
    Public Sub SaveImageToFolder(ByVal sourcepath As String, ByVal destinationpath As String)
        Try
            My.Computer.FileSystem.CopyFile(sourcepath, destinationpath)
        Catch
        End Try
    End Sub
    Function IsUsernameExist(ByVal u As String) As Boolean
        Dim bool As Boolean = Nothing
        Connected()
        sql = "SELECT COUNT(*) FROM tbluser WHERE uname = '" & u & "'"
        CommandDB()
        Dim rows As Integer = cmd.ExecuteScalar()
        If rows <> 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub AuthenticateUser()
        If IsUsernameExist(uname) = True Then
            MsgBox("Unauthorized User!")
            End
        End If
    End Sub

    Public Function DoesExist(ByVal tbl As String, ByVal field As String, ByVal str As String)
        Connected()
        sql = "Select COUNT(*) FROM " & tbl & " WHERE " & field & " = '" & str & "'"
        CommandDB()
        Dim rows As Integer = cmd.ExecuteScalar()
        If rows > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Function GetUserPosition(ByVal str As String) As String
        Connected()
        Dim s As String = ""
        sql = "SELECT uposition from tbluser where uname ='" & str & "'"
        CommandDB()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                s = dr.Item(0).ToString
            Loop
        End If
        Return s
    End Function

    Function GetUserPassword(ByVal str As String) As String
        Connected()
        Dim s As String = ""
        Dim sqlx As String = "NoP9sRPxn3Q6n5FxptNs6wQ4RnTZO09TTN1JBSxSAN53GNl0u6BgdUJOQ8Mytwku"
        sql = chan.Decrypt(sqlx, coder) & str & "'"
        CommandDB()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                s = dr.Item(0).ToString
            Loop
        End If
        Return s
    End Function

    'Generate slip no
    Public Function GenerateSlipNo() As String
        Connected()
        Dim str As String = ""
        sql = "SELECT Max(slipno) FROM tbltransaction"
        CommandDB()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                str = dr.Item(0).ToString.Substring(5) + 1
            Loop
        End If
        Return "SLIP-" & str
    End Function

    Public Function DisableEnableDelete(ByVal str As String) As Boolean
        Dim bool As Boolean
        If str = "manager" Then
            bool = True
        Else
            bool = False
        End If
        Return bool
    End Function

    Public Function ComputeCollumn(ByVal col As Integer, ByVal lvSales As ListView) As Integer
        Dim sum = (From lvi In lvSales.Items _
        Let value = CInt(DirectCast(lvi, ListViewItem).SubItems(col).Text) _
        Select value).Sum
        Return sum
    End Function


    Public Sub Credit(ByVal l As Label)
        chan.Forward(l, l.Left, -250)
    End Sub

    'Load Data

    Public Sub PopulateCompany(ByVal lv As ListView)
        Connected()
        With lv
            .Items.Clear()
            sql = " SELECT * FROM tblcompany"
            CommandDB()
            dr = cmd.ExecuteReader()
            lv.Items.Clear()
            While (dr.Read())
                With lv.Items.Add(dr("id"))
                    .SubItems.Add(dr("tin"))
                    .SubItems.Add(dr("com_name"))
                    .SubItems.Add(dr("com_add"))
                End With
            End While
        End With
    End Sub

    Public Sub PopulateCustomer(ByVal lv As ListView)
        Connected()
        With lv
            .Items.Clear()
            sql = " SELECT * FROM tblcustomer"
            CommandDB()
            dr = cmd.ExecuteReader()
            lv.Items.Clear()
            While (dr.Read())
                With lv.Items.Add(dr("id"))
                    .SubItems.Add(dr("cust_name"))
                    .SubItems.Add(dr("cust_num"))
                    .SubItems.Add(dr("cust_add"))
                    .SubItems.Add(dr("cust_gender"))
                    .SubItems.Add(dr("cust_pic"))
                End With
            End While
        End With
    End Sub

    Public Sub PopulateEmployee(ByVal lv As ListView)
        Connected()
        With lv
            .Items.Clear()
            sql = " SELECT * FROM tblemployee"
            CommandDB()
            dr = cmd.ExecuteReader()
            lv.Items.Clear()
            While (dr.Read())
                With lv.Items.Add(dr("id"))
                    .SubItems.Add(dr("emp_name"))
                    .SubItems.Add(dr("emp_num"))
                    .SubItems.Add(dr("emp_add"))
                    .SubItems.Add(dr("emp_gender"))
                    .SubItems.Add(dr("emp_status"))
                    .SubItems.Add(dr("emp_pic"))
                End With
            End While
        End With
    End Sub
    Public Sub PopulateUser(ByVal lv As ListView)
        Connected()
        With lv
            .Items.Clear()
            sql = " SELECT * FROM tbluser"
            CommandDB()
            dr = cmd.ExecuteReader()
            lv.Items.Clear()
            While (dr.Read())
                With lv.Items.Add(dr("id"))
                    .SubItems.Add(dr("uname"))
                    .SubItems.Add(dr("upword"))
                    .SubItems.Add(dr("uposition"))
                End With
            End While
        End With
    End Sub
    Public Sub PopulateProduct(ByVal lv As ListView)
        Connected()
        With lv
            .Items.Clear()
            sql = " SELECT * FROM tblproduct"
            CommandDB()
            dr = cmd.ExecuteReader()
            lv.Items.Clear()
            While (dr.Read())
                With lv.Items.Add(dr("id"))
                    .SubItems.Add(dr("desc"))
                    .SubItems.Add(dr("price_k"))
                    .SubItems.Add(dr("price_p"))
                End With
            End While
        End With
    End Sub

    Public Sub PopulateTransaction(ByVal lv As ListView)
        Connected()
        With lv
            .Items.Clear()
            sql = " SELECT * FROM tbltransaction"
            CommandDB()
            dr = cmd.ExecuteReader()
            lv.Items.Clear()
            While (dr.Read())
                With lv.Items.Add(dr("id"))
                    .SubItems.Add(dr("slipno"))
                    .SubItems.Add(dr("prod_name"))
                    .SubItems.Add(dr("rec_by"))
                    .SubItems.Add(dr("remarks"))
                    .SubItems.Add(dr("price"))
                    .SubItems.Add(dr("qty"))
                    .SubItems.Add(dr("discount"))
                    .SubItems.Add(dr("net_total"))
                    .SubItems.Add(dr("date_by"))
                End With
            End While
        End With
    End Sub

    Public Sub PopulateSales(ByVal lv As ListView, ByVal fromdate As Date, ByVal todate As Date)
        Connected()
        With lv
            .Items.Clear()
            sql = " SELECT * FROM tbltransaction where date_by >=  # " & fromdate & " #   AND date_by <= # " & todate & " #  order by date_by"
            CommandDB()
            dr = cmd.ExecuteReader()
            lv.Items.Clear()
            While (dr.Read())
                With lv.Items.Add(dr("id"))
                    .SubItems.Add(dr("slipno"))
                    .SubItems.Add(dr("prod_name"))
                    .SubItems.Add(dr("rec_by"))
                    .SubItems.Add(dr("remarks"))
                    .SubItems.Add(dr("price"))
                    .SubItems.Add(dr("qty"))
                    .SubItems.Add(dr("discount"))
                    .SubItems.Add(dr("net_total"))
                    .SubItems.Add(dr("date_by"))
                End With
            End While
        End With
    End Sub

    'search

    Public Sub SearchProduct(ByVal lv As ListView, ByVal search As String)
        Connected()
        Dim result As String = ""
        Dim cond As String = ""
        Dim key As String = "'%" & search & "%'"
        sql = " SELECT * FROM tblproduct WHERE desc LIKE " & key & " order by id"
        CommandDB()
        dr = cmd.ExecuteReader()
        lv.Items.Clear()
        While (dr.Read())
            With lv.Items.Add(dr("id"))
                .SubItems.Add(dr("desc"))
                .SubItems.Add(dr("price_k"))
                .SubItems.Add(dr("price_p"))
            End With
        End While
    End Sub

    Public Sub SearchComapany(ByVal lv As ListView, ByVal search As String)
        Connected()
        Dim result As String = ""
        Dim cond As String = ""
        Dim key As String = "'%" & search & "%'"
        sql = " SELECT * FROM tblcompany WHERE com_name LIKE " & key & " or tin LIKE " & key & " order by id"
        CommandDB()
        dr = cmd.ExecuteReader()
        lv.Items.Clear()
        While (dr.Read())
            With lv.Items.Add(dr("id"))
                .SubItems.Add(dr("tin"))
                .SubItems.Add(dr("com_name"))
                .SubItems.Add(dr("com_add"))
            End With
        End While
    End Sub
    Public Sub SearchEmployee(ByVal lv As ListView, ByVal search As String)
        Connected()
        Dim result As String = ""
        Dim cond As String = ""
        Dim key As String = "'%" & search & "%'"
        sql = " SELECT * FROM tblemployee WHERE emp_name LIKE " & key & " order by id"
        CommandDB()
        dr = cmd.ExecuteReader()
        lv.Items.Clear()
        While (dr.Read())
            With lv.Items.Add(dr("id"))
                .SubItems.Add(dr("emp_name"))
                .SubItems.Add(dr("emp_num"))
                .SubItems.Add(dr("emp_add"))
                .SubItems.Add(dr("emp_gender"))
                .SubItems.Add(dr("emp_status"))
                .SubItems.Add(dr("emp_pic"))
            End With
        End While
    End Sub
    Public Sub SearchCustomer(ByVal lv As ListView, ByVal search As String)
        Connected()
        Dim result As String = ""
        Dim cond As String = ""
        Dim key As String = "'%" & search & "%'"
        sql = " SELECT * FROM tblcustomer WHERE cust_name LIKE " & key & " order by id"
        CommandDB()
        dr = cmd.ExecuteReader()
        lv.Items.Clear()
        While (dr.Read())
            With lv.Items.Add(dr("id"))
                .SubItems.Add(dr("cust_name"))
                .SubItems.Add(dr("cust_num"))
                .SubItems.Add(dr("cust_add"))
                .SubItems.Add(dr("cust_gender"))
                .SubItems.Add(dr("cust_pic"))
            End With
        End While
    End Sub

    Public Sub SearchTransaction(ByVal lv As ListView, ByVal search As String)
        Connected()
        Dim result As String = ""
        Dim cond As String = ""
        Dim key As String = "'%" & search & "%'"
        sql = " SELECT * FROM tbltransaction WHERE slipno LIKE " & key & " or prod_name LIKE " & key & "or rec_by LIKE " & key & " order by id"
        CommandDB()
        dr = cmd.ExecuteReader()
        lv.Items.Clear()
        While (dr.Read())
            With lv.Items.Add(dr("id"))
                .SubItems.Add(dr("slipno"))
                .SubItems.Add(dr("prod_name"))
                .SubItems.Add(dr("rec_by"))
                .SubItems.Add(dr("remarks"))
                .SubItems.Add(dr("price"))
                .SubItems.Add(dr("qty"))
                .SubItems.Add(dr("discount"))
                .SubItems.Add(dr("net_total"))
                .SubItems.Add(dr("date_by"))
            End With
        End While
    End Sub
    Public Sub SearchUser(ByVal lv As ListView, ByVal search As String)
        Connected()
        Dim result As String = ""
        Dim cond As String = ""
        Dim key As String = "'%" & search & "%'"
        sql = " SELECT * FROM tbluser WHERE uname LIKE " & key & " order by id"
        CommandDB()
        dr = cmd.ExecuteReader()
        lv.Items.Clear()
        While (dr.Read())
            With lv.Items.Add(dr("id"))
              .SubItems.Add(dr("uname"))
                .SubItems.Add(dr("upword"))
                .SubItems.Add(dr("uposition"))
            End With
        End While
    End Sub

End Module
