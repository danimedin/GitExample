Public Class frmDesk
    Inherits PatronObservador.Sujeto

    Public Sub btnBrowseH_Click(sender As Object, e As EventArgs) Handles btnBrowseH.Click

        Me.SeleccionaImaxe(pbHomeLogo)

    End Sub

    Public Sub btnBrowseA_Click(sender As Object, e As EventArgs) Handles btnBrowseA.Click
        Me.SeleccionaImaxe(pbAwayLogo)



    End Sub
    Private Sub SeleccionaImaxe(ByVal pb As PictureBox)
        Dim ofdAway As New OpenFileDialog
        Dim fileAway As String

        If ofdAway.ShowDialog = DialogResult.OK Then
            fileAway = ofdAway.FileName
            pb.Image = Bitmap.FromFile(fileAway)
        End If
    End Sub


    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Me.notify()
    End Sub
End Class