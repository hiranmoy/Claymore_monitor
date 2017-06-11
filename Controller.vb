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


Public Class Controller

    Private Sub controller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'position the window in the middle
        Me.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - Me.Width / 2
        Me.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - Me.Height / 2

        'load settings
        gLoading = True
        RestoreSettings()
        gLoading = False

        'delete crash log
        DeleteCrashFileIfNeeded()

        'start mining
        StartMining()
    End Sub

    'select button
    Private Sub SelectClaymoreFdBt_Click(sender As Object, e As EventArgs) Handles SelectClaymoreFdBt.Click
        BrowseClaymore.SelectedPath = ClaymoreFdLabel.Text
        BrowseClaymore.ShowDialog()

        If BrowseClaymore.SelectedPath = ClaymoreFdLabel.Text Or BrowseClaymore.SelectedPath = "FolderBrowserDialog1" Then
            Exit Sub
        End If

        ClaymoreFdLabel.Text = BrowseClaymore.SelectedPath

        SaveSettings()
    End Sub

    'do nothing
    Private Sub DoNothingRd_CheckedChanged(sender As Object, e As EventArgs) Handles DoNothingRd.CheckedChanged
        If DoNothingRd.Checked Then
            gAction = 0

            SaveSettings()
        End If
    End Sub

    'restart claymore
    Private Sub RestartClayRd_CheckedChanged(sender As Object, e As EventArgs) Handles RestartClayRd.CheckedChanged
        If RestartClayRd.Checked Then
            gAction = 1

            SaveSettings()
        End If
    End Sub

    'restart pc
    Private Sub RestartPCRd_CheckedChanged(sender As Object, e As EventArgs) Handles RestartPCRd.CheckedChanged
        If RestartPCRd.Checked Then
            gAction = 2

            SaveSettings()
        End If
    End Sub

    'timer val
    Private Sub WaitTimerVal_ValueChanged(sender As Object, e As EventArgs) Handles WaitTimerVal.ValueChanged
        SaveSettings()
    End Sub

    'claymore folder
    Private Sub ClaymoreFdLabel_TextChanged(sender As Object, e As EventArgs) Handles ClaymoreFdLabel.TextChanged
        LoadLogFiles(ClaymoreFdLabel.Text)
    End Sub

    'open log
    Private Sub OpenLogBt_Click(sender As Object, e As EventArgs) Handles OpenLogBt.Click
        Process.Start("explorer.exe", LoadLogFiles(ClaymoreFdLabel.Text, LogFilesList.SelectedItem.ToString))
    End Sub

    'load log file timer
    Private Sub LoadingTimer_Tick(sender As Object, e As EventArgs) Handles LoadingTimer.Tick
        CheckForActions()
        DumpData()
        UploadDataFile()
    End Sub

End Class
