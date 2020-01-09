<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pFactor
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pFactor))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tInit = New System.Windows.Forms.ToolStripStatusLabel()
        Me.i_info = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lTiers = New System.Windows.Forms.ComboBox()
        Me.gExport = New System.Windows.Forms.DataGridView()
        Me.TiersId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DernierExport = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tTiers = New System.Windows.Forms.LinkLabel()
        Me.bExport = New System.Windows.Forms.Button()
        Me.bMEF = New System.Windows.Forms.Button()
        Me.lFGL = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.gExport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(22, 22)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tInit, Me.i_info})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 501)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(190, 27)
        Me.StatusStrip1.TabIndex = 25
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tInit
        '
        Me.tInit.DoubleClickEnabled = True
        Me.tInit.Name = "tInit"
        Me.tInit.Size = New System.Drawing.Size(24, 22)
        Me.tInit.Text = "init"
        '
        'i_info
        '
        Me.i_info.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.i_info.Image = CType(resources.GetObject("i_info.Image"), System.Drawing.Image)
        Me.i_info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.i_info.IsLink = True
        Me.i_info.Name = "i_info"
        Me.i_info.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.i_info.Size = New System.Drawing.Size(120, 22)
        Me.i_info.Spring = True
        Me.i_info.Tag = ""
        Me.i_info.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lTiers
        '
        Me.lTiers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lTiers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lTiers.FormattingEnabled = True
        Me.lTiers.Location = New System.Drawing.Point(42, 15)
        Me.lTiers.Name = "lTiers"
        Me.lTiers.Size = New System.Drawing.Size(145, 21)
        Me.lTiers.TabIndex = 26
        '
        'gExport
        '
        Me.gExport.AllowUserToAddRows = False
        Me.gExport.AllowUserToDeleteRows = False
        Me.gExport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gExport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gExport.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.gExport.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gExport.ColumnHeadersHeight = 30
        Me.gExport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TiersId, Me.DernierExport})
        Me.gExport.Location = New System.Drawing.Point(6, 135)
        Me.gExport.MultiSelect = False
        Me.gExport.Name = "gExport"
        Me.gExport.ReadOnly = True
        Me.gExport.RowHeadersVisible = False
        Me.gExport.RowHeadersWidth = 32
        Me.gExport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gExport.Size = New System.Drawing.Size(181, 348)
        Me.gExport.TabIndex = 27
        '
        'TiersId
        '
        Me.TiersId.FillWeight = 60.0!
        Me.TiersId.HeaderText = "Id"
        Me.TiersId.Name = "TiersId"
        Me.TiersId.ReadOnly = True
        Me.TiersId.Visible = False
        '
        'DernierExport
        '
        Me.DernierExport.HeaderText = "Derniers Exports"
        Me.DernierExport.Name = "DernierExport"
        Me.DernierExport.ReadOnly = True
        '
        'tTiers
        '
        Me.tTiers.AutoSize = True
        Me.tTiers.Location = New System.Drawing.Point(3, 18)
        Me.tTiers.Name = "tTiers"
        Me.tTiers.Size = New System.Drawing.Size(33, 13)
        Me.tTiers.TabIndex = 28
        Me.tTiers.TabStop = True
        Me.tTiers.Text = "Client"
        '
        'bExport
        '
        Me.bExport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bExport.Enabled = False
        Me.bExport.Location = New System.Drawing.Point(6, 102)
        Me.bExport.Name = "bExport"
        Me.bExport.Size = New System.Drawing.Size(181, 27)
        Me.bExport.TabIndex = 29
        Me.bExport.Text = "Exporter"
        Me.bExport.UseVisualStyleBackColor = True
        '
        'bMEF
        '
        Me.bMEF.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bMEF.Enabled = False
        Me.bMEF.Location = New System.Drawing.Point(6, 69)
        Me.bMEF.Name = "bMEF"
        Me.bMEF.Size = New System.Drawing.Size(181, 27)
        Me.bMEF.TabIndex = 30
        Me.bMEF.Text = "Mise en forme"
        Me.bMEF.UseVisualStyleBackColor = True
        '
        'lFGL
        '
        Me.lFGL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lFGL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lFGL.FormattingEnabled = True
        Me.lFGL.Location = New System.Drawing.Point(42, 42)
        Me.lFGL.Name = "lFGL"
        Me.lFGL.Size = New System.Drawing.Size(145, 21)
        Me.lFGL.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "GL"
        '
        'pFactor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lFGL)
        Me.Controls.Add(Me.bMEF)
        Me.Controls.Add(Me.bExport)
        Me.Controls.Add(Me.tTiers)
        Me.Controls.Add(Me.gExport)
        Me.Controls.Add(Me.lTiers)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "pFactor"
        Me.Size = New System.Drawing.Size(190, 528)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.gExport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As Windows.Forms.StatusStrip
    Friend WithEvents tInit As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents i_info As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lTiers As Windows.Forms.ComboBox
    Friend WithEvents gExport As Windows.Forms.DataGridView
    Friend WithEvents tTiers As Windows.Forms.LinkLabel
    Friend WithEvents bExport As Windows.Forms.Button
    Friend WithEvents bMEF As Windows.Forms.Button
    Friend WithEvents lFGL As Windows.Forms.ComboBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TiersId As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DernierExport As Windows.Forms.DataGridViewTextBoxColumn
End Class
