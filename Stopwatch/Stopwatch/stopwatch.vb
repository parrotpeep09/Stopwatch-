Public Class stopwatch
    Private _start As Date
    Private _stop As Date
    Private _lap As Date
    Private _display As Date
    Public Sub New()

    End Sub
    Public Sub New(StartTime As Date, StopTime As Date, LapTime As Date, Display As Date)
        _start = StartTime
        _stop = StopTime
        _lap = LapTime
        _display = Display
    End Sub

    Public Function getcurrentelapsedtimestring() As String
        Dim t As TimeSpan = DateAndTime.Now - _start
        ' Dim s As String = String.Format("{0}:{1}:{2}", t.Hours, t.Minutes, t.Seconds)
        Dim hours As String = t.Hours.ToString().PadLeft(2, "0")
        Dim minutes As String = t.Minutes.ToString.PadLeft(2, "0")
        Dim seconds As String = t.Seconds.ToString.PadRight(2, "0")
        Dim s As String = hours & ":" & minutes & ":" & seconds
        ' t.ToString()
        Return s
    End Function
End Class
