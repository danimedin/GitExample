<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDesk
    Inherits PatronObservador.Sujeto

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbHomeTeam = New System.Windows.Forms.GroupBox()
        Me.btnBrowseH = New System.Windows.Forms.Button()
        Me.pbHomeLogo = New System.Windows.Forms.PictureBox()
        Me.lblHomeLogo = New System.Windows.Forms.Label()
        Me.nudHome = New System.Windows.Forms.NumericUpDown()
        Me.lblHomeGoal = New System.Windows.Forms.Label()
        Me.tbHomeTeam = New System.Windows.Forms.TextBox()
        Me.lblHomeTeam = New System.Windows.Forms.Label()
        Me.gbAwayTeam = New System.Windows.Forms.GroupBox()
        Me.btnBrowseA = New System.Windows.Forms.Button()
        Me.pbAwayLogo = New System.Windows.Forms.PictureBox()
        Me.lblAwayLogo = New System.Windows.Forms.Label()
        Me.nudAway = New System.Windows.Forms.NumericUpDown()
        Me.lblAwayGoal = New System.Windows.Forms.Label()
        Me.tbAwayTeam = New System.Windows.Forms.TextBox()
        Me.lblAwayTeam = New System.Windows.Forms.Label()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.gbHomeTeam.SuspendLayout()
        CType(Me.pbHomeLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAwayTeam.SuspendLayout()
        CType(Me.pbAwayLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAway, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbHomeTeam
        '
        Me.gbHomeTeam.Controls.Add(Me.btnBrowseH)
        Me.gbHomeTeam.Controls.Add(Me.pbHomeLogo)
        Me.gbHomeTeam.Controls.Add(Me.lblHomeLogo)
        Me.gbHomeTeam.Controls.Add(Me.nudHome)
        Me.gbHomeTeam.Controls.Add(Me.lblHomeGoal)
        Me.gbHomeTeam.Controls.Add(Me.tbHomeTeam)
        Me.gbHomeTeam.Controls.Add(Me.lblHomeTeam)
        Me.gbHomeTeam.Location = New System.Drawing.Point(13, 13)
        Me.gbHomeTeam.Name = "gbHomeTeam"
        Me.gbHomeTeam.Size = New System.Drawing.Size(268, 171)
        Me.gbHomeTeam.TabIndex = 0
        Me.gbHomeTeam.TabStop = False
        Me.gbHomeTeam.Text = "Home Team"
        '
        'btnBrowseH
        '
        Me.btnBrowseH.Location = New System.Drawing.Point(168, 103)
        Me.btnBrowseH.Name = "btnBrowseH"
        Me.btnBrowseH.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseH.TabIndex = 6
        Me.btnBrowseH.Text = "&Browse"
        Me.btnBrowseH.UseVisualStyleBackColor = True
        '
        'pbHomeLogo
        '
        Me.pbHomeLogo.Location = New System.Drawing.Point(99, 92)
        Me.pbHomeLogo.Name = "pbHomeLogo"
        Me.pbHomeLogo.Size = New System.Drawing.Size(55, 55)
        Me.pbHomeLogo.TabIndex = 5
        Me.pbHomeLogo.TabStop = False
        '
        'lblHomeLogo
        '
        Me.lblHomeLogo.AutoSize = True
        Me.lblHomeLogo.Location = New System.Drawing.Point(16, 113)
        Me.lblHomeLogo.Name = "lblHomeLogo"
        Me.lblHomeLogo.Size = New System.Drawing.Size(62, 13)
        Me.lblHomeLogo.TabIndex = 4
        Me.lblHomeLogo.Text = "Home Logo"
        '
        'nudHome
        '
        Me.nudHome.Location = New System.Drawing.Point(99, 58)
        Me.nudHome.Name = "nudHome"
        Me.nudHome.Size = New System.Drawing.Size(41, 20)
        Me.nudHome.TabIndex = 3
        '
        'lblHomeGoal
        '
        Me.lblHomeGoal.AutoSize = True
        Me.lblHomeGoal.Location = New System.Drawing.Point(16, 60)
        Me.lblHomeGoal.Name = "lblHomeGoal"
        Me.lblHomeGoal.Size = New System.Drawing.Size(65, 13)
        Me.lblHomeGoal.TabIndex = 2
        Me.lblHomeGoal.Text = "Home Goals"
        '
        'tbHomeTeam
        '
        Me.tbHomeTeam.Location = New System.Drawing.Point(99, 27)
        Me.tbHomeTeam.Name = "tbHomeTeam"
        Me.tbHomeTeam.Size = New System.Drawing.Size(144, 20)
        Me.tbHomeTeam.TabIndex = 1
        '
        'lblHomeTeam
        '
        Me.lblHomeTeam.AutoSize = True
        Me.lblHomeTeam.Location = New System.Drawing.Point(16, 30)
        Me.lblHomeTeam.Name = "lblHomeTeam"
        Me.lblHomeTeam.Size = New System.Drawing.Size(65, 13)
        Me.lblHomeTeam.TabIndex = 0
        Me.lblHomeTeam.Text = "Home Team"
        '
        'gbAwayTeam
        '
        Me.gbAwayTeam.Controls.Add(Me.btnBrowseA)
        Me.gbAwayTeam.Controls.Add(Me.pbAwayLogo)
        Me.gbAwayTeam.Controls.Add(Me.lblAwayLogo)
        Me.gbAwayTeam.Controls.Add(Me.nudAway)
        Me.gbAwayTeam.Controls.Add(Me.lblAwayGoal)
        Me.gbAwayTeam.Controls.Add(Me.tbAwayTeam)
        Me.gbAwayTeam.Controls.Add(Me.lblAwayTeam)
        Me.gbAwayTeam.Location = New System.Drawing.Point(13, 190)
        Me.gbAwayTeam.Name = "gbAwayTeam"
        Me.gbAwayTeam.Size = New System.Drawing.Size(268, 166)
        Me.gbAwayTeam.TabIndex = 1
        Me.gbAwayTeam.TabStop = False
        Me.gbAwayTeam.Text = "Away Team"
        '
        'btnBrowseA
        '
        Me.btnBrowseA.Location = New System.Drawing.Point(168, 103)
        Me.btnBrowseA.Name = "btnBrowseA"
        Me.btnBrowseA.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseA.TabIndex = 6
        Me.btnBrowseA.Text = "B&rowse"
        Me.btnBrowseA.UseVisualStyleBackColor = True
        '
        'pbAwayLogo
        '
        Me.pbAwayLogo.Location = New System.Drawing.Point(99, 92)
        Me.pbAwayLogo.Name = "pbAwayLogo"
        Me.pbAwayLogo.Size = New System.Drawing.Size(55, 55)
        Me.pbAwayLogo.TabIndex = 5
        Me.pbAwayLogo.TabStop = False
        '
        'lblAwayLogo
        '
        Me.lblAwayLogo.AutoSize = True
        Me.lblAwayLogo.Location = New System.Drawing.Point(16, 113)
        Me.lblAwayLogo.Name = "lblAwayLogo"
        Me.lblAwayLogo.Size = New System.Drawing.Size(60, 13)
        Me.lblAwayLogo.TabIndex = 4
        Me.lblAwayLogo.Text = "Away Logo"
        '
        'nudAway
        '
        Me.nudAway.Location = New System.Drawing.Point(99, 58)
        Me.nudAway.Name = "nudAway"
        Me.nudAway.Size = New System.Drawing.Size(41, 20)
        Me.nudAway.TabIndex = 3
        '
        'lblAwayGoal
        '
        Me.lblAwayGoal.AutoSize = True
        Me.lblAwayGoal.Location = New System.Drawing.Point(16, 60)
        Me.lblAwayGoal.Name = "lblAwayGoal"
        Me.lblAwayGoal.Size = New System.Drawing.Size(63, 13)
        Me.lblAwayGoal.TabIndex = 2
        Me.lblAwayGoal.Text = "Away Goals"
        '
        'tbAwayTeam
        '
        Me.tbAwayTeam.Location = New System.Drawing.Point(99, 27)
        Me.tbAwayTeam.Name = "tbAwayTeam"
        Me.tbAwayTeam.Size = New System.Drawing.Size(144, 20)
        Me.tbAwayTeam.TabIndex = 1
        '
        'lblAwayTeam
        '
        Me.lblAwayTeam.AutoSize = True
        Me.lblAwayTeam.Location = New System.Drawing.Point(16, 30)
        Me.lblAwayTeam.Name = "lblAwayTeam"
        Me.lblAwayTeam.Size = New System.Drawing.Size(63, 13)
        Me.lblAwayTeam.TabIndex = 0
        Me.lblAwayTeam.Text = "Away Team"
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(112, 362)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 2
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'frmDesk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 397)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.gbAwayTeam)
        Me.Controls.Add(Me.gbHomeTeam)
        Me.Name = "frmDesk"
        Me.Text = "frmDesk"
        Me.TopMost = True
        Me.gbHomeTeam.ResumeLayout(False)
        Me.gbHomeTeam.PerformLayout()
        CType(Me.pbHomeLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAwayTeam.ResumeLayout(False)
        Me.gbAwayTeam.PerformLayout()
        CType(Me.pbAwayLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAway, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbHomeTeam As GroupBox
    Friend WithEvents lblHomeTeam As Label
    Friend WithEvents btnBrowseH As Button
    Friend WithEvents pbHomeLogo As PictureBox
    Friend WithEvents lblHomeLogo As Label
    Friend WithEvents nudHome As NumericUpDown
    Friend WithEvents lblHomeGoal As Label
    Friend WithEvents tbHomeTeam As TextBox
    Friend WithEvents gbAwayTeam As GroupBox
    Friend WithEvents btnBrowseA As Button
    Friend WithEvents pbAwayLogo As PictureBox
    Friend WithEvents lblAwayLogo As Label
    Friend WithEvents nudAway As NumericUpDown
    Friend WithEvents lblAwayGoal As Label
    Friend WithEvents tbAwayTeam As TextBox
    Friend WithEvents lblAwayTeam As Label
    Friend WithEvents btnEnviar As Button
End Class
