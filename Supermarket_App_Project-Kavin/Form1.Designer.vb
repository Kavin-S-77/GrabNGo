<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.CheckBoxChicken = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMango = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOrange = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PriceCalculationButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TotalPriceLabel = New System.Windows.Forms.Label()
        Me.BalanceLabel = New System.Windows.Forms.Label()
        Me.SettleButton = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.AmountPaidTextBox = New System.Windows.Forms.TextBox()
        Me.NumericUpDownChicken = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownMango = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownOrange = New System.Windows.Forms.NumericUpDown()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NoOfPlasticLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.clockLabel = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownChicken, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownMango, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownOrange, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBoxChicken
        '
        Me.CheckBoxChicken.AutoSize = True
        Me.CheckBoxChicken.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.CheckBoxChicken.Location = New System.Drawing.Point(107, 116)
        Me.CheckBoxChicken.Margin = New System.Windows.Forms.Padding(6)
        Me.CheckBoxChicken.Name = "CheckBoxChicken"
        Me.CheckBoxChicken.Size = New System.Drawing.Size(110, 30)
        Me.CheckBoxChicken.TabIndex = 0
        Me.CheckBoxChicken.Text = "Chicken"
        Me.CheckBoxChicken.UseVisualStyleBackColor = True
        '
        'CheckBoxMango
        '
        Me.CheckBoxMango.AutoSize = True
        Me.CheckBoxMango.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.CheckBoxMango.Location = New System.Drawing.Point(107, 177)
        Me.CheckBoxMango.Margin = New System.Windows.Forms.Padding(6)
        Me.CheckBoxMango.Name = "CheckBoxMango"
        Me.CheckBoxMango.Size = New System.Drawing.Size(97, 30)
        Me.CheckBoxMango.TabIndex = 1
        Me.CheckBoxMango.Text = "Mango"
        Me.CheckBoxMango.UseVisualStyleBackColor = True
        '
        'CheckBoxOrange
        '
        Me.CheckBoxOrange.AutoSize = True
        Me.CheckBoxOrange.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.CheckBoxOrange.Location = New System.Drawing.Point(107, 233)
        Me.CheckBoxOrange.Margin = New System.Windows.Forms.Padding(6)
        Me.CheckBoxOrange.Name = "CheckBoxOrange"
        Me.CheckBoxOrange.Size = New System.Drawing.Size(103, 30)
        Me.CheckBoxOrange.TabIndex = 2
        Me.CheckBoxOrange.Text = "Orange"
        Me.CheckBoxOrange.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(355, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 26)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "RM 17.765"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(355, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 26)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "RM 7.4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(355, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 26)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "RM 1.362"
        '
        'PriceCalculationButton
        '
        Me.PriceCalculationButton.Location = New System.Drawing.Point(159, 420)
        Me.PriceCalculationButton.Name = "PriceCalculationButton"
        Me.PriceCalculationButton.Size = New System.Drawing.Size(230, 106)
        Me.PriceCalculationButton.TabIndex = 9
        Me.PriceCalculationButton.Text = "Calculate"
        Me.PriceCalculationButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(564, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 26)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Paid"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(564, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 26)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(564, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 26)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Balance"
        '
        'TotalPriceLabel
        '
        Me.TotalPriceLabel.AutoSize = True
        Me.TotalPriceLabel.Location = New System.Drawing.Point(629, 181)
        Me.TotalPriceLabel.Name = "TotalPriceLabel"
        Me.TotalPriceLabel.Size = New System.Drawing.Size(24, 26)
        Me.TotalPriceLabel.TabIndex = 13
        Me.TotalPriceLabel.Text = "0"
        '
        'BalanceLabel
        '
        Me.BalanceLabel.AutoSize = True
        Me.BalanceLabel.Location = New System.Drawing.Point(661, 235)
        Me.BalanceLabel.Name = "BalanceLabel"
        Me.BalanceLabel.Size = New System.Drawing.Size(24, 26)
        Me.BalanceLabel.TabIndex = 14
        Me.BalanceLabel.Text = "0"
        '
        'SettleButton
        '
        Me.SettleButton.Location = New System.Drawing.Point(608, 420)
        Me.SettleButton.Name = "SettleButton"
        Me.SettleButton.Size = New System.Drawing.Size(226, 106)
        Me.SettleButton.TabIndex = 15
        Me.SettleButton.Text = "Settle"
        Me.SettleButton.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(801, 118)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(113, 30)
        Me.RadioButton1.TabIndex = 16
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "E-Wallet"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(801, 180)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(134, 30)
        Me.RadioButton2.TabIndex = 17
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Debit Card"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(801, 235)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(81, 30)
        Me.RadioButton3.TabIndex = 18
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Cash"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'AmountPaidTextBox
        '
        Me.AmountPaidTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountPaidTextBox.Location = New System.Drawing.Point(629, 115)
        Me.AmountPaidTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.AmountPaidTextBox.Name = "AmountPaidTextBox"
        Me.AmountPaidTextBox.Size = New System.Drawing.Size(103, 32)
        Me.AmountPaidTextBox.TabIndex = 25
        '
        'NumericUpDownChicken
        '
        Me.NumericUpDownChicken.Location = New System.Drawing.Point(219, 116)
        Me.NumericUpDownChicken.Name = "NumericUpDownChicken"
        Me.NumericUpDownChicken.Size = New System.Drawing.Size(120, 32)
        Me.NumericUpDownChicken.TabIndex = 26
        '
        'NumericUpDownMango
        '
        Me.NumericUpDownMango.Location = New System.Drawing.Point(219, 177)
        Me.NumericUpDownMango.Name = "NumericUpDownMango"
        Me.NumericUpDownMango.Size = New System.Drawing.Size(120, 32)
        Me.NumericUpDownMango.TabIndex = 27
        '
        'NumericUpDownOrange
        '
        Me.NumericUpDownOrange.Location = New System.Drawing.Point(219, 233)
        Me.NumericUpDownOrange.Name = "NumericUpDownOrange"
        Me.NumericUpDownOrange.Size = New System.Drawing.Size(120, 32)
        Me.NumericUpDownOrange.TabIndex = 28
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.BeepOnError = True
        Me.MaskedTextBox2.Location = New System.Drawing.Point(709, 317)
        Me.MaskedTextBox2.Mask = "000-000 0000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.RejectInputOnFirstFailure = True
        Me.MaskedTextBox2.Size = New System.Drawing.Size(173, 32)
        Me.MaskedTextBox2.TabIndex = 30
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(107, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(246, 57)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Add Plastic Bag(0.20)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(369, 337)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 26)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "NO:"
        '
        'NoOfPlasticLabel
        '
        Me.NoOfPlasticLabel.AutoSize = True
        Me.NoOfPlasticLabel.Location = New System.Drawing.Point(423, 337)
        Me.NoOfPlasticLabel.Name = "NoOfPlasticLabel"
        Me.NoOfPlasticLabel.Size = New System.Drawing.Size(24, 26)
        Me.NoOfPlasticLabel.TabIndex = 33
        Me.NoOfPlasticLabel.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(564, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 26)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Membership"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'clockLabel
        '
        Me.clockLabel.AutoSize = True
        Me.clockLabel.BackColor = System.Drawing.Color.White
        Me.clockLabel.Location = New System.Drawing.Point(672, 9)
        Me.clockLabel.Name = "clockLabel"
        Me.clockLabel.Size = New System.Drawing.Size(60, 26)
        Me.clockLabel.TabIndex = 35
        Me.clockLabel.Text = "Time"
        Me.clockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(967, 575)
        Me.Controls.Add(Me.clockLabel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.NoOfPlasticLabel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.NumericUpDownOrange)
        Me.Controls.Add(Me.NumericUpDownMango)
        Me.Controls.Add(Me.NumericUpDownChicken)
        Me.Controls.Add(Me.AmountPaidTextBox)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.SettleButton)
        Me.Controls.Add(Me.BalanceLabel)
        Me.Controls.Add(Me.TotalPriceLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PriceCalculationButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBoxOrange)
        Me.Controls.Add(Me.CheckBoxMango)
        Me.Controls.Add(Me.CheckBoxChicken)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "  "
        CType(Me.NumericUpDownChicken, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownMango, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownOrange, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBoxChicken As CheckBox
    Friend WithEvents CheckBoxMango As CheckBox
    Friend WithEvents CheckBoxOrange As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PriceCalculationButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TotalPriceLabel As Label
    Friend WithEvents BalanceLabel As Label
    Friend WithEvents SettleButton As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents AmountPaidTextBox As TextBox
    Friend WithEvents NumericUpDownChicken As NumericUpDown
    Friend WithEvents NumericUpDownMango As NumericUpDown
    Friend WithEvents NumericUpDownOrange As NumericUpDown
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents NoOfPlasticLabel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents clockLabel As Label
End Class
