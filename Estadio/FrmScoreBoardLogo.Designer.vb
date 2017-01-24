<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmScoreBoardLogo
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
        Me.MarcadorConLogo = New ScoreBoards.BasicScoreBoardLogo()
        Me.SuspendLayout()
        '
        'MarcadorConLogo
        '
        Me.MarcadorConLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MarcadorConLogo.Location = New System.Drawing.Point(18, 9)
        Me.MarcadorConLogo.Margin = New System.Windows.Forms.Padding(0)
        Me.MarcadorConLogo.Name = "MarcadorConLogo"
        Me.MarcadorConLogo.Size = New System.Drawing.Size(234, 380)
        Me.MarcadorConLogo.TabIndex = 0
        '
        'ScoreBoardLogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 398)
        Me.Controls.Add(Me.MarcadorConLogo)
        Me.Name = "ScoreBoardLogo"
        Me.Text = "ScoreBoardLogo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MarcadorConLogo As ScoreBoards.BasicScoreBoardLogo
End Class
