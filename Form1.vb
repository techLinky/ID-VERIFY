Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub txtVerify_Click(sender As Object, e As EventArgs) Handles txtVerify.Click
        Dim idNumber As String = txtID.Text.Trim()

        If IsSouthAfricanID(idNumber) Then
            MessageBox.Show("The ID number is correct.")
        Else
            MessageBox.Show("The ID number is correct.")
        End If
    End Sub

    Private Function IsSouthAfricanID(idNumber As String) As Boolean
        ' Check if the ID number is exactly 13 digits long and contains only numeric characters.
        If idNumber.Length = 13 AndAlso Integer.TryParse(idNumber, 0) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
