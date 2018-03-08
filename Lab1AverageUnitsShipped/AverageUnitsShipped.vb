Option Strict On
''' Name:   Lab1AverageUnitsShipped
''' Author: Thais Stefanini
''' Date:   02 Feb 2018
''' Description:
'''         A form that accept units shipped per day as whole numbers and calculate 
'''         the average after 7 inputs. The user can input another set of numbers 
'''         after clearing the screen.
Public Class frmAverageUnitsShipped
    ' Global variables and constants.
    Private Const numberOfDays As Integer = 7   ' Number of days to calculate the average
    Private counterDay As Integer = 0           ' Count the number of days inputted already

    ' Declaration Array to save the Units inputted
    Private arrayUnitsShippedPerDay(numberOfDays - 1) As Integer

    ''' <summary>
    ''' End the application.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    ''' <summary>
    ''' Clear the screen.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        resetForm()
    End Sub
    ''' <summary>
    ''' Clear all texts in the screen, and clear all global variables (counters and arrays)
    ''' </summary>
    Private Sub resetForm()
        ' Clear all texts in the screen
        tbUnits.Text = String.Empty
        tbDataHistory.Text = String.Empty
        lbResult.Text = String.Empty
        lbDay.Text = "Day 1"        ' Set as the first day, so the user know that it is from beginning

        btnEnter.Enabled = True     ' Enable button Enter, if disable
        tbUnits.ReadOnly = False    ' Allow the user to type in this textbox, if disable
        tbUnits.Focus()             ' Set focus to the Units textbox
        counterDay = 0              ' Reset the number of days

        ' Clear the arrayUnitsShippedPerDay
        For counter As Integer = 0 To numberOfDays - 1
            arrayUnitsShippedPerDay(counter) = 0
        Next counter
    End Sub

    ''' <summary>
    ''' Validate and accept units inputted by user. After all days inputs are valid, it calculates de average.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        '=========================================
        ' Constants and Variables
        '=========================================
        Const minimumUnits As Integer = 0
        Const maximunUnits As Integer = 1000

        Dim inputUnitsString As String = String.Empty ' Holds the user input as a string
        Dim inputUnitsDouble As Double = 0.0          ' Holds the user input if it converts to a Double
        Dim inputUnitsInteger As Integer = 0          ' Holds the user input if it converts to a Integer
        Dim sumUnits As Integer = 0                   ' Sum of all units in the arrayUnitsShippedPerDay
        Dim unitsHistory As String = String.Empty     ' Holds the value to print in textbox tbDataHistory
        Dim averageUnits As Double = 0.0              ' Average result for units from all days
        Dim errorMessage As String = String.Empty     ' Error message that will be displayed
        Dim isValid As Boolean = False                ' To check if the input is valid

        '=========================================
        ' Input and Validation
        '=========================================
        inputUnitsString = tbUnits.Text  ' Get the input from the Units textbox

        If (Double.TryParse(inputUnitsString, inputUnitsDouble)) Then ' Check if the input is an Integer
            If (Integer.TryParse(inputUnitsString, inputUnitsInteger)) Then
                If (inputUnitsInteger >= minimumUnits AndAlso inputUnitsInteger <= maximunUnits) Then ' Check the range
                    arrayUnitsShippedPerDay(counterDay) = inputUnitsInteger ' Add user input in the array
                    counterDay += 1     ' Change the day counter after a valid input
                    isValid = True      ' Set this input as valid, to avoid the error message
                    tbUnits.Text = String.Empty     ' Clear the textbox, so the user can input the next value

                    ' Change the Day label on screen, until a maximum equal the numberOfDays
                    If (counterDay >= numberOfDays) Then
                        lbDay.Text = "Day " & counterDay ' Keep the label as the numberOfDays
                    Else
                        lbDay.Text = "Day " & counterDay + 1
                    End If
                Else
                    errorMessage = "Units shipped must be a whole number with a minimum value 
                                    of " & minimumUnits.ToString() & " and a maximum value of " &
                                    maximunUnits.ToString() & "."
                End If
            Else
                errorMessage = "Units shipped must be a whole number."
            End If
        Else
            errorMessage = "Units shipped must be numeric."
        End If

        ' Output a error message if input is not valid
        If (isValid = False) Then
            MessageBox.Show(errorMessage, "Error")

            ' Set focus to the Units textbox and selects its text
            tbUnits.Focus()
            tbUnits.SelectionStart = 0
            tbUnits.SelectionLength = tbUnits.Text.Length
        End If

        '=========================================
        ' Process and Output
        '=========================================

        ' Concatenate units in the array and show it in the tbDataHistory textbox
        For index As Integer = 0 To counterDay - 1 ' counterDay must be decreased for this output, because it was already incresed after the valid input
            unitsHistory += arrayUnitsShippedPerDay(index).ToString() & vbCrLf
        Next index
        tbDataHistory.Text = unitsHistory

        If (counterDay = numberOfDays) Then     ' Check if all days was inputted already
            ' Sum all units in the array
            For counter As Integer = 0 To numberOfDays - 1
                sumUnits += arrayUnitsShippedPerDay(counter)
            Next counter

            ' Calculate average and display result
            averageUnits = sumUnits / numberOfDays
            lbResult.Text = "Average per day: " & averageUnits.ToString("n2")

            ' Disable the button Enter and the Units textbox, to stop the inputting of data
            btnEnter.Enabled = False
            tbUnits.ReadOnly = True
            ' Set the focus on the Reset button
            btnReset.Focus()
        End If

    End Sub
End Class
