Imports System.Runtime.InteropServices

Public Class Form1

    Const priceOfOnePlasticBag As Single = 0.2

    Dim amountPaid As Double
    Dim formattedAmountPaid As String

    Dim balance As Double
    Dim formattedBalance As String = Format(balance, "Currency")

    Dim discountedPrice As Double
    Dim formattedDiscountPrice As String

    Dim totalPrice As Double
    Dim storedTotalPrice As Double
    Dim formattedTotalPrice As String

    Dim printReceiptMsg As Integer

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
            chickenPrice = 17.765 * NumericUpDownChicken.Value
        Else
            chickenPrice = 0
        End If
        formattedChickenPrice = Format(chickenPrice, "Currency")
        If CheckBoxMango.Checked = True Then
            mangoPrice = 7.4 * NumericUpDownMango.Value
        Else
            mangoPrice = 0
        End If
        formattedMangoPrice = Format(mangoPrice, "Currency")
        If CheckBoxOrange.Checked = True Then
            orangePrice = 1.362 * NumericUpDownOrange.Value
        Else
            orangePrice = 0
        End If
        formattedOrangePrice = Format(orangePrice, "Currency")
        totalPrice = chickenPrice + mangoPrice + orangePrice + plasticBagPrice
        formattedTotalPrice = Format(totalPrice, "Currency")
        TotalPriceLabel.Text = formattedTotalPrice
    End Sub

    Private Sub SettleButton_Click(sender As Object, e As EventArgs) Handles SettleButton.Click
        'Checks if the user has selected a payment option
        If paymentType = "" Then
            MsgBox("Please select a payment option.", vbOKOnly + vbExclamation)
        ElseIf paymentType = "Debit Card" Then
            If MaskedTextBox2.Text = "012-345 6789" Then
                MsgBox("You get a 5% discount", vbOKOnly)
                discountedPrice = totalPrice - (5 / 100 * totalPrice)
                formattedDiscountPrice = Format(discountedPrice, "Currency")
                TotalPriceLabel.Text = formattedDiscountPrice
            Else
                formattedDiscountPrice = TotalPriceLabel.Text
            End If

            AmountPaidTextBox.Text = TotalPriceLabel.Text
            amountPaid = AmountPaidTextBox.Text
            formattedAmountPaid = Format(amountPaid, "Currency")
            AmountPaidTextBox.BackColor = Color.Green
            MsgBox("Paid " & formattedAmountPaid & " through " & paymentType)
            printReceiptMsg = MsgBox("Do you want to print a receipt?", vbYesNo + vbQuestion)
            If printReceiptMsg = vbYes Then
                ShowReceipt()
            End If
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
                    If MaskedTextBox2.Text = "012-345 6789" Then
                        MsgBox("You get a 5% discount", vbOKOnly)
                        discountedPrice = totalPrice - (5 / 100 * totalPrice)
                        formattedDiscountPrice = Format(discountedPrice, "Currency")
                        TotalPriceLabel.Text = formattedDiscountPrice
                    Else
                        formattedDiscountPrice = TotalPriceLabel.Text
                    End If
                    balance = amountPaid - totalPrice
                    formattedAmountPaid = Format(amountPaid, "Currency")
                    AmountPaidTextBox.Text = formattedAmountPaid
                    formattedBalance = Format(balance, "Currency")
                    BalanceLabel.Text = formattedBalance
                    AmountPaidTextBox.BackColor = Color.Green
                    MsgBox("Paid " & formattedAmountPaid & " with balance of " & formattedBalance & " through " & paymentType)
                    printReceiptMsg = MsgBox("Do you want to print a receipt?", vbYesNo + vbQuestion)
                    If printReceiptMsg = vbYes Then
                        ShowReceipt()
                    End If
                    MsgBox("Thank you for using this app!")
                End If
            End If
        End If

    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        paymentType = "E-Wallet"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        paymentType = "Debit Card"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        paymentType = "Cash"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        plasticBagPrice += priceOfOnePlasticBag
        NoOfPlasticLabel.Text += 1
        totalPrice += priceOfOnePlasticBag
        formattedTotalPrice = Format(totalPrice, "Currency")
        TotalPriceLabel.Text = formattedTotalPrice
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        clockLabel.Text = Format(Now, "General Date")
    End Sub

    Private Sub ShowReceipt()
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
    End Sub
End Class
