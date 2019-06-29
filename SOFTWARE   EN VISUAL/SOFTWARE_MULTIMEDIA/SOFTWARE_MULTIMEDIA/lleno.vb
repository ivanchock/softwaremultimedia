Public Class lleno

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        conjuntos.Show()
    End Sub

    Private Sub lleno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Hide()
        llvacas.Show()
        My.Computer.Audio.Play(My.Resources.VACA, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs)
        Me.Hide()
        conjuntos.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()
        llovejas.Show()
        My.Computer.Audio.Play(My.Resources.OBEJA, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Hide()
        llgatos.Show()
        My.Computer.Audio.Play(My.Resources.GATO, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Me.Hide()
        llperros.Show()
        My.Computer.Audio.Play(My.Resources.PERRO, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Me.Hide()
        llpollitos.Show()
        My.Computer.Audio.Play(My.Resources.POLLITO_PIO, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Me.Hide()
        llgallinas.Show()
        My.Computer.Audio.Play(My.Resources.GALLINA, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox11_Click_1(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Me.Hide()
        conjuntos.Show()
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        conjuntos.Show()
    End Sub
End Class