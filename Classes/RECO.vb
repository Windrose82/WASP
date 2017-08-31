Public Class RECO
    Public Shared ANTRIEB_E As Double
    Public Shared MITTE_E As Double
    Public Shared BEDIEN_E As Double
    Public Shared ANTRIEB_R As Double
    Public Shared MITTE_R As Double
    Public Shared BEDIEN_R As Double
    Public Shared FAKTOR As Integer = 100

    Public Shared Function Antrieb()
        Return (ANTRIEB_E - ANTRIEB_R) * FAKTOR
    End Function
    Public Shared Function Mitte()
        Return (MITTE_E - MITTE_R) * FAKTOR
    End Function
    Public Shared Function Bedien()
        Return (BEDIEN_E - BEDIEN_R) * FAKTOR
    End Function
    Public Shared Function Mittelwert()
        Dim Liste As New List(Of Double)
        Liste.Clear()
        If BEDIEN_R > 0 Then
            Liste.Add((BEDIEN_E - BEDIEN_R) * FAKTOR)
        End If
        If MITTE_R > 0 Then
            Liste.Add((MITTE_E - MITTE_R) * FAKTOR)
        End If
        If ANTRIEB_R > 0 Then
            Liste.Add((ANTRIEB_E - ANTRIEB_R) * FAKTOR)
        End If
        If Liste.Count <> 0 Then
            Return Math.Round(Liste.Average, 2)
        Else
            Return 0
        End If
    End Function
    Public Shared Function Spannweite()
        Dim Liste As New List(Of Double)
        Liste.Clear()
        If BEDIEN_R > 0 Then
            Liste.Add((BEDIEN_E - BEDIEN_R) * FAKTOR)
        End If
        If MITTE_R > 0 Then
            Liste.Add((MITTE_E - MITTE_R) * FAKTOR)
        End If
        If ANTRIEB_R > 0 Then
            Liste.Add((ANTRIEB_E - ANTRIEB_R) * FAKTOR)
        End If
        If Liste.Count <> 0 Then
            Return Math.Round(Liste.Max - Liste.Min, 2)
        Else
            Return 0
        End If

    End Function
End Class
