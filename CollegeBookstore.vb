Imports System.ComponentModel
Imports System.IO

Public Class CollegeBookstore

    Private Sub CollegeBookstore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ListBox1.Items.Add(“Visual Basic 6”)
    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        Me.ListBox1.ClearSelected()
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        'Me.TextBox3.Text = vbEmpty
        Me.RadioButton1.Checked = False
        Me.RadioButton2.Checked = False


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Step 1 - Get Price

        Dim selectedvalue As String
        Dim PriceHere As Double
        Dim PriceDisct, DsctAmt As Double
        Dim ApplyDisct As String
        Dim FinalDisct As String
        Dim FinalPrice As String


        If Me.RadioButton1.Checked Then

            ApplyDisct = "Yes"

        Else : End If

        selectedvalue = Me.ListBox1.SelectedItem


        If selectedvalue = "Visio" Then

            PriceHere = 14.99
            DsctAmt = 0.06
            PriceDisct = PriceHere * DsctAmt


        ElseIf selectedvalue = "QuickBooks" Then

            PriceHere = 24.99
            DsctAmt = 0.08
            PriceDisct = PriceHere * DsctAmt


        ElseIf selectedvalue = "Project" Then

            PriceHere = 17.99
            DsctAmt = 0.08
            PriceDisct = PriceHere * DsctAmt


        ElseIf selectedvalue = "PowerBi" Then

            PriceHere = 9.99
            DsctAmt = 0.05
            PriceDisct = PriceHere * DsctAmt

        ElseIf selectedvalue = "SpeedType" Then

            PriceHere = 29.99
            DsctAmt = 0.02
            PriceDisct = PriceHere * DsctAmt


        End If

        If ApplyDisct = "Yes" Then

            PriceHere = PriceHere - PriceDisct

        Else

            PriceDisct = 0.00

        End If

        FinalPrice = Format(PriceHere, "#.##")
        'FinalDisct = Format(PriceDisct, "#.##")



        'Display Final Price

        Me.TextBox3.Text = FinalPrice

        'STEP 2 - Create Line Item for Text File

        Dim newdatastring As String
        newdatastring = Me.TextBox1.Text & "," & selectedvalue & "," & FinalDisct & "," & FinalPrice
        'newdatastring = "CC:" & Me.TextBox1.Text & ",App:" & selectedvalue & ",Dsct:" & FinalDisct & ",Amt:" & Me.TextBox3.Text
        Dim oldata As String

        'Step 3 - Add to Text File

        'If Text File does not exist, create one...

        Dim path As String
        Dim username As String
        username = Environment.UserName
        Dim filedate As String = DateTime.Now.ToString("MM.dd.yy")
        path = "C:\Users\" & username & "\Documents\" & "CollegeSales_" & filedate & ".txt"

        'Add Data to Text File

        If (File.Exists(path)) Then

            'oldata = My.Computer.FileSystem.ReadAllText(path)
            'My.Computer.FileSystem.WriteAllText(path, oldata & vbCrLf & newdatastring, True)
            File.AppendAllText(path, Environment.NewLine + newdatastring)
        Else

            My.Computer.FileSystem.WriteAllText(path, newdatastring, True)

        End If

        My.Computer.Clipboard.SetText(path)

        MsgBox("File has been saved to & copied to your clipboard: " & path)

        'Open File

        'My.Computer.FileSystem.OpenTextFileReader(path)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim path As String
        Dim filedate As String = DateTime.Now.ToString("MM.dd.yy")
        Dim username As String
        username = Environment.UserName
        path = "C:\Users\" & username & "\Documents\" & "CollegeSales_" & filedate & ".txt"

        'Sum everything after Amt:
        Dim filecontents As String() = IO.File.ReadAllLines(path)
        Dim Sum As Double = 0 ' This holds the sum
        For Each line In filecontents
            ' Using comma ',' as a separator (you may use other characters)
            Dim tokens() As String = line.Split(New Char() {","c})
            Dim value As Double = 0 ' This holds the current value
            ' Let's suppose you need to add up a third column of integer values:
            If tokens.Length >= 3 Then
                ' Parsing the third column and if successful add it to the sum:
                If Double.TryParse(tokens(3), value) Then
                    Sum += value
                End If
            End If
        Next


        MsgBox("Total Daily Sales: $" & Sum)


    End Sub
End Class
