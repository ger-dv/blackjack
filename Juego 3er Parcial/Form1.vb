Public Class Form1
    Dim i As Integer = 200
    Dim cont As Integer = 1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    'Procedimiento para ejecutar la animación al regresar al menú
    Public Sub Volver()
        If playbtn.Visible = False Then
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Playbtn_Click(sender As Object, e As EventArgs) Handles playbtn.Click
        Form2.Show()
        Form2.ProcReset()
        playbtn.Visible = False
        aboutbtn.Visible = False
        salirbtn.Visible = False
        Me.Hide()
    End Sub

    Private Sub Aboutbtn_Click(sender As Object, e As EventArgs) Handles aboutbtn.Click
        Form3.Show()
        playbtn.Visible = False
        aboutbtn.Visible = False
        salirbtn.Visible = False
        Me.Hide()
    End Sub

    Private Sub Salirbtn_Click(sender As Object, e As EventArgs) Handles salirbtn.Click
        Form2.Close()
        Form3.Close()
        Me.Close()
    End Sub

    'Timers animación inicial de botones
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case cont
            Case 1
                playbtn.Visible = True
                i = i - 10
                playbtn.Location = New Point(200, i)
                If playbtn.Location.Y <= 130 Then
                    Timer1.Enabled = False
                    Timer2.Enabled = True
                End If
            Case 2
                aboutbtn.Visible = True
                i = i - 10
                aboutbtn.Location = New Point(200, i)
                If aboutbtn.Location.Y <= 180 Then
                    Timer1.Enabled = False
                    Timer2.Enabled = True
                End If
            Case 3
                salirbtn.Visible = True
                i = i - 10
                salirbtn.Location = New Point(200, i)
                If salirbtn.Location.Y <= 230 Then
                    Timer1.Enabled = False
                    Timer2.Enabled = True
                End If
        End Select
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Select Case cont
            Case 1
                i = i + 2
                playbtn.Location = New Point(200, i)
                If playbtn.Location.Y >= 150 Then
                    i = 250
                    cont = cont + 1
                    Timer2.Enabled = False
                    Timer1.Enabled = True
                End If
            Case 2
                i = i + 2
                aboutbtn.Location = New Point(200, i)
                If aboutbtn.Location.Y >= 200 Then
                    i = 300
                    cont = cont + 1
                    Timer2.Enabled = False
                    Timer1.Enabled = True
                End If
            Case 3
                i = i + 2
                salirbtn.Location = New Point(200, i)
                If salirbtn.Location.Y >= 250 Then
                    cont = 1
                    i = 200
                    Timer2.Enabled = False
                End If
        End Select
    End Sub
End Class
