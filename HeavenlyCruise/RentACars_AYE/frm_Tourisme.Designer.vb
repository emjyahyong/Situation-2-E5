<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Tourisme
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
        Me.txt_marque = New System.Windows.Forms.TextBox()
        Me.txt_tarif = New System.Windows.Forms.TextBox()
        Me.txt_nbPortes = New System.Windows.Forms.TextBox()
        Me.txt_nbBagages = New System.Windows.Forms.TextBox()
        Me.txt_nbPassagers = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.rdb_climOui = New System.Windows.Forms.RadioButton()
        Me.rdb_climNon = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'txt_marque
        '
        Me.txt_marque.Location = New System.Drawing.Point(508, 142)
        Me.txt_marque.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_marque.Name = "txt_marque"
        Me.txt_marque.Size = New System.Drawing.Size(148, 26)
        Me.txt_marque.TabIndex = 0
        '
        'txt_tarif
        '
        Me.txt_tarif.Location = New System.Drawing.Point(508, 205)
        Me.txt_tarif.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_tarif.Name = "txt_tarif"
        Me.txt_tarif.Size = New System.Drawing.Size(148, 26)
        Me.txt_tarif.TabIndex = 1
        '
        'txt_nbPortes
        '
        Me.txt_nbPortes.Location = New System.Drawing.Point(508, 331)
        Me.txt_nbPortes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_nbPortes.Name = "txt_nbPortes"
        Me.txt_nbPortes.Size = New System.Drawing.Size(148, 26)
        Me.txt_nbPortes.TabIndex = 3
        '
        'txt_nbBagages
        '
        Me.txt_nbBagages.Location = New System.Drawing.Point(508, 455)
        Me.txt_nbBagages.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_nbBagages.Name = "txt_nbBagages"
        Me.txt_nbBagages.Size = New System.Drawing.Size(148, 26)
        Me.txt_nbBagages.TabIndex = 5
        '
        'txt_nbPassagers
        '
        Me.txt_nbPassagers.Location = New System.Drawing.Point(508, 392)
        Me.txt_nbPassagers.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_nbPassagers.Name = "txt_nbPassagers"
        Me.txt_nbPassagers.Size = New System.Drawing.Size(148, 26)
        Me.txt_nbPassagers.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(334, 146)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Marque de la voiture"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(334, 215)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Tarif journalier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(334, 342)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nombre de portes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(334, 278)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Climatisation"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(334, 403)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Nombre de passagers"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(334, 466)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nombre de bagages"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(396, 69)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(190, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Nouveau véhicule touriste"
        '
        'btn_ajouter
        '
        Me.btn_ajouter.Location = New System.Drawing.Point(446, 562)
        Me.btn_ajouter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(112, 35)
        Me.btn_ajouter.TabIndex = 13
        Me.btn_ajouter.Text = "Ajouter"
        Me.btn_ajouter.UseVisualStyleBackColor = True
        '
        'rdb_climOui
        '
        Me.rdb_climOui.AutoSize = True
        Me.rdb_climOui.Location = New System.Drawing.Point(508, 278)
        Me.rdb_climOui.Name = "rdb_climOui"
        Me.rdb_climOui.Size = New System.Drawing.Size(58, 24)
        Me.rdb_climOui.TabIndex = 14
        Me.rdb_climOui.TabStop = True
        Me.rdb_climOui.Text = "Oui"
        Me.rdb_climOui.UseVisualStyleBackColor = True
        '
        'rdb_climNon
        '
        Me.rdb_climNon.AutoSize = True
        Me.rdb_climNon.Location = New System.Drawing.Point(593, 278)
        Me.rdb_climNon.Name = "rdb_climNon"
        Me.rdb_climNon.Size = New System.Drawing.Size(63, 24)
        Me.rdb_climNon.TabIndex = 15
        Me.rdb_climNon.TabStop = True
        Me.rdb_climNon.Text = "Non"
        Me.rdb_climNon.UseVisualStyleBackColor = True
        '
        'frm_Tourisme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.rdb_climNon)
        Me.Controls.Add(Me.rdb_climOui)
        Me.Controls.Add(Me.btn_ajouter)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nbBagages)
        Me.Controls.Add(Me.txt_nbPassagers)
        Me.Controls.Add(Me.txt_nbPortes)
        Me.Controls.Add(Me.txt_tarif)
        Me.Controls.Add(Me.txt_marque)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_Tourisme"
        Me.Text = "Ajout d'un nouveau véhicule touriste"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_marque As TextBox
    Friend WithEvents txt_tarif As TextBox
    Friend WithEvents txt_nbPortes As TextBox
    Friend WithEvents txt_nbBagages As TextBox
    Friend WithEvents txt_nbPassagers As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents rdb_climOui As RadioButton
    Friend WithEvents rdb_climNon As RadioButton
End Class
