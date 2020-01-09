<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTiers
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
        Me.bOK = New System.Windows.Forms.Button()
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tNom = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bOK
        '
        Me.bOK.Location = New System.Drawing.Point(255, 121)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(94, 38)
        Me.bOK.TabIndex = 0
        Me.bOK.Text = "Enregistrer"
        Me.bOK.UseVisualStyleBackColor = True
        '
        'bAnnul
        '
        Me.bAnnul.Location = New System.Drawing.Point(26, 121)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(94, 38)
        Me.bAnnul.TabIndex = 1
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(22, 29)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(29, 13)
        Me.label1.TabIndex = 2
        Me.label1.Tag = ""
        Me.label1.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Raison Sociale"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Siret"
        '
        'tNom
        '
        Me.tNom.Location = New System.Drawing.Point(106, 26)
        Me.tNom.Name = "tNom"
        Me.tNom.Size = New System.Drawing.Size(200, 20)
        Me.tNom.TabIndex = 6
        Me.tNom.Tag = "TiersNom,to"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(106, 52)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(243, 20)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.Tag = "RaisonSociale,to"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(106, 78)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(243, 20)
        Me.TextBox3.TabIndex = 6
        Me.TextBox3.Tag = "Siret,to"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(312, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(37, 13)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Tag = "TiersId,k"
        '
        'FrmTiers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 181)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.tNom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.bOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmTiers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tiers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bOK As Windows.Forms.Button
    Friend WithEvents bAnnul As Windows.Forms.Button
    Friend WithEvents label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents tNom As Windows.Forms.TextBox
    Friend WithEvents TextBox2 As Windows.Forms.TextBox
    Friend WithEvents TextBox3 As Windows.Forms.TextBox
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
End Class
