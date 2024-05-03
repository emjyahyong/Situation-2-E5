<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Categorie
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_categ = New System.Windows.Forms.Label()
        Me.dgvCategorie = New System.Windows.Forms.DataGridView()
        Me.btn_tourisme = New System.Windows.Forms.RadioButton()
        Me.btn_utilitaire = New System.Windows.Forms.RadioButton()
        Me.btn_ajout = New System.Windows.Forms.Button()
        Me.btn_reservation = New System.Windows.Forms.Button()
        Me.btn_consultReservation = New System.Windows.Forms.Button()
        CType(Me.dgvCategorie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_categ
        '
        Me.lbl_categ.AutoSize = True
        Me.lbl_categ.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_categ.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_categ.Location = New System.Drawing.Point(72, 40)
        Me.lbl_categ.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_categ.Name = "lbl_categ"
        Me.lbl_categ.Size = New System.Drawing.Size(414, 33)
        Me.lbl_categ.TabIndex = 0
        Me.lbl_categ.Text = "Nos Catégories de véhicules"
        '
        'dgvCategorie
        '
        Me.dgvCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategorie.Location = New System.Drawing.Point(238, 98)
        Me.dgvCategorie.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvCategorie.Name = "dgvCategorie"
        Me.dgvCategorie.RowHeadersWidth = 62
        Me.dgvCategorie.Size = New System.Drawing.Size(762, 540)
        Me.dgvCategorie.TabIndex = 1
        '
        'btn_tourisme
        '
        Me.btn_tourisme.AutoSize = True
        Me.btn_tourisme.Location = New System.Drawing.Point(51, 197)
        Me.btn_tourisme.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_tourisme.Name = "btn_tourisme"
        Me.btn_tourisme.Size = New System.Drawing.Size(99, 24)
        Me.btn_tourisme.TabIndex = 3
        Me.btn_tourisme.Text = "Tourisme"
        Me.btn_tourisme.UseVisualStyleBackColor = True
        '
        'btn_utilitaire
        '
        Me.btn_utilitaire.AutoSize = True
        Me.btn_utilitaire.Location = New System.Drawing.Point(51, 260)
        Me.btn_utilitaire.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_utilitaire.Name = "btn_utilitaire"
        Me.btn_utilitaire.Size = New System.Drawing.Size(91, 24)
        Me.btn_utilitaire.TabIndex = 4
        Me.btn_utilitaire.TabStop = True
        Me.btn_utilitaire.Text = "Utilitaire"
        Me.btn_utilitaire.UseVisualStyleBackColor = True
        '
        'btn_ajout
        '
        Me.btn_ajout.Location = New System.Drawing.Point(51, 521)
        Me.btn_ajout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_ajout.Name = "btn_ajout"
        Me.btn_ajout.Size = New System.Drawing.Size(146, 63)
        Me.btn_ajout.TabIndex = 5
        Me.btn_ajout.Text = "Ajouter véhicule"
        Me.btn_ajout.UseVisualStyleBackColor = True
        Me.btn_ajout.Visible = False
        '
        'btn_reservation
        '
        Me.btn_reservation.Location = New System.Drawing.Point(51, 321)
        Me.btn_reservation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_reservation.Name = "btn_reservation"
        Me.btn_reservation.Size = New System.Drawing.Size(146, 63)
        Me.btn_reservation.TabIndex = 6
        Me.btn_reservation.Text = "Réserver véhicule"
        Me.btn_reservation.UseVisualStyleBackColor = True
        '
        'btn_consultReservation
        '
        Me.btn_consultReservation.Location = New System.Drawing.Point(51, 411)
        Me.btn_consultReservation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_consultReservation.Name = "btn_consultReservation"
        Me.btn_consultReservation.Size = New System.Drawing.Size(146, 81)
        Me.btn_consultReservation.TabIndex = 7
        Me.btn_consultReservation.Text = "Consulter véhicules réservés"
        Me.btn_consultReservation.UseVisualStyleBackColor = True
        Me.btn_consultReservation.Visible = False
        '
        'frm_Categorie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.btn_consultReservation)
        Me.Controls.Add(Me.btn_reservation)
        Me.Controls.Add(Me.btn_ajout)
        Me.Controls.Add(Me.btn_utilitaire)
        Me.Controls.Add(Me.btn_tourisme)
        Me.Controls.Add(Me.dgvCategorie)
        Me.Controls.Add(Me.lbl_categ)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_Categorie"
        Me.Text = "Categories"
        CType(Me.dgvCategorie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_categ As Label
    Friend WithEvents dgvCategorie As DataGridView
    Friend WithEvents btn_tourisme As RadioButton
    Friend WithEvents btn_utilitaire As RadioButton
    Friend WithEvents btn_ajout As Button
    Friend WithEvents btn_reservation As Button
    Friend WithEvents btn_consultReservation As Button
End Class
