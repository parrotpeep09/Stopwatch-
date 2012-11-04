Public Class mainform
    Public mystopwatch As stopwatch

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click, Timer1.Tick


    End Sub
    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
    
   
        Timer1.Stop()

    End Sub

    Private Sub mainform_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim mystopwatch As New stopwatch
        lblShowElapsed.Text = mystopwatch.getcurrentelapsedtimestring()

    End Sub
End Class
