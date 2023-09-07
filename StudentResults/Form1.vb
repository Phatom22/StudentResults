Public Class Form1
    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        Dim Mark As Integer

        If IsNumeric(txtMarks.Text) = True Then
            Mark = txtMarks.Text
        Else
            MsgBox("INVALID! ENTER A NUMBER")
            Exit Sub
        End If

        If Mark < 0 Or Mark > 100 Then
            MsgBox("invalid mark")
        ElseIf Mark >= 50 Then
            MsgBox("PASS")
        ElseIf Mark < 50 Then
            MsgBox("FAIL")
        End If




    End Sub
End Class
