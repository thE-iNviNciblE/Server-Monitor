Imports System.ComponentModel
Imports System.Net

Public Class clsMail
    Public bError As Boolean = False
    Public strArtikelPromo As String = ""
    Public strErrorKunden As String = ""
    Private Shared mailSent As Boolean = False

    Private Shared Sub SendCompletedCallback(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        ' Get the unique identifier for this asynchronous operation.
        Dim token As String = CStr(e.UserState)

        If e.Cancelled Then
            Console.WriteLine("[{0}] Send canceled.", token)
        End If
        If e.Error IsNot Nothing Then
            Console.WriteLine("[{0}] {1}", token, e.Error.ToString())
        Else
            Console.WriteLine("Message sent.")
        End If
        mailSent = True
    End Sub

    '###############################################################
    '# >> eMail Senden 
    '###############################################################
    Public Function setSendMail(ByVal strEmailEmpfänger As String, ByVal strContent As String, ByVal strBetreff As String, Optional bTestModus As Boolean = True) As Boolean
        Dim SmtpObj As New System.Net.Mail.SmtpClient
        Dim pop3Client As New OpenPop.Pop3.Pop3Client
        Try
            ServicePointManager.ServerCertificateValidationCallback = AddressOf AcceptAllCertifications

            '# ->> Fehlerprüfung
            If strContent.Length = 0 Then
                MsgBox("Fehler kein inhalt")
                Return False
                Exit Function
            End If
            If strBetreff.Length = 0 Then
                MsgBox("Fehler kein Betrefftext")
                Return False
                Exit Function
            End If

            '# POP3 before SMTP nur dann ausführen wenn Setting vorliegt 
            If My.Settings.email_pop3_before_smtp = "True" Then

                Try
                    pop3Client.Connect(My.Settings.email_pop3, CInt(My.Settings.email_pop_port), False)
                    pop3Client.Authenticate(My.Settings.email_username_user, My.Settings.email_pwd)
                Catch ex As Exception
                    MessageBox.Show("Fehler bei POP3: " & ex.Message, "Fehler bei POP3", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            End If

            Dim MailNachricht As New System.Net.Mail.MailMessage()
            SmtpObj.Credentials = New System.Net.NetworkCredential(My.Settings.email_username_user, My.Settings.email_pwd)
            SmtpObj.Port = CInt(My.Settings.email_smtp_port)

            If CBool(My.Settings.emailssl) = True Then
                SmtpObj.EnableSsl = True
            Else
                SmtpObj.EnableSsl = False
            End If

            'If My.Settings.email_istTestmodus = True Then
            ' strKundenemail = My.Settings.developer_email_check
            'End If

            SmtpObj.Host = My.Settings.email_smtp  '"mail.gmx.net"
            AddHandler SmtpObj.SendCompleted, AddressOf SendCompletedCallback

            Try
                With MailNachricht
                    .From = New System.Net.Mail.MailAddress(My.Settings.email_username, My.Settings.email_absende_name)

                    If My.Settings.email_bcc.Length > 0 Then
                        .To.Add(New System.Net.Mail.MailAddress(My.Settings.email_bcc, ""))
                    End If

                    .BodyEncoding = System.Text.Encoding.UTF8
                    .To.Add(strEmailEmpfänger)
                    .Subject = strBetreff
                    .IsBodyHtml = True  'My.Settings.email_isthtml
                    .Body = strContent
                End With

            Catch ex As Exception
                strErrorKunden &= ex.Message & vbCrLf

            End Try

            MailNachricht.Attachments.Clear()


            'Dim userState As String = "message " + strKundenemail
            If bTestModus = True Then
                SmtpObj.Send(MailNachricht)
            Else
                Try
                    SmtpObj.Send(MailNachricht)
                Catch ex As Exception
                    If ex.Message.IndexOf("Fehler bei der Transaktion. Die Serverantwort war 5.7.0") >= 0 Then
                        If iErrorCounter = 0 Then
                            MessageBox.Show("E-Mail Limitierung entdeckt." & vbCrLf & vbCrLf & ex.Message, "Mailserver Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            iErrorCounter += 1
                        End If


                    Else
                        strErrorKunden &= ex.Message & vbCrLf
                    End If

                End Try
            End If



            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Fehler beim Email abschicken '" & strEmailEmpfänger & "'", MessageBoxButtons.OK, MessageBoxIcon.Error)
            bError = True
            Return False
        End Try

        Return True
    End Function

End Class
