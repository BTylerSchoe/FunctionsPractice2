Public Class frmFunctionsPractice2

    ' Variables to hold addition function input
    Dim userInputNumber1 As Double = 0.00

    Dim userInputNumber2 As Double = 0.00

    ' Variables to hold subtraction function input
    Dim userInputForSubtraction1 As Double = 0.00

    Dim userInputForSubtraction2 As Double = 0.00

    ' Variabel to hold multiplication function input
    Dim userInputForMultiplication1 As Double = 0.00

    Dim userInputForMultiplication2 As Double = 0.00

    ' Variable to hold division funtion input
    Dim userInputForDivision1 As Double = 0.00

    Dim userInputForDivision2 As Double = 0.00




    ''' <summary>
    ''' Event handler for from initialization
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAddNumber1.Select()
    End Sub



    ''' <summary>
    ''' Add button event handler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim additionNum1 As Double = 0.00
        Dim additionNum2 As Double = 0.00

        If Double.TryParse(txtAddNumber1.Text, userInputNumber1) Then

            If (userInputNumber1 < 0 Or userInputNumber1 > 1000) = False Then

                If Double.TryParse(txtAddNumber2.Text, userInputNumber2) Then

                    If (userInputNumber2 < 0 Or userInputNumber2 > 1000) = False Then


                        lblAddOutput.Text = add(additionNum1, additionNum2)
                    Else
                        MessageBox.Show("Please ensure value entered is between 0 and 1000 inclusive")
                    End If
                Else
                    MessageBox.Show("Please ensure value entered is a valid Double")
                End If
            Else
                MessageBox.Show("Please ensure value entered is between 0 and 1000 inclusive")

            End If
        Else
            MessageBox.Show("Please ensure value entered is a valid Double")
        End If


    End Sub



    ''' <summary>
    ''' Add function 
    ''' </summary>
    ''' <param name="number1"></param>
    ''' <param name="number2"></param>
    ''' <returns></returns>
    Private Function add(number1 As Double, number2 As Double) As Double

        Dim sumOfAdd As Double = 0.0

        number1 = userInputNumber1

        number2 = userInputNumber2

        sumOfAdd = number1 + number2




        Return sumOfAdd

    End Function

    ''' <summary>
    ''' Event handler for reset button of addition function
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnResetAdd_Click(sender As Object, e As EventArgs) Handles btnResetAdd.Click
        txtAddNumber1.Text = ""
        txtAddNumber2.Text = ""

        lblAddOutput.Text = ""

        userInputNumber1 = 0.00
        userInputNumber2 = 0.00

        txtAddNumber1.Select()

    End Sub




    ''' <summary>
    ''' subtract button Event handler 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click

        Dim subtractionNumber1 As Double = 0.00

        Dim subtractionNumber2 As Double = 0.00

        If Double.TryParse(txtSubtractNumber1.Text, userInputForSubtraction1) Then

            If (userInputForSubtraction1 < 0 Or userInputForSubtraction1 > 1000) = False Then

                If Double.TryParse(txtSubtractNumber2.Text, userInputForSubtraction2) Then

                    If (userInputForSubtraction2 < 0 Or userInputForSubtraction2 > 1000) = False Then

                        lblDifferenceOutput.Text = subtract(subtractionNumber1, subtractionNumber2)

                    Else
                        MessageBox.Show("Please ensure value entered is between 0 and 1000 inclusive")
                    End If
                Else
                    MessageBox.Show("Please ensure value entered is a valid Double")
                End If

            Else
                MessageBox.Show("Please ensure value entered is between 0 and 1000 inclusive")
            End If
        Else
            MessageBox.Show("Please ensure value entered is a valid Double")
        End If

    End Sub


    ''' <summary>
    ''' Subtract function
    ''' </summary>
    ''' <param name="sNum1"></param>
    ''' <param name="sNum2"></param>
    ''' <returns></returns>
    Private Function subtract(sNum1 As Double, sNum2 As Double) As Double
        Dim differenceOfSubtraction As Double = 0.00

        sNum1 = userInputForSubtraction1

        sNum2 = userInputForSubtraction2

        differenceOfSubtraction = userInputForSubtraction1 - userInputForSubtraction2

        Return differenceOfSubtraction
    End Function

    ''' <summary>
    ''' Event handler for reset button of subtraction function
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnResetSubtract_Click(sender As Object, e As EventArgs) Handles btnResetSubtract.Click
        txtSubtractNumber1.Text = ""
        txtSubtractNumber2.Text = ""

        lblDifferenceOutput.Text = ""

        userInputForSubtraction1 = 0.00
        userInputForSubtraction2 = 0.00

        txtSubtractNumber1.Select()
    End Sub



    ''' <summary>
    ''' multiply button event handler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnMulitply_Click(sender As Object, e As EventArgs) Handles btnMulitply.Click
        Dim multiplicationNum1 As Double = 0.00
        Dim multiplicationNum2 As Double = 0.00

        If Double.TryParse(txtMultiplicationNumber1.Text, userInputForMultiplication1) Then

            If (userInputForMultiplication1 < 0 Or userInputForMultiplication1 > 1000) = False Then

                If Double.TryParse(txtMultiplicationNumber2.Text, userInputForMultiplication2) Then

                    If (userInputForMultiplication1 < 0 Or userInputForMultiplication2 > 1000) = False Then

                        lblProductOutput.Text = multiply(multiplicationNum1, multiplicationNum2)

                    Else
                        MessageBox.Show("Please ensure value entered is between 0 and 1000 inclusive")
                    End If
                Else
                    MessageBox.Show("Please ensure value entered is a valid Double")
                End If


            Else
                MessageBox.Show("Please ensure value entered is between 0 and 1000 inclusive")
            End If

        Else
            MessageBox.Show("Please ensure value entered is a valid Double")
        End If

    End Sub


    ''' <summary>
    ''' Multiply function
    ''' </summary>
    ''' <param name="mNum1"></param>
    ''' <param name="mNum2"></param>
    ''' <returns></returns>

    Private Function multiply(mNum1 As Double, mNum2 As Double) As Double
        Dim productOfMultiplication As Double = 0.00

        mNum1 = userInputForMultiplication1

        mNum2 = userInputForMultiplication2

        productOfMultiplication = mNum1 * mNum2


        Return productOfMultiplication
    End Function


    ''' <summary>
    ''' Event handler for Reset multiplation button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnResetMultiplication_Click(sender As Object, e As EventArgs) Handles btnResetMultiplication.Click
        txtMultiplicationNumber1.Text = ""
        txtMultiplicationNumber2.Text = ""

        lblProductOutput.Text = ""

        userInputForMultiplication1 = 0.00
        userInputForMultiplication2 = 0.00

        txtMultiplicationNumber1.Select()

    End Sub






    ''' <summary>
    ''' Divide button event handler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click

        Dim divisionNum1 As Double = 0.00
        Dim divisionNum2 As Double = 0.00

        If Double.TryParse(txtDivisionNumber1.Text, userInputForDivision1) Then

            If (userInputForDivision1 < 0 Or userInputForDivision1 > 1000) = False Then

                If Double.TryParse(txtDivisionNumber2.Text, userInputForDivision2) Then

                    If (userInputForDivision2 < 0 Or userInputForDivision2 > 1000) = False Then

                        lblQuotientOutput.Text = divide(divisionNum1, divisionNum2)

                    Else
                        MessageBox.Show("Please ensure value entered is between 0 and 1000 inclusive")
                    End If
                Else
                    MessageBox.Show("Please ensure value entered is a valid Double")
                End If


            Else
                MessageBox.Show("Please ensure value entered is between 0 and 1000 inclusive")
            End If

        Else
            MessageBox.Show("Please ensure value entered is a valid Double")
        End If
    End Sub

    ''' <summary>
    ''' Divide function
    ''' </summary>
    ''' <param name="dNum1"></param>
    ''' <param name="dNum2"></param>
    ''' <returns></returns>
    Private Function divide(dNum1 As Double, dNum2 As Double) As Double
        Dim quotientOfDivision As Double = 0.00

        dNum1 = userInputForDivision1
        dNum2 = userInputForDivision2

        quotientOfDivision = dNum1 / dNum2

        Return quotientOfDivision
    End Function


    ''' <summary>
    ''' Event handler for reset divsion button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnResetDivision_Click(sender As Object, e As EventArgs) Handles btnResetDivision.Click
        txtDivisionNumber1.Text = ""
        txtDivisionNumber2.Text = ""

        lblQuotientOutput.Text = ""

        userInputForDivision1 = 0.00
        userInputForDivision2 = 0.00

        txtDivisionNumber1.Select()
    End Sub
End Class
