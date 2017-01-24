Public Class FrmScoreBoard
    Inherits PatronObservador.Observador


    Public Overrides Sub actualizar()
        Dim desk As frmDesk = CType(Me.sujeto, frmDesk)
        Me.MarcadorSinLogo.setHomeTeam(desk.tbHomeTeam.Text)

    End Sub
End Class