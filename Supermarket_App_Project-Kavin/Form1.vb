Imports System.Runtime.InteropServices

Public Class Form1

    Const priceOfOnePlasticBag As Single = 0.2
    Const priceOfOneChicken As Single = 17.765
    Const priceOfOneMango As Single = 7.4
    Const priceOfOneOrange As Single = 1.362

    Dim amountPaid, balance, memberdiscountPrice, discountPrice, totalPrice, storedTotalPrice As Double
    Dim chickenPrice, mangoPrice, orangePrice, plasticBagPrice As Double

    Dim formattedAmountPaid, formattedBalance, formattedMemberDiscountPrice, formattedDiscountPrice, formattedTotalPrice As String
    Dim receipt, formattedChickenPrice, formattedMangoPrice, formattedOrangePrice, formattedPlasticBagPrice, paymentType As String
    Dim colFormat As String = "{0,-25} {1,-10} {2,10}"

    Dim printReceiptMsg, resetMsg As Integer

    Private Sub PriceCalculationButton_Click(sender As Object, e As EventArgs) Handles PriceCalculationButton.Click
        If CheckBoxChicken.Checked = True Then
            'Calculates the price of chicken
            chickenPrice = priceOfOneChicken * NumericUpDownChicken.Value
        Else
            chickenPrice = 0
        End If
        formattedChickenPrice = Format(chickenPrice, "Currency")

        If CheckBoxMango.Checked = True Then
            'Calculates the price of mango
            mangoPrice = priceOfOneMango * NumericUpDownMango.Value
        Else
            mangoPrice = 0
        End If
        formattedMangoPrice = Format(mangoPrice, "Currency")


        If CheckBoxOrange.Checked = True Then
            'Calculates the price of orange
            orangePrice = priceOfOneOrange * NumericUpDownOrange.Value
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
        ElseIf Not Double.TryParse(AmountPaidTextBox.Text, storedTotalPrice) And AmountPaidTextBox.Text <> "" Then
            'Checks if the amount entered is a integer or decimal
            MsgBox("Please enter a valid number", vbOKOnly)
        Else
            ApplyMemberDiscount()
            ApplyDiscountCode()
            amountPaid = discountPrice
            If paymentType <> "Debit Card" Then
                amountPaid = AmountPaidTextBox.Text
            Else
                If amountPaid < discountPrice Then
                    'Changes the color to red if the amount entered is less that the total
                    AmountPaidTextBox.BackColor = Color.Red
                    MsgBox("Please ensure that your payment is greater than the total price.", vbOKOnly + vbCritical)
                End If
            End If
            formattedAmountPaid = Format(amountPaid, "Currency")
            AmountPaidTextBox.Text = formattedAmountPaid
            balance = amountPaid - discountPrice
            formattedBalance = Format(balance, "Currency")
            BalanceLabel.Text = formattedBalance
            AmountPaidTextBox.BackColor = Color.LawnGreen
            If paymentType = "Debit Card" Then
                MsgBox("Paid " & formattedAmountPaid & " through " & paymentType)
            Else
                MsgBox("Paid " & formattedAmountPaid & " with balance of " & formattedBalance & " through " & paymentType)
            End If
            PrintReceipt()
            MsgBox("Thank you for using this app!")
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
                          "Do you wish to continue?", vbYesNo + vbQuestion)
        If resetMsg = vbYes Then
            amountPaid = 0
            formattedAmountPaid = ""
            balance = 0
            formattedBalance = ""
            discountPrice = 0
            formattedDiscountPrice = ""
            totalPrice = 0
            storedTotalPrice = 0
            formattedTotalPrice = ""
            printReceiptMsg = 0
            memberDiscountPrice = 0
            formattedMemberDiscountPrice = ""

            orangePrice = 0
            formattedOrangePrice = ""
            mangoPrice = 0
            formattedMangoPrice = ""
            chickenPrice = 0
            formattedChickenPrice = ""
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
            DiscountCodeTextBox.Text = ""
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
        receipt = "--RECEIPT--" & vbCrLf & vbCrLf &
                  "Date: " & Format(Now, "Short Date") & vbCrLf &
                  "Time: " & Format(Now, "Long Time") & vbCrLf & vbCrLf
        If NumericUpDownChicken.Value > 0 Then
            receipt += String.Format(colFormat, "Chicken: " & Format(priceOfOneChicken, "Currency"), "Qty: " & NumericUpDownChicken.Value, "Amount: " & formattedChickenPrice & vbCrLf)
        End If
        If NumericUpDownMango.Value > 0 Then
            receipt += String.Format(colFormat, "Mango: " & Format(priceOfOneMango, "Currency"), "Qty: " & NumericUpDownMango.Value, "Amount: " & formattedMangoPrice & vbCrLf)
        End If
        If NumericUpDownOrange.Value > 0 Then
            receipt += String.Format(colFormat, "Orange: " & Format(priceOfOneOrange, "Currency"), "Qty: " & NumericUpDownOrange.Value, "Amount: " & formattedOrangePrice & vbCrLf)
        End If
        If NoOfPlasticLabel.Text > 0 Then
            receipt += String.Format(colFormat, "Plastic Bag:" & Format(priceOfOnePlasticBag, "Currency"), "Qty: " & NoOfPlasticLabel.Text, "Amount: " & Format(plasticBagPrice, "Currency") & vbCrLf)
        End If
        receipt += vbCrLf & "Type of Payment: " & paymentType & vbCrLf & vbCrLf &
                   "Total Price: " & formattedTotalPrice & vbCrLf &
                   "Discounted Price: " & formattedDiscountPrice & vbCrLf & vbCrLf &
                   "Amount Paid: " & formattedAmountPaid & vbCrLf
        If paymentType <> "Debit Card" Then
            receipt += "Balance: " & formattedBalance & vbCrLf
        End If
        printReceiptMsg = MsgBox("Do you want to print a receipt?", vbYesNo + vbQuestion)
        If printReceiptMsg = vbYes Then
            MsgBox(receipt)
        End If
    End Sub
    Private Sub ApplyMemberDiscount()
        formattedMemberDiscountPrice = TotalPriceLabel.Text
        memberDiscountPrice = totalPrice
        If MemberMaskedTextBox.Text = "012-345 6789" Then
            MsgBox("You get a 5% discount", vbOKOnly + vbInformation, "Member Discount")
            memberDiscountPrice = totalPrice - (5 / 100 * totalPrice)
            formattedMemberDiscountPrice = Format(memberDiscountPrice, "Currency")
            TotalPriceLabel.Text = formattedMemberDiscountPrice
        ElseIf MemberMaskedTextBox.MaskCompleted AndAlso MemberMaskedTextBox.Text <> "012-3456789" Then
            MsgBox("Sorry, you are not a member", vbOKOnly + vbInformation, "Member Discount")

        End If

    End Sub
    Private Sub ApplyDiscountCode()
        formattedDiscountPrice = formattedMemberDiscountPrice
        discountPrice = memberDiscountPrice
        If DiscountCodeTextBox.Text = "DISCOUNT5" Then
            MsgBox("You get a 5% discount", vbOKOnly + vbInformation, "Discount Code")
            discountPrice = memberDiscountPrice - (5 / 100 * totalPrice)
            formattedDiscountPrice = Format(discountPrice, "Currency")
            TotalPriceLabel.Text = formattedDiscountPrice
        ElseIf DiscountCodeTextBox.Text <> "" And DiscountCodeTextBox.Text <> "DISCOUNT5" Then
            MsgBox("This discount code is not valid", vbOKOnly + vbInformation, "Discount Code")

        End If

    End Sub

End Class
