Imports System.Data.OleDb

Module Testing

    Dim cn As OleDbConnection
    Dim cm As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim ds As DataSet = New DataSet
    Dim Subject As String

    Sub populate_test_dropdowns()

        ds.Clear()

        Dim SubjectSearch As String = "SELECT * FROM tblFlashCards"

        Main.cbSubjectEdit.Items.Clear()

        da = New OleDbDataAdapter(SubjectSearch, conn)
        'Data adapter told to fill the da   taset
        da.Fill(ds, "subjects")
        'Defining the datatable
        dt = ds.Tables("subjects")

        Dim repeat As String = ""

        Dim subjects(100) As String

        subjects(0) = ds.Tables("subjects").Rows(0).Item(1).ToString
        Dim located As Boolean = False

        For i As Integer = 1 To ds.Tables("subjects").Rows.Count - 1
            located = False
            For l As Integer = 0 To subjects.Count - 1
                If subjects(l) = ds.Tables("subjects").Rows(i).Item(1).ToString Then
                    located = True
                    Exit For
                ElseIf subjects(l) = Nothing Then
                    Exit For
                End If
            Next
            If located = False Then
                For x As Integer = 0 To subjects.Count - 1
                    If subjects(x) = Nothing Then
                        subjects(x) = ds.Tables("subjects").Rows(i).Item(1).ToString
                        Exit For
                    End If
                Next
            End If
        Next

        For i As Integer = 0 To subjects.Count - 1
            If subjects(i) = Nothing Then
                Exit For
            End If
            Main.cbSubjectTesting.Items.Add(subjects(i))
        Next

    End Sub

    Sub populate_topic_test(subjectsel)

        ds.Clear()
        Main.clbTopics.Items.Clear()

        Dim TopicSearch As String = "SELECT * FROM tblFlashCards WHERE Subject ='" & subjectsel & "' "

        da = New OleDbDataAdapter(TopicSearch, conn)
        'Data adapter told to fill the da   taset
        da.Fill(ds, "Topics")
        'Defining the datatable
        dt = ds.Tables("Topics")

        Dim Topics(100) As String

        Topics(0) = ds.Tables("Topics").Rows(0).Item(2).ToString
        Dim located As Boolean = False

        For i As Integer = 1 To ds.Tables("Topics").Rows.Count - 1
            located = False
            For l As Integer = 0 To Topics.Count - 1
                If Topics(l) = ds.Tables("Topics").Rows(i).Item(2).ToString Then
                    located = True
                    Exit For
                ElseIf Topics(l) = Nothing Then
                    Exit For
                End If
            Next
            If located = False Then
                For x As Integer = 0 To Topics.Count - 1
                    If Topics(x) = Nothing Then
                        Topics(x) = ds.Tables("Topics").Rows(i).Item(2).ToString
                        Exit For
                    End If
                Next
            End If
        Next

        For i As Integer = 0 To Topics.Count - 1
            If Topics(i) = Nothing Then
                Exit For
            End If
            Main.clbTopics.Items.Add(Topics(i))
        Next

    End Sub

    Dim final_test(1000, 1)

    Sub start_test()

        If Main.btnStartTest.Text = "End Test" Then
            Main.btnStartTest.Text = "Start Test"
        Else
            Main.btnStartTest.Text = "End Test"
        End If

        Main.btnCorrectTest.Enabled = True
        Main.btnIncorrectTest.Enabled = True

        If Main.btnStartTest.Text = "End Test" Then
        Else
            Main.txtFinalTestAnswer.Text = ""
            Main.txtFinalTestQuestion.Text = ""
            Exit Sub
        End If

        Dim subjects As String = ""
        Dim selected(Main.clbTopics.Items.Count - 1) As String
        Dim card_counter = 0

        If Main.cbCardNumber.Text = "" Then
            MsgBox("Enter a Card Count")
            Exit Sub
        End If

        For Each i As Char In Main.cbCardNumber.Text
            If Char.IsNumber(i) = True Then
            Else
                Exit Sub

            End If
        Next

        For i As Integer = 0 To Main.clbTopics.Items.Count - 1
            If (Main.clbTopics.GetItemCheckState(i) = CheckState.Checked) Then
                selected(i) = Main.clbTopics.Items(i)
            End If
        Next

        For Each item In selected
            If item = Nothing Then
                Continue For
            End If

            Dim test_population As String = "SELECT * FROM tblFlashCards WHERE Topic='" & item & "' "
            da = New OleDbDataAdapter(test_population, conn)
            'Data adapter told to fill the da   taset
            da.Fill(ds, "test")
            'Defining the datatable
            dt = ds.Tables("test")
        Next

        Dim topics(ds.Tables("test").Rows.Count - 1) As String
        Dim allcardsquestions(ds.Tables("test").Rows.Count - 1) As String
        Dim allcardsanswers(ds.Tables("test").Rows.Count - 1) As String

        card_counter = CInt(Main.cbCardNumber.Text - 1)

        Dim c As Integer = 0
        For Each row In ds.Tables("test").Rows
            topics(c) = row.item(2)
            allcardsquestions(c) = row.item(3)
            allcardsanswers(c) = row.item(4)
            c += 1
        Next

        If card_counter > CInt(ds.Tables("test").Rows.Count - 1) Then
            MsgBox("Test Length, exceeds the number of available cards. Card Count Set to: " & ds.Tables("test").Rows.Count - 1)
            card_counter = ds.Tables("test").Rows.Count - 1
        End If

        Dim randomnumbers(card_counter - 1)

        For i As Integer = 0 To card_counter
            Dim rand As Integer = CInt(Math.Ceiling(Rnd() * card_counter))
            For Each item In randomnumbers
                If rand = item Then

                End If

            Next
            final_test(i, 0) = allcardsquestions(rand).ToString
            final_test(i, 1) = allcardsanswers(rand).ToString
        Next

        Main.txtFinalTestQuestion.Text = final_test(0, 0)
        'Main.txtFinalTestAnswer.Text = final_test(0, 1)

    End Sub

    Dim questionnum As Integer = 0

    Sub final_test_show_answer()

        If Main.showanstest = True Then
            Main.txtFinalTestAnswer.Text = final_test(questionnum, 1)
            Main.showanstest = False
        ElseIf Main.showanstest = False Then
            Main.txtFinalTestAnswer.Text = ""
        End If

    End Sub

    Sub nextqtest(btnpushed)

        If btnpushed = "btnCorrectTest" Then

        Else

        End If

        questionnum += 1

        If final_test(questionnum, 0) = Nothing Then
            MsgBox("Test Finished")
            Main.btnCorrectTest.Enabled = False
            Main.btnIncorrectTest.Enabled = False
            Main.btnStartTest.Text = "Start Test"
            Main.txtFinalTestAnswer.Text = ""
            Main.txtFinalTestQuestion.Text = ""
            questionnum = 0
            Exit Sub
        End If

        Main.txtFinalTestQuestion.Text = final_test(questionnum, 0)
        Main.txtFinalTestAnswer.Text = ""

    End Sub




End Module
