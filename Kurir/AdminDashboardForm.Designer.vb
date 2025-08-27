<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboardForm
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
        Me.lblTotalPackages = New System.Windows.Forms.Label()
        Me.lblActiveCouriers = New System.Windows.Forms.Label()
        Me.lblPendingDeliveries = New System.Windows.Forms.Label()
        Me.btnPackages = New System.Windows.Forms.Button()
        Me.btnCouriers = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NavigateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PackagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CouriersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTotalPackages
        '
        Me.lblTotalPackages.AutoSize = True
        Me.lblTotalPackages.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalPackages.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPackages.Location = New System.Drawing.Point(691, 58)
        Me.lblTotalPackages.Name = "lblTotalPackages"
        Me.lblTotalPackages.Size = New System.Drawing.Size(132, 20)
        Me.lblTotalPackages.TabIndex = 0
        Me.lblTotalPackages.Text = "Total Packages"
        '
        'lblActiveCouriers
        '
        Me.lblActiveCouriers.AutoSize = True
        Me.lblActiveCouriers.BackColor = System.Drawing.Color.Transparent
        Me.lblActiveCouriers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActiveCouriers.Location = New System.Drawing.Point(691, 94)
        Me.lblActiveCouriers.Name = "lblActiveCouriers"
        Me.lblActiveCouriers.Size = New System.Drawing.Size(130, 20)
        Me.lblActiveCouriers.TabIndex = 1
        Me.lblActiveCouriers.Text = "Active Couriers"
        '
        'lblPendingDeliveries
        '
        Me.lblPendingDeliveries.AutoSize = True
        Me.lblPendingDeliveries.BackColor = System.Drawing.Color.Transparent
        Me.lblPendingDeliveries.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendingDeliveries.Location = New System.Drawing.Point(691, 130)
        Me.lblPendingDeliveries.Name = "lblPendingDeliveries"
        Me.lblPendingDeliveries.Size = New System.Drawing.Size(157, 20)
        Me.lblPendingDeliveries.TabIndex = 2
        Me.lblPendingDeliveries.Text = "Pending Deliveries"
        '
        'btnPackages
        '
        Me.btnPackages.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnPackages.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPackages.Location = New System.Drawing.Point(55, 537)
        Me.btnPackages.Name = "btnPackages"
        Me.btnPackages.Size = New System.Drawing.Size(253, 60)
        Me.btnPackages.TabIndex = 3
        Me.btnPackages.Text = "Manage Packages"
        Me.btnPackages.UseVisualStyleBackColor = False
        '
        'btnCouriers
        '
        Me.btnCouriers.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCouriers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCouriers.Location = New System.Drawing.Point(709, 537)
        Me.btnCouriers.Name = "btnCouriers"
        Me.btnCouriers.Size = New System.Drawing.Size(244, 60)
        Me.btnCouriers.TabIndex = 4
        Me.btnCouriers.Text = "Manage Couriers"
        Me.btnCouriers.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Khaki
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NavigateToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1002, 36)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(73, 32)
        Me.ExitToolStripMenuItem.Text = "Home"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(154, 34)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(154, 34)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'NavigateToolStripMenuItem
        '
        Me.NavigateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PackagesToolStripMenuItem, Me.CouriersToolStripMenuItem})
        Me.NavigateToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavigateToolStripMenuItem.Name = "NavigateToolStripMenuItem"
        Me.NavigateToolStripMenuItem.Size = New System.Drawing.Size(97, 32)
        Me.NavigateToolStripMenuItem.Text = "Navigate"
        '
        'PackagesToolStripMenuItem
        '
        Me.PackagesToolStripMenuItem.Name = "PackagesToolStripMenuItem"
        Me.PackagesToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.PackagesToolStripMenuItem.Text = "Packages"
        '
        'CouriersToolStripMenuItem
        '
        Me.CouriersToolStripMenuItem.Name = "CouriersToolStripMenuItem"
        Me.CouriersToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.CouriersToolStripMenuItem.Text = "Couriers"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(63, 32)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(157, 34)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.Location = New System.Drawing.Point(378, 537)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(246, 60)
        Me.btnHistory.TabIndex = 6
        Me.btnHistory.Text = "History"
        Me.btnHistory.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Kurir.My.Resources.Resources.pngwing_com__5_
        Me.PictureBox1.Location = New System.Drawing.Point(28, 228)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(306, 285)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Kurir.My.Resources.Resources.pngwing_com__7_
        Me.PictureBox2.Location = New System.Drawing.Point(349, 228)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(306, 285)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Kurir.My.Resources.Resources.pngwing_com__6_
        Me.PictureBox3.Location = New System.Drawing.Point(675, 228)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(306, 285)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'AdminDashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Kurir.My.Resources.Resources._6068294
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1002, 712)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.btnCouriers)
        Me.Controls.Add(Me.btnPackages)
        Me.Controls.Add(Me.lblPendingDeliveries)
        Me.Controls.Add(Me.lblActiveCouriers)
        Me.Controls.Add(Me.lblTotalPackages)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AdminDashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DashboardForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotalPackages As Label
    Friend WithEvents lblActiveCouriers As Label
    Friend WithEvents lblPendingDeliveries As Label
    Friend WithEvents btnPackages As Button
    Friend WithEvents btnCouriers As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NavigateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PackagesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CouriersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents btnHistory As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
