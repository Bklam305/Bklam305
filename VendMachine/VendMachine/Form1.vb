Public Class Form1
    Dim v As New Bank
    Private Sub nickelButton_Click(sender As Object, e As EventArgs) Handles nickelButton.Click
        v.addNickel()
        Label2.Text = v.total.ToString("C2")
    End Sub
    Private Sub dimeButton_Click(sender As Object, e As EventArgs) Handles dimeButton.Click
        v.addDime()
        Label2.Text = v.total.ToString("C2")
    End Sub
    Private Sub quarterButton_Click(sender As Object, e As EventArgs) Handles quarterButton.Click
        v.addQuarter()
        Label2.Text = v.total.ToString("C2")
    End Sub
    Private Sub fifftyButton_Click(sender As Object, e As EventArgs) Handles fifftyButton.Click
        v.addfifty()
        Label2.Text = v.total.ToString("C2")
    End Sub
    Private Sub dollarbutton_Click(sender As Object, e As EventArgs) Handles dollarbutton.Click
        v.addDollar()
        Label2.Text = v.total.ToString("C2")
    End Sub

    Private Sub ressesButton_Click(sender As Object, e As EventArgs) Handles ressesButton.Click
        If v.Buy(1) Then
            ListBox1.Items.Add(v.contents)
        End If
    End Sub
End Class
