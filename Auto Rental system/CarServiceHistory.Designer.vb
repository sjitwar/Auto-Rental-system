<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarServiceHistory
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
        Me.lstPreviousHistory = New System.Windows.Forms.ListBox()
        Me.txtFaultDetails = New System.Windows.Forms.TextBox()
        Me.lblFaultDetails = New System.Windows.Forms.Label()
        Me.datRepairDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRepairDetails = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstPreviousHistory
        '
        Me.lstPreviousHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstPreviousHistory.FormattingEnabled = True
        Me.lstPreviousHistory.ItemHeight = 16
        Me.lstPreviousHistory.Location = New System.Drawing.Point(39, 207)
        Me.lstPreviousHistory.Margin = New System.Windows.Forms.Padding(4)
        Me.lstPreviousHistory.Name = "lstPreviousHistory"
        Me.lstPreviousHistory.Size = New System.Drawing.Size(281, 274)
        Me.lstPreviousHistory.TabIndex = 1
        '
        'txtFaultDetails
        '
        Me.txtFaultDetails.Enabled = False
        Me.txtFaultDetails.Location = New System.Drawing.Point(177, 191)
        Me.txtFaultDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFaultDetails.Multiline = True
        Me.txtFaultDetails.Name = "txtFaultDetails"
        Me.txtFaultDetails.Size = New System.Drawing.Size(281, 128)
        Me.txtFaultDetails.TabIndex = 2
        '
        'lblFaultDetails
        '
        Me.lblFaultDetails.AutoSize = True
        Me.lblFaultDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaultDetails.Location = New System.Drawing.Point(16, 191)
        Me.lblFaultDetails.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFaultDetails.Name = "lblFaultDetails"
        Me.lblFaultDetails.Size = New System.Drawing.Size(114, 25)
        Me.lblFaultDetails.TabIndex = 3
        Me.lblFaultDetails.Text = "FaultDetails"
        '
        'datRepairDate
        '
        Me.datRepairDate.Enabled = False
        Me.datRepairDate.Location = New System.Drawing.Point(223, 130)
        Me.datRepairDate.Margin = New System.Windows.Forms.Padding(4)
        Me.datRepairDate.Name = "datRepairDate"
        Me.datRepairDate.Size = New System.Drawing.Size(236, 22)
        Me.datRepairDate.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 130)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Repair Date"
        '
        'txtRepairDetails
        '
        Me.txtRepairDetails.Enabled = False
        Me.txtRepairDetails.Location = New System.Drawing.Point(177, 327)
        Me.txtRepairDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRepairDetails.Multiline = True
        Me.txtRepairDetails.Name = "txtRepairDetails"
        Me.txtRepairDetails.Size = New System.Drawing.Size(281, 128)
        Me.txtRepairDetails.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 327)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "RepairDetails"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtRepairDetails)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.datRepairDate)
        Me.Panel1.Controls.Add(Me.lblFaultDetails)
        Me.Panel1.Controls.Add(Me.txtFaultDetails)
        Me.Panel1.Location = New System.Drawing.Point(401, 15)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 521)
        Me.Panel1.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(3, 14)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(580, 62)
        Me.Panel3.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(99, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(346, 42)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "SERVICE DETAILS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lstPreviousHistory)
        Me.Panel2.Location = New System.Drawing.Point(16, 15)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 521)
        Me.Panel2.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(161, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Repair Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Service ID"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(16, 29)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(360, 62)
        Me.Panel4.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(356, 42)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "SERVICE HISTORY"
        '
        'CarServiceHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1001, 550)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CarServiceHistory"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstPreviousHistory As System.Windows.Forms.ListBox
    Friend WithEvents txtFaultDetails As System.Windows.Forms.TextBox
    Friend WithEvents lblFaultDetails As System.Windows.Forms.Label
    Friend WithEvents datRepairDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRepairDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
End Class
