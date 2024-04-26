<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_days_to_monitor_blood_donations = New System.Windows.Forms.TextBox()
        Me.grd_blood_donations = New UJGrid.UJGrid()
        Me.btn_set_days = New System.Windows.Forms.Button()
        Me.btn_set_donors = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(430, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "number of days to monitor blood donations:"
        '
        'txt_days_to_monitor_blood_donations
        '
        Me.txt_days_to_monitor_blood_donations.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_days_to_monitor_blood_donations.Location = New System.Drawing.Point(495, 37)
        Me.txt_days_to_monitor_blood_donations.Name = "txt_days_to_monitor_blood_donations"
        Me.txt_days_to_monitor_blood_donations.Size = New System.Drawing.Size(100, 32)
        Me.txt_days_to_monitor_blood_donations.TabIndex = 1
        '
        'grd_blood_donations
        '
        Me.grd_blood_donations.Dock = System.Windows.Forms.DockStyle.Right
        Me.grd_blood_donations.FixedCols = 1
        Me.grd_blood_donations.FixedRows = 1
        Me.grd_blood_donations.Location = New System.Drawing.Point(713, 0)
        Me.grd_blood_donations.Margin = New System.Windows.Forms.Padding(4)
        Me.grd_blood_donations.Name = "grd_blood_donations"
        Me.grd_blood_donations.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grd_blood_donations.Size = New System.Drawing.Size(458, 734)
        Me.grd_blood_donations.TabIndex = 2
        '
        'btn_set_days
        '
        Me.btn_set_days.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_set_days.Location = New System.Drawing.Point(320, 98)
        Me.btn_set_days.Name = "btn_set_days"
        Me.btn_set_days.Size = New System.Drawing.Size(275, 75)
        Me.btn_set_days.TabIndex = 3
        Me.btn_set_days.Text = "Set Days"
        Me.btn_set_days.UseVisualStyleBackColor = True
        '
        'btn_set_donors
        '
        Me.btn_set_donors.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_set_donors.Location = New System.Drawing.Point(320, 189)
        Me.btn_set_donors.Name = "btn_set_donors"
        Me.btn_set_donors.Size = New System.Drawing.Size(275, 67)
        Me.btn_set_donors.TabIndex = 4
        Me.btn_set_donors.Text = "Set Donors"
        Me.btn_set_donors.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1171, 734)
        Me.Controls.Add(Me.btn_set_donors)
        Me.Controls.Add(Me.btn_set_days)
        Me.Controls.Add(Me.grd_blood_donations)
        Me.Controls.Add(Me.txt_days_to_monitor_blood_donations)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_days_to_monitor_blood_donations As TextBox
    Friend WithEvents grd_blood_donations As UJGrid.UJGrid
    Friend WithEvents btn_set_days As Button
    Friend WithEvents btn_set_donors As Button
End Class
