Imports System.Net.Http
Imports System.Net.NetworkInformation

Public Class frmServerMonitor
    Dim iLäufe As Double = 0
    Dim clsMail As New clsMail
    Private Sub txtServer_TextChanged(sender As Object, e As EventArgs) Handles txtServer.TextChanged
        My.Settings.server = txtServer.Text
        My.Settings.Save()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            chkEmailImFehlerfall.Checked = My.Settings.email_aktiv
            txtDNSIP.Text = My.Settings.ping_server
            txtIntervall.Text = My.Settings.intervall
            tmrMain.Interval = Convert.ToInt32(txtIntervall.Text) * 1000
            txtEmailBCC.Text = My.Settings.email_bcc

            '# Autoload
            'If txtServer.Text IsNot "https://" Then
            '    tmrMain.Enabled = True
            'End If

            txtServer.Text = My.Settings.server
            My.Settings.Save()

        Catch ex As Exception

        End Try

    End Sub

    Private Async Sub tmrMain_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
        Dim hc As HttpClient

        Try

            If My.Settings.ping_server.Length > 0 Then
                Try
                    Dim host As String = My.Settings.ping_server ' use any other machine name
                    Dim pingreq As Ping = New Ping()
                    Dim rep As PingReply = pingreq.Send(host)
                    Dim lvwIteam_ping As New ListViewItem
                    lvwIteam_ping.Text = Date.Now
                    lvwIteam_ping.SubItems.Add("Server-Ping: " & rep.Status)
                    lvwIteam_ping.SubItems.Add(rep.Status)
                    lvwLogviewer_OK.Items.Add(lvwIteam_ping)

                Catch ex As Exception
                    Dim host As String = My.Settings.server.Replace("https://www.", "").Replace("https://", "").Replace("http://", "") ' use any other machine name
                    Dim pingreq As Ping = New Ping()
                    Dim rep As PingReply = pingreq.Send(host)
                    Dim lvwIteam_ping As New ListViewItem
                    lvwIteam_ping.Text = Date.Now
                    lvwIteam_ping.SubItems.Add("Server-Ping: " & rep.Status)
                    lvwIteam_ping.SubItems.Add(rep.Status)
                    lvwLogviewer_fehler.Items.Add(lvwIteam_ping)
                End Try
            End If

            hc = New HttpClient
            Dim rm As HttpResponseMessage
            rm = Await hc.GetAsync(My.Settings.server)

            If rm.IsSuccessStatusCode Then
                Dim lvwIteam As New ListViewItem
                lvwIteam.Text = Date.Now
                lvwIteam.SubItems.Add("Server: " & My.Settings.server & " " & rm.IsSuccessStatusCode & " - " & rm.StatusCode)
                lvwIteam.SubItems.Add(rm.IsSuccessStatusCode)
                lvwLogviewer_OK.Items.Add(lvwIteam)
            Else
                Dim lvwIteam As New ListViewItem
                lvwIteam.Text = Date.Now
                lvwIteam.SubItems.Add("Server: " & My.Settings.server & " " & rm.IsSuccessStatusCode & " - " & rm.StatusCode)
                lvwIteam.SubItems.Add(rm.IsSuccessStatusCode)
                lvwLogviewer_fehler.Items.Add(lvwIteam)

                If My.Settings.email_aktiv = True Then
                    clsMail.setSendMail(My.Settings.email_username, "Fehler HTTP-Server : " & rm.StatusCode, "maiwell.com Server-Fehler " & rm.StatusCode)
                End If

            End If

            Dim res As String
            res = Await rm.Content.ReadAsStringAsync()
            iLäufe += 1
            lblNächsterLauf.Text = "Gelaufen: " & iLäufe & "x"

        Catch ex As Exception
            Dim lvwIteam As New ListViewItem
            lvwIteam.Text = Date.Now
            lvwIteam.SubItems.Add("Server: " & My.Settings.server & " " & ex.Message)
            lvwIteam.SubItems.Add("404")
            lvwLogviewer_fehler.Items.Add(lvwIteam)
        End Try
    End Sub

    Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnStartStop.Click

        If tmrMain.Enabled = False Then
            tmrMain.Enabled = True
            tmrCountdown.Enabled = True
            tmrMain.Interval = Convert.ToInt32(My.Settings.intervall) * 1000
            btnStartStop.Text = "&Stoppen"
        Else
            tmrMain.Enabled = False
            tmrCountdown.Enabled = False
            btnStartStop.Text = "&Starten"
        End If


    End Sub

    Private Sub tmrCountdown_Tick(sender As Object, e As EventArgs) Handles tmrCountdown.Tick

    End Sub

    Private Sub txtIntervall_TextChanged(sender As Object, e As EventArgs) Handles txtIntervall.TextChanged
        If IsNumeric(txtIntervall.Text) Then
            My.Settings.intervall = txtIntervall.Text
            tmrMain.Interval = Convert.ToInt32(My.Settings.intervall) * 1000
            My.Settings.Save()
        End If
    End Sub

    Private Sub btnKonfig_Click(sender As Object, e As EventArgs) Handles btnKonfig.Click
        Dim frmMailServer As New frmMailServer
        frmMailServer.ShowDialog(Me)
    End Sub

    Private Sub chkEmailImFehlerfall_CheckedChanged(sender As Object, e As EventArgs) Handles chkEmailImFehlerfall.CheckedChanged
        My.Settings.email_aktiv = chkEmailImFehlerfall.Checked
        My.Settings.Save()
    End Sub

    Private Sub txtDNSIP_TextChanged(sender As Object, e As EventArgs) Handles txtDNSIP.TextChanged
        My.Settings.ping_server = txtDNSIP.Text
        My.Settings.Save()
    End Sub

    Private Sub txtEmailBCC_TextChanged(sender As Object, e As EventArgs) Handles txtEmailBCC.TextChanged
        My.Settings.email_bcc = txtEmailBCC.Text
        My.Settings.Save()
    End Sub
End Class
