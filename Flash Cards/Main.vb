Public Class Main

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connect()
        btnImport.Enabled = False
        btnCorrect.Enabled = False
        btnIncorrect.Enabled = False
        btnShowAnswer.Enabled = False
        btnEnd.Enabled = False

        btnStartTest.Text = "Start Test"
        'tc_main.TabPages(3).Enabled = False
        txtAnswer.ReadOnly = True
        txtQuestion.ReadOnly = True

        populate_dropdowns()
        populate_test_dropdowns()
        populate_Edit_dropdowns()

    End Sub

    Private Sub txtTopic_TextChanged(sender As Object, e As EventArgs) Handles txtTopic.TextChanged

        check_content()

    End Sub

    Private Sub txtSubject_TextChanged(sender As Object, e As EventArgs)

        check_content()

    End Sub

    Private Sub cbSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSubject.SelectionChangeCommitted
        Dim subjectsel As String = ""
        subjectsel = cbSubject.SelectedItem
        populate_topic(subjectsel)

    End Sub

    Private Sub cbTopic_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbTopic.SelectionChangeCommitted

        Dim topic As String = ""
        topic = cbTopic.SelectedItem
        Fetch_test(topic)

    End Sub

    Private Sub cbSubjectEdit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSubjectEdit.SelectionChangeCommitted

        Dim subjectsel As String = ""
        subjectsel = cbSubjectEdit.SelectedItem
        populate_topic_edit(subjectsel)

    End Sub

    Private Sub cbTopicEdit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtopicEdit.TextChanged

        Dim topicsel As String = cbtopicEdit.Text

        fill_cards_selection(topicsel)

    End Sub

    Private Sub cbSubjectTesting_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSubjectTesting.SelectionChangeCommitted

        Dim subjectsel As String = ""
        subjectsel = cbSubjectTesting.SelectedItem
        populate_topic_test(subjectsel)

    End Sub

    Private Sub dgvcards_selectedindexchanged(sender As Object, e As EventArgs) Handles dgvCards.Click

        'this defined i as an integer
        Dim i As Integer
        'this sets i to be the current row number
        i = dgvCards.CurrentRow.Index

        populate_question(i)

        'this will populate stock name datagridview with any data that matches that stock style criteria


    End Sub

    Private Sub dgvcard_keypress(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvCards.KeyUp

        Dim i As Integer
        'this sets i to be the current row number
        i = dgvCards.CurrentRow.Index

        Select Case e.KeyCode
            Case Keys.Down
                populate_question(i)
            Case Keys.Up
                populate_question(i)
        End Select
    End Sub

    Public showansk As Boolean = False
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkbShowAns.CheckedChanged

        If chkbShowAns.Checked = False Then
            showansk = False
        ElseIf chkbShowAns.Checked = True Then
            showansk = True
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        save_edit()

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click

        delete_card()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Add_Card()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnStart.Click

        test()

    End Sub

    Private Sub btnCorrect_Click(sender As Object, e As EventArgs) Handles btnCorrect.Click, btnIncorrect.Click

        Dim btnpushed As String = Me.ActiveControl.Name.ToString

        nextq(btnpushed)

    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click

        endtest()

    End Sub

    Private Sub btnShowAnswer_Click(sender As Object, e As EventArgs) Handles btnShowAnswer.Click

        showans()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnImport.Click

        Import_file()

    End Sub

    Private Sub btnDeleteStack_Click(sender As Object, e As EventArgs) Handles btnDeleteStack.Click

        If cbSubjectEdit.Text = Nothing Or cbtopicEdit.Text = Nothing Then
            MsgBox("No stack selected, please select a stack before pressing delete")
            Exit Sub
        End If

        Dim result As Integer = MessageBox.Show("Are you sure you want to Delete the Entire Stack: " & cbtopicEdit.Text, "Warning", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then
            Delete_stack()
        End If



    End Sub

    Private Sub btnNewStack_Click(sender As Object, e As EventArgs) Handles btnNewStack.Click

        If cbtopicEdit.Text = "" Then
            MsgBox("Enter a name in the Topic Box")
            Exit Sub
        ElseIf txtEditQuestion.Text = "" Or txtEditAnswer.Text = "" Then
            MsgBox("Enter the First Question and answer for the stack")
            Exit Sub
        Else
            For Each item In cbtopicEdit.Items
                If cbtopicEdit.Text = item Then
                    MsgBox("Topic Already Exists!")
                    Exit Sub
                End If
            Next

            create_stack()

        End If

    End Sub

    Private Sub btnEditStack_Click(sender As Object, e As EventArgs) Handles btnEditStack.Click



        If cbtopicEdit.Text = "" Then
            MsgBox("Enter a name in the Topic Box")
            Exit Sub
        ElseIf txtEditQuestion.Text = "" Or txtEditAnswer.Text = "" Then
            MsgBox("Enter the First Question and answer for the stack")
            Exit Sub
        Else
            For Each item In cbtopicEdit.Items
                If cbtopicEdit.Text = item Then
                    MsgBox("Topic Already Exists!")
                    Exit Sub
                End If
            Next

            edit_stack()

        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnStartTest.Click

        start_test()

    End Sub

    Public showanstest As Boolean = False
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If showanstest = False Then
            showanstest = True
        Else
            showanstest = False
        End If

        final_test_show_answer()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnCorrectTest.Click

        Dim btnpushed As String = Me.ActiveControl.Name.ToString

        nextqtest(btnpushed)


    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        Search_cards()


    End Sub

End Class
