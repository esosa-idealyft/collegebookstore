<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CollegeBookstore
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
        Label1 = New Label()
        ListBox1 = New ListBox()
        Label2 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        Button3 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(48, 6)
        Label1.Name = "Label1"
        Label1.RightToLeft = RightToLeft.Yes
        Label1.Size = New Size(259, 25)
        Label1.TabIndex = 0
        Label1.Text = "Please Select An Access Code"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ImeMode = ImeMode.NoControl
        ListBox1.ItemHeight = 25
        ListBox1.Items.AddRange(New Object() {"Visio", "QuickBooks", "Project", "PowerBi", "Speed Type"})
        ListBox1.Location = New Point(58, 34)
        ListBox1.Name = "ListBox1"
        ListBox1.ScrollAlwaysVisible = True
        ListBox1.Size = New Size(570, 129)
        ListBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(46, 180)
        Label2.Name = "Label2"
        Label2.RightToLeft = RightToLeft.Yes
        Label2.Size = New Size(85, 25)
        Label2.TabIndex = 2
        Label2.Text = "?Student"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(66, 474)
        Button2.Name = "Button2"
        Button2.Size = New Size(271, 57)
        Button2.TabIndex = 3
        Button2.Text = "Clear Form"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(241, 334)
        Button1.Name = "Button1"
        Button1.Size = New Size(271, 57)
        Button1.TabIndex = 4
        Button1.Text = "Final Total"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(379, 474)
        Button3.Name = "Button3"
        Button3.Size = New Size(271, 57)
        Button3.TabIndex = 3
        Button3.Text = "Daily Total"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(47, 290)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(335, 33)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(423, 290)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(134, 33)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(206, 411)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(335, 33)
        TextBox3.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(47, 262)
        Label3.Name = "Label3"
        Label3.RightToLeft = RightToLeft.Yes
        Label3.Size = New Size(247, 25)
        Label3.TabIndex = 6
        Label3.Text = "Buyer's Credit Card Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(423, 262)
        Label4.Name = "Label4"
        Label4.RightToLeft = RightToLeft.Yes
        Label4.Size = New Size(307, 25)
        Label4.TabIndex = 6
        Label4.Text = "Buyer's Credit Card Expiration Date"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(58, 213)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(64, 29)
        RadioButton1.TabIndex = 7
        RadioButton1.TabStop = True
        RadioButton1.Text = "Yes"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(168, 213)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(62, 29)
        RadioButton2.TabIndex = 7
        RadioButton2.TabStop = True
        RadioButton2.Text = "No"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' CollegeBookstore
        ' 
        AutoScaleDimensions = New SizeF(11.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 561)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox3)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Controls.Add(ListBox1)
        Controls.Add(Label1)
        ImeMode = ImeMode.On
        Name = "CollegeBookstore"
        Text = "College Bookstore"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
