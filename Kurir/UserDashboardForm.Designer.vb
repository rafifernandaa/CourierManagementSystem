<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserDashboardForm
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
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NavigateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PackagesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CouriersToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTotalPackages = New System.Windows.Forms.Label()
        Me.lblActiveCouriers = New System.Windows.Forms.Label()
        Me.lblPendingDeliveries = New System.Windows.Forms.Label()
        Me.btnViewPackages = New System.Windows.Forms.Button()
        Me.btnViewCouriers = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.Khaki
        Me.MenuStrip2.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NavigateToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1002, 30)
        Me.MenuStrip2.TabIndex = 6
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem1, Me.ExitToolStripMenuItem2})
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(73, 26)
        Me.ExitToolStripMenuItem.Text = "Home"
        '
        'LoginToolStripMenuItem1
        '
        Me.LoginToolStripMenuItem1.Name = "LoginToolStripMenuItem1"
        Me.LoginToolStripMenuItem1.Size = New System.Drawing.Size(154, 34)
        Me.LoginToolStripMenuItem1.Text = "Login"
        '
        'ExitToolStripMenuItem2
        '
        Me.ExitToolStripMenuItem2.Name = "ExitToolStripMenuItem2"
        Me.ExitToolStripMenuItem2.Size = New System.Drawing.Size(154, 34)
        Me.ExitToolStripMenuItem2.Text = "Exit"
        '
        'NavigateToolStripMenuItem
        '
        Me.NavigateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PackagesToolStripMenuItem1, Me.CouriersToolStripMenuItem1})
        Me.NavigateToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavigateToolStripMenuItem.Name = "NavigateToolStripMenuItem"
        Me.NavigateToolStripMenuItem.Size = New System.Drawing.Size(97, 26)
        Me.NavigateToolStripMenuItem.Text = "Navigate"
        '
        'PackagesToolStripMenuItem1
        '
        Me.PackagesToolStripMenuItem1.Name = "PackagesToolStripMenuItem1"
        Me.PackagesToolStripMenuItem1.Size = New System.Drawing.Size(189, 34)
        Me.PackagesToolStripMenuItem1.Text = "Packages"
        '
        'CouriersToolStripMenuItem1
        '
        Me.CouriersToolStripMenuItem1.Name = "CouriersToolStripMenuItem1"
        Me.CouriersToolStripMenuItem1.Size = New System.Drawing.Size(189, 34)
        Me.CouriersToolStripMenuItem1.Text = "Couriers"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(63, 26)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(157, 34)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'lblTotalPackages
        '
        Me.lblTotalPackages.AutoSize = True
        Me.lblTotalPackages.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPackages.Location = New System.Drawing.Point(691, 58)
        Me.lblTotalPackages.Name = "lblTotalPackages"
        Me.lblTotalPackages.Size = New System.Drawing.Size(132, 20)
        Me.lblTotalPackages.TabIndex = 7
        Me.lblTotalPackages.Text = "Total Packages"
        '
        'lblActiveCouriers
        '
        Me.lblActiveCouriers.AutoSize = True
        Me.lblActiveCouriers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActiveCouriers.Location = New System.Drawing.Point(691, 130)
        Me.lblActiveCouriers.Name = "lblActiveCouriers"
        Me.lblActiveCouriers.Size = New System.Drawing.Size(130, 20)
        Me.lblActiveCouriers.TabIndex = 8
        Me.lblActiveCouriers.Text = "Active Couriers"
        '
        'lblPendingDeliveries
        '
        Me.lblPendingDeliveries.AutoSize = True
        Me.lblPendingDeliveries.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendingDeliveries.Location = New System.Drawing.Point(691, 94)
        Me.lblPendingDeliveries.Name = "lblPendingDeliveries"
        Me.lblPendingDeliveries.Size = New System.Drawing.Size(157, 20)
        Me.lblPendingDeliveries.TabIndex = 9
        Me.lblPendingDeliveries.Text = "Pending Deliveries"
        '
        'btnViewPackages
        '
        Me.btnViewPackages.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnViewPackages.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewPackages.Location = New System.Drawing.Point(139, 537)
        Me.btnViewPackages.Name = "btnViewPackages"
        Me.btnViewPackages.Size = New System.Drawing.Size(246, 60)
        Me.btnViewPackages.TabIndex = 10
        Me.btnViewPackages.Text = "View Packages"
        Me.btnViewPackages.UseVisualStyleBackColor = False
        '
        'btnViewCouriers
        '
        Me.btnViewCouriers.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnViewCouriers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewCouriers.Location = New System.Drawing.Point(628, 537)
        Me.btnViewCouriers.Name = "btnViewCouriers"
        Me.btnViewCouriers.Size = New System.Drawing.Size(246, 60)
        Me.btnViewCouriers.TabIndex = 11
        Me.btnViewCouriers.Text = "View Couriers"
        Me.btnViewCouriers.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Kurir.My.Resources.Resources.pngwing_com__8_
        Me.PictureBox2.Location = New System.Drawing.Point(538, 228)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(403, 274)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Kurir.My.Resources.Resources.pngwing_com__9_
        Me.PictureBox1.Location = New System.Drawing.Point(69, 228)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(403, 274)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'UserDashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Kurir.My.Resources.Resources._6068294
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1002, 712)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnViewCouriers)
        Me.Controls.Add(Me.btnViewPackages)
        Me.Controls.Add(Me.lblPendingDeliveries)
        Me.Controls.Add(Me.lblActiveCouriers)
        Me.Controls.Add(Me.lblTotalPackages)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "UserDashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserDashboardForm"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents NavigateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PackagesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CouriersToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents lblTotalPackages As Label
    Friend WithEvents lblActiveCouriers As Label
    Friend WithEvents lblPendingDeliveries As Label
    Friend WithEvents btnViewPackages As Button
    Friend WithEvents btnViewCouriers As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
