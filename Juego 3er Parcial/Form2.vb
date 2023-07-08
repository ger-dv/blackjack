Public Class Form2
    Dim saldo As Integer = 2000
    Dim apuesta As Integer = 0
    Dim dapuesta As Integer = 0 'Variable para doblar la apuesta
    Dim pjug As Integer = 0 'Puntos totales del jugador
    Dim ppc As Integer = 0 'Puntos totales de la pc
    Dim pjugadaj As Integer = 0 'Puntos de la jugada del jugador
    Dim pjugadap As Integer = 0 'Puntos de la jugada de la pc
    Dim cont As Integer = 0 'Contador número de jugada
    Dim cartapc As Integer = 0
    Dim cartajug As Integer = 0
    Dim i As Integer = 0
    Dim j As Integer = 155
    'Vector para validar si se repite la carta
    Dim repite(52) As Integer
    'Vector de valores de la baraja
    Dim baraja() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
        11, 12, 13, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13}
    'Vector de imágenes de cartas
    Dim cartaimg() As Image = {My.Resources.carta, My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4,
    My.Resources._5, My.Resources._6, My.Resources._7, My.Resources._8, My.Resources._9, My.Resources._10,
    My.Resources._11, My.Resources._12, My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16,
    My.Resources._17, My.Resources._18, My.Resources._19, My.Resources._20, My.Resources._21, My.Resources._22,
    My.Resources._23, My.Resources._24, My.Resources._25, My.Resources._26, My.Resources._27, My.Resources._28,
    My.Resources._29, My.Resources._30, My.Resources._31, My.Resources._32, My.Resources._33, My.Resources._34,
    My.Resources._35, My.Resources._36, My.Resources._37, My.Resources._38, My.Resources._39, My.Resources._40,
    My.Resources._41, My.Resources._42, My.Resources._43, My.Resources._44, My.Resources._45, My.Resources._46,
    My.Resources._47, My.Resources._48, My.Resources._49, My.Resources._50, My.Resources._51, My.Resources._52}

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    'Cerrar completamente el programa (evitar que se queden ejecutando las otras forms)
    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Close()
        Form3.Close()
    End Sub

    'Procedimiento para reiniciar parámetros
    Public Sub ProcReset()
        robarbtn.Enabled = False
        doblarbtn.Enabled = False
        compbtn.Enabled = False
        resetbtn.Enabled = False
        saldolbl.Text = Format(saldo, "$ #,###")
        apuesta = 0
        apuestalbl.Text = "$ 0"
        pjug = 0
        pjuglbl.Text = "Puntos Jugador: 0"
        ppc = 0
        ppclbl.Text = "Puntos CPU: 0"
        cont = 0
        dapuesta = 0
        cartajug = 0
        cartapc = 0
        i = 0
        j = 155
        bet50btn.Enabled = False
        bet50btn.BackgroundImage = My.Resources.gray
        bet100btn.Enabled = False
        bet100btn.BackgroundImage = My.Resources.gray
        bet500btn.Enabled = False
        bet500btn.BackgroundImage = My.Resources.gray
        bet1kbtn.Enabled = False
        bet1kbtn.BackgroundImage = My.Resources.gray
        bet2kbtn.Enabled = False
        bet2kbtn.BackgroundImage = My.Resources.gray
        Cjug1.Visible = False
        Cpc1.Visible = False
        Cjug2.Visible = False
        Cpc2.Visible = False
        Cjug3.Visible = False
        Cpc3.Visible = False
        Cjug4.Visible = False
        Cpc4.Visible = False
        Cjug5.Visible = False
        Cpc5.Visible = False
        Cjug6.Visible = False
        Cpc6.Visible = False
        Cjug1.Image = My.Resources.carta
        Cpc1.Image = My.Resources.carta
        Cjug2.Image = My.Resources.carta
        Cpc2.Image = My.Resources.carta
        Cjug3.Image = My.Resources.carta
        Cpc3.Image = My.Resources.carta
        Cjug4.Image = My.Resources.carta
        Cpc4.Image = My.Resources.carta
        Cjug5.Image = My.Resources.carta
        Cpc5.Image = My.Resources.carta
        Cjug6.Image = My.Resources.carta
        Cpc6.Image = My.Resources.carta
        Timer1.Enabled = True
    End Sub

    'Procedimiento para apuestas
    Private Sub ProcApuesta()
        saldo = saldo - apuesta
        bet50btn.Enabled = False
        bet50btn.BackgroundImage = My.Resources.gray
        bet100btn.Enabled = False
        bet100btn.BackgroundImage = My.Resources.gray
        bet500btn.Enabled = False
        bet500btn.BackgroundImage = My.Resources.gray
        bet1kbtn.Enabled = False
        bet1kbtn.BackgroundImage = My.Resources.gray
        bet2kbtn.Enabled = False
        bet2kbtn.BackgroundImage = My.Resources.gray
        apuestalbl.Text = Format(apuesta, "$ #,###")
        saldolbl.Text = Format(saldo, "$ #,###")
        robarbtn.Enabled = True
        If saldo = 0 Then
            saldolbl.Text = "$ 0"
        End If
    End Sub

    'Procedimiento para activar botones de apuesta
    Private Sub ProcActivarap()
        If saldo >= 2000 Then
            bet50btn.Enabled = True
            bet50btn.BackgroundImage = My.Resources.green
            bet100btn.Enabled = True
            bet100btn.BackgroundImage = My.Resources.blue
            bet500btn.Enabled = True
            bet500btn.BackgroundImage = My.Resources.red
            bet1kbtn.Enabled = True
            bet1kbtn.BackgroundImage = My.Resources.black
            bet2kbtn.Enabled = True
            bet2kbtn.BackgroundImage = My.Resources.gold
        ElseIf saldo < 2000 And saldo >= 1000 Then
            bet50btn.Enabled = True
            bet50btn.BackgroundImage = My.Resources.green
            bet100btn.Enabled = True
            bet100btn.BackgroundImage = My.Resources.blue
            bet500btn.Enabled = True
            bet500btn.BackgroundImage = My.Resources.red
            bet1kbtn.Enabled = True
            bet1kbtn.BackgroundImage = My.Resources.black
        ElseIf saldo < 1000 And saldo >= 500 Then
            bet50btn.Enabled = True
            bet50btn.BackgroundImage = My.Resources.green
            bet100btn.Enabled = True
            bet100btn.BackgroundImage = My.Resources.blue
            bet500btn.Enabled = True
            bet500btn.BackgroundImage = My.Resources.red
        ElseIf saldo < 500 And saldo >= 100 Then
            bet50btn.Enabled = True
            bet50btn.BackgroundImage = My.Resources.green
            bet100btn.Enabled = True
            bet100btn.BackgroundImage = My.Resources.blue
        ElseIf saldo < 100 And saldo >= 50 Then
            bet50btn.Enabled = True
            bet50btn.BackgroundImage = My.Resources.green
        End If
    End Sub

    'Procedimiento para limpiar vector repite
    Private Sub ProcBaraja()
        For i = 0 To 52
            repite(i) = 0
        Next
        i = 0
    End Sub

    'Volver al menú principal
    Private Sub Menubtn_Click(sender As Object, e As EventArgs) Handles menubtn.Click
        saldo = 2000
        ProcReset()
        Form1.Show()
        Form1.Volver()
        Me.Hide()
    End Sub

    'Reiniciar el juego
    Private Sub Resetbtn_Click(sender As Object, e As EventArgs) Handles resetbtn.Click
        saldo = 2000
        resetbtn.Enabled = False
        ProcReset()
    End Sub

    'Cerrar el programa
    Private Sub Salirbtn_Click(sender As Object, e As EventArgs) Handles salirbtn.Click
        Form1.Close()
        Form3.Close()
        Me.Close()
    End Sub

    'Botones de apuesta
    Private Sub Bet50btn_Click(sender As Object, e As EventArgs) Handles bet50btn.Click
        apuesta = 50
        ProcApuesta()
    End Sub

    Private Sub Bet100btn_Click(sender As Object, e As EventArgs) Handles bet100btn.Click
        apuesta = 100
        ProcApuesta()
    End Sub

    Private Sub Bet500btn_Click(sender As Object, e As EventArgs) Handles bet500btn.Click
        apuesta = 500
        ProcApuesta()
    End Sub

    Private Sub Bet1kbtn_Click(sender As Object, e As EventArgs) Handles bet1kbtn.Click
        apuesta = 1000
        ProcApuesta()
    End Sub

    Private Sub Bet2kbtn_Click(sender As Object, e As EventArgs) Handles bet2kbtn.Click
        apuesta = 2000
        ProcApuesta()
    End Sub

    'Doblar la apuesta
    Private Sub Doblarbtn_Click(sender As Object, e As EventArgs) Handles doblarbtn.Click
        apuesta = apuesta * 2
        dapuesta = apuesta / 2
        saldo = saldo - dapuesta
        apuestalbl.Text = Format(apuesta, "$ #,###")
        saldolbl.Text = Format(saldo, "$ #,###")
        If saldo = 0 Then
            saldolbl.Text = "$ 0"
        End If
        doblarbtn.Enabled = False
        compbtn.Enabled = False
    End Sub

    'Tomar nueva carta
    Private Sub Robarbtn_Click(sender As Object, e As EventArgs) Handles robarbtn.Click
        cont = cont + 1

        Randomize()
        cartajug = Int(Rnd() * 52) + 1
        While repite(cartajug) = 1
            Randomize()
            cartajug = Int(Rnd() * 52) + 1
        End While
        repite(cartajug) = 1
        pjugadaj = baraja(cartajug)
        pjug = pjug + pjugadaj

        Randomize()
        cartapc = Int(Rnd() * 52) + 1
        While repite(cartapc) = 1
            Randomize()
            cartapc = Int(Rnd() * 52) + 1
        End While
        repite(cartapc) = 1
        pjugadap = baraja(cartapc)
        ppc = ppc + pjugadap

        'Cambiar imágenes de las cartas
        Select Case cont
            Case 1
                Cjug1.Image = cartaimg(cartajug)
                Cpc1.Image = cartaimg(cartapc)
                If saldo >= apuesta Then
                    doblarbtn.Enabled = True
                Else
                    doblarbtn.Enabled = False
                End If
            Case 2
                Cjug2.Image = cartaimg(cartajug)
                Cpc2.Image = cartaimg(cartapc)
                compbtn.Enabled = True
            Case 3
                Cjug3.Image = cartaimg(cartajug)
                Cpc3.Image = cartaimg(cartapc)
            Case 4
                Cjug4.Image = cartaimg(cartajug)
                Cpc4.Image = cartaimg(cartapc)
            Case 5
                Cjug5.Image = cartaimg(cartajug)
                Cpc5.Image = cartaimg(cartapc)
            Case 6
                Cjug6.Image = cartaimg(cartajug)
                Cpc6.Image = cartaimg(cartapc)
                robarbtn.Enabled = False
        End Select

        pjuglbl.Text = Format(pjug, "Puntos Jugador: ##")
        ppclbl.Text = Format(ppc, "Puntos CPU: ##")

        'Validacion de puntos para ganar, perder o empatar
        If ppc > 21 And pjug <= 21 Or pjug = 21 Then
            MsgBox("¡Felicidades!", Title:="Ganaste")
            apuesta = apuesta * 2
            saldo = saldo + apuesta
            ProcReset()
            ProcBaraja()
        ElseIf pjug > 21 And ppc <= 21 Or ppc = 21 Then
            MsgBox("Más suerte para la próxima :(", Title:="Pierdes")
            If saldo = 0 Then
                saldolbl.Text = "$ 0"
                MsgBox("No hay más que apostar, se terminó el juego.", Title:="Saldo insuficiente")
                apuestalbl.Text = "$ 0"
                saldo = 2000
                Form1.Show()
                Form1.Volver()
                Me.Hide()
            Else
                ProcReset()
                ProcBaraja()
            End If
        ElseIf pjug > 21 And ppc > 21 Then
            MsgBox("Ambos tienen más de 21", Title:="Empate")
            If dapuesta > 0 Then
                apuesta = apuesta / 2
                saldo = saldo + apuesta
            Else
                saldo = saldo + apuesta
            End If
            ProcReset()
            ProcBaraja()
        End If
    End Sub

    'Comparar puntos
    Private Sub Compbtn_Click(sender As Object, e As EventArgs) Handles compbtn.Click
        If pjug > ppc Then
            MsgBox("Ganaste!", Title:="Felicidades")
            apuesta = apuesta * 2
            saldo = saldo + apuesta
            ProcReset()
            ProcBaraja()
        ElseIf ppc > pjug Then
            MsgBox("Más suerte para la próxima :(", Title:="Pierdes")
            If saldo = 0 Then
                saldolbl.Text = "$ 0"
                MsgBox("No hay más que apostar, se terminó el juego.", Title:="Saldo insuficiente")
                apuestalbl.Text = "$ 0"
                saldo = 2000
                Form1.Show()
                Form1.Volver()
                Me.Hide()
            Else
                ProcReset()
                ProcBaraja()
            End If
        ElseIf pjug = ppc Then
            MsgBox("Ambos tienen lo mismo.", Title:="Empate")
            If dapuesta > 0 Then
                apuesta = apuesta / 2
                saldo = saldo + apuesta
            Else
                saldo = saldo + apuesta
            End If
            ProcReset()
            ProcBaraja()
        End If
    End Sub

    'Timers animación de las cartas
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case cont
            Case 0
                Cpc1.Visible = True
                i = i + 10
                Cpc1.Location = New Point(300, i)
                Cjug1.Visible = True
                j = j + 10
                Cjug1.Location = New Point(300, j)
                If Cpc1.Location.Y >= 100 Then
                    Timer1.Enabled = False
                    Timer2.Enabled = True
                End If
            Case 1
                Cpc2.Visible = True
                i = i + 10
                Cpc2.Location = New Point(353, i)
                Cjug2.Visible = True
                j = j + 10
                Cjug2.Location = New Point(353, j)
                If Cpc2.Location.Y >= 80 Then
                    Timer1.Enabled = False
                    Timer2.Enabled = True
                End If
            Case 2
                Cpc3.Visible = True
                i = i + 10
                Cpc3.Location = New Point(407, i)
                Cjug3.Visible = True
                j = j + 10
                Cjug3.Location = New Point(407, j)
                If Cpc3.Location.Y >= 100 Then
                    Timer1.Enabled = False
                    Timer2.Enabled = True
                End If
            Case 3
                Cpc4.Visible = True
                i = i + 10
                Cpc4.Location = New Point(460, i)
                Cjug4.Visible = True
                j = j + 10
                Cjug4.Location = New Point(460, j)
                If Cpc4.Location.Y >= 80 Then
                    Timer1.Enabled = False
                    Timer2.Enabled = True
                End If
            Case 4
                Cpc5.Visible = True
                i = i + 10
                Cpc5.Location = New Point(513, i)
                Cjug5.Visible = True
                j = j + 10
                Cjug5.Location = New Point(513, j)
                If Cpc5.Location.Y >= 100 Then
                    Timer1.Enabled = False
                    Timer2.Enabled = True
                End If
            Case 5
                Cpc6.Visible = True
                i = i + 10
                Cpc6.Location = New Point(566, i)
                Cjug6.Visible = True
                j = j + 10
                Cjug6.Location = New Point(566, j)
                If Cpc6.Location.Y >= 80 Then
                    Timer1.Enabled = False
                    Timer2.Enabled = True
                End If
        End Select

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Select Case cont
            Case 0
                i = i - 2
                Cpc1.Location = New Point(300, i)
                j = j - 2
                Cjug1.Location = New Point(300, j)
                If Cpc1.Location.Y <= 80 Then
                    i = 0
                    j = 155
                    Timer2.Enabled = False
                    cont = cont + 1
                    Timer1.Enabled = True
                End If
            Case 1
                i = i - 2
                Cpc2.Location = New Point(353, i)
                j = j - 2
                Cjug2.Location = New Point(353, j)
                If Cpc2.Location.Y <= 60 Then
                    i = 0
                    j = 155
                    Timer2.Enabled = False
                    cont = cont + 1
                    Timer1.Enabled = True
                End If
            Case 2
                i = i - 2
                Cpc3.Location = New Point(407, i)
                j = j - 2
                Cjug3.Location = New Point(407, j)
                If Cpc3.Location.Y <= 80 Then
                    i = 0
                    j = 155
                    Timer2.Enabled = False
                    cont = cont + 1
                    Timer1.Enabled = True
                End If
            Case 3
                i = i - 2
                Cpc4.Location = New Point(460, i)
                j = j - 2
                Cjug4.Location = New Point(460, j)
                If Cpc4.Location.Y <= 60 Then
                    i = 0
                    j = 155
                    Timer2.Enabled = False
                    cont = cont + 1
                    Timer1.Enabled = True
                End If
            Case 4
                i = i - 2
                Cpc5.Location = New Point(513, i)
                j = j - 2
                Cjug5.Location = New Point(513, j)
                If Cpc5.Location.Y <= 80 Then
                    i = 0
                    j = 155
                    Timer2.Enabled = False
                    cont = cont + 1
                    Timer1.Enabled = True
                End If
            Case 5
                i = i - 1
                Cpc6.Location = New Point(566, i)
                j = j - 1
                Cjug6.Location = New Point(566, j)
                If Cpc6.Location.Y <= 60 Then
                    i = 0
                    j = 155
                    Timer2.Enabled = False
                    cont = 0
                End If
                If Timer2.Enabled = False Then
                    resetbtn.Enabled = True
                    ProcActivarap()
                End If
        End Select
    End Sub

End Class