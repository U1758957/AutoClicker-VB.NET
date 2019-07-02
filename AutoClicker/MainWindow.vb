Imports System.Globalization
Imports System.Text.RegularExpressions
Imports System.Threading
Public Class MainWindow


    Dim totalTime As Double = 0
    Dim timeUnits As String() = {"h", "m", "s", "ms"}
    Dim totalTestClicks As UInteger = 0
    Dim testButtonClickStartTime As DateTime
    Dim testButtonClickElapsedTime As TimeSpan
    Dim currentCountDownTime As UInteger = 5
    Dim stopClicking As Boolean = False

    ''' <summary>
    ''' Converts a unit of time (hours, minutes, seconds, etc) into milliseconds
    ''' </summary>
    ''' <param name="x">The time to convert</param>
    ''' <param name="unit">The unit of said time</param>
    Private Sub TimeConverter(ByVal x As UInteger, ByRef unit As String)
        Select Case unit
            Case "h"
                x = x * 60 * 60 * 1000
            Case "m"
                x = x * 60 * 1000
            Case "s"
                x *= 1000
        End Select
        totalTime += x
    End Sub

    ''' <summary>
    ''' Spawns as a separate thread, this will autoclick the mouse at a time interval defined by the user. Has a couple of safety features to stop clicking either by pressing the STOP button in the program, or the spacebar key on the keyboard
    ''' </summary>
    Private Sub ClickAuto()
        While (Not stopClicking)
            If NativeMethods.GetAsyncKeyState(&H20) Then
                stopClicking = True
            Else
                If currentCountDownTime <= 0 Then
                    NativeMethods.mouse_event(&H2, 0, 0, 0, 0) ' &H2 is left click down
                    NativeMethods.mouse_event(&H4, 0, 0, 0, 0) ' &H4 is left click up
                    Thread.Sleep(totalTime)
                Else
                    Thread.Sleep(100) ' This is here to stop one of your CPU cores screaming while waiting for the countdown
                End If
            End If
        End While
    End Sub

    ''' <summary>
    ''' Does a 5 second countdown after you start the autoclicking, so you have time to get to the thing you want to autoclick on. Also spawns as a separate thread
    ''' </summary>
    Private Sub ClickCountDown()
        For x As Integer = 1 To 5
            If Not stopClicking Then
                Thread.Sleep(1000)
                currentCountDownTime -= 1
            Else
                Exit For
            End If
        Next
    End Sub

    ''' <summary>
    ''' A Button that says "Autoclick!". When you click this button, the time input is parsed, a countdown is then started and at the same time the auto clicker is activated.
    ''' </summary>
    ''' <param name="sender">Component of vb.NET for button listening</param>
    ''' <param name="e">Component of vb.NET for button listening</param>
    Private Sub AutoClickButton_Click(sender As Object, e As EventArgs) Handles AutoClickButton.Click
        AutoClickButton.Enabled = False
        Dim currentTimeValue As UInteger
        Dim currentTimeString As String = "0"
        For Each timeUnit As String In timeUnits
            Select Case timeUnit
                Case "h"
                    currentTimeString = HourBox.Text
                Case "m"
                    currentTimeString = MinuteBox.Text
                Case "s"
                    currentTimeString = SecondBox.Text
                Case "ms"
                    currentTimeString = MillisecondBox.Text
            End Select
            If Not Regex.IsMatch(currentTimeString, "^[0-9 ]+$") Then
                StopButton.PerformClick()
                Exit Sub
            End If
            Dim parseSuccess = UInteger.TryParse(currentTimeString, currentTimeValue)
            If Not parseSuccess Then
                StopButton.PerformClick()
                Exit Sub
            End If
            TimeConverter(currentTimeValue, timeUnit)
        Next
        If (totalTime > 0) Then
            stopClicking = False
            Dim countDownThread As New Thread(AddressOf ClickCountDown)
            Dim clickThread As New Thread(AddressOf ClickAuto)
            countDownThread.Start()
            clickThread.Start()
        Else
            StopButton.PerformClick()
        End If
    End Sub

    ''' <summary>
    ''' Hover the mouse over this button when autoclicking, and it will click it. Shows how many clicks have happened, and the time it takes to do 1 click, as a way to see that everything is working, and the (rough) time per click
    ''' </summary>
    ''' <param name="sender">Component of vb.NET for button listening</param>
    ''' <param name="e">Component of vb.NET for button listening</param>
    Private Sub TestButton_Click(sender As Object, e As EventArgs) Handles TestButton.Click
        totalTestClicks += 1
        testButtonClickElapsedTime = Now.Subtract(testButtonClickStartTime)
        testButtonClickStartTime = Now
        TimeMeasureLabel.Text = testButtonClickElapsedTime.TotalSeconds.ToString("0.00000" & "s", CultureInfo.CurrentCulture)
        TestButtonClicksLabel.Text = totalTestClicks
    End Sub

    ''' <summary>
    ''' Click this button to stop autoclicking, resets everything
    ''' </summary>
    ''' <param name="sender">Component of vb.NET for button listening</param>
    ''' <param name="e">Component of vb.NET for button listening</param>
    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        stopClicking = True
        totalTime = 0
        totalTestClicks = 0
        TimeMeasureLabel.Text = ""
        TestButtonClicksLabel.Text = ""
        currentCountDownTime = 5
        AutoClickButton.Enabled = True
    End Sub

    Private Sub MainWindow_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        stopClicking = True
    End Sub

    ''' <summary>
    ''' NativeMethods class for accessing libraries
    ''' </summary>
    Friend Class NativeMethods
        Private Sub New()
        End Sub
        Friend Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As IntPtr)
        Friend Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short

    End Class

End Class
