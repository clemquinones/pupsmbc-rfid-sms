Imports MySql.Data.MySqlClient
Module modVariables
    Public conN As New MySqlConnection
    ' Public CMD As New MySqlCommand
    'Public dim dR as MySqlDataReaderAs MySqlDataReader
    Public dS As New DataSet

    Public Title As String = Application.ProductName.ToString
    Public logID, logUserType, logUserName, logUserPass As String
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



#Region "Database Connection"
    Public DataSource, dbUserID, dbPassword, DB As String
#End Region

#Region "Local Machine"
    Public Machine, PCname, PCSystem As String
#End Region

#Region "MsgBox"
    Public mbTitle As String = "Prompt"
    Public mbIcon As String = "i"
    Public mbButtons As String = "ok"
    Public mbMessage As String = "Message"
#End Region


End Module
