<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class suggestionlistb
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listbSuggestion = New System.Windows.Forms.ListBox()
        Me.txtOpinion = New System.Windows.Forms.TextBox()
        Me.btnSuggestion = New System.Windows.Forms.Button()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(230, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Give Your Suggestion"
        '
        'listbSuggestion
        '
        Me.listbSuggestion.FormattingEnabled = True
        Me.listbSuggestion.Location = New System.Drawing.Point(8, 9)
        Me.listbSuggestion.Name = "listbSuggestion"
        Me.listbSuggestion.Size = New System.Drawing.Size(279, 121)
        Me.listbSuggestion.TabIndex = 1
        '
        'txtOpinion
        '
        Me.txtOpinion.Location = New System.Drawing.Point(8, 9)
        Me.txtOpinion.Multiline = True
        Me.txtOpinion.Name = "txtOpinion"
        Me.txtOpinion.Size = New System.Drawing.Size(344, 118)
        Me.txtOpinion.TabIndex = 2
        '
        'btnSuggestion
        '
        Me.btnSuggestion.Location = New System.Drawing.Point(8, 133)
        Me.btnSuggestion.Name = "btnSuggestion"
        Me.btnSuggestion.Size = New System.Drawing.Size(75, 23)
        Me.btnSuggestion.TabIndex = 3
        Me.btnSuggestion.Text = "Click Me"
        Me.btnSuggestion.UseVisualStyleBackColor = True
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.Location = New System.Drawing.Point(16, 140)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(0, 13)
        Me.lblConfirm.TabIndex = 4
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 80)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtOpinion)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSuggestion)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.SplitContainer1.Panel2.Controls.Add(Me.listbSuggestion)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblConfirm)
        Me.SplitContainer1.Size = New System.Drawing.Size(708, 257)
        Me.SplitContainer1.SplitterDistance = 381
        Me.SplitContainer1.TabIndex = 5
        '
        'suggestionlistb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 368)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "suggestionlistb"
        Me.Text = "Suggestion Form"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents listbSuggestion As ListBox
    Friend WithEvents txtOpinion As TextBox
    Friend WithEvents btnSuggestion As Button
    Friend WithEvents lblConfirm As Label
    Friend WithEvents SplitContainer1 As SplitContainer
End Class
