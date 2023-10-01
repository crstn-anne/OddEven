Imports System.Windows.Forms.VisualStyles

Public Class Form1
    Private Sub btn_count_Click(sender As Object, e As EventArgs) Handles btn_count.Click

        Dim intNumber As Integer
        Dim strNumber As String
        Dim strOddEven As String
        Dim temp As Integer

        Do Until IsNumeric(strNumber)
            strNumber = InputBox("Please Enter a Number: ")
        Loop

        intNumber = CInt(strNumber)

        Do Until strOddEven = "EVEN" Or strOddEven = "ODD"
            strOddEven = InputBox("Do you want to count in ODD or EVEN?")
            strOddEven = strOddEven.ToUpper()
        Loop

        If strOddEven = "EVEN" Then
            For temp = 2 To intNumber Step 2
                MessageBox.Show(temp)
            Next
        Else
            For temp = 1 To intNumber Step 2
                MessageBox.Show(temp)
            Next
        End If

    End Sub
End Class
