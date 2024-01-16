Imports System.IO
Public Class QuestionWindow
    Dim currentFileReader As StreamReader
    Dim QandA(59) As String
    Dim QuestionAndAnswersNewOrder(59) As String
    Dim m As Integer 'Used to loop through the questions when the next button is clicked
    Dim T As Integer 'Used to loop through the answers to see if the user has got the correct answer
    Dim Score As Integer
    Dim Answers(9) As String
    Private Sub QuestionWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Read()
        'PictureBox_QPicture.Image = Image.FromFile(CurDir() & "\test.png")
        SetQonForm()
        Button_PreviousQ.Hide()
        Answers(9) = GetAnswers()
        AcceptButton = Button_NextQ
    End Sub
    ''' <summary>
    ''' Reads from a file and stores the data within an array
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Read()
        '****The following code is credited to the microsoft website.
        Dim x As Integer = 0
        Dim CurrentRow As String()
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(CurDir() & "\Questions.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            While MyReader.EndOfData = False
                CurrentRow = MyReader.ReadFields()
                Dim currentField As String
                For Each currentField In CurrentRow
                    QandA(x) = currentField 'Stores the current field in the q and a array
                    x += 1
                Next
            End While
        End Using
        '****This is the end of the code
        SetQandA()
    End Sub
    
    ''' <summary>
    ''' Randomly sets the questions and answers
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetQandA()
        Dim QuestionNumber(9) As Integer 'The data stored in the array will be the position in the parameter for the question number. Eg. Q1 - 1 Q2 - 6 Q3 - 12
        Dim y As Integer = 0
        Dim z As Integer = 0
        SetQnumber(QuestionNumber)
        newQorder(QuestionNumber) ' Randomly swaps the question numbers around
            Do While z < 59
            For x = 0 To 5
                QuestionAndAnswersNewOrder(z) = QandA(QuestionNumber(y) + x) 'Sets the new question order using the randomly generated question number order.
                z += 1
            Next
            If y < 9 Then
                y = y + 1
            End If
        Loop
    End Sub
    ''' <summary>
    ''' Sets the question number in the array
    ''' </summary>
    ''' <param name="Array">The question number array</param>
    ''' <remarks></remarks>
    Private Sub SetQnumber(ByRef Array() As Integer)
        For x = 1 To 9
            Array(x) = Array(x - 1) + 6
        Next
    End Sub
    ''' <summary>
    ''' Gets the answers for the questions and stores them in order in an array
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetAnswers() As String
        Dim b As Integer = 5
        For x = 0 To 9
            Answers(x) = QuestionAndAnswersNewOrder(b)
            b += 6
        Next
        Return Answers(9)
    End Function
    ''' <summary>
    ''' Calculates if the user has gotten the answer right
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CalculateQuestionsAndAnswers()
        Dim UserInputAnswer As String
        UserInputAnswer = ReturnMarkedRadioBTNAnswer()
        If Answers(T) = UserInputAnswer Then
            Score += 1
        End If
        T += 1
    End Sub
    ''' <summary>
    ''' Gets the text from the radio button the user has selected
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function ReturnMarkedRadioBTNAnswer()
        Dim TxtAnswer As String = ""
        If RadioButton_Option1.Checked = True Then
            TxtAnswer = RadioButton_Option1.Text
        ElseIf RadioButton_Option2.Checked = True Then
            TxtAnswer = RadioButton_Option2.Text
        ElseIf RadioButton_Option3.Checked = True Then
            TxtAnswer = RadioButton_Option3.Text
        ElseIf RadioButton_Option4.Checked = True Then
            TxtAnswer = RadioButton_Option4.Text
        End If
        If m < 59 Then
            ClearRadio()
        End If
        Return TxtAnswer
    End Function
    Private Sub Button_NextQ_Click(sender As Object, e As EventArgs) Handles Button_NextQ.Click
        Button_PreviousQ.Show()
        If Button_NextQ.Text = "Finish" Then
            CalculateQuestionsAndAnswers()
            CorrectAnswers()
        End If
        If m = 0 Then
            Button_PreviousQ.Hide()
        End If
        If RadioButton_Option1.Checked = False And RadioButton_Option2.Checked = False And RadioButton_Option3.Checked = False And RadioButton_Option4.Checked = False Then
            MsgBox("Please select an answer")
        Else
            ProgressBar_QNumber.Increment(1)
            If m < 59 Then
                CalculateQuestionsAndAnswers()
                SetQonForm()
            End If
        End If
    End Sub

    Private Sub Button_PreviousQ_Click(sender As Object, e As EventArgs) Handles Button_PreviousQ.Click
        If m > 6 Then 'If m is great than 6 then the following code will be run. This is the prevent the program from crashing at the start if the user selects the back button on the first question
            ProgressBar_QNumber.Increment(-1)
            If m > 59 Then
                Button_NextQ.Text = "Next Question"
            End If
            PreviousQOnForm()
            T -= 1
            If Score > 0 Then
                Score -= 1
            End If
            If m = 6 Then
                Button_PreviousQ.Hide()
            End If
            ClearRadio()
        End If
    End Sub
    ''' <summary>
    ''' Sets the questions on the form
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetQonForm()
        Label_Questions.Text = QuestionAndAnswersNewOrder(m)
        m += 1
        RadioButton_Option1.Text = QuestionAndAnswersNewOrder(m)
        m += 1
        RadioButton_Option2.Text = QuestionAndAnswersNewOrder(m)
        m += 1
        RadioButton_Option3.Text = QuestionAndAnswersNewOrder(m)
        m += 1
        RadioButton_Option4.Text = QuestionAndAnswersNewOrder(m)
        m += 2
        If m > 59 Then
            Button_NextQ.Text = "Finish"
        End If
    End Sub
    ''' <summary>
    ''' Sets the previous question on the form
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PreviousQOnForm()
        m = m - 12 'Takes 12 off m to go back to the start of the array for the previous question
        Label_Questions.Text = QuestionAndAnswersNewOrder(m)
        m += 1
        RadioButton_Option1.Text = QuestionAndAnswersNewOrder(m)
        m += 1
        RadioButton_Option2.Text = QuestionAndAnswersNewOrder(m)
        m += 1
        RadioButton_Option3.Text = QuestionAndAnswersNewOrder(m)
        m += 1
        RadioButton_Option4.Text = QuestionAndAnswersNewOrder(m)
        m += 2 'Adds two to m so that the actual answer is skipped over and not added to the form in the next question
    End Sub
    ''' <summary>
    ''' Clears the options on the radio button
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearRadio()
        RadioButton_Option1.Checked = False
        RadioButton_Option2.Checked = False
        RadioButton_Option3.Checked = False
        RadioButton_Option4.Checked = False
    End Sub
    ''' <summary>
    ''' Tells the user their score and then closes the form
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CorrectAnswers()
        MsgBox("Your score is: " & Score)
        Me.Close()
    End Sub
End Class