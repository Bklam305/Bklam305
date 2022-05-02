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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        v.restock()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        v.restock()
        ListBox1.Items.Clear()
        ListBox1.Items.Add(v.contents)
        Label2.Text = v.total.ToString("C2")
    End Sub
    Private Sub ressesButton_Click(sender As Object, e As EventArgs) Handles ressesButton.Click
        If v.Buy(1.99, 1) Then
            ListBox1.Items.Add(v.contents)
            Label2.Text = v.total.ToString("C2")
        End If
    End Sub
    Private Sub milkyButton_Click(sender As Object, e As EventArgs) Handles milkyButton.Click
        If v.Buy(1.99, 2) Then
            ListBox1.Items.Add(v.contents)
            Label2.Text = v.total.ToString("C2")
        End If
    End Sub
    Private Sub twixButton_Click(sender As Object, e As EventArgs) Handles twixButton.Click
        If v.Buy(1.99, 3) Then
            ListBox1.Items.Add(v.contents)
            Label2.Text = v.total.ToString("C2")
        End If
    End Sub
    Private Sub coolButton_Click(sender As Object, e As EventArgs) Handles coolButton.Click
        If v.Buy(0.99, 4) Then
            ListBox1.Items.Add(v.contents)
            Label2.Text = v.total.ToString("C2")
        End If
    End Sub
    Private Sub gardenButton_Click(sender As Object, e As EventArgs) Handles gardenButton.Click
        If v.Buy(1.5, 5) Then
            ListBox1.Items.Add(v.contents)
            Label2.Text = v.total.ToString("C2")
        End If
    End Sub
    Private Sub nachoButton_Click(sender As Object, e As EventArgs) Handles nachoButton.Click
        If v.Buy(0.99, 6) Then
            ListBox1.Items.Add(v.contents)
            Label2.Text = v.total.ToString("C2")
        End If
    End Sub
    Private Sub yellowButton_Click(sender As Object, e As EventArgs) Handles yellowButton.Click
        If v.Buy(0.99, 7) Then
            ListBox1.Items.Add(v.contents)
            Label2.Text = v.total.ToString("C2")
        End If
    End Sub
    Private Sub puffButton_Click(sender As Object, e As EventArgs) Handles puffButton.Click
        If v.Buy(1.25, 3) Then
            ListBox1.Items.Add(v.contents)
            Label2.Text = v.total.ToString("C2")
        End If
    End Sub
    Private Sub greenButton_Click(sender As Object, e As EventArgs) Handles greenButton.Click
        If v.Buy(0.99, 9) Then
            ListBox1.Items.Add(v.contents)
            Label2.Text = v.total.ToString("C2")
        End If
    End Sub
End Class
