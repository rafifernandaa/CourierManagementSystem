<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoryForm
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
        Me.dgvHistory = New System.Windows.Forms.DataGridView()
        Me.btnBackHF = New System.Windows.Forms.Button()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvHistory
        '
        Me.dgvHistory.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistory.Location = New System.Drawing.Point(36, 153)
        Me.dgvHistory.Name = "dgvHistory"
        Me.dgvHistory.RowHeadersWidth = 62
        Me.dgvHistory.RowTemplate.Height = 28
        Me.dgvHistory.Size = New System.Drawing.Size(923, 508)
        Me.dgvHistory.TabIndex = 0
        '
        'btnBackHF
        '
        Me.btnBackHF.BackColor = System.Drawing.Color.Khaki
        Me.btnBackHF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackHF.Location = New System.Drawing.Point(23, 21)
        Me.btnBackHF.Name = "btnBackHF"
        Me.btnBackHF.Size = New System.Drawing.Size(97, 44)
        Me.btnBackHF.TabIndex = 13
        Me.btnBackHF.Text = "Back"
        Me.btnBackHF.UseVisualStyleBackColor = False
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFilter.Location = New System.Drawing.Point(809, 89)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(150, 44)
        Me.btnFilter.TabIndex = 2
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'cmbFilter
        '
        Me.cmbFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Items.AddRange(New Object() {"Add", "Update", "Delete"})
        Me.cmbFilter.Location = New System.Drawing.Point(619, 105)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(166, 28)
        Me.cmbFilter.TabIndex = 3
        Me.cmbFilter.Text = "Status"
        '
        'HistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Kurir.My.Resources.Resources._6068294
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1002, 712)
        Me.Controls.Add(Me.cmbFilter)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.btnBackHF)
        Me.Controls.Add(Me.dgvHistory)
        Me.Name = "HistoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HistoryForm"
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvHistory As DataGridView
    Friend WithEvents btnBackHF As Button
    Friend WithEvents btnFilter As Button
    Friend WithEvents cmbFilter As ComboBox
End Class
