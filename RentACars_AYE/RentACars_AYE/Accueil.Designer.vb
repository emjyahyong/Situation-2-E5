<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_categ = New System.Windows.Forms.Label()
        Me.btn_reserver = New System.Windows.Forms.Button()
        Me.btn_reserver2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_categ
        '
        Me.lbl_categ.AutoSize = True
        Me.lbl_categ.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_categ.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_categ.Location = New System.Drawing.Point(98, 84)
        Me.lbl_categ.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_categ.Name = "lbl_categ"
        Me.lbl_categ.Size = New System.Drawing.Size(603, 33)
        Me.lbl_categ.TabIndex = 1
        Me.lbl_categ.Text = "HeavenlyCruise pour une conduite céleste"
        '
        'btn_reserver
        '
        Me.btn_reserver.Location = New System.Drawing.Point(344, 197)
        Me.btn_reserver.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_reserver.Name = "btn_reserver"
        Me.btn_reserver.Size = New System.Drawing.Size(112, 57)
        Me.btn_reserver.TabIndex = 7
        Me.btn_reserver.Text = "Réserver "
        Me.btn_reserver.UseVisualStyleBackColor = True
        '
        'btn_reserver2
        '
        Me.btn_reserver2.BackColor = System.Drawing.SystemColors.Control
        Me.btn_reserver2.Location = New System.Drawing.Point(794, 442)
        Me.btn_reserver2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_reserver2.Name = "btn_reserver2"
        Me.btn_reserver2.Size = New System.Drawing.Size(10, 10)
        Me.btn_reserver2.TabIndex = 8
        Me.btn_reserver2.Text = "Réserver "
        Me.btn_reserver2.UseVisualStyleBackColor = False
        Me.btn_reserver2.Visible = False
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_reserver2)
        Me.Controls.Add(Me.btn_reserver)
        Me.Controls.Add(Me.lbl_categ)
        Me.Name = "Accueil"
        Me.Text = "Accueil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_categ As Label
    Friend WithEvents btn_reserver As Button
    Friend WithEvents btn_reserver2 As Button
End Class
