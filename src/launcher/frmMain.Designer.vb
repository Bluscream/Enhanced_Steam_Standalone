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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tmrNginx = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRinetd = New System.Windows.Forms.Timer(Me.components)
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.tmrStatus = New System.Windows.Forms.Timer(Me.components)
        Me.grpStatus = New System.Windows.Forms.GroupBox()
        Me.btnCheckHosts = New System.Windows.Forms.Button()
        Me.lblRinetd = New System.Windows.Forms.Label()
        Me.lblNginx = New System.Windows.Forms.Label()
        Me.lblHost = New System.Windows.Forms.Label()
        Me.btnRinetdStop = New System.Windows.Forms.Button()
        Me.btnNginxStart = New System.Windows.Forms.Button()
        Me.btnRinetdStart = New System.Windows.Forms.Button()
        Me.btnNginxStop = New System.Windows.Forms.Button()
        Me.chkStatus = New System.Windows.Forms.CheckBox()
        Me.tmrFirst = New System.Windows.Forms.Timer(Me.components)
        Me.grpStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrNginx
        '
        Me.tmrNginx.Enabled = True
        '
        'tmrRinetd
        '
        Me.tmrRinetd.Enabled = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(12, 9)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(185, 29)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "Not Enhanced :("
        '
        'tmrStatus
        '
        Me.tmrStatus.Enabled = True
        '
        'grpStatus
        '
        Me.grpStatus.Controls.Add(Me.btnCheckHosts)
        Me.grpStatus.Controls.Add(Me.lblRinetd)
        Me.grpStatus.Controls.Add(Me.lblNginx)
        Me.grpStatus.Controls.Add(Me.lblHost)
        Me.grpStatus.Controls.Add(Me.btnRinetdStop)
        Me.grpStatus.Controls.Add(Me.btnNginxStart)
        Me.grpStatus.Controls.Add(Me.btnRinetdStart)
        Me.grpStatus.Controls.Add(Me.btnNginxStop)
        Me.grpStatus.Location = New System.Drawing.Point(17, 72)
        Me.grpStatus.Name = "grpStatus"
        Me.grpStatus.Size = New System.Drawing.Size(254, 121)
        Me.grpStatus.TabIndex = 8
        Me.grpStatus.TabStop = False
        Me.grpStatus.Text = "Status"
        '
        'btnCheckHosts
        '
        Me.btnCheckHosts.Location = New System.Drawing.Point(173, 92)
        Me.btnCheckHosts.Name = "btnCheckHosts"
        Me.btnCheckHosts.Size = New System.Drawing.Size(75, 23)
        Me.btnCheckHosts.TabIndex = 14
        Me.btnCheckHosts.Text = "Check"
        Me.btnCheckHosts.UseVisualStyleBackColor = True
        '
        'lblRinetd
        '
        Me.lblRinetd.AutoSize = True
        Me.lblRinetd.Location = New System.Drawing.Point(85, 60)
        Me.lblRinetd.Name = "lblRinetd"
        Me.lblRinetd.Size = New System.Drawing.Size(40, 13)
        Me.lblRinetd.TabIndex = 13
        Me.lblRinetd.Text = "Status:"
        '
        'lblNginx
        '
        Me.lblNginx.AutoSize = True
        Me.lblNginx.Location = New System.Drawing.Point(85, 31)
        Me.lblNginx.Name = "lblNginx"
        Me.lblNginx.Size = New System.Drawing.Size(40, 13)
        Me.lblNginx.TabIndex = 12
        Me.lblNginx.Text = "Status:"
        '
        'lblHost
        '
        Me.lblHost.AutoSize = True
        Me.lblHost.Location = New System.Drawing.Point(6, 97)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Size = New System.Drawing.Size(48, 13)
        Me.lblHost.TabIndex = 9
        Me.lblHost.Text = "Host file:"
        '
        'btnRinetdStop
        '
        Me.btnRinetdStop.Location = New System.Drawing.Point(6, 55)
        Me.btnRinetdStop.Name = "btnRinetdStop"
        Me.btnRinetdStop.Size = New System.Drawing.Size(73, 23)
        Me.btnRinetdStop.TabIndex = 11
        Me.btnRinetdStop.Text = "Stop rinetd"
        Me.btnRinetdStop.UseVisualStyleBackColor = True
        '
        'btnNginxStart
        '
        Me.btnNginxStart.Location = New System.Drawing.Point(6, 26)
        Me.btnNginxStart.Name = "btnNginxStart"
        Me.btnNginxStart.Size = New System.Drawing.Size(72, 23)
        Me.btnNginxStart.TabIndex = 7
        Me.btnNginxStart.Text = "Start nginx"
        Me.btnNginxStart.UseVisualStyleBackColor = True
        '
        'btnRinetdStart
        '
        Me.btnRinetdStart.Location = New System.Drawing.Point(7, 55)
        Me.btnRinetdStart.Name = "btnRinetdStart"
        Me.btnRinetdStart.Size = New System.Drawing.Size(72, 23)
        Me.btnRinetdStart.TabIndex = 8
        Me.btnRinetdStart.Text = "Start rinetd"
        Me.btnRinetdStart.UseVisualStyleBackColor = True
        '
        'btnNginxStop
        '
        Me.btnNginxStop.Location = New System.Drawing.Point(6, 26)
        Me.btnNginxStop.Name = "btnNginxStop"
        Me.btnNginxStop.Size = New System.Drawing.Size(73, 23)
        Me.btnNginxStop.TabIndex = 10
        Me.btnNginxStop.Text = "Stop nginx"
        Me.btnNginxStop.UseVisualStyleBackColor = True
        '
        'chkStatus
        '
        Me.chkStatus.AutoSize = True
        Me.chkStatus.Location = New System.Drawing.Point(17, 49)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Size = New System.Drawing.Size(86, 17)
        Me.chkStatus.TabIndex = 9
        Me.chkStatus.Text = "Show Status"
        Me.chkStatus.UseVisualStyleBackColor = True
        '
        'tmrFirst
        '
        Me.tmrFirst.Enabled = True
        Me.tmrFirst.Interval = 400
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 203)
        Me.Controls.Add(Me.chkStatus)
        Me.Controls.Add(Me.grpStatus)
        Me.Controls.Add(Me.lblStatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Enhanced Steam"
        Me.grpStatus.ResumeLayout(False)
        Me.grpStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrNginx As System.Windows.Forms.Timer
    Friend WithEvents tmrRinetd As System.Windows.Forms.Timer
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents tmrStatus As System.Windows.Forms.Timer
    Friend WithEvents grpStatus As System.Windows.Forms.GroupBox
    Friend WithEvents lblRinetd As System.Windows.Forms.Label
    Friend WithEvents lblNginx As System.Windows.Forms.Label
    Friend WithEvents lblHost As System.Windows.Forms.Label
    Friend WithEvents btnRinetdStop As System.Windows.Forms.Button
    Friend WithEvents btnNginxStart As System.Windows.Forms.Button
    Friend WithEvents btnRinetdStart As System.Windows.Forms.Button
    Friend WithEvents btnNginxStop As System.Windows.Forms.Button
    Friend WithEvents chkStatus As System.Windows.Forms.CheckBox
    Friend WithEvents btnCheckHosts As System.Windows.Forms.Button
    Friend WithEvents tmrFirst As System.Windows.Forms.Timer

End Class
