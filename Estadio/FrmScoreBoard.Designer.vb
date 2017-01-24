<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmScoreBoard
    Inherits PatronObservador.Observador

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MarcadorSinLogo = New ScoreBoards.football.UserControl2()
        Me.SuspendLayout()
        '
        'MarcadorSinLogo
        '
        Me.MarcadorSinLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MarcadorSinLogo.Location = New System.Drawing.Point(9, 9)
        Me.MarcadorSinLogo.Margin = New System.Windows.Forms.Padding(0)
        Me.MarcadorSinLogo.Name = "MarcadorSinLogo"
        Me.MarcadorSinLogo.Size = New System.Drawing.Size(266, 243)
        Me.MarcadorSinLogo.TabIndex = 0
        '
        'FrmScoreBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.MarcadorSinLogo)
        Me.Name = "FrmScoreBoard"
        Me.Text = "ScoreBoard"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MarcadorSinLogo As ScoreBoards.football.UserControl2
End Class
