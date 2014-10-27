' Name:         CityState Project
' Purpose:      Displays the city name followed by a comma,
'               a space, and the state name
' Programmer:  Cody Wood 10/27/2014

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private city As String
    Private state As String
    Private cityState As String
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub input(sender As Object, e As EventArgs) Handles MyBase.Load
        Const cityStr As String = "City:"
        Const stateStr As String = "State:"
        Const cityTitle As String = "City Entry"
        Const stateTitle As String = "State Entry"
        city = InputBox(cityStr, cityTitle)
        state = InputBox(stateStr, stateTitle)

    End Sub

    Private Sub concatCityState(sender As Object, e As EventArgs) Handles btnDisplay.Click
        lblCityState.Text = city & ", " & state


    End Sub
End Class
