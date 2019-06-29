Public Class unitario

    Private Sub unitario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        conjuntos.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        Me.Hide()
        uperros.Show()
        My.Computer.Audio.Play(My.Resources.PERRO, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)
        Me.Hide()
        ucerditos.Show()
        My.Computer.Audio.Play(My.Resources.CERDO, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Me.Hide()
        conjuntos.Show()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)
        Me.Hide()
        ovejas.Show()
        My.Computer.Audio.Play(My.Resources.OVEJA, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox7_Click_1(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Hide()
        ucerditos.Show()
        My.Computer.Audio.Play(My.Resources.CERDO, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Hide()
        ovejas.Show()
        My.Computer.Audio.Play(My.Resources.OVEJA, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()
        uperros.Show()
        My.Computer.Audio.Play(My.Resources.PERRO, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Me.Hide()
        conjuntos.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        conjuntos.Show()
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Me.Close()
    End Sub
End Class