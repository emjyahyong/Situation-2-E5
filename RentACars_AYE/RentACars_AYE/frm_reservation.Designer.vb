<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_reservation
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_telephone = New System.Windows.Forms.TextBox()
        Me.btn_reserver = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_voiture = New System.Windows.Forms.Label()
        Me.txt_codePostal = New System.Windows.Forms.TextBox()
        Me.txt_ville = New System.Windows.Forms.TextBox()
        Me.txt_adresse = New System.Windows.Forms.TextBox()
        Me.txt_prenom = New System.Windows.Forms.TextBox()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.btn_mr = New System.Windows.Forms.RadioButton()
        Me.btn_mme = New System.Windows.Forms.RadioButton()
        Me.date_depart = New System.Windows.Forms.DateTimePicker()
        Me.date_retour = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(430, 529)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 20)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Téléphone"
        '
        'txt_telephone
        '
        Me.txt_telephone.Location = New System.Drawing.Point(604, 520)
        Me.txt_telephone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_telephone.Name = "txt_telephone"
        Me.txt_telephone.Size = New System.Drawing.Size(148, 26)
        Me.txt_telephone.TabIndex = 44
        '
        'btn_reserver
        '
        Me.btn_reserver.Location = New System.Drawing.Point(547, 588)
        Me.btn_reserver.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_reserver.Name = "btn_reserver"
        Me.btn_reserver.Size = New System.Drawing.Size(112, 35)
        Me.btn_reserver.TabIndex = 43
        Me.btn_reserver.Text = "Réserver"
        Me.btn_reserver.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(492, 43)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 20)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Nouvelle réservation"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(430, 463)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Code postal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(430, 400)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 20)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Ville"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(430, 338)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Adresse"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(430, 275)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Prénom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(430, 212)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 20)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Nom"
        '
        'lbl_voiture
        '
        Me.lbl_voiture.AutoSize = True
        Me.lbl_voiture.Location = New System.Drawing.Point(430, 101)
        Me.lbl_voiture.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_voiture.Name = "lbl_voiture"
        Me.lbl_voiture.Size = New System.Drawing.Size(137, 20)
        Me.lbl_voiture.TabIndex = 36
        Me.lbl_voiture.Text = "Voiture réservée : "
        '
        'txt_codePostal
        '
        Me.txt_codePostal.Location = New System.Drawing.Point(604, 454)
        Me.txt_codePostal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_codePostal.Name = "txt_codePostal"
        Me.txt_codePostal.Size = New System.Drawing.Size(148, 26)
        Me.txt_codePostal.TabIndex = 35
        '
        'txt_ville
        '
        Me.txt_ville.Location = New System.Drawing.Point(604, 391)
        Me.txt_ville.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_ville.Name = "txt_ville"
        Me.txt_ville.Size = New System.Drawing.Size(148, 26)
        Me.txt_ville.TabIndex = 34
        '
        'txt_adresse
        '
        Me.txt_adresse.Location = New System.Drawing.Point(604, 330)
        Me.txt_adresse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_adresse.Name = "txt_adresse"
        Me.txt_adresse.Size = New System.Drawing.Size(148, 26)
        Me.txt_adresse.TabIndex = 33
        '
        'txt_prenom
        '
        Me.txt_prenom.Location = New System.Drawing.Point(604, 267)
        Me.txt_prenom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_prenom.Name = "txt_prenom"
        Me.txt_prenom.Size = New System.Drawing.Size(148, 26)
        Me.txt_prenom.TabIndex = 32
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(604, 208)
        Me.txt_nom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(148, 26)
        Me.txt_nom.TabIndex = 31
        '
        'btn_mr
        '
        Me.btn_mr.AutoSize = True
        Me.btn_mr.Location = New System.Drawing.Point(434, 157)
        Me.btn_mr.Name = "btn_mr"
        Me.btn_mr.Size = New System.Drawing.Size(51, 24)
        Me.btn_mr.TabIndex = 46
        Me.btn_mr.TabStop = True
        Me.btn_mr.Text = "M."
        Me.btn_mr.UseVisualStyleBackColor = True
        '
        'btn_mme
        '
        Me.btn_mme.AutoSize = True
        Me.btn_mme.Location = New System.Drawing.Point(604, 157)
        Me.btn_mme.Name = "btn_mme"
        Me.btn_mme.Size = New System.Drawing.Size(73, 24)
        Me.btn_mme.TabIndex = 47
        Me.btn_mme.TabStop = True
        Me.btn_mme.Text = "Mme."
        Me.btn_mme.UseVisualStyleBackColor = True
        '
        'date_depart
        '
        Me.date_depart.Location = New System.Drawing.Point(101, 145)
        Me.date_depart.Name = "date_depart"
        Me.date_depart.Size = New System.Drawing.Size(200, 26)
        Me.date_depart.TabIndex = 48
        '
        'date_retour
        '
        Me.date_retour.Location = New System.Drawing.Point(101, 224)
        Me.date_retour.Name = "date_retour"
        Me.date_retour.Size = New System.Drawing.Size(200, 26)
        Me.date_retour.TabIndex = 49
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(46, 230)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 20)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "au"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(46, 145)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 20)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Du "
        '
        'frm_reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.date_retour)
        Me.Controls.Add(Me.date_depart)
        Me.Controls.Add(Me.btn_mme)
        Me.Controls.Add(Me.btn_mr)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_telephone)
        Me.Controls.Add(Me.btn_reserver)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_voiture)
        Me.Controls.Add(Me.txt_codePostal)
        Me.Controls.Add(Me.txt_ville)
        Me.Controls.Add(Me.txt_adresse)
        Me.Controls.Add(Me.txt_prenom)
        Me.Controls.Add(Me.txt_nom)
        Me.Name = "frm_reservation"
        Me.Text = "frm_reservation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents txt_telephone As TextBox
    Friend WithEvents btn_reserver As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_voiture As Label
    Friend WithEvents txt_codePostal As TextBox
    Friend WithEvents txt_ville As TextBox
    Friend WithEvents txt_adresse As TextBox
    Friend WithEvents txt_prenom As TextBox
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents btn_mr As RadioButton
    Friend WithEvents btn_mme As RadioButton
    Friend WithEvents date_depart As DateTimePicker
    Friend WithEvents date_retour As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
