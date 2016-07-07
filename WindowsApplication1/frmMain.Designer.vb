<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.nmbMatrixX = New System.Windows.Forms.NumericUpDown()
        Me.nmbMatrixY = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnShowSelection = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMatrixX = New System.Windows.Forms.Label()
        Me.lblMatrixY = New System.Windows.Forms.Label()
        Me.btnPixels = New System.Windows.Forms.Button()
        Me.rtbPixels = New System.Windows.Forms.RichTextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.tbxServerIP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nmbServerPort = New System.Windows.Forms.NumericUpDown()
        Me.btnOutput = New System.Windows.Forms.Button()
        CType(Me.nmbMatrixX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmbMatrixY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmbServerPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nmbMatrixX
        '
        Me.nmbMatrixX.Location = New System.Drawing.Point(12, 34)
        Me.nmbMatrixX.Maximum = New Decimal(New Integer() {1024, 0, 0, 0})
        Me.nmbMatrixX.Name = "nmbMatrixX"
        Me.nmbMatrixX.Size = New System.Drawing.Size(58, 20)
        Me.nmbMatrixX.TabIndex = 0
        Me.nmbMatrixX.Value = New Decimal(New Integer() {128, 0, 0, 0})
        '
        'nmbMatrixY
        '
        Me.nmbMatrixY.Location = New System.Drawing.Point(76, 34)
        Me.nmbMatrixY.Maximum = New Decimal(New Integer() {256, 0, 0, 0})
        Me.nmbMatrixY.Name = "nmbMatrixY"
        Me.nmbMatrixY.Size = New System.Drawing.Size(58, 20)
        Me.nmbMatrixY.TabIndex = 1
        Me.nmbMatrixY.Value = New Decimal(New Integer() {32, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Y"
        '
        'btnShowSelection
        '
        Me.btnShowSelection.Location = New System.Drawing.Point(140, 31)
        Me.btnShowSelection.Name = "btnShowSelection"
        Me.btnShowSelection.Size = New System.Drawing.Size(75, 23)
        Me.btnShowSelection.TabIndex = 4
        Me.btnShowSelection.Text = "Show"
        Me.btnShowSelection.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "X-pos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Y-pos:"
        '
        'lblMatrixX
        '
        Me.lblMatrixX.AutoSize = True
        Me.lblMatrixX.Location = New System.Drawing.Point(55, 57)
        Me.lblMatrixX.Name = "lblMatrixX"
        Me.lblMatrixX.Size = New System.Drawing.Size(0, 13)
        Me.lblMatrixX.TabIndex = 7
        '
        'lblMatrixY
        '
        Me.lblMatrixY.AutoSize = True
        Me.lblMatrixY.Location = New System.Drawing.Point(55, 70)
        Me.lblMatrixY.Name = "lblMatrixY"
        Me.lblMatrixY.Size = New System.Drawing.Size(0, 13)
        Me.lblMatrixY.TabIndex = 8
        '
        'btnPixels
        '
        Me.btnPixels.Location = New System.Drawing.Point(403, 31)
        Me.btnPixels.Name = "btnPixels"
        Me.btnPixels.Size = New System.Drawing.Size(75, 23)
        Me.btnPixels.TabIndex = 9
        Me.btnPixels.Text = "Get pixels"
        Me.btnPixels.UseVisualStyleBackColor = True
        '
        'rtbPixels
        '
        Me.rtbPixels.Location = New System.Drawing.Point(12, 86)
        Me.rtbPixels.Name = "rtbPixels"
        Me.rtbPixels.Size = New System.Drawing.Size(466, 172)
        Me.rtbPixels.TabIndex = 10
        Me.rtbPixels.Text = ""
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(400, 70)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(0, 13)
        Me.lblTime.TabIndex = 11
        '
        'tbxServerIP
        '
        Me.tbxServerIP.Location = New System.Drawing.Point(221, 33)
        Me.tbxServerIP.Name = "tbxServerIP"
        Me.tbxServerIP.Size = New System.Drawing.Size(100, 20)
        Me.tbxServerIP.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(221, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "PixelServer IP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(324, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Port"
        '
        'nmbServerPort
        '
        Me.nmbServerPort.Location = New System.Drawing.Point(327, 34)
        Me.nmbServerPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.nmbServerPort.Name = "nmbServerPort"
        Me.nmbServerPort.Size = New System.Drawing.Size(58, 20)
        Me.nmbServerPort.TabIndex = 15
        Me.nmbServerPort.Value = New Decimal(New Integer() {29960, 0, 0, 0})
        '
        'btnOutput
        '
        Me.btnOutput.Location = New System.Drawing.Point(221, 57)
        Me.btnOutput.Name = "btnOutput"
        Me.btnOutput.Size = New System.Drawing.Size(75, 23)
        Me.btnOutput.TabIndex = 16
        Me.btnOutput.Text = "Start output"
        Me.btnOutput.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 261)
        Me.Controls.Add(Me.btnOutput)
        Me.Controls.Add(Me.nmbServerPort)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbxServerIP)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.rtbPixels)
        Me.Controls.Add(Me.btnPixels)
        Me.Controls.Add(Me.lblMatrixY)
        Me.Controls.Add(Me.lblMatrixX)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnShowSelection)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nmbMatrixY)
        Me.Controls.Add(Me.nmbMatrixX)
        Me.Name = "frmMain"
        Me.Text = "ScreenPixelator"
        CType(Me.nmbMatrixX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmbMatrixY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmbServerPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nmbMatrixX As System.Windows.Forms.NumericUpDown
    Friend WithEvents nmbMatrixY As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnShowSelection As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblMatrixX As System.Windows.Forms.Label
    Friend WithEvents lblMatrixY As System.Windows.Forms.Label
    Friend WithEvents btnPixels As System.Windows.Forms.Button
    Friend WithEvents rtbPixels As System.Windows.Forms.RichTextBox
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents tbxServerIP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nmbServerPort As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnOutput As System.Windows.Forms.Button

End Class
