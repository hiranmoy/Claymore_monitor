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


Module globals

    'settings file
    Public gSettingsFile As String = My.Application.Info.DirectoryPath + "\Settings.ini"

    'crash log
    Public gCrashLog As String = My.Application.Info.DirectoryPath + "\crash.txt"

    'data log
    Public gDataLog As String = My.Application.Info.DirectoryPath + "\data.html"

    'action
    Public gAction As Integer = 1

    'loading
    Public gLoading As Boolean = True

    'mining process
    Public gMiningProcess As Process

End Module
