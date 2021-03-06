﻿Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class frmAdd

    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        'Get weight and validate
        If IsNumeric(txtWeight.Text) Then
            Dim weight As Double = txtWeight.Text
            'Connect to DB
            'DO NOT EDIT THIS LINE
            provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database.accdb"
            connString = provider
            myConnection.ConnectionString = connString
            myConnection.Open()
            MessageBox.Show("Success!")

            'Add new weight to DB
            Dim str As String
            str = "INSERT INTO Table1 ([Weight], [BMI]) VALUES ('" & weight & "','" & 3 & "');"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
            cmd.ExecuteNonQuery()

            'Close
            myConnection.Close()

            Me.Close()
        Else
            'Throw error if invalid input
            MessageBox.Show("Enter a valid weight please. Numbers only!")
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        'Go back to main form
        Me.Close()

    End Sub

    Private Sub frmAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtWeight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWeight.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtWeight_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtWeight.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txtWeight.Text = digitsOnly.Replace(txtWeight.Text, "")
    End Sub
End Class