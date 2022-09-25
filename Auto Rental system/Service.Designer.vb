<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Service
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
        Me.lstCarsInService = New System.Windows.Forms.ListBox()
        Me.lblCarMake = New System.Windows.Forms.Label()
        Me.lblCarModel = New System.Windows.Forms.Label()
        Me.txtCarMake = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lstServiceHistory = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.datRepairDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHRepairDetails = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHFaultDetails = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblCarID = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblServiceID = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRepairDetails = New System.Windows.Forms.TextBox()
        Me.txtFaultDetails = New System.Windows.Forms.TextBox()
        Me.txtCarModel = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstCarsInService
        '
        Me.lstCarsInService.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCarsInService.FormattingEnabled = True
        Me.lstCarsInService.ItemHeight = 25
        Me.lstCarsInService.Location = New System.Drawing.Point(40, 160)
        Me.lstCarsInService.Margin = New System.Windows.Forms.Padding(4)
        Me.lstCarsInService.Name = "lstCarsInService"
        Me.lstCarsInService.Size = New System.Drawing.Size(319, 329)
        Me.lstCarsInService.TabIndex = 0
        '
        'lblCarMake
        '
        Me.lblCarMake.AutoSize = True
        Me.lblCarMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarMake.Location = New System.Drawing.Point(16, 151)
        Me.lblCarMake.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCarMake.Name = "lblCarMake"
        Me.lblCarMake.Size = New System.Drawing.Size(98, 25)
        Me.lblCarMake.TabIndex = 1
        Me.lblCarMake.Text = "Car Make"
        '
        'lblCarModel
        '
        Me.lblCarModel.AutoSize = True
        Me.lblCarModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarModel.Location = New System.Drawing.Point(16, 199)
        Me.lblCarModel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCarModel.Name = "lblCarModel"
        Me.lblCarModel.Size = New System.Drawing.Size(103, 25)
        Me.lblCarModel.TabIndex = 2
        Me.lblCarModel.Text = "Car Model"
        '
        'txtCarMake
        '
        Me.txtCarMake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCarMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarMake.Location = New System.Drawing.Point(140, 149)
        Me.txtCarMake.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCarMake.Name = "txtCarMake"
        Me.txtCarMake.Size = New System.Drawing.Size(166, 30)
        Me.txtCarMake.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(6, 7)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1312, 783)
        Me.Panel1.TabIndex = 5
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Location = New System.Drawing.Point(859, 21)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(444, 63)
        Me.Panel7.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 7)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(356, 42)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "SERVICE HISTORY"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Location = New System.Drawing.Point(426, 20)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(423, 63)
        Me.Panel6.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 10)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(346, 42)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "SERVICE DETAILS"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.lstServiceHistory)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.datRepairDate)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.txtHRepairDetails)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txtHFaultDetails)
        Me.Panel4.Location = New System.Drawing.Point(859, 8)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(445, 732)
        Me.Panel4.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(161, 114)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 17)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Repaired Date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(29, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 17)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Service ID"
        '
        'lstServiceHistory
        '
        Me.lstServiceHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstServiceHistory.FormattingEnabled = True
        Me.lstServiceHistory.ItemHeight = 25
        Me.lstServiceHistory.Location = New System.Drawing.Point(28, 134)
        Me.lstServiceHistory.Margin = New System.Windows.Forms.Padding(4)
        Me.lstServiceHistory.Name = "lstServiceHistory"
        Me.lstServiceHistory.Size = New System.Drawing.Size(312, 129)
        Me.lstServiceHistory.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 295)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 25)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Repaired Date"
        '
        'datRepairDate
        '
        Me.datRepairDate.Enabled = False
        Me.datRepairDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datRepairDate.Location = New System.Drawing.Point(164, 292)
        Me.datRepairDate.Margin = New System.Windows.Forms.Padding(4)
        Me.datRepairDate.Name = "datRepairDate"
        Me.datRepairDate.Size = New System.Drawing.Size(229, 30)
        Me.datRepairDate.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 508)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Repair Details"
        '
        'txtHRepairDetails
        '
        Me.txtHRepairDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHRepairDetails.Enabled = False
        Me.txtHRepairDetails.Location = New System.Drawing.Point(29, 534)
        Me.txtHRepairDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHRepairDetails.MaxLength = 1000
        Me.txtHRepairDetails.Multiline = True
        Me.txtHRepairDetails.Name = "txtHRepairDetails"
        Me.txtHRepairDetails.Size = New System.Drawing.Size(311, 126)
        Me.txtHRepairDetails.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 345)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Fault Details"
        '
        'txtHFaultDetails
        '
        Me.txtHFaultDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHFaultDetails.Enabled = False
        Me.txtHFaultDetails.Location = New System.Drawing.Point(28, 370)
        Me.txtHFaultDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHFaultDetails.MaxLength = 1000
        Me.txtHFaultDetails.Multiline = True
        Me.txtHFaultDetails.Name = "txtHFaultDetails"
        Me.txtHFaultDetails.Size = New System.Drawing.Size(311, 123)
        Me.txtHFaultDetails.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.lstCarsInService)
        Me.Panel3.Location = New System.Drawing.Point(3, 6)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(416, 732)
        Me.Panel3.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(150, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 17)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Car ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(37, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Service ID"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Location = New System.Drawing.Point(0, 12)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(414, 63)
        Me.Panel5.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 7)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(341, 42)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "CARS IN SERVICE"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblCarID)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.lblServiceID)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtRepairDetails)
        Me.Panel2.Controls.Add(Me.txtFaultDetails)
        Me.Panel2.Controls.Add(Me.txtCarModel)
        Me.Panel2.Controls.Add(Me.txtCarMake)
        Me.Panel2.Controls.Add(Me.lblCarModel)
        Me.Panel2.Controls.Add(Me.lblCarMake)
        Me.Panel2.Location = New System.Drawing.Point(426, 8)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(425, 732)
        Me.Panel2.TabIndex = 13
        '
        'lblCarID
        '
        Me.lblCarID.AutoSize = True
        Me.lblCarID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarID.Location = New System.Drawing.Point(287, 114)
        Me.lblCarID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCarID.Name = "lblCarID"
        Me.lblCarID.Size = New System.Drawing.Size(19, 25)
        Me.lblCarID.TabIndex = 14
        Me.lblCarID.Text = "-"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(192, 114)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 25)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Car ID"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 114)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 25)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Service ID"
        '
        'lblServiceID
        '
        Me.lblServiceID.AutoSize = True
        Me.lblServiceID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceID.Location = New System.Drawing.Point(135, 114)
        Me.lblServiceID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblServiceID.Name = "lblServiceID"
        Me.lblServiceID.Size = New System.Drawing.Size(19, 25)
        Me.lblServiceID.TabIndex = 11
        Me.lblServiceID.Text = "-"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(27, 608)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 57)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 430)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Repair Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 245)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Fault Details"
        '
        'txtRepairDetails
        '
        Me.txtRepairDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRepairDetails.Location = New System.Drawing.Point(23, 455)
        Me.txtRepairDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRepairDetails.MaxLength = 1000
        Me.txtRepairDetails.Multiline = True
        Me.txtRepairDetails.Name = "txtRepairDetails"
        Me.txtRepairDetails.Size = New System.Drawing.Size(311, 145)
        Me.txtRepairDetails.TabIndex = 7
        '
        'txtFaultDetails
        '
        Me.txtFaultDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFaultDetails.Location = New System.Drawing.Point(23, 273)
        Me.txtFaultDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFaultDetails.MaxLength = 1000
        Me.txtFaultDetails.Multiline = True
        Me.txtFaultDetails.Name = "txtFaultDetails"
        Me.txtFaultDetails.Size = New System.Drawing.Size(311, 145)
        Me.txtFaultDetails.TabIndex = 6
        '
        'txtCarModel
        '
        Me.txtCarModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCarModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarModel.Location = New System.Drawing.Point(140, 199)
        Me.txtCarModel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCarModel.Name = "txtCarModel"
        Me.txtCarModel.Size = New System.Drawing.Size(166, 30)
        Me.txtCarModel.TabIndex = 5
        '
        'Service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1331, 791)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Service"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstCarsInService As System.Windows.Forms.ListBox
    Friend WithEvents lblCarMake As System.Windows.Forms.Label
    Friend WithEvents lblCarModel As System.Windows.Forms.Label
    Friend WithEvents txtCarMake As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtCarModel As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRepairDetails As System.Windows.Forms.TextBox
    Friend WithEvents txtFaultDetails As System.Windows.Forms.TextBox
    Friend WithEvents lblServiceID As System.Windows.Forms.Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHRepairDetails As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHFaultDetails As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lstServiceHistory As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents datRepairDate As DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblCarID As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
End Class
