<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Timer1 = New Timer(components)
        TimerText = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 15)
        Label1.TabIndex = 0
        Label1.Text = "Game Tebak Angka"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(30, 77)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(173, 23)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(30, 106)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(30, 135)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(173, 23)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(30, 192)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(173, 23)
        TextBox4.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(30, 221)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 5
        Button1.Text = "Mulai"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(128, 221)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 6
        Button2.Text = "Jawab"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(282, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 7
        Label2.Text = "Menang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(347, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 8
        Label3.Text = "Kalah"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(298, 51)
        Label4.Name = "Label4"
        Label4.Size = New Size(13, 15)
        Label4.TabIndex = 9
        Label4.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(358, 51)
        Label5.Name = "Label5"
        Label5.Size = New Size(13, 15)
        Label5.TabIndex = 10
        Label5.Text = "0"
        ' 
        ' Timer1
        ' 
        ' 
        ' TimerText
        ' 
        TimerText.AutoSize = True
        TimerText.Location = New Point(452, 25)
        TimerText.Name = "TimerText"
        TimerText.Size = New Size(13, 15)
        TimerText.TabIndex = 11
        TimerText.Text = "0"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TimerText)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TimerText As Label

End Class
