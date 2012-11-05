Public Class stopwatch
    Private _start As Date
    Private _stop As Date
    Private _lap As Date
    Private _display As Date
    Public Sub New()

    End Sub
    'Public Sub New(StartTime As Date, StopTime As Date, LapTime As Date, Display As Date)
    '    _start = StartTime
    '    _stop = StopTime
    '    _lap = LapTime
    '    _display = Display
    'End Sub

    Public Function getcurrentelapsedtimestring() As String
        Dim t As TimeSpan
        Dim e As Integer = CInt(stoptime().Millisecond)
        Dim b As Integer = CInt(starttime().Millisecond)
        Dim tot As Integer = e - b
        Dim hours As String = t.Hours.ToString().PadLeft(2, "0")
        Dim minutes As String = t.Minutes.ToString.PadLeft(2, "0")
        Dim seconds As String = t.Seconds.ToString.PadRight(2, "0")

        Dim s As String = String.Format("{0}:{1}:{2}", t.Hours, t.Minutes, t.Seconds)
        Dim strn As String = hours & ":" & minutes & ":" & seconds
        Return tot
    End Function
    Public Function starttime() As Date
        Dim TimeStart As Date = TimeOfDay.AddMilliseconds(1)


        Return CDate(TimeStart)
    End Function

    Public Function stoptime() As Date
        Dim TimeStop As Date
        TimeStop = TimeOfDay.ToString()
        
        Return CDate(TimeStop)
    End Function

    Public Function TimeDifferenceCalc() As String
        Dim tempTime As DataSetDateTime = 0


        '    tempTime = starttime().Second - stoptime.Second


        Return tempTime.ToString()
    End Function
End Class