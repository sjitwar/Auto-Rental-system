<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff
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
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnOrdersManagement = New System.Windows.Forms.Button()
        Me.lblStaffName = New System.Windows.Forms.Label()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.btnService = New System.Windows.Forms.Button()
        Me.btnCustomersManagement = New System.Windows.Forms.Button()
        Me.btnOverdueOrders = New System.Windows.Forms.Button()
        Me.btnStaffManagement = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnStaffDetails = New System.Windows.Forms.Button()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.btnCarsManagement = New System.Windows.Forms.Button()
        Me.panFrmTemplate = New System.Windows.Forms.Panel()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReports.Location = New System.Drawing.Point(900, 4)
        Me.btnReports.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(135, 63)
        Me.btnReports.TabIndex = 12
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'btnOrdersManagement
        '
        Me.btnOrdersManagement.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnOrdersManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOrdersManagement.Location = New System.Drawing.Point(512, 4)
        Me.btnOrdersManagement.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOrdersManagement.Name = "btnOrdersManagement"
        Me.btnOrdersManagement.Size = New System.Drawing.Size(122, 63)
        Me.btnOrdersManagement.TabIndex = 17
        Me.btnOrdersManagement.Text = "Orders Management"
        Me.btnOrdersManagement.UseVisualStyleBackColor = False
        '
        'lblStaffName
        '
        Me.lblStaffName.AutoSize = True
        Me.lblStaffName.Location = New System.Drawing.Point(15, 11)
        Me.lblStaffName.Name = "lblStaffName"
        Me.lblStaffName.Size = New System.Drawing.Size(45, 17)
        Me.lblStaffName.TabIndex = 19
        Me.lblStaffName.Text = "Name"
        '
        'lblStaffID
        '
        Me.lblStaffID.AutoSize = True
        Me.lblStaffID.Location = New System.Drawing.Point(17, 47)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(21, 17)
        Me.lblStaffID.TabIndex = 20
        Me.lblStaffID.Text = "ID"
        '
        'btnService
        '
        Me.btnService.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnService.Location = New System.Drawing.Point(771, 4)
        Me.btnService.Margin = New System.Windows.Forms.Padding(4)
        Me.btnService.Name = "btnService"
        Me.btnService.Size = New System.Drawing.Size(130, 63)
        Me.btnService.TabIndex = 21
        Me.btnService.Text = "Service"
        Me.btnService.UseVisualStyleBackColor = False
        '
        'btnCustomersManagement
        '
        Me.btnCustomersManagement.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCustomersManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCustomersManagement.Location = New System.Drawing.Point(257, 4)
        Me.btnCustomersManagement.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCustomersManagement.Name = "btnCustomersManagement"
        Me.btnCustomersManagement.Size = New System.Drawing.Size(131, 63)
        Me.btnCustomersManagement.TabIndex = 23
        Me.btnCustomersManagement.Text = "Customers Management"
        Me.btnCustomersManagement.UseVisualStyleBackColor = False
        '
        'btnOverdueOrders
        '
        Me.btnOverdueOrders.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnOverdueOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOverdueOrders.Location = New System.Drawing.Point(633, 4)
        Me.btnOverdueOrders.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOverdueOrders.Name = "btnOverdueOrders"
        Me.btnOverdueOrders.Size = New System.Drawing.Size(139, 63)
        Me.btnOverdueOrders.TabIndex = 24
        Me.btnOverdueOrders.Text = "Overdue Orders"
        Me.btnOverdueOrders.UseVisualStyleBackColor = False
        '
        'btnStaffManagement
        '
        Me.btnStaffManagement.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnStaffManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStaffManagement.Location = New System.Drawing.Point(387, 4)
        Me.btnStaffManagement.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStaffManagement.Name = "btnStaffManagement"
        Me.btnStaffManagement.Size = New System.Drawing.Size(126, 63)
        Me.btnStaffManagement.TabIndex = 25
        Me.btnStaffManagement.Text = "Staff Management"
        Me.btnStaffManagement.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel6.Controls.Add(Me.btnStaffManagement)
        Me.Panel6.Controls.Add(Me.btnReports)
        Me.Panel6.Controls.Add(Me.btnStaffDetails)
        Me.Panel6.Controls.Add(Me.btnService)
        Me.Panel6.Controls.Add(Me.btnSignOut)
        Me.Panel6.Controls.Add(Me.btnCarsManagement)
        Me.Panel6.Controls.Add(Me.btnCustomersManagement)
        Me.Panel6.Controls.Add(Me.btnOverdueOrders)
        Me.Panel6.Controls.Add(Me.lblStaffID)
        Me.Panel6.Controls.Add(Me.lblStaffName)
        Me.Panel6.Controls.Add(Me.btnOrdersManagement)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1333, 73)
        Me.Panel6.TabIndex = 26
        '
        'btnStaffDetails
        '
        Me.btnStaffDetails.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnStaffDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStaffDetails.Location = New System.Drawing.Point(1033, 4)
        Me.btnStaffDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStaffDetails.Name = "btnStaffDetails"
        Me.btnStaffDetails.Size = New System.Drawing.Size(130, 63)
        Me.btnStaffDetails.TabIndex = 28
        Me.btnStaffDetails.Text = "My Details"
        Me.btnStaffDetails.UseVisualStyleBackColor = False
        '
        'btnSignOut
        '
        Me.btnSignOut.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSignOut.Location = New System.Drawing.Point(1174, 4)
        Me.btnSignOut.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(105, 61)
        Me.btnSignOut.TabIndex = 27
        Me.btnSignOut.Text = "Sign Out"
        Me.btnSignOut.UseVisualStyleBackColor = False
        '
        'btnCarsManagement
        '
        Me.btnCarsManagement.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCarsManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCarsManagement.Location = New System.Drawing.Point(130, 4)
        Me.btnCarsManagement.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCarsManagement.Name = "btnCarsManagement"
        Me.btnCarsManagement.Size = New System.Drawing.Size(128, 63)
        Me.btnCarsManagement.TabIndex = 26
        Me.btnCarsManagement.Text = " Cars Management"
        Me.btnCarsManagement.UseVisualStyleBackColor = False
        '
        'panFrmTemplate
        '
        Me.panFrmTemplate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panFrmTemplate.Location = New System.Drawing.Point(0, 73)
        Me.panFrmTemplate.Margin = New System.Windows.Forms.Padding(4)
        Me.panFrmTemplate.Name = "panFrmTemplate"
        Me.panFrmTemplate.Size = New System.Drawing.Size(1331, 791)
        Me.panFrmTemplate.TabIndex = 27
        '
        'Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1333, 878)
        Me.Controls.Add(Me.panFrmTemplate)
        Me.Controls.Add(Me.Panel6)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Staff"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnOrdersManagement As System.Windows.Forms.Button
    Friend WithEvents lblStaffName As Label
    Friend WithEvents lblStaffID As Label
    Friend WithEvents btnService As System.Windows.Forms.Button
    Friend WithEvents btnCustomersManagement As System.Windows.Forms.Button
    Friend WithEvents btnOverdueOrders As System.Windows.Forms.Button
    Friend WithEvents btnStaffManagement As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents panFrmTemplate As System.Windows.Forms.Panel
    Friend WithEvents btnCarsManagement As System.Windows.Forms.Button
    Friend WithEvents btnSignOut As System.Windows.Forms.Button
    Friend WithEvents btnStaffDetails As System.Windows.Forms.Button
End Class
