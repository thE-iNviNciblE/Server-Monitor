<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServerMonitor
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.tbcMain = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tabLogview = New System.Windows.Forms.TabControl()
        Me.tabLogview_Fehler = New System.Windows.Forms.TabPage()
        Me.lvwLogviewer_OK = New System.Windows.Forms.ListView()
        Me.colDatum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMessage = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabLogview_OK = New System.Windows.Forms.TabPage()
        Me.lvwLogviewer_fehler = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblNächsterLauf = New System.Windows.Forms.Label()
        Me.btnStartStop = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDNSIP = New System.Windows.Forms.TextBox()
        Me.btnKonfig = New System.Windows.Forms.Button()
        Me.chkEmailImFehlerfall = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIntervall = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.tmrCountdown = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmailBCC = New System.Windows.Forms.TextBox()
        Me.tbcMain.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.tabLogview.SuspendLayout()
        Me.tabLogview_Fehler.SuspendLayout()
        Me.tabLogview_OK.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrMain
        '
        Me.tmrMain.Interval = 10000
        '
        'tbcMain
        '
        Me.tbcMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbcMain.Controls.Add(Me.TabPage1)
        Me.tbcMain.Controls.Add(Me.TabPage2)
        Me.tbcMain.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcMain.Location = New System.Drawing.Point(12, 12)
        Me.tbcMain.Name = "tbcMain"
        Me.tbcMain.SelectedIndex = 0
        Me.tbcMain.Size = New System.Drawing.Size(1235, 707)
        Me.tbcMain.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.tabLogview)
        Me.TabPage1.Controls.Add(Me.lblNächsterLauf)
        Me.TabPage1.Controls.Add(Me.btnStartStop)
        Me.TabPage1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1227, 680)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Logviewer"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tabLogview
        '
        Me.tabLogview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabLogview.Controls.Add(Me.tabLogview_Fehler)
        Me.tabLogview.Controls.Add(Me.tabLogview_OK)
        Me.tabLogview.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabLogview.Location = New System.Drawing.Point(0, 90)
        Me.tabLogview.Name = "tabLogview"
        Me.tabLogview.SelectedIndex = 0
        Me.tabLogview.Size = New System.Drawing.Size(1231, 594)
        Me.tabLogview.TabIndex = 3
        '
        'tabLogview_Fehler
        '
        Me.tabLogview_Fehler.Controls.Add(Me.lvwLogviewer_OK)
        Me.tabLogview_Fehler.Location = New System.Drawing.Point(4, 25)
        Me.tabLogview_Fehler.Name = "tabLogview_Fehler"
        Me.tabLogview_Fehler.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLogview_Fehler.Size = New System.Drawing.Size(1223, 565)
        Me.tabLogview_Fehler.TabIndex = 0
        Me.tabLogview_Fehler.Text = "Keine Fehler"
        Me.tabLogview_Fehler.UseVisualStyleBackColor = True
        '
        'lvwLogviewer_OK
        '
        Me.lvwLogviewer_OK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwLogviewer_OK.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDatum, Me.colMessage, Me.colStatus})
        Me.lvwLogviewer_OK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwLogviewer_OK.FullRowSelect = True
        Me.lvwLogviewer_OK.GridLines = True
        Me.lvwLogviewer_OK.HideSelection = False
        Me.lvwLogviewer_OK.Location = New System.Drawing.Point(3, 3)
        Me.lvwLogviewer_OK.Name = "lvwLogviewer_OK"
        Me.lvwLogviewer_OK.Size = New System.Drawing.Size(1217, 559)
        Me.lvwLogviewer_OK.TabIndex = 0
        Me.lvwLogviewer_OK.UseCompatibleStateImageBehavior = False
        Me.lvwLogviewer_OK.View = System.Windows.Forms.View.Details
        '
        'colDatum
        '
        Me.colDatum.Text = "Datum"
        Me.colDatum.Width = 133
        '
        'colMessage
        '
        Me.colMessage.Text = "Nachricht"
        Me.colMessage.Width = 1136
        '
        'colStatus
        '
        Me.colStatus.Text = "Status"
        '
        'tabLogview_OK
        '
        Me.tabLogview_OK.Controls.Add(Me.lvwLogviewer_fehler)
        Me.tabLogview_OK.Location = New System.Drawing.Point(4, 22)
        Me.tabLogview_OK.Name = "tabLogview_OK"
        Me.tabLogview_OK.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLogview_OK.Size = New System.Drawing.Size(1223, 569)
        Me.tabLogview_OK.TabIndex = 1
        Me.tabLogview_OK.Text = "Fehler"
        Me.tabLogview_OK.UseVisualStyleBackColor = True
        '
        'lvwLogviewer_fehler
        '
        Me.lvwLogviewer_fehler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwLogviewer_fehler.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvwLogviewer_fehler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwLogviewer_fehler.FullRowSelect = True
        Me.lvwLogviewer_fehler.GridLines = True
        Me.lvwLogviewer_fehler.HideSelection = False
        Me.lvwLogviewer_fehler.Location = New System.Drawing.Point(3, 3)
        Me.lvwLogviewer_fehler.Name = "lvwLogviewer_fehler"
        Me.lvwLogviewer_fehler.Size = New System.Drawing.Size(1217, 563)
        Me.lvwLogviewer_fehler.TabIndex = 1
        Me.lvwLogviewer_fehler.UseCompatibleStateImageBehavior = False
        Me.lvwLogviewer_fehler.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Datum"
        Me.ColumnHeader1.Width = 133
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nachricht"
        Me.ColumnHeader2.Width = 1136
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Status"
        '
        'lblNächsterLauf
        '
        Me.lblNächsterLauf.AutoSize = True
        Me.lblNächsterLauf.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNächsterLauf.Location = New System.Drawing.Point(509, 46)
        Me.lblNächsterLauf.Name = "lblNächsterLauf"
        Me.lblNächsterLauf.Size = New System.Drawing.Size(100, 16)
        Me.lblNächsterLauf.TabIndex = 2
        Me.lblNächsterLauf.Text = "Nächster Lauf..."
        '
        'btnStartStop
        '
        Me.btnStartStop.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartStop.Location = New System.Drawing.Point(18, 21)
        Me.btnStartStop.Name = "btnStartStop"
        Me.btnStartStop.Size = New System.Drawing.Size(485, 63)
        Me.btnStartStop.TabIndex = 1
        Me.btnStartStop.Text = "&Starten"
        Me.btnStartStop.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtEmailBCC)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtDNSIP)
        Me.TabPage2.Controls.Add(Me.btnKonfig)
        Me.TabPage2.Controls.Add(Me.chkEmailImFehlerfall)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtIntervall)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txtServer)
        Me.TabPage2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1227, 680)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Einstellungen"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "DNS Überwachung vom IP-Adresse vom Hosting"
        '
        'txtDNSIP
        '
        Me.txtDNSIP.Location = New System.Drawing.Point(29, 106)
        Me.txtDNSIP.Name = "txtDNSIP"
        Me.txtDNSIP.Size = New System.Drawing.Size(236, 20)
        Me.txtDNSIP.TabIndex = 6
        '
        'btnKonfig
        '
        Me.btnKonfig.Location = New System.Drawing.Point(29, 644)
        Me.btnKonfig.Name = "btnKonfig"
        Me.btnKonfig.Size = New System.Drawing.Size(1192, 31)
        Me.btnKonfig.TabIndex = 5
        Me.btnKonfig.Text = "&Konfig..."
        Me.btnKonfig.UseVisualStyleBackColor = True
        '
        'chkEmailImFehlerfall
        '
        Me.chkEmailImFehlerfall.AutoSize = True
        Me.chkEmailImFehlerfall.Location = New System.Drawing.Point(29, 232)
        Me.chkEmailImFehlerfall.Name = "chkEmailImFehlerfall"
        Me.chkEmailImFehlerfall.Size = New System.Drawing.Size(116, 18)
        Me.chkEmailImFehlerfall.TabIndex = 4
        Me.chkEmailImFehlerfall.Text = "Email im Fehlerfall?"
        Me.chkEmailImFehlerfall.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Intervall der Prüfung in Sekunden"
        '
        'txtIntervall
        '
        Me.txtIntervall.Location = New System.Drawing.Point(29, 155)
        Me.txtIntervall.Name = "txtIntervall"
        Me.txtIntervall.Size = New System.Drawing.Size(181, 20)
        Me.txtIntervall.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(550, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "HTTP-Überwachung vom Server (Für JTL Shop Cron-Task - https://www.domainname.de/i" &
    "ncludes/cron_inc.php)"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(29, 54)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(1143, 20)
        Me.txtServer.TabIndex = 0
        '
        'tmrCountdown
        '
        Me.tmrCountdown.Interval = 1000
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 14)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "BCC Email"
        '
        'txtEmailBCC
        '
        Me.txtEmailBCC.Location = New System.Drawing.Point(29, 206)
        Me.txtEmailBCC.Name = "txtEmailBCC"
        Me.txtEmailBCC.Size = New System.Drawing.Size(181, 20)
        Me.txtEmailBCC.TabIndex = 8
        '
        'frmServerMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1259, 731)
        Me.Controls.Add(Me.tbcMain)
        Me.Name = "frmServerMonitor"
        Me.Text = "Server Monitor Tool von Bludau-Media.de"
        Me.tbcMain.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.tabLogview.ResumeLayout(False)
        Me.tabLogview_Fehler.ResumeLayout(False)
        Me.tabLogview_OK.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tmrMain As Timer
    Friend WithEvents tbcMain As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents txtServer As TextBox
    Friend WithEvents lvwLogviewer_OK As ListView
    Friend WithEvents colDatum As ColumnHeader
    Friend WithEvents colMessage As ColumnHeader
    Friend WithEvents colStatus As ColumnHeader
    Friend WithEvents tmrCountdown As Timer
    Friend WithEvents btnStartStop As Button
    Friend WithEvents lblNächsterLauf As Label
    Friend WithEvents tabLogview As TabControl
    Friend WithEvents tabLogview_Fehler As TabPage
    Friend WithEvents tabLogview_OK As TabPage
    Friend WithEvents lvwLogviewer_fehler As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIntervall As TextBox
    Friend WithEvents btnKonfig As Button
    Friend WithEvents chkEmailImFehlerfall As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDNSIP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmailBCC As TextBox
End Class
