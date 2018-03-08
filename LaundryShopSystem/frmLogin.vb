Imports kitchanismo

Public Class frmLogin
    Dim kit As New betsayda

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnTitle.MouseDown, lbltitle.MouseDown
        xpos = Cursor.Position.X - Panel1.Location.X
        ypos = Cursor.Position.Y - Panel1.Location.Y
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnTitle.MouseMove, lbltitle.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            pos = MousePosition
            pos.X = pos.X - xpos
            pos.Y = pos.Y - ypos
            Panel1.Location = pos
        End If
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click

        'validation if textboxes is empty
        If tbuname.Text = "" Then
            lblum.Visible = True
            tbuname.SelectAll()
            Exit Sub
        ElseIf tbpword.Text = "" Then
            lblup.Visible = True
            tbpword.SelectAll()
            Exit Sub
        End If

        'CheckLoginNormal() 'login in normal mode
        CheckLoginEncrypted() 'login in better security

    End Sub

    Sub CheckLoginEncrypted()
        Dim _uname As String = chan.Encrypt(tbuname.Text, coder)
        Dim pword As String = chan.Encrypt(tbpword.Text, coder)
        If Not GetUserPassword(chan.Decrypt(_uname, coder)) <> chan.Decrypt(pword, coder) Then
            'access
            lblnotif.Visible = True
            tbpword.Text = ""
            uname = tbuname.Text
            lblWelcome.Text = "WELCOME " & uname.ToUpper
            Panel1.Visible = False
            tbuname.Text = ""
            Timer1.Start()
        Else
            'denied
            lblnotif.Visible = True
            lblnotif.Text = "*Invalid Username/Password!"
        End If

    End Sub

    Sub CheckLoginNormal()
        'method call for login
        CheckLogin(tbuname.Text, tbpword.Text)
        'condition to check the login
        If (dr.Read() = True) Then
            'access
            lblnotif.Visible = True
            tbpword.Text = ""
            uname = tbuname.Text
            lblWelcome.Text = "WELCOME " & uname.ToUpper
            Panel1.Visible = False
            tbuname.Text = ""
            Timer1.Start()
        Else
            'denied
            lblnotif.Visible = True
            lblnotif.Text = "*Invalid Username/Password!"
        End If
    End Sub

    Private Sub tbuname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbuname.TextChanged
        lblum.Visible = False
        lblnotif.Visible = False
    End Sub
    Private Sub tbpword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbpword.TextChanged
        lblup.Visible = False
        lblnotif.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("www.facebook.com/kitchanismo")
    End Sub
    Dim ctr As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ctr += 1
        If ctr >= 3 Then
            Timer1.Stop()
            frmMain.Show()
            Me.Hide()
            ctr = 0
            Panel1.Visible = True
            lblWelcome.Text = ""
        End If
    End Sub


    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connected()
    End Sub
End Class