' -*- Visual basic -*-

'*****************************************************************
'
'              Copyright 2017 Hiranmoy Basak
'
'                  All Rights Reserved.
'
'           THIS WORK CONTAINS TRADE SECRET And
'       PROPRIETARY INFORMATION WHICH Is THE PROPERTY
'            OF HIRANMOY BASAK OR ITS LICENSOR
'            AND IS SUBJECT TO LICENSE TERMS.
'
'*****************************************************************/
'
' No part of this file may be reproduced, stored in a retrieval system,
' Or transmitted in any form Or by any means --- electronic, mechanical,
' photocopying, recording, Or otherwise --- without prior written permission
' of Hiranmoy Basak.
'
' WARRANTY:
' Use all material in this file at your own risk. Hiranmoy Basak.
' makes no claims about any material contained in this file.
' 
' Author: Hiranmoy Basak (hiranmoy.iitkgp@gmail.com)


Imports System.IO


Module utils

    'start mining
    Public Sub StartMining()
        Dim minefile As String = Controller.ClaymoreFdLabel.Text + "\mine.bat"
        If My.Computer.FileSystem.FileExists(minefile) = False Then
            Exit Sub
        End If

        Directory.SetCurrentDirectory(Controller.ClaymoreFdLabel.Text)
        gMiningProcess = Process.Start(minefile)

        My.Forms.Controller.WindowState = FormWindowState.Minimized
    End Sub

    'save enable speech check in a file
    Public Sub SaveSettings()
        If gLoading = True Then
            Return
        End If

        'dump settings
        FileOpen(1, gSettingsFile, OpenMode.Output)

        'enable speech check
        Print(1, Controller.ClaymoreFdLabel.Text + Environment.NewLine)

        'timer val
        Print(1, Controller.WaitTimerVal.Value.ToString + "                    : timer value" + Environment.NewLine)

        'action
        Print(1, gAction.ToString + "                    : action value" + Environment.NewLine)

        FileClose(1)
    End Sub

    'restore enable speech check from a file
    Public Sub RestoreSettings()
        If My.Computer.FileSystem.FileExists(gSettingsFile) = False Then
            Exit Sub
        End If

        FileOpen(1, gSettingsFile, OpenMode.Input)

        'enable speech check
        Dim data As String

        'claymore folder
        Controller.ClaymoreFdLabel.Text = LineInput(1)

        'timer val
        data = LineInput(1)
        data = data.Substring(0, 5)
        Controller.WaitTimerVal.Value = CInt(data)

        'action
        data = LineInput(1)
        data = data.Substring(0, 5)
        gAction = data

        Select Case gAction
            Case 0 : Controller.DoNothingRd.Checked = True
            Case 1 : Controller.RestartClayRd.Checked = True
            Case 2 : Controller.RestartPCRd.Checked = True
            Case Else : Debug.Assert(False)
        End Select

        FileClose(1)
    End Sub

    'load log files
    Public Function LoadLogFiles(dir As String, Optional timeSelected As String = "") As String
        If My.Computer.FileSystem.DirectoryExists(dir) = False Then
            Return ""
        End If

        Dim clayMore As DirectoryInfo = New DirectoryInfo(dir)
        Dim logs() As FileInfo = clayMore.GetFiles("*_log.txt")

        Controller.LogFilesList.Items.Clear()
        Controller.LogFilesList.ResetText()

        Dim retFile As String = dir + "\" + logs(logs.Length - 1).ToString

        For idx = 0 To logs.Length - 1
            Dim fileName As String = logs(idx).ToString

            Dim creationTime As Date = My.Computer.FileSystem.GetFileInfo(dir + "\" + fileName).CreationTime()
            Dim writeTime As Date = My.Computer.FileSystem.GetFileInfo(dir + "\" + fileName).LastWriteTime()
            Dim displayTime As String = creationTime.ToShortTimeString + " " +
                                        creationTime.ToShortDateString() + " - " +
                                        writeTime.ToShortTimeString + " " +
                                        writeTime.ToShortDateString()

            Controller.LogFilesList.Items.Add(displayTime)

            If displayTime = timeSelected Then
                retFile = dir + "\" + fileName
            End If
        Next

        Controller.LogFilesList.SelectedIndex = logs.Length - 1

        Return retFile
    End Function

    'take proper action if needed
    Public Sub CheckForActions()
        If gAction = 0 Then
            'do nothing
            Exit Sub
        End If

        Dim curFile As String = LoadLogFiles(Controller.ClaymoreFdLabel.Text)
        Dim fileWriteTime As Date = My.Computer.FileSystem.GetFileInfo(curFile).LastWriteTime()
        Dim curTime As Date = Now
        Dim timeDiff As TimeSpan = curTime - fileWriteTime

        If timeDiff.TotalMinutes < Controller.WaitTimerVal.Value Then
            Exit Sub
        End If

        UpdateCrashLog(My.Computer.FileSystem.GetFileInfo(curFile).CreationTime(), fileWriteTime)

        Select Case gAction
            Case 1
                'restart miner
                Try
                    'kill previous mining process
                    gMiningProcess.Kill()
                Catch
                End Try

                StartMining()

            Case 2
                'restart pc
                Process.Start("shutdown", "-r -t 00")

            Case Else
                Debug.Assert(False)
        End Select
    End Sub

    'update crash log
    Private Sub UpdateCrashLog(starTime As Date, endTime As Date)
        DeleteCrashFileIfNeeded()

        'dump settings
        FileOpen(1, gCrashLog, OpenMode.Append)

        'enable speech check
        Print(1, "System started at " + starTime.ToString + " and crashed at " + endTime.ToString + Environment.NewLine)

        FileClose(1)
    End Sub

    'delete crash log if it was not created today
    Public Sub DeleteCrashFileIfNeeded()
        If My.Computer.FileSystem.FileExists(gCrashLog) = False Then
            Return
        End If

        If My.Computer.FileSystem.GetFileInfo(gCrashLog).LastWriteTime().Date <> Now.Date Then
            'delete crash log
            My.Computer.FileSystem.DeleteFile(gCrashLog)
        End If
    End Sub

End Module
