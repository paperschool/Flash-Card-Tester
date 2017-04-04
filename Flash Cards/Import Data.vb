Imports System.Data.OleDb

Module Import_Data

    Dim cn As OleDbConnection
    Dim cm As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim ds As DataSet = New DataSet
    Dim file_path As String
    Dim OpenFileDlg As New OpenFileDialog
    Dim tbl As System.Data.OleDb.OleDbConnection
    Dim ExcelTables As DataTable = Nothing

    Sub check_content()

        If Main.txtTopic.Text = "" Or Main.cbSubjectcreate.Text = "" Then
            Main.btnImport.Enabled = False
        Else
            Main.btnImport.Enabled = True
        End If

    End Sub

    Sub Import_file()

        open_File()

        Dim cnstring As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & file_path & "; Extended Properties=""Excel 8.0;HDR=Yes;IMEX=1;"""

        cn = New OleDbConnection(cnstring)
        Dim tablename As String = ""

        Try
            tbl = New System.Data.OleDb.OleDbConnection(cnstring)
            tbl.Open()
            ExcelTables = tbl.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLES"})
            Console.WriteLine((tbl.GetSchema("TABLES").Rows(0)("TABLE_NAME")))
            tablename = (tbl.GetSchema("TABLES").Rows(0)("TABLE_NAME"))
        Catch ex As Exception
        Finally
        End Try

        Try
            cn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try


        FillDataGridView("select * from [" & tablename & "]")

        tbl.Close()

        populate_dropdowns()
        populate_test_dropdowns()
        populate_Edit_dropdowns()

    End Sub

    Sub open_File()

        ds.Clear()

        OpenFileDlg.FileName = "" ' Default file name
        OpenFileDlg.DefaultExt = ".xls" ' Default file extension
        OpenFileDlg.Filter = "Excel Documents (*.XLS)|*.XLS"
        OpenFileDlg.Multiselect = True
        OpenFileDlg.RestoreDirectory = True

        ' Show open file dialog box
        Dim result? As Boolean = OpenFileDlg.ShowDialog()

        ' Process open file dialog box results
        For Each path In OpenFileDlg.FileNames
            file_path = path
        Next

    End Sub

    Private Sub FillDataGridView(ByVal Query As String)

        da = New OleDbDataAdapter(Query, cn)
        dt = New DataTable
        da.Fill(ds, "ImportSales")

        Try
            With Main.dgvExcel
                .DataSource = ds
                .DataMember = "ImportSales"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        collectdata()

    End Sub

    Sub collectdata()

        Dim Subject As String = ""
        Dim Topic As String = ""
        Dim Question(Main.dgvExcel.RowCount) As String
        Dim Answer(Main.dgvExcel.RowCount) As String

        For i As Integer = 0 To (Main.dgvExcel.RowCount - 1)
            If ds.Tables("ImportSales").Rows(i).Item(0).ToString = Nothing Or ds.Tables("ImportSales").Rows(i).Item(1).ToString = Nothing Then
                'Console.WriteLine("asd")
            Else
                Subject = Main.cbSubjectcreate.Text
                Topic = Main.txtTopic.Text
                Question(i) = ds.Tables("ImportSales").Rows(i).Item(0).ToString
                Answer(i) = ds.Tables("ImportSales").Rows(i).Item(1).ToString
                'Console.WriteLine(i & " | " & Question(i) & " | " & Answer(i))
            End If

        Next

        For i As Integer = 0 To Main.dgvExcel.RowCount - 1
            If Question(i) Is Nothing Or Answer(i) Is Nothing Then
                'Console.WriteLine("")
            Else
                Dim FlashCardInsert As String = "INSERT INTO tblFlashCards ([Subject],[Topic],[Question],[Answer]) VALUES (@Subject,@Topic,@Question,@Answer)"
                Dim SQL_Command As New OleDbCommand
                With SQL_Command
                    .CommandText = FlashCardInsert
                    .Parameters.AddWithValue("@Subject", Subject)
                    .Parameters.AddWithValue("@Topic", Topic)
                    .Parameters.AddWithValue("@Question", Question(i))
                    .Parameters.AddWithValue("@Answer", Answer(i))
                    .Connection = conn
                    .ExecuteNonQuery()
                End With
            End If
        Next

        Main.cbSubjectcreate.Text = ""
        Main.txtTopic.Text = ""
        populate_dropdowns()

        MsgBox("Test Successfully Saved")

    End Sub

End Module
