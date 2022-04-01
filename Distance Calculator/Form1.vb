Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the program'
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim strInputSpeed As String 'Input Speed'
        Dim strInputTime As String 'Input Time'
        Dim intTotal As Integer = 0 'Loop Counter'
        Dim intDistance As Integer = 0 'Distance'
        Dim decSpeed As Decimal = 0 'Speed'
        Dim decTime As Decimal = 0 'Time Driving'
        Dim decTotal As Decimal = 0 'Total Distance'

        'Input Speed'
        strInputSpeed = InputBox("Enter the speed of the vehicle in miles-per-hour")

        'Convert to decimal'
        If Decimal.TryParse(strInputSpeed, decSpeed) Then

            'Get Time'
            strInputTime = InputBox("Enter the time in hours that the vehicle is traveling")

            'Convert to Decimal"
            If Decimal.TryParse(strInputTime, decTime) Then

                'Calculate Time'
                decTotal = decTime * decSpeed

                'Display Speed'
                strInputSpeed = "Vehicle Speed: " & decSpeed.ToString() & " MPH"
                lstDistance.Items.Add(strInputSpeed)

                'Display Time Traveled'
                lstDistance.Items.Add("Time Traveled: " & decTime.ToString() & " Hours")

                'Adds Hours and Distance Columns"
                lstDistance.Items.Add("Hours      Distance Traveled")

                'Show Gap Seperation'
                lstDistance.Items.Add("_________________________")

                For intTotal = 1 To 7
                    'Calculate Distance'
                    intDistance = CInt(intTotal * decSpeed)
                    lstDistance.Items.Add(intTotal.ToString & "               " & intDistance.ToString)

                Next

                lstDistance.Items.Add("Total Distance: " & decTotal.ToString)
            Else
                MessageBox.Show("Error: Enter Numberic Value For Time.")
            End If
        Else
            MessageBox.Show("Error: Enter Numeric Value For Speed.")
        End If

    End Sub
End Class
