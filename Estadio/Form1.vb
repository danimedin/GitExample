Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FrmScoreBoardLeft As New FrmScoreBoard
        Dim FrmScoreBoardRight As New FrmScoreBoard
        Dim FrmScoreBoardTop As New FrmScoreBoardLogo
        Dim FrmScoreBoardBottom As New FrmScoreBoardLogo
        Dim frmDesk As New frmDesk
        FrmScoreBoardLeft.Show()
        FrmScoreBoardRight.Show()
        FrmScoreBoardTop.Show()
        FrmScoreBoardBottom.Show()

        FrmScoreBoardLeft.Text = "Fondo"
        FrmScoreBoardRight.Text = "Gol"
        FrmScoreBoardTop.Text = "Rio"
        FrmScoreBoardBottom.Text = "Tribuna"

        'FrmScoreBoardBottom.BringToFront()
        frmDesk.Show()
        frmDesk.attach(FrmScoreBoardLeft)
        frmDesk.attach(FrmScoreBoardRight)
        frmDesk.attach(FrmScoreBoardTop)
        frmDesk.attach(FrmScoreBoardBottom)
        FrmScoreBoardLeft.sujeto = frmDesk
        FrmScoreBoardRight.sujeto = frmDesk
        FrmScoreBoardTop.sujeto = frmDesk
        FrmScoreBoardBottom.sujeto = frmDesk
    End Sub


End Class
