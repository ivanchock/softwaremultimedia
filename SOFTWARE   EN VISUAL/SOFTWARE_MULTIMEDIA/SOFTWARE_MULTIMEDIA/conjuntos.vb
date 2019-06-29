Public Class conjuntos

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_ControlAdded(sender As Object, e As ControlEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        unitario.Show()
        My.Computer.Audio.Play(My.Resources.VOZ_CONJUNTO_UNITARIO, AudioPlayMode.Background)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        vacio.Show()
        My.Computer.Audio.Play(My.Resources.VOZ_CONJUNTO_VACIO, AudioPlayMode.Background)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        lleno.Show()
        My.Computer.Audio.Play(My.Resources.VOZ_CONJUNTO_LLENO, AudioPlayMode.Background)
    End Sub

    Private Sub conjunto_vacio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        inicio.Show()
    End Sub
End Class