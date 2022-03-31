Public Class Form2

    Dim SONUC As Integer



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Top -= 5
        PictureBox2.Top -= 5
        PictureBox3.Top -= 5
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If PictureBox1.Location.Y < -60 Or PictureBox2.Location.Y < -60 Or PictureBox3.Location.Y < -60 Then
            Me.Dispose()
            MsgBox("OYUN BİTTİ")
            Form1.Show()


        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        SONUC = SONUC + 1
        Label1.Text = SONUC
        PictureBox1.Location = New Point(200, 400)


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        SONUC = SONUC + 1
        Label1.Text = SONUC
        PictureBox2.Location = New Point(200, 400)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        SONUC = SONUC + 1
        Label1.Text = SONUC
        PictureBox3.Location = New Point(200, 400)
    End Sub
End Class