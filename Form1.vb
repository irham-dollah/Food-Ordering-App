Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel3.Height = Button1.Height
        Panel3.Top = Button1.Top
        food.Visible = True
        drinks.Visible = False
        dessert.Visible = False
        cart.Visible = False
        about.Visible = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Me.Close()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs)
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        Else
            Me.WindowState = WindowState.Normal
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        If Me.WindowState.Normal Or Me.WindowState.Maximized Then
            Me.WindowState = WindowState.Minimized
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel4.Height = Button2.Height
        Panel4.Top = Button2.Top
        food.Visible = False
        drinks.Visible = True
        dessert.Visible = False
        cart.Visible = False
        about.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel5.Height = Button3.Height
        Panel5.Top = Button3.Top
        food.Visible = False
        drinks.Visible = False
        dessert.Visible = True
        cart.Visible = False
        about.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel6.Height = Button4.Height
        Panel6.Top = Button4.Top
        food.Visible = False
        drinks.Visible = False
        dessert.Visible = False
        cart.Visible = True
        about.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel7.Height = Button5.Height
        Panel7.Top = Button5.Top
        food.Visible = False
        drinks.Visible = False
        dessert.Visible = False
        cart.Visible = False
        about.Visible = True
    End Sub
End Class
