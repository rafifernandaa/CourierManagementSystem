<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewPackagesForm
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
        Me.dgvViewPackagesForm = New System.Windows.Forms.DataGridView()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnBackVPF = New System.Windows.Forms.Button()
        Me.btnSelectPackages = New System.Windows.Forms.Button()
        Me.lblCourierID3 = New System.Windows.Forms.Label()
        Me.txtCourierID3 = New System.Windows.Forms.TextBox()
        Me.btnUpdatePackageStatus = New System.Windows.Forms.Button()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.lblStatusPackages = New System.Windows.Forms.Label()
        Me.lblPackageID2 = New System.Windows.Forms.Label()
        Me.txtPackageID2 = New System.Windows.Forms.TextBox()
        CType(Me.dgvViewPackagesForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvViewPackagesForm
        '
        Me.dgvViewPackagesForm.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgvViewPackagesForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvViewPackagesForm.Location = New System.Drawing.Point(36, 211)
        Me.dgvViewPackagesForm.Name = "dgvViewPackagesForm"
        Me.dgvViewPackagesForm.RowHeadersWidth = 62
        Me.dgvViewPackagesForm.RowTemplate.Height = 28
        Me.dgvViewPackagesForm.Size = New System.Drawing.Size(923, 450)
        Me.dgvViewPackagesForm.TabIndex = 0
        '
        'btnBackVPF
        '
        Me.btnBackVPF.BackColor = System.Drawing.Color.Khaki
        Me.btnBackVPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackVPF.Location = New System.Drawing.Point(23, 21)
        Me.btnBackVPF.Name = "btnBackVPF"
        Me.btnBackVPF.Size = New System.Drawing.Size(97, 44)
        Me.btnBackVPF.TabIndex = 1
        Me.btnBackVPF.Text = "Back"
        Me.btnBackVPF.UseVisualStyleBackColor = False
        '
        'btnSelectPackages
        '
        Me.btnSelectPackages.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSelectPackages.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectPackages.Location = New System.Drawing.Point(584, 120)
        Me.btnSelectPackages.Name = "btnSelectPackages"
        Me.btnSelectPackages.Size = New System.Drawing.Size(150, 61)
        Me.btnSelectPackages.TabIndex = 2
        Me.btnSelectPackages.Text = "Select Packages"
        Me.btnSelectPackages.UseVisualStyleBackColor = False
        '
        'lblCourierID3
        '
        Me.lblCourierID3.AutoSize = True
        Me.lblCourierID3.BackColor = System.Drawing.Color.Transparent
        Me.lblCourierID3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourierID3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCourierID3.Location = New System.Drawing.Point(32, 118)
        Me.lblCourierID3.Name = "lblCourierID3"
        Me.lblCourierID3.Size = New System.Drawing.Size(91, 20)
        Me.lblCourierID3.TabIndex = 3
        Me.lblCourierID3.Text = "Courier ID"
        '
        'txtCourierID3
        '
        Me.txtCourierID3.Location = New System.Drawing.Point(36, 153)
        Me.txtCourierID3.Name = "txtCourierID3"
        Me.txtCourierID3.Size = New System.Drawing.Size(150, 26)
        Me.txtCourierID3.TabIndex = 4
        Me.txtCourierID3.Text = "CourierID"
        '
        'btnUpdatePackageStatus
        '
        Me.btnUpdatePackageStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdatePackageStatus.AutoSize = True
        Me.btnUpdatePackageStatus.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnUpdatePackageStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdatePackageStatus.Location = New System.Drawing.Point(740, 120)
        Me.btnUpdatePackageStatus.Name = "btnUpdatePackageStatus"
        Me.btnUpdatePackageStatus.Size = New System.Drawing.Size(219, 61)
        Me.btnUpdatePackageStatus.TabIndex = 5
        Me.btnUpdatePackageStatus.Text = "Update Packages Status"
        Me.btnUpdatePackageStatus.UseVisualStyleBackColor = False
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(425, 153)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(130, 28)
        Me.cmbStatus.TabIndex = 6
        '
        'lblStatusPackages
        '
        Me.lblStatusPackages.AutoSize = True
        Me.lblStatusPackages.BackColor = System.Drawing.Color.Transparent
        Me.lblStatusPackages.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusPackages.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStatusPackages.Location = New System.Drawing.Point(421, 120)
        Me.lblStatusPackages.Name = "lblStatusPackages"
        Me.lblStatusPackages.Size = New System.Drawing.Size(62, 20)
        Me.lblStatusPackages.TabIndex = 7
        Me.lblStatusPackages.Text = "Status"
        '
        'lblPackageID2
        '
        Me.lblPackageID2.AutoSize = True
        Me.lblPackageID2.BackColor = System.Drawing.Color.Transparent
        Me.lblPackageID2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPackageID2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPackageID2.Location = New System.Drawing.Point(222, 120)
        Me.lblPackageID2.Name = "lblPackageID2"
        Me.lblPackageID2.Size = New System.Drawing.Size(102, 20)
        Me.lblPackageID2.TabIndex = 8
        Me.lblPackageID2.Text = "Package ID"
        '
        'txtPackageID2
        '
        Me.txtPackageID2.Location = New System.Drawing.Point(226, 155)
        Me.txtPackageID2.Name = "txtPackageID2"
        Me.txtPackageID2.Size = New System.Drawing.Size(150, 26)
        Me.txtPackageID2.TabIndex = 9
        Me.txtPackageID2.Text = "PackageID"
        '
        'ViewPackagesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Kurir.My.Resources.Resources._6068294
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1002, 712)
        Me.Controls.Add(Me.txtPackageID2)
        Me.Controls.Add(Me.lblPackageID2)
        Me.Controls.Add(Me.lblStatusPackages)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.btnUpdatePackageStatus)
        Me.Controls.Add(Me.txtCourierID3)
        Me.Controls.Add(Me.lblCourierID3)
        Me.Controls.Add(Me.btnSelectPackages)
        Me.Controls.Add(Me.btnBackVPF)
        Me.Controls.Add(Me.dgvViewPackagesForm)
        Me.Name = "ViewPackagesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewPackagesForm"
        CType(Me.dgvViewPackagesForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvViewPackagesForm As DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnBackVPF As Button
    Friend WithEvents btnSelectPackages As Button
    Friend WithEvents lblCourierID3 As Label
    Friend WithEvents txtCourierID3 As TextBox
    Friend WithEvents btnUpdatePackageStatus As Button
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents lblStatusPackages As Label
    Friend WithEvents lblPackageID2 As Label
    Friend WithEvents txtPackageID2 As TextBox
End Class
