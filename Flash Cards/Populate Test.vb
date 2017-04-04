Imports System.Data.OleDb

Module Populate_Test

    Dim cn As OleDbConnection
    Dim cm As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim ds As DataSet = New DataSet
    Dim Subject As String

    Sub populate_dropdowns()

        ds.Clear()

        Dim SubjectSearch As String = "SELECT * FROM tblFlashCards"

        Main.cbSubject.Items.Clear()
        Main.cbTopic.Items.Clear()
        Main.cbSubjectcreate.Items.Clear()

        da = New OleDbDataAdapter(SubjectSearch, conn)
        'Data adapter told to fill the da   taset
        da.Fill(ds, "subjects")
        'Defining the datatable
        dt = ds.Tables("subjects")


        Dim subjects(ds.Tables("subjects").Rows.Count) As String

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
            Main.cbSubject.Items.Add(subjects(i))
            Main.cbSubjectcreate.Items.Add(subjects(i))
        Next

    End Sub

    Sub populate_topic(subjectsel)

        ds.Clear()
        Main.cbTopic.Items.Clear()

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
            Main.cbTopic.Items.Add(Topics(i))
        Next


    End Sub

    Dim answers As List(Of String) = New List(Of String)()
    Dim questions As List(Of String) = New List(Of String)()

    Dim cards(1000, 3)

    Sub Fetch_test(topic)

        answers.Clear()
        questions.Clear()

        Dim fetchtest As String = "SELECT * FROM tblFlashCards WHERE Topic = '" & topic & "' "

        ds.Clear()

        da = New OleDbDataAdapter(fetchtest, conn)
        'Data adapter told to fill the da   taset
        da.Fill(ds, "test")
        'Defining the datatable
        dt = ds.Tables("test")

        Main.lblNumberofCards.Text = "Number of Cards: " & ds.Tables("test").Rows.Count

        For i As Integer = 0 To ds.Tables("test").Rows.Count - 1
            answers.Add(ds.Tables("test").Rows(i).Item(4).ToString)
            questions.Add(ds.Tables("test").Rows(i).Item(3).ToString)
            'answers(i) = ds.Tables("test").Rows(i).Item(3).ToString
            'questions(i) = ds.Tables("test").Rows(i).Item(4).ToString
            'Console.WriteLine(answers(i) & " | " & questions(i))
        Next

    End Sub

    Dim questionnum As Integer = 0
    Sub test()

        If questions.Count = 0 Or answers.Count = 0 Then
            MsgBox("No Topic Selected")
            Exit Sub
        End If

        Main.btnShowAnswer.Enabled = True
        Main.btnStart.Enabled = False
        Main.btnEnd.Enabled = True

        Main.cbSubject.Enabled = False
        Main.cbTopic.Enabled = False


        Dim questionoutput As String = ""
        Dim answeroutput As String = ""
        Dim questioncheck As String = questions(questionnum)
        Dim answercheck As String = answers(questionnum)
        Dim counter As Integer = 0

        For Each i As Char In questions(questionnum)
            If i = "." Then
                If counter + 2 > Len(questions(questionnum)) Or counter + 1 > Len(questions(questionnum)) Then
                Else
                    If questioncheck(counter + 1) = vbCr And questioncheck(counter + 2) = vbCr Then
                    Else
                        questionoutput = questionoutput + i + Environment.NewLine + Environment.NewLine
                    End If
                End If
            Else
                questionoutput = questionoutput + i
            End If
            counter += 1
        Next

        Main.txtQuestion.Text = questionoutput
        If Main.showansk = True Then
            For Each i As Char In answers(questionnum)
                If i = "." Then
                    If counter + 2 > Len(answers(questionnum)) Or counter + 1 > Len(answers(questionnum)) Then
                    Else
                        If answercheck(counter + 1) = vbCr And answercheck(counter + 2) = vbCr Then
                        Else
                            answeroutput = answeroutput + i + Environment.NewLine + Environment.NewLine
                        End If
                    End If

                Else
                    answeroutput = answeroutput + i
                End If
            Next
            Main.txtAnswer.Text = answeroutput
            counter += 1
        Else
            Main.txtAnswer.Text = ""
        End If

        Main.btnCorrect.Enabled = True
        Main.btnIncorrect.Enabled = True

        Main.lblCardsleft.Text = "Cards Left: " & questions.Count - questionnum

    End Sub

    Sub nextq(btnpushed)

        If btnpushed = "btnCorrect" Then
            correctans = correctans + 1
            Main.lblCorrect.Text = "Correct Answers: " & correctans
        ElseIf btnpushed = "btnIncorrect" Then
            incorrectans = incorrectans + 1
            Main.lblIncorrect.Text = "Incorrect Answers: " & incorrectans
        End If


        questionnum = questionnum + 1

        If questionnum > answers.Count - 1 Then
            Main.txtQuestion.Text = "TEST FINISHED! Correct Answers: " & correctans & " Incorrect Answers : " & incorrectans
            Main.txtAnswer.Text = "TEST FINISHED! Correct Answers: " & correctans & " Incorrect Answers : " & incorrectans
            Main.btnCorrect.Enabled = False
            Main.btnIncorrect.Enabled = False
            Main.lblCorrect.Text = "Correct Answers: "
            Main.lblIncorrect.Text = "Incorrect Answers: "
            Exit Sub
        End If

        Dim questionoutput As String = ""
        Dim answeroutput As String = ""
        Dim questioncheck As String = questions(questionnum)
        Dim answercheck As String = answers(questionnum)
        Dim counter As Integer = 0

        Main.lblCardsleft.Text = "Cards Left: " & questions.Count - questionnum
        Try
            For Each i As Char In questions(questionnum)
                If i = "." Then
                    If counter + 2 > Len(questions(questionnum)) Or counter + 1 > Len(questions(questionnum)) Then
                    Else
                        If questioncheck(counter + 1) = vbCr And questioncheck(counter + 2) = vbCr Then
                        Else
                            questionoutput = questionoutput + i + Environment.NewLine + Environment.NewLine
                        End If
                    End If
                Else
                    questionoutput = questionoutput + i
                End If
                counter += 1
            Next
            Main.txtQuestion.Text = questionoutput

        Catch ex As Exception

        End Try

        counter = 0

        If Main.showansk = True Then
            For Each i As Char In answers(questionnum)
                If i = "." Then
                    If counter + 2 > Len(answers(questionnum)) Or counter + 1 > Len(answers(questionnum)) Then
                    Else
                        If answercheck(counter + 1) = vbCr And answercheck(counter + 2) = vbCr Then
                        Else
                            answeroutput = answeroutput + i + Environment.NewLine + Environment.NewLine
                        End If
                    End If

                Else
                    answeroutput = answeroutput + i
                End If
            Next
            Main.txtAnswer.Text = answeroutput
            counter += 1
        Else
            Main.txtAnswer.Text = ""
        End If

    End Sub

    Sub endtest()

        questionnum = 0
        answers.Clear()
        questions.Clear()
        correctans = 0
        incorrectans = 0


        Main.txtQuestion.Text = "TEST Ended"
        Main.txtAnswer.Text = "TEST Ended"

        Main.btnCorrect.Enabled = False
        Main.btnIncorrect.Enabled = False
        Main.lblCorrect.Text = "Correct Answers: "
        Main.lblIncorrect.Text = "Incorrect Answers: "

        Main.btnStart.Enabled = True
        Main.btnEnd.Enabled = False
        Main.cbSubject.Enabled = True
        Main.cbTopic.Enabled = True
        Main.btnShowAnswer.Enabled = False

    End Sub

    Dim correctans As Integer = 0
    Dim incorrectans As Integer = 0

    Sub showans()

        Dim questioncheck As String = questions(questionnum)
        Dim answercheck As String = answers(questionnum)
        Dim counter As Integer = 0

        Dim answeroutput As String = ""

        If Main.txtAnswer.Text = "" Then
            For Each i As Char In answers(questionnum)
                If i = "." Then
                    If counter + 2 > Len(answers(questionnum)) Or counter + 1 > Len(answers(questionnum)) Then
                    Else
                        If answercheck(counter + 1) = vbCr And answercheck(counter + 2) = vbCr Then
                        Else
                            answeroutput = answeroutput + i + Environment.NewLine + Environment.NewLine
                        End If
                    End If

                Else
                    answeroutput = answeroutput + i
                End If
            Next
            Main.txtAnswer.Text = answeroutput
            counter += 1
        Else
            Main.txtAnswer.Text = ""
        End If

    End Sub

End Module
