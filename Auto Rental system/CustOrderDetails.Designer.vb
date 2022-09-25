<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustOrderDetails
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
        Me.panMyOrders = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstOrders = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtCollectDate = New System.Windows.Forms.TextBox()
        Me.txtReturnDate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtOTotalCost = New System.Windows.Forms.TextBox()
        Me.txtOCollected = New System.Windows.Forms.TextBox()
        Me.txtOReturned = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtOCarModel = New System.Windows.Forms.TextBox()
        Me.txtOCarMake = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPenaltyCost = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPaidDate = New System.Windows.Forms.TextBox()
        Me.panMyOrders.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'panMyOrders
        '
        Me.panMyOrders.BackColor = System.Drawing.SystemColors.Control
        Me.panMyOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panMyOrders.Controls.Add(Me.Label6)
        Me.panMyOrders.Controls.Add(Me.Label5)
        Me.panMyOrders.Controls.Add(Me.Panel2)
        Me.panMyOrders.Controls.Add(Me.lstOrders)
        Me.panMyOrders.Location = New System.Drawing.Point(26, 13)
        Me.panMyOrders.Margin = New System.Windows.Forms.Padding(4)
        Me.panMyOrders.Name = "panMyOrders"
        Me.panMyOrders.Size = New System.Drawing.Size(555, 698)
        Me.panMyOrders.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(228, 204)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Start Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(80, 206)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ORDER ID"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(1, 38)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(555, 86)
        Me.Panel2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(140, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 42)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MY ORDERS"
        '
        'lstOrders
        '
        Me.lstOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOrders.FormattingEnabled = True
        Me.lstOrders.ItemHeight = 25
        Me.lstOrders.Location = New System.Drawing.Point(84, 225)
        Me.lstOrders.Margin = New System.Windows.Forms.Padding(4)
        Me.lstOrders.Name = "lstOrders"
        Me.lstOrders.Size = New System.Drawing.Size(366, 329)
        Me.lstOrders.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(591, 13)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(659, 698)
        Me.Panel1.TabIndex = 47
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(-1, 38)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(659, 86)
        Me.Panel4.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(161, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 42)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ORDER DETAILS"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtPaidDate)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txtPenaltyCost)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtCollectDate)
        Me.Panel3.Controls.Add(Me.txtReturnDate)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.txtOTotalCost)
        Me.Panel3.Controls.Add(Me.txtOCollected)
        Me.Panel3.Controls.Add(Me.txtOReturned)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.txtOCarModel)
        Me.Panel3.Controls.Add(Me.txtOCarMake)
        Me.Panel3.Location = New System.Drawing.Point(49, 132)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(520, 560)
        Me.Panel3.TabIndex = 47
        '
        'txtCollectDate
        '
        Me.txtCollectDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCollectDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCollectDate.Location = New System.Drawing.Point(260, 188)
        Me.txtCollectDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCollectDate.Name = "txtCollectDate"
        Me.txtCollectDate.Size = New System.Drawing.Size(231, 38)
        Me.txtCollectDate.TabIndex = 50
        '
        'txtReturnDate
        '
        Me.txtReturnDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReturnDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReturnDate.Location = New System.Drawing.Point(260, 244)
        Me.txtReturnDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReturnDate.Name = "txtReturnDate"
        Me.txtReturnDate.Size = New System.Drawing.Size(231, 38)
        Me.txtReturnDate.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 251)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 31)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Return Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 195)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 31)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Collect Date"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(20, 303)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(193, 31)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "Collected Date"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(21, 357)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(191, 31)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Returned Date"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(21, 140)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(139, 31)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Total Cost"
        '
        'txtOTotalCost
        '
        Me.txtOTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOTotalCost.Location = New System.Drawing.Point(303, 133)
        Me.txtOTotalCost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOTotalCost.Name = "txtOTotalCost"
        Me.txtOTotalCost.Size = New System.Drawing.Size(188, 38)
        Me.txtOTotalCost.TabIndex = 43
        '
        'txtOCollected
        '
        Me.txtOCollected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOCollected.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOCollected.Location = New System.Drawing.Point(260, 296)
        Me.txtOCollected.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOCollected.Name = "txtOCollected"
        Me.txtOCollected.Size = New System.Drawing.Size(231, 38)
        Me.txtOCollected.TabIndex = 42
        '
        'txtOReturned
        '
        Me.txtOReturned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOReturned.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOReturned.Location = New System.Drawing.Point(262, 350)
        Me.txtOReturned.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOReturned.Name = "txtOReturned"
        Me.txtOReturned.Size = New System.Drawing.Size(229, 38)
        Me.txtOReturned.TabIndex = 41
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(21, 28)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(138, 31)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Car Model"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 82)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 31)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Car Make"
        '
        'txtOCarModel
        '
        Me.txtOCarModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOCarModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOCarModel.Location = New System.Drawing.Point(260, 21)
        Me.txtOCarModel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOCarModel.Name = "txtOCarModel"
        Me.txtOCarModel.Size = New System.Drawing.Size(231, 38)
        Me.txtOCarModel.TabIndex = 33
        '
        'txtOCarMake
        '
        Me.txtOCarMake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOCarMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOCarMake.Location = New System.Drawing.Point(260, 75)
        Me.txtOCarMake.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOCarMake.Name = "txtOCarMake"
        Me.txtOCarMake.Size = New System.Drawing.Size(231, 38)
        Me.txtOCarMake.TabIndex = 34
        Me.txtOCarMake.Text = " "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 417)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 31)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "PenaltyCost"
        '
        'txtPenaltyCost
        '
        Me.txtPenaltyCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPenaltyCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenaltyCost.Location = New System.Drawing.Point(303, 410)
        Me.txtPenaltyCost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPenaltyCost.Name = "txtPenaltyCost"
        Me.txtPenaltyCost.Size = New System.Drawing.Size(188, 38)
        Me.txtPenaltyCost.TabIndex = 52
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 479)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 31)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Paid Date"
        '
        'txtPaidDate
        '
        Me.txtPaidDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPaidDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaidDate.Location = New System.Drawing.Point(262, 472)
        Me.txtPaidDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPaidDate.Name = "txtPaidDate"
        Me.txtPaidDate.Size = New System.Drawing.Size(229, 38)
        Me.txtPaidDate.TabIndex = 54
        '
        'CustOrderDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1263, 740)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panMyOrders)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CustOrderDetails"
        Me.Text = "CustOrderDetails"
        Me.panMyOrders.ResumeLayout(False)
        Me.panMyOrders.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panMyOrders As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtOTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents txtOCollected As System.Windows.Forms.TextBox
    Friend WithEvents txtOReturned As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtOCarModel As System.Windows.Forms.TextBox
    Friend WithEvents txtOCarMake As System.Windows.Forms.TextBox
    Friend WithEvents lstOrders As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCollectDate As System.Windows.Forms.TextBox
    Friend WithEvents txtReturnDate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPaidDate As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPenaltyCost As TextBox
    Friend WithEvents Label8 As Label
End Class
