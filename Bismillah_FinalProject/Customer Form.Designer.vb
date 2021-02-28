<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customer_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer_Form))
        Me.MenuStripCustomer = New System.Windows.Forms.MenuStrip()
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TShirtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DTPcust = New System.Windows.Forms.DateTimePicker()
        Me.ImageListItems = New System.Windows.Forms.ImageList(Me.components)
        Me.ListViewItems = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStripCustomer.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripCustomer
        '
        Me.MenuStripCustomer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderToolStripMenuItem, Me.PaymentToolStripMenuItem})
        Me.MenuStripCustomer.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripCustomer.Name = "MenuStripCustomer"
        Me.MenuStripCustomer.Size = New System.Drawing.Size(709, 24)
        Me.MenuStripCustomer.TabIndex = 0
        Me.MenuStripCustomer.Text = "MenuStrip1"
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemsToolStripMenuItem, Me.TShirtToolStripMenuItem})
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.OrderToolStripMenuItem.Text = "Order"
        '
        'ItemsToolStripMenuItem
        '
        Me.ItemsToolStripMenuItem.Name = "ItemsToolStripMenuItem"
        Me.ItemsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ItemsToolStripMenuItem.Text = "Items List"
        '
        'TShirtToolStripMenuItem
        '
        Me.TShirtToolStripMenuItem.Name = "TShirtToolStripMenuItem"
        Me.TShirtToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TShirtToolStripMenuItem.Text = "Market"
        '
        'PaymentToolStripMenuItem
        '
        Me.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        Me.PaymentToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.PaymentToolStripMenuItem.Text = "Payment"
        '
        'DTPcust
        '
        Me.DTPcust.Location = New System.Drawing.Point(497, 47)
        Me.DTPcust.Name = "DTPcust"
        Me.DTPcust.Size = New System.Drawing.Size(200, 20)
        Me.DTPcust.TabIndex = 1
        '
        'ImageListItems
        '
        Me.ImageListItems.ImageStream = CType(resources.GetObject("ImageListItems.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListItems.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListItems.Images.SetKeyName(0, "band background.png")
        Me.ImageListItems.Images.SetKeyName(1, "Classic Rock Revolution Logos.jpg")
        Me.ImageListItems.Images.SetKeyName(2, "gnr logo tshirt.png")
        Me.ImageListItems.Images.SetKeyName(3, "acdc logo tshirt.png")
        Me.ImageListItems.Images.SetKeyName(4, "lamb of god tshirt.png")
        Me.ImageListItems.Images.SetKeyName(5, "metallica logo tshirt.png")
        Me.ImageListItems.Images.SetKeyName(6, "nirvana smiley tshirt.png")
        Me.ImageListItems.Images.SetKeyName(7, "the clash logo tshirt.png")
        Me.ImageListItems.Images.SetKeyName(8, "acdc logo tshirt.png")
        '
        'ListViewItems
        '
        Me.ListViewItems.LargeImageList = Me.ImageListItems
        Me.ListViewItems.Location = New System.Drawing.Point(12, 74)
        Me.ListViewItems.Name = "ListViewItems"
        Me.ListViewItems.Size = New System.Drawing.Size(685, 164)
        Me.ListViewItems.TabIndex = 2
        Me.ListViewItems.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Items in Pictures List"
        '
        'Customer_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 250)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListViewItems)
        Me.Controls.Add(Me.DTPcust)
        Me.Controls.Add(Me.MenuStripCustomer)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStripCustomer
        Me.Name = "Customer_Form"
        Me.Text = "Customer Form"
        Me.MenuStripCustomer.ResumeLayout(False)
        Me.MenuStripCustomer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStripCustomer As MenuStrip
    Friend WithEvents OrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TShirtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DTPcust As DateTimePicker
    Friend WithEvents ImageListItems As ImageList
    Friend WithEvents ListViewItems As ListView
    Friend WithEvents Label1 As Label
End Class
