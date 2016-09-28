Imports MySql.Data.MySqlClient 
Module modVariables
    Public conN As New MySqlConnection
    Public CMD As New MySqlCommand
    '    Public dR As MySqlDataReader
    Public dS As New DataSet
    Public AppPath As String = ""

    Public Title As String = Application.ProductName.ToString
   
    
#Region "Connection"
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
