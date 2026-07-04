Imports System.Runtime.InteropServices

Public Class Form1

    Const priceOfOnePlasticBag As Single = 0.2

    Dim amountPaid As Double
    Dim formattedAmountPaid As String

    Dim balance As Double
    Dim formattedBalance As String

    Dim discountedPrice As Double
    Dim formattedDiscountPrice As String

    Dim totalPrice As Double
    Dim storedTotalPrice As Double
    Dim formattedTotalPrice As String

    Dim printReceiptMsg As Integer
    Dim resetMsg As Integer

    Dim chickenPrice As Double
    Dim formattedChickenPrice As String
    Dim mangoPrice As Double
    Dim formattedMangoPrice As String
    Dim orangePrice As Double
    Dim formattedOrangePrice As String

    Dim plasticBagPrice As Double
    Dim formattedPlasticBagPrice As String

    Dim paymentType As String
    Private Sub PriceCalculationButton_Click(sender As Object, e As EventArgs) Handles PriceCalculationButton.Click
        If CheckBoxChicken.Checked = True Then
            'Calculates the price of chicken
            chickenPrice = 17.765 * NumericUpDownChicken.Value
        Else
            chickenPrice = 0
        End If
        formattedChickenPrice = Format(chickenPrice, "Currency")

        If CheckBoxMango.Checked = True Then
            'Calculates the price of mango
            mangoPrice = 7.4 * NumericUpDownMango.Value
        Else
            mangoPrice = 0
        End If
        formattedMangoPrice = Format(mangoPrice, "Currency")


        If CheckBoxOrange.Checked = True Then
            'Calculates the price of orange
            orangePrice = 1.362 * NumericUpDownOrange.Value
        Else
            orangePrice = 0
        End If
        formattedOrangePrice = Format(orangePrice, "Currency")

        'Calculates, formats and displays the total
        totalPrice = chickenPrice + mangoPrice + orangePrice + plasticBagPrice
        formattedTotalPrice = Format(totalPrice, "Currency")
        TotalPriceLabel.Text = formattedTotalPrice
    End Sub

    Private Sub SettleButton_Click(sender As Object, e As EventArgs) Handles SettleButton.Click
        If paymentType = "" Then
            'Checks if the user has selected a payment option
            MsgBox("Please select a payment option.", vbOKOnly + vbExclamation)
        ElseIf paymentType = "Debit Card" Then
            'Undergoes the payment procedure for debit card
            MemberDiscount()
            AmountPaidTextBox.Text = TotalPriceLabel.Text
            amountPaid = AmountPaidTextBox.Text
            formattedAmountPaid = Format(amountPaid, "Currency")
            AmountPaidTextBox.BackColor = Color.LawnGreen
            MsgBox("Paid " & formattedAmountPaid & " through " & paymentType)
            PrintReceipt()
            MsgBox("Thank you for using this app!")
        Else
            If Not Double.TryParse(AmountPaidTextBox.Text, storedTotalPrice) Then
                'Checks if the amount entered is a integer or decimal
                MsgBox("Please enter a valid number", vbOKOnly)
            Else
                amountPaid = AmountPaidTextBox.Text

                If amountPaid < totalPrice Then
                    'Changes the color to red if the amount entered is less that the total
                    AmountPaidTextBox.BackColor = Color.Red
                    MsgBox("Please ensure that your payment is greater than the total price.", vbOKOnly + vbCritical)
                Else
                    'Undergoes the payment procedure for cash or e-wallet 
                    MemberDiscount()
                    balance = amountPaid - discountedPrice
                    formattedAmountPaid = Format(amountPaid, "Currency")
                    AmountPaidTextBox.Text = formattedAmountPaid
                    formattedBalance = Format(balance, "Currency")
                    BalanceLabel.Text = formattedBalance
                    AmountPaidTextBox.BackColor = Color.LawnGreen
                    MsgBox("Paid " & formattedAmountPaid & " with balance of " & formattedBalance & " through " & paymentType)
                    PrintReceipt()
                    MsgBox("Thank you for using this app!")
                End If
            End If
        End If

    End Sub
    Private Sub EWalletRDB_CheckedChanged(sender As Object, e As EventArgs) Handles EWalletRDB.CheckedChanged
        paymentType = "E-Wallet"
    End Sub

    Private Sub DebitCard_CheckedChanged(sender As Object, e As EventArgs) Handles DebitCardRDB.CheckedChanged
        paymentType = "Debit Card"
    End Sub

    Private Sub CashRDB_CheckedChanged(sender As Object, e As EventArgs) Handles CashRDB.CheckedChanged
        paymentType = "Cash"
    End Sub

    Private Sub PlasticButton_Click(sender As Object, e As EventArgs) Handles PlasticButton.Click
        plasticBagPrice += priceOfOnePlasticBag
        NoOfPlasticLabel.Text += 1
        totalPrice += priceOfOnePlasticBag
        formattedTotalPrice = Format(totalPrice, "Currency")
        TotalPriceLabel.Text = formattedTotalPrice
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        resetMsg = MsgBox("All progress will be lost" & vbCrLf &
                          "Do you wish to continue?", vbYesNo)
        If resetMsg = vbYes Then
            amountPaid = 0
            formattedAmountPaid = ""
            balance = 0
            formattedBalance = ""
            discountedPrice = 0
            formattedDiscountPrice = ""
            totalPrice = 0
            storedTotalPrice = 0
            formattedTotalPrice = ""
            printReceiptMsg = 0

            orangePrice = 0
            formattedOrangePrice = ""
            mangoPrice = 0
            formattedMangoPrice = ""
            orangePrice = 0
            formattedOrangePrice = ""
            plasticBagPrice = 0
            formattedPlasticBagPrice = ""
            paymentType = ""

            NumericUpDownChicken.Value = 0
            NumericUpDownMango.Value = 0
            NumericUpDownOrange.Value = 0
            CheckBoxChicken.Checked = False
            CheckBoxMango.Checked = False
            CheckBoxOrange.Checked = False
            AmountPaidTextBox.BackColor = Color.White
            AmountPaidTextBox.Text = ""
            TotalPriceLabel.Text = "0"
            BalanceLabel.Text = "0"
            NoOfPlasticLabel.Text = "0"
            MemberMaskedTextBox.Text = ""
            EWalletRDB.Checked = False
            DebitCardRDB.Checked = False
            CashRDB.Checked = False
            resetMsg = 0
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        clockLabel.Text = Format(Now, "General Date")
    End Sub

    Private Sub PrintReceipt()
        printReceiptMsg = MsgBox("Do you want to print a receipt?", vbYesNo + vbQuestion)
        If printReceiptMsg = vbYes Then
            MsgBox("--RECEIPT--" & vbCrLf &
                    vbCrLf &
                    "Date: " & Format(Now, "Short Date") & vbCrLf &
                    "Time: " & Format(Now, "Long Time") & vbCrLf &
                    vbCrLf &
                    "Chicken: RM17.765     Qty: " & NumericUpDownChicken.Value & "     Amount: " & formattedChickenPrice & vbCrLf &
                    "Mango: RM7.40          Qty: " & NumericUpDownMango.Value & "     Amount: " & formattedMangoPrice & vbCrLf &
                    "Orange: RM1.362       Qty: " & NumericUpDownOrange.Value & "     Amount: " & formattedOrangePrice & vbCrLf &
                    "Plastic Bag: RM0.20    Qty: " & NoOfPlasticLabel.Text & "     Amount: " & Format(plasticBagPrice, "Currency") & vbCrLf &
                    vbCrLf &
                    "Type of Payment: " & paymentType & vbCrLf &
                    vbCrLf &
                    "Total Price: " & formattedTotalPrice & vbCrLf &
                    "Discounted Price: " & formattedDiscountPrice & vbCrLf &
                    vbCrLf &
                    "Amount Paid: " & formattedAmountPaid & vbCrLf &
                    "Balance: " & formattedBalance & vbCrLf)
        End If
    End Sub
    Private Sub MemberDiscount()
        If MemberMaskedTextBox.Text = "012-345 6789" Then
            MsgBox("You get a 5% discount", vbOKOnly)
            discountedPrice = totalPrice - (5 / 100 * totalPrice)
            formattedDiscountPrice = Format(discountedPrice, "Currency")
            TotalPriceLabel.Text = formattedDiscountPrice
        Else
            formattedDiscountPrice = TotalPriceLabel.Text
            discountedPrice = totalPrice
        End If
    End Sub


End Class
