Public Class Form1
    Dim Azar As Boolean = True

    Function NumDado(Random As Boolean) As Integer
        If Random Then Randomize()
        Return Int(Rnd() * 6 + 1)
    End Function

    Private Sub Cubilete_Click(sender As Object, e As EventArgs) Handles Cubilete.Click
        CambiaDado(Dado)
        CambiaDado(Dado2)
    End Sub


    Sub CambiaDado(ByRef DadoX As PictureBox)
        Dim Num As Integer = NumDado(True)
        Select Case Num
            Case 1 : DadoX.Image = My.Resources.dado1
            Case 2 : DadoX.Image = My.Resources.dado2
            Case 3 : DadoX.Image = My.Resources.dado3
            Case 4 : DadoX.Image = My.Resources.dado4
            Case 5 : DadoX.Image = My.Resources.dado5
            Case 6 : DadoX.Image = My.Resources.dado6

        End Select
    End Sub



    '  Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    'Dim monto As Decimal = 1000
    'Dim IVA As Decimal = 0, IIBB As Decimal = 0, Interes1 As Decimal = 0
    '   CalculaValores(monto, IVA, IIBB, Interes1)
    '  MessageBox.Show("monto:" & monto & ", IVA: " & IVA & "IIBB : " & IIBB & " Interes1 : " & Interes1)

    'End Sub
    'Sub CalculaValores(ByVal MontoX As Decimal, ByRef IVA As Decimal, ByRef IB As Decimal, ByRef Interes1 As Decimal)
    '   IVA = MontoX * 31 / 100
    '  IB = MontoX * 3 / 100
    ' Interes1 = MontoX * 5 / 100
    'End Sub

End Class
