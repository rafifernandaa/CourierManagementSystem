<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PackagesForm
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
        Me.dgvPackages = New System.Windows.Forms.DataGridView()
        Me.btnAddPackage = New System.Windows.Forms.Button()
        Me.btnUpdatePackage = New System.Windows.Forms.Button()
        Me.btnDeletePackage = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblPackageName = New System.Windows.Forms.Label()
        Me.txtPackageName = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.lblDestinationAddress = New System.Windows.Forms.Label()
        Me.txtDestinationAddress = New System.Windows.Forms.TextBox()
        Me.lblCourierID = New System.Windows.Forms.Label()
        Me.txtCourierID = New System.Windows.Forms.TextBox()
        Me.lblPackageID = New System.Windows.Forms.Label()
        Me.txtPackageID = New System.Windows.Forms.TextBox()
        CType(Me.dgvPackages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPackages
        '
        Me.dgvPackages.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgvPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPackages.Location = New System.Drawing.Point(36, 85)
        Me.dgvPackages.Name = "dgvPackages"
        Me.dgvPackages.RowHeadersWidth = 62
        Me.dgvPackages.RowTemplate.Height = 28
        Me.dgvPackages.Size = New System.Drawing.Size(923, 407)
        Me.dgvPackages.TabIndex = 0
        '
        'btnAddPackage
        '
        Me.btnAddPackage.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnAddPackage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPackage.Location = New System.Drawing.Point(446, 614)
        Me.btnAddPackage.Name = "btnAddPackage"
        Me.btnAddPackage.Size = New System.Drawing.Size(150, 44)
        Me.btnAddPackage.TabIndex = 1
        Me.btnAddPackage.Text = "Add Packages"
        Me.btnAddPackage.UseVisualStyleBackColor = False
        '
        'btnUpdatePackage
        '
        Me.btnUpdatePackage.AutoSize = True
        Me.btnUpdatePackage.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnUpdatePackage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdatePackage.Location = New System.Drawing.Point(621, 614)
        Me.btnUpdatePackage.Name = "btnUpdatePackage"
        Me.btnUpdatePackage.Size = New System.Drawing.Size(161, 44)
        Me.btnUpdatePackage.TabIndex = 2
        Me.btnUpdatePackage.Text = "Update Packages"
        Me.btnUpdatePackage.UseVisualStyleBackColor = False
        '
        'btnDeletePackage
        '
        Me.btnDeletePackage.AutoSize = True
        Me.btnDeletePackage.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnDeletePackage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletePackage.Location = New System.Drawing.Point(804, 614)
        Me.btnDeletePackage.Name = "btnDeletePackage"
        Me.btnDeletePackage.Size = New System.Drawing.Size(155, 44)
        Me.btnDeletePackage.TabIndex = 3
        Me.btnDeletePackage.Text = "Delete Packages"
        Me.btnDeletePackage.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Khaki
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Location = New System.Drawing.Point(23, 21)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(97, 44)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblPackageName
        '
        Me.lblPackageName.AutoSize = True
        Me.lblPackageName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPackageName.Location = New System.Drawing.Point(216, 520)
        Me.lblPackageName.Name = "lblPackageName"
        Me.lblPackageName.Size = New System.Drawing.Size(124, 20)
        Me.lblPackageName.TabIndex = 5
        Me.lblPackageName.Text = "PackageName"
        '
        'txtPackageName
        '
        Me.txtPackageName.Location = New System.Drawing.Point(220, 558)
        Me.txtPackageName.Name = "txtPackageName"
        Me.txtPackageName.Size = New System.Drawing.Size(150, 26)
        Me.txtPackageName.TabIndex = 6
        Me.txtPackageName.Text = "PackageName"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(407, 520)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(62, 20)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "Status"
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Pending", "In Transit", "Delivered"})
        Me.cmbStatus.Location = New System.Drawing.Point(410, 557)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(130, 28)
        Me.cmbStatus.TabIndex = 8
        Me.cmbStatus.Text = "Status"
        '
        'lblDestinationAddress
        '
        Me.lblDestinationAddress.AutoSize = True
        Me.lblDestinationAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestinationAddress.Location = New System.Drawing.Point(570, 520)
        Me.lblDestinationAddress.Name = "lblDestinationAddress"
        Me.lblDestinationAddress.Size = New System.Drawing.Size(167, 20)
        Me.lblDestinationAddress.TabIndex = 9
        Me.lblDestinationAddress.Text = "DestinationAddress"
        '
        'txtDestinationAddress
        '
        Me.txtDestinationAddress.Location = New System.Drawing.Point(574, 559)
        Me.txtDestinationAddress.Name = "txtDestinationAddress"
        Me.txtDestinationAddress.Size = New System.Drawing.Size(150, 26)
        Me.txtDestinationAddress.TabIndex = 10
        Me.txtDestinationAddress.Text = "DestinationAddress"
        '
        'lblCourierID
        '
        Me.lblCourierID.AutoSize = True
        Me.lblCourierID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourierID.Location = New System.Drawing.Point(777, 520)
        Me.lblCourierID.Name = "lblCourierID"
        Me.lblCourierID.Size = New System.Drawing.Size(86, 20)
        Me.lblCourierID.TabIndex = 11
        Me.lblCourierID.Text = "CourierID"
        '
        'txtCourierID
        '
        Me.txtCourierID.Location = New System.Drawing.Point(780, 559)
        Me.txtCourierID.Name = "txtCourierID"
        Me.txtCourierID.Size = New System.Drawing.Size(150, 26)
        Me.txtCourierID.TabIndex = 12
        Me.txtCourierID.Text = "CourierID"
        '
        'lblPackageID
        '
        Me.lblPackageID.AutoSize = True
        Me.lblPackageID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPackageID.Location = New System.Drawing.Point(32, 522)
        Me.lblPackageID.Name = "lblPackageID"
        Me.lblPackageID.Size = New System.Drawing.Size(97, 20)
        Me.lblPackageID.TabIndex = 13
        Me.lblPackageID.Text = "PackageID"
        '
        'txtPackageID
        '
        Me.txtPackageID.Location = New System.Drawing.Point(36, 559)
        Me.txtPackageID.Name = "txtPackageID"
        Me.txtPackageID.Size = New System.Drawing.Size(150, 26)
        Me.txtPackageID.TabIndex = 14
        Me.txtPackageID.Text = "PackageID"
        '
        'PackagesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Kurir.My.Resources.Resources._6068294
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1002, 712)
        Me.Controls.Add(Me.txtPackageID)
        Me.Controls.Add(Me.lblPackageID)
        Me.Controls.Add(Me.txtCourierID)
        Me.Controls.Add(Me.lblCourierID)
        Me.Controls.Add(Me.txtDestinationAddress)
        Me.Controls.Add(Me.lblDestinationAddress)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtPackageName)
        Me.Controls.Add(Me.lblPackageName)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDeletePackage)
        Me.Controls.Add(Me.btnUpdatePackage)
        Me.Controls.Add(Me.btnAddPackage)
        Me.Controls.Add(Me.dgvPackages)
        Me.Name = "PackagesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PackagesForm"
        CType(Me.dgvPackages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPackages As DataGridView
    Friend WithEvents btnAddPackage As Button
    Friend WithEvents btnUpdatePackage As Button
    Friend WithEvents btnDeletePackage As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblPackageName As Label
    Friend WithEvents txtPackageName As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents lblDestinationAddress As Label
    Friend WithEvents txtDestinationAddress As TextBox
    Friend WithEvents lblCourierID As Label
    Friend WithEvents txtCourierID As TextBox
    Friend WithEvents lblPackageID As Label
    Friend WithEvents txtPackageID As TextBox
End Class
