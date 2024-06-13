Public Class Form1
    Public RandomNumberOne As Integer
    Public RandomNumberTwo As Integer
    Public ExpectedResult As Integer
    Public RandomOperator As Integer

    Public MenangCount As Integer
    Public KalahCount As Integer

    Public Seconds As Integer = 0

    Public Operators As List(Of String) = New List(Of String) From {"+", "-", "*"}

    ' mulai game
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadGame()
    End Sub

    ' jawab dan cek jawaban
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ReceivedResult As Integer

        If Not String.IsNullOrEmpty(TextBox4.Text) Then
            Try
                ReceivedResult = Integer.Parse(TextBox4.Text)
            Catch ex As Exception
                MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK)
            End Try

            If (ReceivedResult = ExpectedResult) Then
                MessageBox.Show("Jawaban Benar")

                ' confirmation to play again
                Dim result As Integer = MessageBox.Show("Main lagi?", "Confirmation", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    Me.Close()
                Else
                    LoadGame()
                    MenangCount += 1
                    Label4.Text = MenangCount
                    TextBox4.Text = ""
                End If
            Else
                MessageBox.Show("Jawaban Salah")
                KalahCount += 1
                LoadGame()
                Label5.Text = KalahCount
                TextBox4.Text = ""
            End If
        End If
    End Sub

    Private Sub LoadGame()
        GetRandomNumber(1, 10)
        GetRandomOperator()

        TextBox1.Text = RandomNumberOne
        TextBox2.Text = Operators(RandomOperator)
        TextBox3.Text = RandomNumberTwo

        Select Case RandomOperator
            Case 0
                ExpectedResult = RandomNumberOne + RandomNumberTwo
            Case 1
                ExpectedResult = RandomNumberOne - RandomNumberTwo
            Case 2
                ExpectedResult = RandomNumberOne * RandomNumberTwo
        End Select
    End Sub

    Private Sub GetRandomNumber(LowerBound As Integer, UpperBound As Integer)
        RandomNumberOne = New Random().Next(LowerBound, UpperBound)
        RandomNumberTwo = New Random().Next(LowerBound, UpperBound)
    End Sub

    Private Sub GetRandomOperator()
        RandomOperator = New Random().Next(0, Operators.Count)
    End Sub

    Public Sub UpdateTimerElapsed()
        Dim hours As Integer = Seconds / 3600
        Dim minutes As Integer = (Seconds Mod 3600) / 60
        Dim secs As Integer = Seconds Mod 60

        TimerText.Text = "Time Elapsed: " & String.Format("{0}:{1}:{2}", hours.ToString("00"), minutes.ToString("00"), secs.ToString("00"))
    End Sub

    Public Sub ResetTimer()
        Seconds = 0
        UpdateTimerElapsed()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Seconds += 1
        UpdateTimerElapsed()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub
End Class
