﻿Public Class AdminPage

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DesktopLocation = New Point(100, 100)

    End Sub

    Private Sub btnTimeClock_Click(sender As Object, e As EventArgs) Handles btnTimeClock.Click
        Me.Close()
        TimeClock.Show()
    End Sub
End Class