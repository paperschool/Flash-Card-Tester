Imports System.Data.OleDb

Module Establish_Connection

    Public conn As New OleDbConnection

    Public Sub connect()
        Try

            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|datadirectory|\Flashcards.accdb;"

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If


            If conn.State = ConnectionState.Open Then
                'MsgBox("Connected")
            Else
                MsgBox("Error")
            End If
        Catch ex As Exception
            MsgBox("Database not found in local directory, opening file selection dialog.")
            finddatabase()
        End Try
    End Sub

    Dim OpenFileDlg As New OpenFileDialog


    Dim filepath As String

    'this subroutine will open a dialog box and will further allow the user to select a database
    Sub finddatabase()

        'these filedialog properties will set the type of file the database opens, and will allow for some other settings
        OpenFileDlg.FileName = "" ' Default file name
        OpenFileDlg.DefaultExt = ".accdb" ' Default file extension
        OpenFileDlg.Filter = "Access Documents (*.ACCDB)|*.ACCDB"
        OpenFileDlg.Multiselect = True
        OpenFileDlg.RestoreDirectory = True

        'Show open file dialog box
        Dim result? As Boolean = OpenFileDlg.ShowDialog()

        'Process open file dialog box results
        For Each path In OpenFileDlg.FileNames
            filepath = path
        Next

        'this will check to ensure a file was chosen if not the program is closed
        If filepath = "" Then
            MsgBox("No Database selected, Exiting Program")
            Main.Close()
            Exit Sub
        End If

        'experimental code to move database from located directory to main directory 
        Dim FileToMove As String = filepath
        Dim MoveLocation As String = My.Application.Info.DirectoryPath + "\Flashcards.accdb"

        'MsgBox(My.Application.Info.DirectoryPath & " | " & FileToMove)



        If System.IO.File.Exists(FileToMove) = True Then
            'FileIO.FileSystem.CopyFile(FileToMove, MoveLocation)
            Try
                System.IO.File.Copy(FileToMove, MoveLocation)
                'this formats a new connection string for the database location with the selected database
                conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|datadirectory|\Flashcards.accdb;"
            Catch ex As Exception
                conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & FileToMove & ";"
            End Try

        End If


        MsgBox("Database: Flashcards.accdb Located.")

        'this checks if the connection state is open or closed
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

    End Sub

End Module
