Public Class mainform
    Public mystopwatch As stopwatch

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        Timer1.Dispose()
        Try
            Timer1.Start()
            lblShowElapsed.Text = String.Empty
            lblLapTime1.Text = String.Empty

            btnStop.Enabled = True
            Dim mytime As stopwatch = New stopwatch

            lblShowElapsed.Text = mytime.starttime.Hour.ToString() & ":" & mytime.starttime.Minute.ToString() & ":" & mytime.starttime.Second.ToString() & ":" & mytime.starttime.Millisecond.ToString()
            ' lblLapTime1.Text = mytime.TimeDifferenceCalc.Hour.ToString() & ":" & mytime.TimeDifferenceCalc.Minute.ToString() & ":" & mytime.TimeDifferenceCalc.Second.ToString()
            lblLapTime1.Text = mytime.getcurrentelapsedtimestring.ToString
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        Timer1.Stop()
        Try
            lblShowElapsed.Text = String.Empty
            lblLapTime1.Text = String.Empty


            Dim mytime As stopwatch = New stopwatch

            lblShowElapsed.Text = mytime.stoptime.Hour.ToString() & ":" & mytime.stoptime.Minute.ToString() & ":" & mytime.stoptime.Second.ToString() & ":" & mytime.stoptime.Millisecond.ToString()
            'lblLapTime1.Text = mytime.TimeDifferenceCalc.Hour.ToString() & ":" & mytime.TimeDifferenceCalc.Minute.ToString() & ":" & mytime.TimeDifferenceCalc.Second.ToString()
            lblLapTime1.Text = mytime.getcurrentelapsedtimestring.ToString
            Timer1.Stop()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub mainform_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load, Timer1.Tick






    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ' TimeSpan.Zero
        Dim mytime As stopwatch = New stopwatch


        lblShowElapsed.Text = mytime.stoptime.Hour.ToString() & ":" & mytime.stoptime.Minute.ToString() & ":" & mytime.stoptime.Second.ToString() & ":" & mytime.starttime.Millisecond.ToString()
        lblLapTime1.Text = mytime.getcurrentelapsedtimestring.ToString

    End Sub
End Class
