<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
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
        Me.components = New System.ComponentModel.Container()
        Me.lbUnits = New System.Windows.Forms.Label()
        Me.lbDay = New System.Windows.Forms.Label()
        Me.lbResult = New System.Windows.Forms.Label()
        Me.tbUnits = New System.Windows.Forms.TextBox()
        Me.tbDataHistory = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ttToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lbUnits
        '
        Me.lbUnits.Location = New System.Drawing.Point(22, 10)
        Me.lbUnits.Name = "lbUnits"
        Me.lbUnits.Size = New System.Drawing.Size(60, 33)
        Me.lbUnits.TabIndex = 0
        Me.lbUnits.Text = "&Units:"
        Me.lbUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttToolTip.SetToolTip(Me.lbUnits, "Units")
        '
        'lbDay
        '
        Me.lbDay.Location = New System.Drawing.Point(194, 15)
        Me.lbDay.Name = "lbDay"
        Me.lbDay.Size = New System.Drawing.Size(55, 23)
        Me.lbDay.TabIndex = 2
        Me.lbDay.Text = "Day 1"
        Me.lbDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttToolTip.SetToolTip(Me.lbDay, "Day to input units")
        '
        'lbResult
        '
        Me.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbResult.Location = New System.Drawing.Point(40, 172)
        Me.lbResult.Name = "lbResult"
        Me.lbResult.Size = New System.Drawing.Size(195, 23)
        Me.lbResult.TabIndex = 4
        Me.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttToolTip.SetToolTip(Me.lbResult, "Calculated Average Units Shipped")
        '
        'tbUnits
        '
        Me.tbUnits.Location = New System.Drawing.Point(88, 15)
        Me.tbUnits.Name = "tbUnits"
        Me.tbUnits.Size = New System.Drawing.Size(100, 22)
        Me.tbUnits.TabIndex = 1
        Me.ttToolTip.SetToolTip(Me.tbUnits, "Input units per day as whole numbers")
        '
        'tbDataHistory
        '
        Me.tbDataHistory.BackColor = System.Drawing.SystemColors.HighlightText
        Me.tbDataHistory.Location = New System.Drawing.Point(41, 49)
        Me.tbDataHistory.Multiline = True
        Me.tbDataHistory.Name = "tbDataHistory"
        Me.tbDataHistory.ReadOnly = True
        Me.tbDataHistory.Size = New System.Drawing.Size(194, 120)
        Me.tbDataHistory.TabIndex = 3
        Me.ttToolTip.SetToolTip(Me.tbDataHistory, "Shows units already inputed")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(22, 207)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 5
        Me.btnEnter.Text = "&Enter"
        Me.ttToolTip.SetToolTip(Me.btnEnter, "Save units inputed and calculate the average after 7 inputs")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(103, 207)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.ttToolTip.SetToolTip(Me.btnReset, "Clear screen")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(184, 207)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.ttToolTip.SetToolTip(Me.btnExit, "Exit application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.tbDataHistory)
        Me.Controls.Add(Me.tbUnits)
        Me.Controls.Add(Me.lbResult)
        Me.Controls.Add(Me.lbDay)
        Me.Controls.Add(Me.lbUnits)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ttToolTip.SetToolTip(Me, "Average Units Shipped Calculator")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbUnits As Label
    Friend WithEvents lbDay As Label
    Friend WithEvents lbResult As Label
    Friend WithEvents tbUnits As TextBox
    Friend WithEvents tbDataHistory As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ttToolTip As ToolTip
End Class
