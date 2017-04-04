<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.tc_main = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cbSubjectcreate = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTopic = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvExcel = New System.Windows.Forms.DataGridView()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnCorrect = New System.Windows.Forms.Button()
        Me.btnIncorrect = New System.Windows.Forms.Button()
        Me.btnShowAnswer = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCardsleft = New System.Windows.Forms.Label()
        Me.chkbShowAns = New System.Windows.Forms.CheckBox()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblIncorrect = New System.Windows.Forms.Label()
        Me.lblCorrect = New System.Windows.Forms.Label()
        Me.lblNumberofCards = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbTopic = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbSubject = New System.Windows.Forms.ComboBox()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txteditTopic = New System.Windows.Forms.TextBox()
        Me.txteditSubject = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnEditStack = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNewStack = New System.Windows.Forms.Button()
        Me.btnDeleteStack = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEditAnswer = New System.Windows.Forms.TextBox()
        Me.txtEditQuestion = New System.Windows.Forms.TextBox()
        Me.dgvCards = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbtopicEdit = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbSubjectEdit = New System.Windows.Forms.ComboBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnStartTest = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbCardNumber = New System.Windows.Forms.ComboBox()
        Me.clbTopics = New System.Windows.Forms.CheckedListBox()
        Me.btnCorrectTest = New System.Windows.Forms.Button()
        Me.btnIncorrectTest = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txtFinalTestAnswer = New System.Windows.Forms.TextBox()
        Me.txtFinalTestQuestion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbSubjectTesting = New System.Windows.Forms.ComboBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.tc_main.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvCards, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'tc_main
        '
        Me.tc_main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_main.Controls.Add(Me.TabPage1)
        Me.tc_main.Controls.Add(Me.TabPage2)
        Me.tc_main.Controls.Add(Me.TabPage3)
        Me.tc_main.Controls.Add(Me.TabPage4)
        Me.tc_main.Location = New System.Drawing.Point(1, 1)
        Me.tc_main.Name = "tc_main"
        Me.tc_main.SelectedIndex = 0
        Me.tc_main.Size = New System.Drawing.Size(765, 628)
        Me.tc_main.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cbSubjectcreate)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtTopic)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.dgvExcel)
        Me.TabPage1.Controls.Add(Me.btnImport)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(757, 602)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Import Data"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cbSubjectcreate
        '
        Me.cbSubjectcreate.FormattingEnabled = True
        Me.cbSubjectcreate.Location = New System.Drawing.Point(132, 7)
        Me.cbSubjectcreate.Name = "cbSubjectcreate"
        Me.cbSubjectcreate.Size = New System.Drawing.Size(207, 21)
        Me.cbSubjectcreate.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(345, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Topic"
        '
        'txtTopic
        '
        Me.txtTopic.Location = New System.Drawing.Point(385, 8)
        Me.txtTopic.Name = "txtTopic"
        Me.txtTopic.Size = New System.Drawing.Size(207, 20)
        Me.txtTopic.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Subject"
        '
        'dgvExcel
        '
        Me.dgvExcel.AllowUserToAddRows = False
        Me.dgvExcel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvExcel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.dgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExcel.Location = New System.Drawing.Point(6, 35)
        Me.dgvExcel.Name = "dgvExcel"
        Me.dgvExcel.Size = New System.Drawing.Size(746, 561)
        Me.dgvExcel.TabIndex = 7
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(6, 6)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(75, 23)
        Me.btnImport.TabIndex = 3
        Me.btnImport.Text = "Import Data"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightGray
        Me.TabPage2.Controls.Add(Me.btnCorrect)
        Me.TabPage2.Controls.Add(Me.btnIncorrect)
        Me.TabPage2.Controls.Add(Me.btnShowAnswer)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.txtAnswer)
        Me.TabPage2.Controls.Add(Me.txtQuestion)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(757, 602)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Practice"
        '
        'btnCorrect
        '
        Me.btnCorrect.BackColor = System.Drawing.Color.YellowGreen
        Me.btnCorrect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCorrect.Location = New System.Drawing.Point(104, 276)
        Me.btnCorrect.Name = "btnCorrect"
        Me.btnCorrect.Size = New System.Drawing.Size(93, 44)
        Me.btnCorrect.TabIndex = 20
        Me.btnCorrect.Text = "Correct"
        Me.btnCorrect.UseVisualStyleBackColor = False
        '
        'btnIncorrect
        '
        Me.btnIncorrect.BackColor = System.Drawing.Color.Tomato
        Me.btnIncorrect.Location = New System.Drawing.Point(201, 276)
        Me.btnIncorrect.Name = "btnIncorrect"
        Me.btnIncorrect.Size = New System.Drawing.Size(93, 44)
        Me.btnIncorrect.TabIndex = 19
        Me.btnIncorrect.Text = "Incorrect"
        Me.btnIncorrect.UseVisualStyleBackColor = False
        '
        'btnShowAnswer
        '
        Me.btnShowAnswer.BackColor = System.Drawing.Color.Transparent
        Me.btnShowAnswer.Location = New System.Drawing.Point(7, 276)
        Me.btnShowAnswer.Name = "btnShowAnswer"
        Me.btnShowAnswer.Size = New System.Drawing.Size(93, 44)
        Me.btnShowAnswer.TabIndex = 18
        Me.btnShowAnswer.Text = "Show Answer"
        Me.btnShowAnswer.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 324)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Answer"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Question"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblCardsleft)
        Me.GroupBox1.Controls.Add(Me.chkbShowAns)
        Me.GroupBox1.Controls.Add(Me.btnEnd)
        Me.GroupBox1.Controls.Add(Me.btnStart)
        Me.GroupBox1.Controls.Add(Me.lblIncorrect)
        Me.GroupBox1.Controls.Add(Me.lblCorrect)
        Me.GroupBox1.Controls.Add(Me.lblNumberofCards)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbTopic)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbSubject)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(745, 86)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Test Settings"
        '
        'lblCardsleft
        '
        Me.lblCardsleft.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCardsleft.AutoSize = True
        Me.lblCardsleft.Location = New System.Drawing.Point(595, 24)
        Me.lblCardsleft.Name = "lblCardsleft"
        Me.lblCardsleft.Size = New System.Drawing.Size(58, 13)
        Me.lblCardsleft.TabIndex = 19
        Me.lblCardsleft.Text = "Cards Left:"
        '
        'chkbShowAns
        '
        Me.chkbShowAns.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkbShowAns.AutoSize = True
        Me.chkbShowAns.Location = New System.Drawing.Point(598, 50)
        Me.chkbShowAns.Name = "chkbShowAns"
        Me.chkbShowAns.Size = New System.Drawing.Size(138, 17)
        Me.chkbShowAns.TabIndex = 18
        Me.chkbShowAns.Text = "Always Show Answers?"
        Me.chkbShowAns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkbShowAns.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.Tomato
        Me.btnEnd.Location = New System.Drawing.Point(376, 46)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(86, 23)
        Me.btnEnd.TabIndex = 17
        Me.btnEnd.Text = "End Test"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.YellowGreen
        Me.btnStart.Location = New System.Drawing.Point(284, 46)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(86, 23)
        Me.btnStart.TabIndex = 16
        Me.btnStart.Text = "Start!"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'lblIncorrect
        '
        Me.lblIncorrect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIncorrect.AutoSize = True
        Me.lblIncorrect.Location = New System.Drawing.Point(469, 51)
        Me.lblIncorrect.Name = "lblIncorrect"
        Me.lblIncorrect.Size = New System.Drawing.Size(95, 13)
        Me.lblIncorrect.TabIndex = 15
        Me.lblIncorrect.Text = "Incorrect Answers:"
        '
        'lblCorrect
        '
        Me.lblCorrect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCorrect.AutoSize = True
        Me.lblCorrect.Location = New System.Drawing.Point(469, 24)
        Me.lblCorrect.Name = "lblCorrect"
        Me.lblCorrect.Size = New System.Drawing.Size(87, 13)
        Me.lblCorrect.TabIndex = 14
        Me.lblCorrect.Text = "Correct Answers:"
        '
        'lblNumberofCards
        '
        Me.lblNumberofCards.AutoSize = True
        Me.lblNumberofCards.Location = New System.Drawing.Point(281, 24)
        Me.lblNumberofCards.Name = "lblNumberofCards"
        Me.lblNumberofCards.Size = New System.Drawing.Size(89, 13)
        Me.lblNumberofCards.TabIndex = 13
        Me.lblNumberofCards.Text = "Number of Cards:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Select Topic"
        '
        'cbTopic
        '
        Me.cbTopic.FormattingEnabled = True
        Me.cbTopic.Location = New System.Drawing.Point(97, 48)
        Me.cbTopic.Name = "cbTopic"
        Me.cbTopic.Size = New System.Drawing.Size(178, 21)
        Me.cbTopic.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Select Subject"
        '
        'cbSubject
        '
        Me.cbSubject.FormattingEnabled = True
        Me.cbSubject.Location = New System.Drawing.Point(97, 21)
        Me.cbSubject.Name = "cbSubject"
        Me.cbSubject.Size = New System.Drawing.Size(178, 21)
        Me.cbSubject.TabIndex = 9
        '
        'txtAnswer
        '
        Me.txtAnswer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(7, 347)
        Me.txtAnswer.Multiline = True
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAnswer.Size = New System.Drawing.Size(745, 245)
        Me.txtAnswer.TabIndex = 1
        '
        'txtQuestion
        '
        Me.txtQuestion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestion.Location = New System.Drawing.Point(7, 118)
        Me.txtQuestion.Multiline = True
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtQuestion.Size = New System.Drawing.Size(745, 152)
        Me.txtQuestion.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.LightGray
        Me.TabPage3.Controls.Add(Me.txtSearch)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.txteditTopic)
        Me.TabPage3.Controls.Add(Me.txteditSubject)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.btnEditStack)
        Me.TabPage3.Controls.Add(Me.Panel1)
        Me.TabPage3.Controls.Add(Me.btnNewStack)
        Me.TabPage3.Controls.Add(Me.btnDeleteStack)
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.btnSave)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.txtEditAnswer)
        Me.TabPage3.Controls.Add(Me.txtEditQuestion)
        Me.TabPage3.Controls.Add(Me.dgvCards)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.cbtopicEdit)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.cbSubjectEdit)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(757, 602)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Edit Cards"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(583, 44)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(165, 20)
        Me.txtSearch.TabIndex = 35
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(537, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Search:"
        '
        'txteditTopic
        '
        Me.txteditTopic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txteditTopic.Enabled = False
        Me.txteditTopic.Location = New System.Drawing.Point(508, 566)
        Me.txteditTopic.Multiline = True
        Me.txteditTopic.Name = "txteditTopic"
        Me.txteditTopic.Size = New System.Drawing.Size(160, 30)
        Me.txteditTopic.TabIndex = 32
        '
        'txteditSubject
        '
        Me.txteditSubject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txteditSubject.Enabled = False
        Me.txteditSubject.Location = New System.Drawing.Point(508, 530)
        Me.txteditSubject.Multiline = True
        Me.txteditSubject.Name = "txteditSubject"
        Me.txteditSubject.Size = New System.Drawing.Size(160, 30)
        Me.txteditSubject.TabIndex = 31
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Plum
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(390, 530)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 30)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Edit Stack Subject"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnEditStack
        '
        Me.btnEditStack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEditStack.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnEditStack.Enabled = False
        Me.btnEditStack.Location = New System.Drawing.Point(390, 566)
        Me.btnEditStack.Name = "btnEditStack"
        Me.btnEditStack.Size = New System.Drawing.Size(112, 30)
        Me.btnEditStack.TabIndex = 29
        Me.btnEditStack.Text = "Edit Stack Topic"
        Me.btnEditStack.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Location = New System.Drawing.Point(7, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(741, 3)
        Me.Panel1.TabIndex = 28
        '
        'btnNewStack
        '
        Me.btnNewStack.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnNewStack.Location = New System.Drawing.Point(631, 10)
        Me.btnNewStack.Name = "btnNewStack"
        Me.btnNewStack.Size = New System.Drawing.Size(87, 21)
        Me.btnNewStack.TabIndex = 27
        Me.btnNewStack.Text = "Create Stack"
        Me.btnNewStack.UseVisualStyleBackColor = False
        '
        'btnDeleteStack
        '
        Me.btnDeleteStack.BackColor = System.Drawing.Color.IndianRed
        Me.btnDeleteStack.Location = New System.Drawing.Point(540, 10)
        Me.btnDeleteStack.Name = "btnDeleteStack"
        Me.btnDeleteStack.Size = New System.Drawing.Size(85, 21)
        Me.btnDeleteStack.TabIndex = 26
        Me.btnDeleteStack.Text = "Delete Stack"
        Me.btnDeleteStack.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button2.Location = New System.Drawing.Point(309, 530)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 66)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Add Card"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.IndianRed
        Me.Button1.Location = New System.Drawing.Point(228, 530)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 66)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Delete Card"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.GreenYellow
        Me.btnSave.Location = New System.Drawing.Point(674, 530)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 66)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 20)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Cards"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(224, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Answer"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(224, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Question"
        '
        'txtEditAnswer
        '
        Me.txtEditAnswer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEditAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditAnswer.Location = New System.Drawing.Point(228, 258)
        Me.txtEditAnswer.Multiline = True
        Me.txtEditAnswer.Name = "txtEditAnswer"
        Me.txtEditAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEditAnswer.Size = New System.Drawing.Size(521, 266)
        Me.txtEditAnswer.TabIndex = 19
        '
        'txtEditQuestion
        '
        Me.txtEditQuestion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEditQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditQuestion.Location = New System.Drawing.Point(228, 67)
        Me.txtEditQuestion.Multiline = True
        Me.txtEditQuestion.Name = "txtEditQuestion"
        Me.txtEditQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEditQuestion.Size = New System.Drawing.Size(521, 165)
        Me.txtEditQuestion.TabIndex = 18
        '
        'dgvCards
        '
        Me.dgvCards.AllowUserToAddRows = False
        Me.dgvCards.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvCards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.dgvCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCards.Location = New System.Drawing.Point(6, 69)
        Me.dgvCards.Name = "dgvCards"
        Me.dgvCards.RowHeadersVisible = False
        Me.dgvCards.Size = New System.Drawing.Size(216, 527)
        Me.dgvCards.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(274, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Select Topic"
        '
        'cbtopicEdit
        '
        Me.cbtopicEdit.FormattingEnabled = True
        Me.cbtopicEdit.Location = New System.Drawing.Point(356, 10)
        Me.cbtopicEdit.Name = "cbtopicEdit"
        Me.cbtopicEdit.Size = New System.Drawing.Size(178, 21)
        Me.cbtopicEdit.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Select Subject"
        '
        'cbSubjectEdit
        '
        Me.cbSubjectEdit.FormattingEnabled = True
        Me.cbSubjectEdit.Location = New System.Drawing.Point(92, 10)
        Me.cbSubjectEdit.Name = "cbSubjectEdit"
        Me.cbSubjectEdit.Size = New System.Drawing.Size(178, 21)
        Me.cbSubjectEdit.TabIndex = 13
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Gray
        Me.TabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage4.Controls.Add(Me.Panel2)
        Me.TabPage4.Controls.Add(Me.TextBox9)
        Me.TabPage4.Controls.Add(Me.Label14)
        Me.TabPage4.Controls.Add(Me.Panel3)
        Me.TabPage4.Controls.Add(Me.Panel4)
        Me.TabPage4.Controls.Add(Me.TextBox8)
        Me.TabPage4.Controls.Add(Me.Label20)
        Me.TabPage4.Controls.Add(Me.TextBox7)
        Me.TabPage4.Controls.Add(Me.TextBox6)
        Me.TabPage4.Controls.Add(Me.TextBox5)
        Me.TabPage4.Controls.Add(Me.Label19)
        Me.TabPage4.Controls.Add(Me.Label18)
        Me.TabPage4.Controls.Add(Me.Label17)
        Me.TabPage4.Controls.Add(Me.btnStartTest)
        Me.TabPage4.Controls.Add(Me.Label16)
        Me.TabPage4.Controls.Add(Me.cbCardNumber)
        Me.TabPage4.Controls.Add(Me.clbTopics)
        Me.TabPage4.Controls.Add(Me.btnCorrectTest)
        Me.TabPage4.Controls.Add(Me.btnIncorrectTest)
        Me.TabPage4.Controls.Add(Me.Button6)
        Me.TabPage4.Controls.Add(Me.txtFinalTestAnswer)
        Me.TabPage4.Controls.Add(Me.txtFinalTestQuestion)
        Me.TabPage4.Controls.Add(Me.Label13)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.cbSubjectTesting)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(757, 602)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Test"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Location = New System.Drawing.Point(622, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(6, 130)
        Me.Panel2.TabIndex = 31
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(531, 13)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(85, 20)
        Me.TextBox9.TabIndex = 39
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label14.Location = New System.Drawing.Point(483, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Test ID:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Location = New System.Drawing.Point(474, 7)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(6, 130)
        Me.Panel3.TabIndex = 30
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.Location = New System.Drawing.Point(6, 133)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(745, 6)
        Me.Panel4.TabIndex = 30
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(568, 105)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(48, 20)
        Me.TextBox8.TabIndex = 37
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label20.Location = New System.Drawing.Point(483, 108)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 13)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "Total Cards:"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(568, 82)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(48, 20)
        Me.TextBox7.TabIndex = 35
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(568, 59)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(48, 20)
        Me.TextBox6.TabIndex = 34
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(522, 36)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(94, 20)
        Me.TextBox5.TabIndex = 33
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label19.Location = New System.Drawing.Point(483, 85)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 13)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Incorrect Cards:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label18.Location = New System.Drawing.Point(483, 62)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 13)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Correct Cards:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label17.Location = New System.Drawing.Point(483, 39)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 13)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "Time:"
        '
        'btnStartTest
        '
        Me.btnStartTest.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnStartTest.Location = New System.Drawing.Point(276, 33)
        Me.btnStartTest.Name = "btnStartTest"
        Me.btnStartTest.Size = New System.Drawing.Size(93, 44)
        Me.btnStartTest.TabIndex = 28
        Me.btnStartTest.Text = "Start / End Test"
        Me.btnStartTest.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label16.Location = New System.Drawing.Point(277, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Amount Of Cards"
        '
        'cbCardNumber
        '
        Me.cbCardNumber.FormattingEnabled = True
        Me.cbCardNumber.Items.AddRange(New Object() {"10", "20", "30", "40", "50", "60", "70", "80", "90", "100"})
        Me.cbCardNumber.Location = New System.Drawing.Point(366, 6)
        Me.cbCardNumber.Name = "cbCardNumber"
        Me.cbCardNumber.Size = New System.Drawing.Size(102, 21)
        Me.cbCardNumber.TabIndex = 26
        '
        'clbTopics
        '
        Me.clbTopics.FormattingEnabled = True
        Me.clbTopics.Location = New System.Drawing.Point(90, 33)
        Me.clbTopics.Name = "clbTopics"
        Me.clbTopics.Size = New System.Drawing.Size(178, 94)
        Me.clbTopics.TabIndex = 25
        '
        'btnCorrectTest
        '
        Me.btnCorrectTest.BackColor = System.Drawing.Color.YellowGreen
        Me.btnCorrectTest.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCorrectTest.Location = New System.Drawing.Point(375, 33)
        Me.btnCorrectTest.Name = "btnCorrectTest"
        Me.btnCorrectTest.Size = New System.Drawing.Size(93, 44)
        Me.btnCorrectTest.TabIndex = 24
        Me.btnCorrectTest.Text = "Correct"
        Me.btnCorrectTest.UseVisualStyleBackColor = False
        '
        'btnIncorrectTest
        '
        Me.btnIncorrectTest.BackColor = System.Drawing.Color.Tomato
        Me.btnIncorrectTest.Location = New System.Drawing.Point(375, 83)
        Me.btnIncorrectTest.Name = "btnIncorrectTest"
        Me.btnIncorrectTest.Size = New System.Drawing.Size(93, 44)
        Me.btnIncorrectTest.TabIndex = 23
        Me.btnIncorrectTest.Text = "Incorrect"
        Me.btnIncorrectTest.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightBlue
        Me.Button6.Location = New System.Drawing.Point(276, 83)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(93, 44)
        Me.Button6.TabIndex = 22
        Me.Button6.Text = "Show Answer"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'txtFinalTestAnswer
        '
        Me.txtFinalTestAnswer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFinalTestAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinalTestAnswer.Location = New System.Drawing.Point(6, 350)
        Me.txtFinalTestAnswer.Multiline = True
        Me.txtFinalTestAnswer.Name = "txtFinalTestAnswer"
        Me.txtFinalTestAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFinalTestAnswer.Size = New System.Drawing.Size(745, 245)
        Me.txtFinalTestAnswer.TabIndex = 19
        Me.txtFinalTestAnswer.Text = "Answer"
        '
        'txtFinalTestQuestion
        '
        Me.txtFinalTestQuestion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFinalTestQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinalTestQuestion.Location = New System.Drawing.Point(6, 145)
        Me.txtFinalTestQuestion.Multiline = True
        Me.txtFinalTestQuestion.Name = "txtFinalTestQuestion"
        Me.txtFinalTestQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFinalTestQuestion.Size = New System.Drawing.Size(745, 199)
        Me.txtFinalTestQuestion.TabIndex = 18
        Me.txtFinalTestQuestion.Text = "UNDER CONSTRUCTION"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label13.Location = New System.Drawing.Point(8, 37)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Select Topics"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label12.Location = New System.Drawing.Point(8, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Select Subject"
        '
        'cbSubjectTesting
        '
        Me.cbSubjectTesting.FormattingEnabled = True
        Me.cbSubjectTesting.Location = New System.Drawing.Point(90, 6)
        Me.cbSubjectTesting.Name = "cbSubjectTesting"
        Me.cbSubjectTesting.Size = New System.Drawing.Size(178, 21)
        Me.cbSubjectTesting.TabIndex = 11
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 628)
        Me.Controls.Add(Me.tc_main)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(784, 666)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " - Flash Card Tester Ver 0.1"
        Me.tc_main.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgvCards, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tc_main As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvExcel As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTopic As System.Windows.Forms.TextBox
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents txtQuestion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblIncorrect As System.Windows.Forms.Label
    Friend WithEvents lblCorrect As System.Windows.Forms.Label
    Friend WithEvents lblNumberofCards As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbTopic As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbSubject As System.Windows.Forms.ComboBox
    Friend WithEvents btnCorrect As System.Windows.Forms.Button
    Friend WithEvents btnIncorrect As System.Windows.Forms.Button
    Friend WithEvents btnShowAnswer As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents chkbShowAns As System.Windows.Forms.CheckBox
    Friend WithEvents lblCardsleft As System.Windows.Forms.Label
    Friend WithEvents cbSubjectcreate As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtEditAnswer As System.Windows.Forms.TextBox
    Friend WithEvents txtEditQuestion As System.Windows.Forms.TextBox
    Friend WithEvents dgvCards As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbtopicEdit As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbSubjectEdit As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnNewStack As System.Windows.Forms.Button
    Friend WithEvents btnDeleteStack As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnEditStack As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txteditTopic As System.Windows.Forms.TextBox
    Friend WithEvents txteditSubject As System.Windows.Forms.TextBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents txtFinalTestAnswer As System.Windows.Forms.TextBox
    Friend WithEvents txtFinalTestQuestion As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbSubjectTesting As System.Windows.Forms.ComboBox
    Friend WithEvents btnStartTest As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cbCardNumber As System.Windows.Forms.ComboBox
    Friend WithEvents clbTopics As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnCorrectTest As System.Windows.Forms.Button
    Friend WithEvents btnIncorrectTest As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label

End Class
