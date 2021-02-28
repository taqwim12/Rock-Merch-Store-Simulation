<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderForm
    Inherits System.Windows.Forms.Form

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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbItems = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBsizeS = New System.Windows.Forms.CheckBox()
        Me.CBsizeL = New System.Windows.Forms.CheckBox()
        Me.CBsizeM = New System.Windows.Forms.CheckBox()
        Me.lblSleeve = New System.Windows.Forms.Label()
        Me.SleeveL = New System.Windows.Forms.RadioButton()
        Me.SleeveS = New System.Windows.Forms.RadioButton()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.lbltPrice = New System.Windows.Forms.Label()
        Me.lblPricee = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIDForm = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Items Name :"
        '
        'CmbItems
        '
        Me.CmbItems.FormattingEnabled = True
        Me.CmbItems.Items.AddRange(New Object() {"ACDC Logo T-Shirt", "GNR Logo T-Shirt", "LOG Logo T-Shirt", "Metallica Logo T-Shirt", "Nirvana Smiley T-Shirt", "The Clash Logo T-Shirt"})
        Me.CmbItems.Location = New System.Drawing.Point(16, 46)
        Me.CmbItems.Name = "CmbItems"
        Me.CmbItems.Size = New System.Drawing.Size(262, 21)
        Me.CmbItems.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Size :"
        '
        'CBsizeS
        '
        Me.CBsizeS.AutoSize = True
        Me.CBsizeS.Location = New System.Drawing.Point(16, 105)
        Me.CBsizeS.Name = "CBsizeS"
        Me.CBsizeS.Size = New System.Drawing.Size(33, 17)
        Me.CBsizeS.TabIndex = 21
        Me.CBsizeS.Text = "S"
        Me.CBsizeS.UseVisualStyleBackColor = True
        '
        'CBsizeL
        '
        Me.CBsizeL.AutoSize = True
        Me.CBsizeL.Location = New System.Drawing.Point(246, 105)
        Me.CBsizeL.Name = "CBsizeL"
        Me.CBsizeL.Size = New System.Drawing.Size(32, 17)
        Me.CBsizeL.TabIndex = 22
        Me.CBsizeL.Text = "L"
        Me.CBsizeL.UseVisualStyleBackColor = True
        '
        'CBsizeM
        '
        Me.CBsizeM.AutoSize = True
        Me.CBsizeM.Location = New System.Drawing.Point(125, 105)
        Me.CBsizeM.Name = "CBsizeM"
        Me.CBsizeM.Size = New System.Drawing.Size(35, 17)
        Me.CBsizeM.TabIndex = 23
        Me.CBsizeM.Text = "M"
        Me.CBsizeM.UseVisualStyleBackColor = True
        '
        'lblSleeve
        '
        Me.lblSleeve.AutoSize = True
        Me.lblSleeve.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSleeve.Location = New System.Drawing.Point(12, 139)
        Me.lblSleeve.Name = "lblSleeve"
        Me.lblSleeve.Size = New System.Drawing.Size(65, 20)
        Me.lblSleeve.TabIndex = 24
        Me.lblSleeve.Text = "Sleeve :"
        '
        'SleeveL
        '
        Me.SleeveL.AutoSize = True
        Me.SleeveL.Location = New System.Drawing.Point(122, 162)
        Me.SleeveL.Name = "SleeveL"
        Me.SleeveL.Size = New System.Drawing.Size(49, 17)
        Me.SleeveL.TabIndex = 26
        Me.SleeveL.TabStop = True
        Me.SleeveL.Text = "Long"
        Me.SleeveL.UseVisualStyleBackColor = True
        '
        'SleeveS
        '
        Me.SleeveS.AutoSize = True
        Me.SleeveS.Location = New System.Drawing.Point(16, 162)
        Me.SleeveS.Name = "SleeveS"
        Me.SleeveS.Size = New System.Drawing.Size(50, 17)
        Me.SleeveS.TabIndex = 25
        Me.SleeveS.TabStop = True
        Me.SleeveS.Text = "Short"
        Me.SleeveS.UseVisualStyleBackColor = True
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(12, 203)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(76, 20)
        Me.lblQuantity.TabIndex = 28
        Me.lblQuantity.Text = "Quantity :"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(113, 203)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(67, 20)
        Me.NumericUpDown1.TabIndex = 27
        '
        'lbltPrice
        '
        Me.lbltPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltPrice.Location = New System.Drawing.Point(111, 256)
        Me.lbltPrice.Name = "lbltPrice"
        Me.lbltPrice.Size = New System.Drawing.Size(167, 20)
        Me.lbltPrice.TabIndex = 30
        Me.lbltPrice.Text = "_"
        '
        'lblPricee
        '
        Me.lblPricee.AutoSize = True
        Me.lblPricee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPricee.Location = New System.Drawing.Point(14, 256)
        Me.lblPricee.Name = "lblPricee"
        Me.lblPricee.Size = New System.Drawing.Size(52, 20)
        Me.lblPricee.TabIndex = 29
        Me.lblPricee.Text = "Price :"
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(93, 337)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(161, 38)
        Me.btnsave.TabIndex = 31
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(239, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "ID : "
        '
        'lblIDForm
        '
        Me.lblIDForm.AutoSize = True
        Me.lblIDForm.Location = New System.Drawing.Point(284, 23)
        Me.lblIDForm.Name = "lblIDForm"
        Me.lblIDForm.Size = New System.Drawing.Size(13, 13)
        Me.lblIDForm.TabIndex = 33
        Me.lblIDForm.Text = "_"
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 426)
        Me.Controls.Add(Me.lblIDForm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.lbltPrice)
        Me.Controls.Add(Me.lblPricee)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.SleeveL)
        Me.Controls.Add(Me.SleeveS)
        Me.Controls.Add(Me.lblSleeve)
        Me.Controls.Add(Me.CBsizeM)
        Me.Controls.Add(Me.CBsizeL)
        Me.Controls.Add(Me.CBsizeS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbItems)
        Me.Controls.Add(Me.Label2)
        Me.Name = "OrderForm"
        Me.Text = "OrderForm"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents CmbItems As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CBsizeS As CheckBox
    Friend WithEvents CBsizeL As CheckBox
    Friend WithEvents CBsizeM As CheckBox
    Friend WithEvents lblSleeve As Label
    Friend WithEvents SleeveL As RadioButton
    Friend WithEvents SleeveS As RadioButton
    Friend WithEvents lblQuantity As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents lbltPrice As Label
    Friend WithEvents lblPricee As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblIDForm As Label
End Class
