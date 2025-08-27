<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewCourierForm
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
        Me.dgvViewCouriers = New System.Windows.Forms.DataGridView()
        Me.btnUpdateStatus = New System.Windows.Forms.Button()
        Me.txtCourierID2 = New System.Windows.Forms.TextBox()
        Me.lblCourierID2 = New System.Windows.Forms.Label()
        Me.chkAvailability2 = New System.Windows.Forms.CheckBox()
        Me.lblAvailability2 = New System.Windows.Forms.Label()
        Me.btnBackVCF = New System.Windows.Forms.Button()
        CType(Me.dgvViewCouriers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvViewCouriers
        '
        Me.dgvViewCouriers.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgvViewCouriers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvViewCouriers.Location = New System.Drawing.Point(36, 194)
        Me.dgvViewCouriers.Name = "dgvViewCouriers"
        Me.dgvViewCouriers.RowHeadersWidth = 62
        Me.dgvViewCouriers.RowTemplate.Height = 28
        Me.dgvViewCouriers.Size = New System.Drawing.Size(923, 450)
        Me.dgvViewCouriers.TabIndex = 0
        '
        'btnUpdateStatus
        '
        Me.btnUpdateStatus.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnUpdateStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateStatus.Location = New System.Drawing.Point(763, 120)
        Me.btnUpdateStatus.Name = "btnUpdateStatus"
        Me.btnUpdateStatus.Size = New System.Drawing.Size(174, 47)
        Me.btnUpdateStatus.TabIndex = 1
        Me.btnUpdateStatus.Text = "Update Status"
        Me.btnUpdateStatus.UseVisualStyleBackColor = False
        '
        'txtCourierID2
        '
        Me.txtCourierID2.Location = New System.Drawing.Point(440, 141)
        Me.txtCourierID2.Name = "txtCourierID2"
        Me.txtCourierID2.Size = New System.Drawing.Size(150, 26)
        Me.txtCourierID2.TabIndex = 2
        Me.txtCourierID2.Text = "Courier ID"
        '
        'lblCourierID2
        '
        Me.lblCourierID2.AutoSize = True
        Me.lblCourierID2.BackColor = System.Drawing.Color.Transparent
        Me.lblCourierID2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourierID2.Location = New System.Drawing.Point(436, 105)
        Me.lblCourierID2.Name = "lblCourierID2"
        Me.lblCourierID2.Size = New System.Drawing.Size(91, 20)
        Me.lblCourierID2.TabIndex = 3
        Me.lblCourierID2.Text = "Courier ID"
        '
        'chkAvailability2
        '
        Me.chkAvailability2.AutoSize = True
        Me.chkAvailability2.Location = New System.Drawing.Point(632, 143)
        Me.chkAvailability2.Name = "chkAvailability2"
        Me.chkAvailability2.Size = New System.Drawing.Size(98, 24)
        Me.chkAvailability2.TabIndex = 4
        Me.chkAvailability2.Text = "Available"
        Me.chkAvailability2.UseVisualStyleBackColor = True
        '
        'lblAvailability2
        '
        Me.lblAvailability2.AutoSize = True
        Me.lblAvailability2.BackColor = System.Drawing.Color.Transparent
        Me.lblAvailability2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailability2.Location = New System.Drawing.Point(628, 105)
        Me.lblAvailability2.Name = "lblAvailability2"
        Me.lblAvailability2.Size = New System.Drawing.Size(62, 20)
        Me.lblAvailability2.TabIndex = 5
        Me.lblAvailability2.Text = "Status"
        '
        'btnBackVCF
        '
        Me.btnBackVCF.BackColor = System.Drawing.Color.Khaki
        Me.btnBackVCF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackVCF.Location = New System.Drawing.Point(23, 21)
        Me.btnBackVCF.Name = "btnBackVCF"
        Me.btnBackVCF.Size = New System.Drawing.Size(97, 44)
        Me.btnBackVCF.TabIndex = 6
        Me.btnBackVCF.Text = "Back"
        Me.btnBackVCF.UseVisualStyleBackColor = False
        '
        'ViewCourierForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 712)
        Me.Controls.Add(Me.btnBackVCF)
        Me.Controls.Add(Me.lblAvailability2)
        Me.Controls.Add(Me.chkAvailability2)
        Me.Controls.Add(Me.lblCourierID2)
        Me.Controls.Add(Me.txtCourierID2)
        Me.Controls.Add(Me.btnUpdateStatus)
        Me.Controls.Add(Me.dgvViewCouriers)
        Me.Name = "ViewCourierForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewCourierForm"
        CType(Me.dgvViewCouriers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvViewCouriers As DataGridView
    Friend WithEvents btnUpdateStatus As Button
    Friend WithEvents txtCourierID2 As TextBox
    Friend WithEvents lblCourierID2 As Label
    Friend WithEvents chkAvailability2 As CheckBox
    Friend WithEvents lblAvailability2 As Label
    Friend WithEvents btnBackVCF As Button
End Class
