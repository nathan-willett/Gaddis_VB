Public Class Form1
    Private Sub btnDisplayDirections_Click(sender As Object, e As EventArgs) Handles btnDisplayDirections.Click
        'display directions
        lblDirections.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close form
        Me.Close()
    End Sub
End Class
