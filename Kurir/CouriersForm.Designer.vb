<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CouriersForm
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
        Me.lblCourierID = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblAvailability = New System.Windows.Forms.Label()
        Me.lblAssignedOrders = New System.Windows.Forms.Label()
        Me.txtCourierID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.chkAvailability = New System.Windows.Forms.CheckBox()
        Me.numAssignedOrders = New System.Windows.Forms.NumericUpDown()
        Me.btnAddCourier = New System.Windows.Forms.Button()
        Me.btnUpdateCourier = New System.Windows.Forms.Button()
        Me.btnDeleteCourier = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgvCouriers = New System.Windows.Forms.DataGridView()
        Me.SuspendCourier = New System.Windows.Forms.Button()
        CType(Me.numAssignedOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCouriers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCourierID
        '
        Me.lblCourierID.AutoSize = True
        Me.lblCourierID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourierID.Location = New System.Drawing.Point(32, 517)
        Me.lblCourierID.Name = "lblCourierID"
        Me.lblCourierID.Size = New System.Drawing.Size(91, 20)
        Me.lblCourierID.TabIndex = 0
        Me.lblCourierID.Text = "Courier ID"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(229, 518)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(55, 20)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(422, 518)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(60, 20)
        Me.lblPhone.TabIndex = 2
        Me.lblPhone.Text = "Phone"
        '
        'lblAvailability
        '
        Me.lblAvailability.AutoSize = True
        Me.lblAvailability.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailability.Location = New System.Drawing.Point(630, 518)
        Me.lblAvailability.Name = "lblAvailability"
        Me.lblAvailability.Size = New System.Drawing.Size(98, 20)
        Me.lblAvailability.TabIndex = 3
        Me.lblAvailability.Text = "Availability "
        '
        'lblAssignedOrders
        '
        Me.lblAssignedOrders.AutoSize = True
        Me.lblAssignedOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssignedOrders.Location = New System.Drawing.Point(779, 518)
        Me.lblAssignedOrders.Name = "lblAssignedOrders"
        Me.lblAssignedOrders.Size = New System.Drawing.Size(137, 20)
        Me.lblAssignedOrders.TabIndex = 4
        Me.lblAssignedOrders.Text = "AssignedOrders"
        '
        'txtCourierID
        '
        Me.txtCourierID.Location = New System.Drawing.Point(36, 553)
        Me.txtCourierID.Name = "txtCourierID"
        Me.txtCourierID.Size = New System.Drawing.Size(152, 26)
        Me.txtCourierID.TabIndex = 5
        Me.txtCourierID.Text = "CourierID "
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(233, 552)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(152, 26)
        Me.txtName.TabIndex = 6
        Me.txtName.Text = "Name"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(426, 552)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(152, 26)
        Me.txtPhone.TabIndex = 7
        Me.txtPhone.Text = "Phone"
        '
        'chkAvailability
        '
        Me.chkAvailability.AutoSize = True
        Me.chkAvailability.Location = New System.Drawing.Point(633, 555)
        Me.chkAvailability.Name = "chkAvailability"
        Me.chkAvailability.Size = New System.Drawing.Size(98, 24)
        Me.chkAvailability.TabIndex = 8
        Me.chkAvailability.Text = "Available"
        Me.chkAvailability.UseVisualStyleBackColor = True
        '
        'numAssignedOrders
        '
        Me.numAssignedOrders.Location = New System.Drawing.Point(785, 553)
        Me.numAssignedOrders.Name = "numAssignedOrders"
        Me.numAssignedOrders.Size = New System.Drawing.Size(120, 26)
        Me.numAssignedOrders.TabIndex = 9
        '
        'btnAddCourier
        '
        Me.btnAddCourier.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnAddCourier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCourier.Location = New System.Drawing.Point(621, 614)
        Me.btnAddCourier.Name = "btnAddCourier"
        Me.btnAddCourier.Size = New System.Drawing.Size(150, 44)
        Me.btnAddCourier.TabIndex = 10
        Me.btnAddCourier.Text = "Add Courier"
        Me.btnAddCourier.UseVisualStyleBackColor = False
        '
        'btnUpdateCourier
        '
        Me.btnUpdateCourier.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnUpdateCourier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateCourier.Location = New System.Drawing.Point(428, 614)
        Me.btnUpdateCourier.Name = "btnUpdateCourier"
        Me.btnUpdateCourier.Size = New System.Drawing.Size(150, 44)
        Me.btnUpdateCourier.TabIndex = 11
        Me.btnUpdateCourier.Text = "Update Courier"
        Me.btnUpdateCourier.UseVisualStyleBackColor = False
        '
        'btnDeleteCourier
        '
        Me.btnDeleteCourier.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnDeleteCourier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteCourier.Location = New System.Drawing.Point(809, 614)
        Me.btnDeleteCourier.Name = "btnDeleteCourier"
        Me.btnDeleteCourier.Size = New System.Drawing.Size(150, 44)
        Me.btnDeleteCourier.TabIndex = 12
        Me.btnDeleteCourier.Text = "Delete Courier"
        Me.btnDeleteCourier.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Khaki
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(23, 21)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(97, 44)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'dgvCouriers
        '
        Me.dgvCouriers.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgvCouriers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCouriers.Location = New System.Drawing.Point(36, 85)
        Me.dgvCouriers.Name = "dgvCouriers"
        Me.dgvCouriers.RowHeadersWidth = 62
        Me.dgvCouriers.RowTemplate.Height = 28
        Me.dgvCouriers.Size = New System.Drawing.Size(923, 407)
        Me.dgvCouriers.TabIndex = 14
        '
        'SuspendCourier
        '
        Me.SuspendCourier.BackColor = System.Drawing.SystemColors.Desktop
        Me.SuspendCourier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuspendCourier.Location = New System.Drawing.Point(12, 656)
        Me.SuspendCourier.Name = "SuspendCourier"
        Me.SuspendCourier.Size = New System.Drawing.Size(150, 44)
        Me.SuspendCourier.TabIndex = 15
        Me.SuspendCourier.Text = "Suspend"
        Me.SuspendCourier.UseVisualStyleBackColor = False
        '
        'CouriersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Kurir.My.Resources.Resources._6068294
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1002, 712)
        Me.Controls.Add(Me.SuspendCourier)
        Me.Controls.Add(Me.dgvCouriers)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDeleteCourier)
        Me.Controls.Add(Me.btnUpdateCourier)
        Me.Controls.Add(Me.btnAddCourier)
        Me.Controls.Add(Me.numAssignedOrders)
        Me.Controls.Add(Me.chkAvailability)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtCourierID)
        Me.Controls.Add(Me.lblAssignedOrders)
        Me.Controls.Add(Me.lblAvailability)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCourierID)
        Me.Name = "CouriersForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CouriersForm"
        CType(Me.numAssignedOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCouriers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCourierID As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblAvailability As Label
    Friend WithEvents lblAssignedOrders As Label
    Friend WithEvents txtCourierID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents chkAvailability As CheckBox
    Friend WithEvents numAssignedOrders As NumericUpDown
    Friend WithEvents btnAddCourier As Button
    Friend WithEvents btnUpdateCourier As Button
    Friend WithEvents btnDeleteCourier As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents dgvCouriers As DataGridView
    Friend WithEvents SuspendCourier As Button
End Class
