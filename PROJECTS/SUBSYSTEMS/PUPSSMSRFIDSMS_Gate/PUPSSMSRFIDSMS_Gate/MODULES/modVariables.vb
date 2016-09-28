Imports MySql.Data.MySqlClient 
Module modVariables
    Public conN As New MySqlConnection
    Public CMD As New MySqlCommand
    Public dR As MySqlDataReader
    Public dS As New DataSet

    Public Title As String = Application.ProductName.ToString
    Public logID, logUserType, logUserName As String
    Public ADMINPASSWORD As String = ""


    Public StudentDetectionRFID As String = ""
    Public Path As String = ""
    Public PathSearch As String = ""


    Public LastLogInDetectedRFID(), LastLogOutDetectedRFID() As String
    Public UnLogOut As Boolean = False
    Public LogInPrev, LogInNext, LogOutPrev, LogOutNext As Boolean
    Public LastDetection As String
    Public FindStud As String
    Public IDserialNo As String = ""


    Enum Message
        LoginMessage = 0
        LogoutMessage = 1
        AnnouncementMessage = 2
        UnlogoutMessage = 3
        AdvisoryMessage = 4
    End Enum
#Region "Database Connection"
    Public DataSource, dbUserID, dbPassword, DB As String
#End Region

#Region "Local Machine"
    Public Machine, PCname, PCSystem As String
#End Region

#Region "MsgBox"
    Public mbTitle As String = "Prompt"
    Public mbIcon = "i"
    Public mbButtons = "ok"
    Public mbMessage = "Message"
#End Region


End Module
