Imports System.ComponentModel

Public Class NSform
    Dim music As New SoundTrack
    Public tiempo = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = True
        Randomize()
        Dim valor As Integer
        valor = (-9 * Rnd() + 10)
        TextBox2.Text = valor

        NumericUpDown1.Enabled = False
        If NumericUpDown1.Value = valor Then
            MessageBox.Show("FELICIDADES GANASTE UN PREMIO")
        Else
            MessageBox.Show("!PARA RECUPERAR TU ALMA DEBES CONTESTAR ESTE ACERTIJO Y ES POR TIEMPO! ")
            MessageBox.Show("¿Qué es lo primero que le mete un hombre a su mujer cuando se casan?")
            Timer1.Start()

        End If
        Button3.Visible = True
        TextBox3.Visible = True
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tiempo += 1

        Label4.Text = Val(Label4.Text) + 1
        If Val(Label4.Text = 100) Then
            Timer1.Stop()
        End If

        Button1.Enabled = False

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        NumericUpDown1.Enabled = True
        NumericUpDown1.Value = 0
        TextBox3.Text = ""


        Button1.Enabled = True
        TextBox2.Text = 0
        Label4.Text = 0
        Timer1.Stop()



    End Sub

    Private Sub NSform_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
        music.StopM()
        GMenu.Show()
    End Sub

    Private Sub NSform_Load(sender As Object, e As EventArgs) Handles Me.Load
        'music.PlayM("MSP.mp3")
        TextBox3.Visible = False
        Button3.Visible = False

    End Sub

    Private Sub SpeedGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeedGameToolStripMenuItem.Click
        Me.Hide()
        SMform.Show()
        SMform.SPG()

        music.StopM()
    End Sub

    Private Sub SimonSaysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimonSaysToolStripMenuItem.Click
        Me.Hide()
        SMform.Show()
        SMform.SSG()

        music.StopM()
    End Sub

    Private Sub DonkeyKongToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonkeyKongToolStripMenuItem.Click
        Me.Hide()
        DKform.Show()
        music.StopM()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If tiempo <= 100 Then
            If TextBox3.Text = "anillo" Or TextBox3.Text = "Anillo" Or TextBox3.Text = "ANILLO" Then
                Timer1.Stop()
                MessageBox.Show("FELICIDADES GANASTE UN PREMIO")
            Else
                MessageBox.Show("Incorrecto")
            End If
        Else
            MessageBox.Show("Perdiste")
        End If
    End Sub
End Class


