<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pTVA
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pTVA))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tInit = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cFTVA = New System.Windows.Forms.ComboBox()
        Me.cOTVA = New System.Windows.Forms.ComboBox()
        Me.fTVA = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cFGL = New System.Windows.Forms.ComboBox()
        Me.cOGL = New System.Windows.Forms.ComboBox()
        Me.tAnnee = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.i_info = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.fTVA.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(22, 22)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tInit, Me.i_info})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 545)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(167, 27)
        Me.StatusStrip1.TabIndex = 24
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tInit
        '
        Me.tInit.DoubleClickEnabled = True
        Me.tInit.Name = "tInit"
        Me.tInit.Size = New System.Drawing.Size(24, 22)
        Me.tInit.Text = "init"
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(9, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 29)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Recherche"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cFTVA
        '
        Me.cFTVA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cFTVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cFTVA.FormattingEnabled = True
        Me.cFTVA.Location = New System.Drawing.Point(6, 28)
        Me.cFTVA.Name = "cFTVA"
        Me.cFTVA.Size = New System.Drawing.Size(149, 21)
        Me.cFTVA.TabIndex = 40
        '
        'cOTVA
        '
        Me.cOTVA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cOTVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cOTVA.FormattingEnabled = True
        Me.cOTVA.Location = New System.Drawing.Point(6, 55)
        Me.cOTVA.Name = "cOTVA"
        Me.cOTVA.Size = New System.Drawing.Size(149, 21)
        Me.cOTVA.TabIndex = 41
        '
        'fTVA
        '
        Me.fTVA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fTVA.Controls.Add(Me.cFTVA)
        Me.fTVA.Controls.Add(Me.cOTVA)
        Me.fTVA.Location = New System.Drawing.Point(3, 123)
        Me.fTVA.Name = "fTVA"
        Me.fTVA.Size = New System.Drawing.Size(161, 88)
        Me.fTVA.TabIndex = 44
        Me.fTVA.TabStop = False
        Me.fTVA.Text = "Fichier TVA"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cFGL)
        Me.GroupBox1.Controls.Add(Me.cOGL)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(161, 88)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Grand Livre"
        '
        'cFGL
        '
        Me.cFGL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cFGL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cFGL.FormattingEnabled = True
        Me.cFGL.Location = New System.Drawing.Point(6, 28)
        Me.cFGL.Name = "cFGL"
        Me.cFGL.Size = New System.Drawing.Size(149, 21)
        Me.cFGL.TabIndex = 40
        '
        'cOGL
        '
        Me.cOGL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cOGL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cOGL.FormattingEnabled = True
        Me.cOGL.Location = New System.Drawing.Point(6, 55)
        Me.cOGL.Name = "cOGL"
        Me.cOGL.Size = New System.Drawing.Size(149, 21)
        Me.cOGL.TabIndex = 41
        '
        'tAnnee
        '
        Me.tAnnee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tAnnee.Location = New System.Drawing.Point(112, 8)
        Me.tAnnee.Name = "tAnnee"
        Me.tAnnee.Size = New System.Drawing.Size(52, 20)
        Me.tAnnee.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Année"
        '
        'i_info
        '
        Me.i_info.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.i_info.Image = CType(resources.GetObject("i_info.Image"), System.Drawing.Image)
        Me.i_info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.i_info.IsLink = True
        Me.i_info.Name = "i_info"
        Me.i_info.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.i_info.Size = New System.Drawing.Size(128, 22)
        Me.i_info.Spring = True
        Me.i_info.Tag = ""
        Me.i_info.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pTVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tAnnee)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fTVA)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "pTVA"
        Me.Size = New System.Drawing.Size(167, 572)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.fTVA.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tInit As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cFTVA As Windows.Forms.ComboBox
    Friend WithEvents cOTVA As Windows.Forms.ComboBox
    Friend WithEvents fTVA As Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents cFGL As Windows.Forms.ComboBox
    Friend WithEvents cOGL As Windows.Forms.ComboBox
    Friend WithEvents tAnnee As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents i_info As Windows.Forms.ToolStripStatusLabel
End Class
