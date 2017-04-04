Imports System.Data.OleDb
Module Edit_Cards

    Dim cn As OleDbConnection
    Dim cm As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim ds As DataSet = New DataSet
    Dim Subject As String

    Dim selectedcardid As String

    Sub populate_Edit_dropdowns()

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
            Main.cbSubjectEdit.Items.Add(subjects(i))
        Next

    End Sub

    Sub populate_topic_edit(subjectsel)

        ds.Clear()
        Main.cbtopicEdit.Items.Clear()

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
            Main.cbtopicEdit.Items.Add(Topics(i))
        Next


    End Sub

    Sub fill_cards_selection(topicsel)

        Dim Subjectedit As String = Main.cbSubjectEdit.Text
        Dim Topicedit As String = Main.cbtopicEdit.Text
        Dim ds2 As DataSet = New DataSet

        Dim Display_cards As String = "SELECT * FROM tblFlashCards WHERE Subject= '" & Subjectedit & "' AND Topic= '" & Topicedit & "' "
        da = New OleDbDataAdapter(Display_cards, conn)
        da.Fill(ds2, "CardDisplay")
        dt = ds2.Tables("CardDisplay")

        'MsgBox(ds2.Tables("CardDisplay").Rows.Count)

        Dim questions(ds2.Tables("CardDisplay").Rows.Count) As String

        For i As Integer = 0 To ds2.Tables("CardDisplay").Rows.Count - 1

            questions(i) = ds2.Tables("CardDisplay").Rows(i).Item(3).ToString

        Next

        With Main.dgvCards
            .AutoGenerateColumns = True
            .DataSource = ds2
            .DataMember = "CardDisplay"
        End With

        Main.dgvCards.Columns(0).Visible = False
        Main.dgvCards.Columns(1).Visible = False
        Main.dgvCards.Columns(2).Visible = False

        Main.dgvCards.AutoResizeRows()
        Main.dgvCards.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Sub populate_question(i)

        If IsDBNull(Main.dgvCards.Item(0, i).Value()) = True Then
            Exit Sub
        End If

        Main.txteditSubject.Text = Main.dgvCards.Item(1, i).Value()
        Main.txteditTopic.Text = Main.dgvCards.Item(2, i).Value()

        selectedcardid = Main.dgvCards.Item(0, i).Value()

        Dim question As String = Main.dgvCards.Item(3, i).Value()
        Dim answer As String = Main.dgvCards.Item(4, i).Value()

        Dim questionoutput As String = ""
        Dim answeroutput As String = ""
        Dim counter As Integer = 0

        For Each l As Char In question
            If l = "." Then
                If counter + 2 > Len(question) Or counter + 3 > Len(question) Then
                ElseIf question(counter + 1) <> " " Then
                    questionoutput = questionoutput + l
                ElseIf question(counter + 1) <> "." Then
                    questionoutput = questionoutput + l
                Else
                    If question(counter + 1) = vbCr And question(counter + 2) = vbCr Then
                    Else
                        questionoutput = questionoutput + l + vbNewLine + vbNewLine
                    End If
                End If
                
            Else
                questionoutput = questionoutput + l
            End If
            counter += 1
        Next

        counter = 0

        For Each l As Char In answer
            If l = "." Then
                If counter + 2 > Len(answer) Or counter + 3 > Len(answer) Then
                    Exit For
                Else
                    If Not answer(counter + 1) = " " Or Not answer(counter + 1) = "." Then
                        answeroutput = answeroutput + l
                    ElseIf answer(counter + 1) = vbCr Or answer(counter + 2) = vbCr Then
                    Else
                        answeroutput = answeroutput + l + vbNewLine + vbNewLine
                    End If
                End If
            Else
                    answeroutput = answeroutput + l
            End If
                counter += 1
        Next

        Main.txtEditQuestion.Text = questionoutput + "."
        Main.txtEditAnswer.Text = answeroutput + "."

    End Sub

    Sub Search_cards()

        Main.cbSubjectEdit.Text = ""
        Main.cbtopicEdit.Text = ""

        ds.Clear()

        Dim search_string = Main.txtSearch.Text

        'For Each i As Char In search_string
        '    If i = "'" Then
        '        Main.txtSearch.BackColor = Color.Salmon
        '        Exit Sub
        '    ElseIf Main.txtSearch.Text = "" Then
        '        Main.txtSearch.BackColor = Color.White
        '    Else
        '        Main.txtSearch.BackColor = Color.White
        '    End If
        'Next


        Dim Search_Cards As String = "SELECT * FROM tblFlashCards WHERE Question like '%" & search_string & "%' OR Answer like '%" & search_string & "%' "
        da = New OleDbDataAdapter(Search_Cards, conn)
        da.Fill(ds, "CardSearch")
        dt = ds.Tables("CardSearch")

        With Main.dgvCards
            .AutoGenerateColumns = True
            .DataSource = ds
            .DataMember = "CardSearch"
        End With

        Main.dgvCards.Columns(0).Visible = False
        Main.dgvCards.Columns(1).Visible = False
        Main.dgvCards.Columns(2).Visible = False

        Main.dgvCards.AutoResizeRows()
        Main.dgvCards.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Sub save_edit()

        If selectedcardid Is Nothing Then
            MsgBox("Subject And Topic Dont Exist Yet, Try hitting the add card Button Instead.")
            Exit Sub
        End If

        Dim Card_Update As String = "UPDATE tblFlashCards SET Question = @question, Answer = @answer WHERE CardID = @cardid"
        Dim Card_Update_Com As New OleDbCommand
        With Card_Update_Com
            .CommandText = Card_Update
            .Parameters.AddWithValue("@question", Main.txtEditQuestion.Text)
            .Parameters.AddWithValue("@answer", Main.txtEditAnswer.Text)
            .Parameters.AddWithValue("@cardid", selectedcardid)
            .Connection = conn
            .ExecuteNonQuery()
        End With

        MsgBox("Card: " & selectedcardid & " Successfully Saved")

        populate_dropdowns()
        populate_test_dropdowns()
        populate_Edit_dropdowns()

    End Sub

    Sub delete_card()

        Main.txtEditQuestion.Text = ""
        Main.txtEditAnswer.Text = ""

        If selectedcardid Is Nothing Then
            MsgBox("Card doesnt exist, cannot delete")
            Exit Sub
        End If

        Dim Card_Delete As String = "DELETE FROM tblFlashCards WHERE CardID = @cardid"
        Dim Card_Delete_Com As New OleDbCommand
        With Card_Delete_Com
            .CommandText = Card_Delete
            .Parameters.AddWithValue("@cardid", selectedcardid)
            .Connection = conn
            .ExecuteNonQuery()
        End With

        MsgBox("Card: " & selectedcardid & " Deleted")

        populate_dropdowns()
        populate_test_dropdowns()
        populate_Edit_dropdowns()

        Main.cbtopicEdit.Items.Clear()
        Main.cbtopicEdit.Text = ""
        Main.txtEditQuestion.Text = ""
        Main.txtEditAnswer.Text = ""

    End Sub

    Sub Add_Card()

        Dim Card_Delete As String = "INSERT INTO tblFlashCards (Subject, Topic, Question, Answer) VALUES (@subject, @topic, @question, @answer)"
        Dim Card_Delete_Com As New OleDbCommand
        With Card_Delete_Com
            .CommandText = Card_Delete
            .Parameters.AddWithValue("@subject", Main.cbSubjectEdit.Text)
            .Parameters.AddWithValue("@topic", Main.cbtopicEdit.Text)
            .Parameters.AddWithValue("@question", Main.txtEditQuestion.Text)
            .Parameters.AddWithValue("@answer", Main.txtEditAnswer.Text)
            .Connection = conn
            .ExecuteNonQuery()
        End With

        MsgBox("Card: " & selectedcardid & " Successfully Added")

        populate_dropdowns()
        populate_test_dropdowns()
        populate_Edit_dropdowns()

    End Sub

    Sub Delete_stack()

        Dim Stack_Delete As String = "DELETE FROM tblFlashCards WHERE Topic = @topic"
        Dim Stack_Delete_Com As New OleDbCommand
        With Stack_Delete_Com
            .CommandText = Stack_Delete
            .Parameters.AddWithValue("@topic", Main.cbtopicEdit.Text)
            .Connection = conn
            .ExecuteNonQuery()
        End With

        populate_dropdowns()
        populate_Edit_dropdowns()

        Main.cbtopicEdit.Items.Clear()
        Main.cbtopicEdit.Text = ""
        Main.txtEditQuestion.Text = ""
        Main.txtEditAnswer.Text = ""

        ds.Clear()

    End Sub

    Sub create_stack()

        Dim Create_stack As String = "INSERT INTO tblFlashCards (Subject,Topic) VALUES (@subject,@topic)"
        Dim Create_stack_Com As New OleDbCommand
        With Create_stack_Com
            .CommandText = Create_stack
            .Parameters.AddWithValue("@subject", Main.cbSubjectEdit.Text)
            .Parameters.AddWithValue("@topic", Main.cbtopicEdit.Text)
            .Connection = conn
            .ExecuteNonQuery()
        End With

        MsgBox("Stack : " & Main.cbtopicEdit.Text & ", Created.")

    End Sub

    Sub edit_stack()

        Dim stack_Update As String = "UPDATE tblFlashCards SET Topic = @topic WHERE Subject = @subject"
        Dim stack_Update_Com As New OleDbCommand
        With stack_Update_Com
            .CommandText = stack_Update
            .Parameters.AddWithValue("@topic", Main.cbtopicEdit.Text)
            .Parameters.AddWithValue("@subject", Main.cbSubjectEdit.Text)
            .Connection = conn
            .ExecuteNonQuery()
        End With

        MsgBox("Stack: " & Main.cbtopicEdit.Text & " Successfully Saved")

        populate_dropdowns()
        populate_Edit_dropdowns()

    End Sub

End Module
