Public Class Utils
    ' Return a business day based on a start date and number
    ' of days to add. This should always return a weekday date.
    Public Shared Function AddBusinessDays(ByVal startDate As DateTime, ByVal daysToAdd As Integer) As DateTime
        Dim result As DateTime = startDate
        Dim i As Integer = 0
        Dim temp As Double = 0

        ' cycle until the requested number of days to add is
        ' reached. Pass over any weekend days.
        Do While i < daysToAdd
            temp += 1
            result = startDate.AddDays(temp)

            If IsWeekend(result) Then
                Continue Do
            End If

            i += 1
        Loop
        Return result
    End Function

    ' returns true if the date passed in is a Saturday or Sunday
    Public Shared Function IsWeekend(ByVal [date] As DateTime) As Boolean
        Return ([date].DayOfWeek = DayOfWeek.Saturday) OrElse ([date].DayOfWeek = DayOfWeek.Sunday)
    End Function

    Public Shared Function GetContrastingColor(ByVal color As Color) As Color
        Return color.FromArgb(color.ToArgb() Xor &HFFFFFF)
    End Function

    Public Shared Function GetKnownColorName(ByVal color As Color) As String

        For Each knownColor As KnownColor In System.Enum.GetValues(GetType(KnownColor))
            If color.ToArgb() = color.FromKnownColor(knownColor).ToArgb() Then
                Return color.FromKnownColor(knownColor).Name
            End If
        Next knownColor
        Return String.Empty
    End Function
End Class