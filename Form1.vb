Imports System.ComponentModel

Public Class Form1
  Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

  End Sub
  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me.Top = System.Windows.Forms.Screen.FromControl(Me).Bounds.Height - Me.Height
    Me.Left = System.Windows.Forms.Screen.FromControl(Me).Bounds.Left
  End Sub
End Class
