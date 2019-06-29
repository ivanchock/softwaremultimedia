Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Visible = False
        Form1.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Visible = False
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        vacio.Show()

        My.Computer.Audio.Play(My.Resources.VOZ_CONJUNTO_VACIO, AudioPlayMode.Background)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Visible = False
        lleno.Show()

        My.Computer.Audio.Play(My.Resources.VOZ_CONJUNTO_LLENO, AudioPlayMode.Background)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Visible = False
        unitario.Show()

        My.Computer.Audio.Play(My.Resources.VOZ_CONJUNTO_UNITARIO, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub
End Class