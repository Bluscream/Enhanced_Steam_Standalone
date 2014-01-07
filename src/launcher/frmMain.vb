Imports System.IO
Imports System.Net

Public Class frmMain
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Function CheckStatus()
        If (lblHost.Text = "Host File: Good" And lblNginx.Text = "Status: Running" And lblRinetd.Text = "Status: Running") Then
            lblStatus.Text = "Enhanced!"
            lblStatus.ForeColor = Color.Green
        Else
            lblStatus.Text = "Not Enhanced"
            lblStatus.ForeColor = Color.Red
        End If
    End Function

    Public Function CheckHosts()
        Dim systempath As String = Environment.GetFolderPath(Environment.SpecialFolder.System)
        Dim hosts As String = systempath & "\" & "drivers" & "\" & "etc" & "\" & "hosts"

        Dim line1 As Boolean
        Dim line2 As Boolean

        'this creates the streamwriter "writer" and sets its path to our string hosts, done above.
        Try
            Dim sr As StreamReader = New StreamReader(hosts)
            Do While sr.Peek() >= 0
                Dim line = sr.ReadLine
                If sr.ReadLine = "127.0.0.200 store.steampowered.com" Then
                    line1 = True
                End If
                If sr.ReadLine = "127.0.0.201 steamcommunity.com" Then
                    line2 = True
                End If
            Loop
            sr.Close()

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        If (line1 = True And line2 = True) Then
            lblHost.Text = "Host File: Good"
        Else
            lblHost.Text = "Host File: Entries Not Present"
        End If
    End Function

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 111
        CheckHosts()

        Dim p() As Process
        p = Process.GetProcessesByName("nginx")
        If p.Count > 0 Then
            ' Process is running
        Else
            ' Process is not running            
            startNginx()
        End If

        Dim r() As Process
        r = Process.GetProcessesByName("rinetd")
        If r.Count > 0 Then
            ' Process is running
        Else
            ' Process is not running
            startRinetd()
        End If

    End Sub

    Public Function startNginx()
        Try
            Dim exeFile As String = (New System.Uri(Reflection.Assembly.GetEntryAssembly().CodeBase)).LocalPath
            Dim exeDir As String = Path.GetDirectoryName(exeFile)

            Dim pNginx As New ProcessStartInfo()
            pNginx.WorkingDirectory = exeDir & "\nginx\"
            pNginx.FileName = "nginx.exe"
            pNginx.WindowStyle = ProcessWindowStyle.Hidden
            Process.Start(pNginx)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Function

    Public Function startRinetd()
        Try
            Dim exeFile As String = (New System.Uri(Reflection.Assembly.GetEntryAssembly().CodeBase)).LocalPath
            Dim exeDir As String = Path.GetDirectoryName(exeFile)

            Dim pRinetd As New ProcessStartInfo()
            pRinetd.UseShellExecute = True
            pRinetd.WorkingDirectory = exeDir & "\rinetd\"
            pRinetd.FileName = "rinetd.exe"
            pRinetd.Arguments = "-c rinetd.conf"
            pRinetd.WindowStyle = ProcessWindowStyle.Hidden
            Process.Start(pRinetd)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Function

    Private Sub btnNginxStart_Click(sender As Object, e As EventArgs) Handles btnNginxStart.Click
        startNginx()
    End Sub

    Private Sub btnRinetdStart_Click(sender As Object, e As EventArgs) Handles btnRinetdStart.Click
        startRinetd()
    End Sub

    Private Sub tmrNginx_Tick(sender As Object, e As EventArgs) Handles tmrNginx.Tick
        Dim p() As Process

        p = Process.GetProcessesByName("nginx")
        If p.Count > 0 Then
            ' Process is running
            lblNginx.Text = "Status: Running"
            btnNginxStop.Visible = True
            btnNginxStart.Visible = False
        Else
            ' Process is not running
            lblNginx.Text = "Status: Not Running"
            btnNginxStart.Visible = True
            btnNginxStop.Visible = False
        End If
    End Sub

    Private Sub tmrRinetd_Tick(sender As Object, e As EventArgs) Handles tmrRinetd.Tick
        Dim p() As Process

        p = Process.GetProcessesByName("rinetd")
        If p.Count > 0 Then
            ' Process is running
            lblRinetd.Text = "Status: Running"
            btnRinetdStop.Visible = True
            btnRinetdStart.Visible = False
        Else
            ' Process is not running
            lblRinetd.Text = "Status: Not Running"
            btnRinetdStart.Visible = True
            btnRinetdStop.Visible = False
        End If
    End Sub

    Private Sub btnNginxStop_Click(sender As Object, e As EventArgs) Handles btnNginxStop.Click
        Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName("nginx")

        For Each p As Process In pProcess
            p.Kill()
        Next
    End Sub

    Private Sub btnRinetdStop_Click(sender As Object, e As EventArgs) Handles btnRinetdStop.Click
        Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName("rinetd")

        For Each p As Process In pProcess
            p.Kill()
        Next
    End Sub

    Private Sub tmrStatus_Tick(sender As Object, e As EventArgs) Handles tmrStatus.Tick
        CheckStatus()
    End Sub

    Private Sub chkStatus_CheckedChanged(sender As Object, e As EventArgs) Handles chkStatus.CheckedChanged
        If chkStatus.Checked = True Then
            Me.Height = 243
        Else
            Me.Height = 111
        End If
    End Sub

    Private Sub btnCheckHosts_Click(sender As Object, e As EventArgs) Handles btnCheckHosts.Click
        CheckHosts()
    End Sub

    Private Sub tmrFirst_Tick(sender As Object, e As EventArgs) Handles tmrFirst.Tick
        If lblStatus.Text = "Not Enhanced" Then
            chkStatus.Checked = True
        End If
        'tmrPort80Status.Enabled = True
        tmrFirst.Enabled = False
    End Sub

    Private Sub tmrPort80Status_Tick(sender As Object, e As EventArgs) Handles tmrPort80Status.Tick
        Dim hostname As String = "localhost"
        Dim portno As Integer = 80

        Try
            Dim sock As New System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp)
            sock.Connect(hostname, portno)
            If sock.Connected = False Then
                ' Port is in use and connection is successful
                Console.WriteLine("Port is Closed")
            End If

            sock.Close()
        Catch ex As System.Net.Sockets.SocketException
            If ex.ErrorCode = 10061 Then
                ' Port is unused and could not establish connection 
                Console.WriteLine("Port is Open!")
            Else
                Console.WriteLine(ex.Message)
            End If
        End Try
    End Sub
End Class
