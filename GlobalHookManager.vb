Imports System.Runtime.InteropServices

Public Class GlobalHookManager
    Implements IDisposable

    Private WH_KEYBOARD_LL As Integer = 13
    Private Shared hHook As Integer = 0

    Private hookproc As CallBack

    Public Event KeyboardEvents(sender As Object, e As KeyEventArgs)

    Private Delegate Function CallBack(nCode As Integer, wParam As IntPtr, lParam As IntPtr) As Integer

    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Private Overloads Shared Function SetWindowsHookEx _
        (idHook As Integer, HookProc As CallBack, hInstance As IntPtr, wParam As Integer) As Integer
    End Function

    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Private Overloads Shared Function GetModuleHandle _
        (lpModuleName As String) As IntPtr
    End Function

    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Private Overloads Shared Function CallNextHookEx _
        (idHook As Integer, nCode As Integer, wParam As IntPtr, lParam As IntPtr) As Integer
    End Function

    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Private Overloads Shared Function UnhookWindowsHookEx _
        (idHook As Integer) As Boolean
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Private Structure KeyboardLLHookStruct
        Public vkCode As Integer
        Public scanCode As Integer
        Public flags As Integer
        Public time As Integer
        Public dwExtraInfo As Integer
    End Structure

    Public Sub New()
        hookproc = AddressOf KeyboardHookProc
        hHook = SetWindowsHookEx(WH_KEYBOARD_LL, hookproc,
                                 GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName), 0)
        If hHook.Equals(0) Then
            MessageBox.Show("SetWindowsHookEx Failed")
        End If
    End Sub

    Private Function KeyboardHookProc _
        (nCode As Integer, wParam As IntPtr, lParam As IntPtr) As Integer
        
        If (nCode < 0) Then
            Return CallNextHookEx(hHook, nCode, wParam, lParam)
        End If

        Dim hookStruct As New KeyboardLLHookStruct()
        hookStruct = CType(Marshal.PtrToStructure(lParam, hookStruct.GetType()), KeyboardLLHookStruct)

        Dim e As New KeyEventArgs(hookStruct.vkCode)
        OnKeyboardEvents(e)

        Return CallNextHookEx(hHook, nCode, wParam, lParam)
    End Function

    Protected Sub OnKeyboardEvents(ByVal e As KeyEventArgs)
        RaiseEvent KeyboardEvents(Me, e)
    End Sub

    Public Sub Dispose() Implements System.IDisposable.Dispose
        If hHook > 0 Then
            UnhookWindowsHookEx(hHook)
        End If
    End Sub
End Class
