'Joshua Pickenpaugh
'October 24th, 2016
'Zip Codes (non-OOP)

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Adds names to the list box on load:
        lstCities.Items.Add("Park Ridge")
        lstCities.Items.Add("Barrington")
        lstCities.Items.Add("Glen Ellyn")
        lstCities.Items.Add("Algonquin")
        lstCities.Items.Add("Crystal Lake")

    End Sub

    Private Sub lstCities_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstCities.SelectedValueChanged

        Dim strCity As String

        strCity = lstCities.Text

        Select Case strCity
            Case "Park Ridge"
                lblZipCodes.Text = "60068"
            Case "Barrington"
                lblZipCodes.Text = "60010, 60011"
            Case "Glen Ellyn"
                lblZipCodes.Text = "60137, 60138"
            Case "Algonquin"
                lblZipCodes.Text = "60102"
            Case "Crystal Lake"
                lblZipCodes.Text = "60012"
            Case Else
                lblZipCodes.Text = "(n/a)"

        End Select

    End Sub
End Class
