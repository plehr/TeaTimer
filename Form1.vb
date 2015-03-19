Public Class Teatimer
    ' Information:
    ' Form icon: https://www.iconfinder.com/icons/283979/coffee_cup_drink_food_tea_icon#size=128
    ' Exit icon: https://www.iconfinder.com/icons/27856/exit_out_sign_out_icon#size=128

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Programminfo.Click
        Dim Programminfo As String
        Programminfo = "Dieses Programm wurde von P Lehr erstellt. Sie dürfen dieses gerne kostenlos benutzen. Modifizieren in jeglicher Form ist gestattet. Es muss jedoch immer ein Verweis auf mein GIT-Repository vorhanden sein! Copyright 2015 P Lehr. Github: https://github.com/plehr"
        MsgBox(Programminfo)

    End Sub
    Dim timeran As Boolean
    Dim Time As Double
    Dim fertig As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If timeran = True Then
            Timer1.Stop()
            Button1.Text = "Ich möchte einen anderen Tee überwachen"
            timeran = False
            Label1.Visible = False
            StopToolStripMenuItem.Visible = False
            StartToolStripMenuItem.Visible = True
        Else
            Button1.Text = "Meinen Tee bitte nicht mehr überwachen"
            Button1.AutoSize = True
            Timer1.Start()
            timeran = True
            Time = 0.0
            Time = Time + 8.0
            Label1.Visible = True
            StopToolStripMenuItem.Visible = True
            StartToolStripMenuItem.Visible = False
        End If
        Me.AutoSize = True
    End Sub
    Private Sub untenclick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        Me.Show()
        NotifyIcon1.Visible = False
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Me.WindowState = FormWindowState.Minimized
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(1)
        Me.Hide()
        e.Cancel = True
    End Sub
    Private Sub herz(sender As Object, e As EventArgs) Handles Timer1.Tick
        Time = Time - 1
        Label1.Text = "Ihr Tee ist in " & Time & " Minuten fertig."
        If Time <= 0 Then
            Timer1.Stop()
            Label1.Text = "Ihr Tee ist fertig"
            MsgBox("Alarm: Ihr Tee ist fertig")
            Button1.Text = "Danke weiß ich"
            NotifyIcon1.BalloonTipText = "Ihr Tee ist fertig!"
            NotifyIcon1.ShowBalloonTip(1)
            fertig = True

        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, BeendenToolStripMenuItem.Click
        Application.ExitThread()
    End Sub
    Private Sub Startbutton(sender As Object, e As EventArgs) Handles StartToolStripMenuItem.Click
        If timeran = True Then
            Timer1.Stop()
            Button1.Text = "Ich möchte einen anderen Tee überwachen"
            timeran = False
            Label1.Visible = False
            StopToolStripMenuItem.Visible = False
            StartToolStripMenuItem.Visible = True
        Else
            Button1.Text = "Meinen Tee bitte nicht mehr überwachen"
            Button1.AutoSize = True
            Timer1.Start()
            timeran = True
            Time = 0.0
            Time = Time + 8.0
            Label1.Visible = True
            StopToolStripMenuItem.Visible = True
            StartToolStripMenuItem.Visible = False
        End If
        Me.AutoSize = True
    End Sub
    Private Sub Stopbutton(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        If timeran = True Then
            Timer1.Stop()
            Button1.Text = "Ich möchte einen anderen Tee überwachen"
            timeran = False
            Label1.Visible = False
            StopToolStripMenuItem.Visible = False
            StartToolStripMenuItem.Visible = True
        Else
            Button1.Text = "Meinen Tee bitte nicht mehr überwachen"
            Button1.AutoSize = True
            Timer1.Start()
            timeran = True
            Time = 0.0
            Time = Time + 8.0
            Label1.Visible = True
            StopToolStripMenuItem.Visible = True
            StartToolStripMenuItem.Visible = False
        End If
        Me.AutoSize = True
    End Sub

    Private Sub Teatimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
