Imports System.ComponentModel

Public Class Form1
    Private globalHookManager As GlobalHookManager

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not globalHookManager Is Nothing Then
            globalHookManager.Dispose()
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = System.Windows.Forms.Screen.FromControl(Me).Bounds.Height - Me.Height
        Me.Left = System.Windows.Forms.Screen.FromControl(Me).Bounds.Left

        globalHookManager = New GlobalHookManager()
        AddHandler globalHookManager.KeyboardEvents, AddressOf keyHook_keyboardEvents
    End Sub
    Private Sub keyHook_keyboardEvents(sender As Object, e As KeyEventArgs)
        MessageBox.Show(e.KeyValue)
    End Sub
End Class
