﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Utilitaire
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
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_largeur = New System.Windows.Forms.TextBox()
        Me.txt_longueur = New System.Windows.Forms.TextBox()
        Me.txt_chargeUtile = New System.Windows.Forms.TextBox()
        Me.txt_volume = New System.Windows.Forms.TextBox()
        Me.txt_tarif = New System.Windows.Forms.TextBox()
        Me.txt_marque = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_hauteur = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_ajouter
        '
        Me.btn_ajouter.Location = New System.Drawing.Point(555, 611)
        Me.btn_ajouter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(112, 35)
        Me.btn_ajouter.TabIndex = 27
        Me.btn_ajouter.Text = "Ajouter"
        Me.btn_ajouter.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(500, 83)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(191, 20)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Nouveau véhicule utilitaire"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(438, 480)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Largeur"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(438, 417)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Longueur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(438, 355)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Charge Utile"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(438, 292)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Volume"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(438, 229)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Tarif journalier"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(438, 160)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Marque voiture"
        '
        'txt_largeur
        '
        Me.txt_largeur.Location = New System.Drawing.Point(612, 469)
        Me.txt_largeur.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_largeur.Name = "txt_largeur"
        Me.txt_largeur.Size = New System.Drawing.Size(148, 26)
        Me.txt_largeur.TabIndex = 19
        '
        'txt_longueur
        '
        Me.txt_longueur.Location = New System.Drawing.Point(612, 406)
        Me.txt_longueur.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_longueur.Name = "txt_longueur"
        Me.txt_longueur.Size = New System.Drawing.Size(148, 26)
        Me.txt_longueur.TabIndex = 18
        '
        'txt_chargeUtile
        '
        Me.txt_chargeUtile.Location = New System.Drawing.Point(612, 345)
        Me.txt_chargeUtile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_chargeUtile.Name = "txt_chargeUtile"
        Me.txt_chargeUtile.Size = New System.Drawing.Size(148, 26)
        Me.txt_chargeUtile.TabIndex = 17
        '
        'txt_volume
        '
        Me.txt_volume.Location = New System.Drawing.Point(612, 282)
        Me.txt_volume.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_volume.Name = "txt_volume"
        Me.txt_volume.Size = New System.Drawing.Size(148, 26)
        Me.txt_volume.TabIndex = 16
        '
        'txt_tarif
        '
        Me.txt_tarif.Location = New System.Drawing.Point(612, 218)
        Me.txt_tarif.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_tarif.Name = "txt_tarif"
        Me.txt_tarif.Size = New System.Drawing.Size(148, 26)
        Me.txt_tarif.TabIndex = 15
        '
        'txt_marque
        '
        Me.txt_marque.Location = New System.Drawing.Point(612, 155)
        Me.txt_marque.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_marque.Name = "txt_marque"
        Me.txt_marque.Size = New System.Drawing.Size(148, 26)
        Me.txt_marque.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(438, 546)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 20)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Hauteur"
        '
        'txt_hauteur
        '
        Me.txt_hauteur.Location = New System.Drawing.Point(612, 535)
        Me.txt_hauteur.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_hauteur.Name = "txt_hauteur"
        Me.txt_hauteur.Size = New System.Drawing.Size(148, 26)
        Me.txt_hauteur.TabIndex = 28
        '
        'frm_Utilitaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_hauteur)
        Me.Controls.Add(Me.btn_ajouter)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_largeur)
        Me.Controls.Add(Me.txt_longueur)
        Me.Controls.Add(Me.txt_chargeUtile)
        Me.Controls.Add(Me.txt_volume)
        Me.Controls.Add(Me.txt_tarif)
        Me.Controls.Add(Me.txt_marque)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_Utilitaire"
        Me.Text = "Ajout d'un nouveau véhicule utilitaire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_ajouter As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_largeur As TextBox
    Friend WithEvents txt_longueur As TextBox
    Friend WithEvents txt_chargeUtile As TextBox
    Friend WithEvents txt_volume As TextBox
    Friend WithEvents txt_tarif As TextBox
    Friend WithEvents txt_marque As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_hauteur As TextBox
End Class
