Imports System.Runtime.InteropServices

' Declares types and methods that can be called from the DLL
Public Class Shell32
    Public Shared Function GetFileBitmap(ByVal fileName As String) As Bitmap
        Dim result As Bitmap = Nothing
        Dim shFileInfo As New SHFILEINFO()
        Dim returnCode As IntPtr = SHGetFileInfo(fileName, 0, shFileInfo, Marshal.SizeOf(shFileInfo), SHGFI_ICON)

        If shFileInfo.hIcon <> IntPtr.Zero Then
            Dim icon As System.Drawing.Icon = System.Drawing.Icon.FromHandle(shFileInfo.hIcon)
            result = icon.ToBitmap()
            DestroyIcon(shFileInfo.hIcon)
            icon.Dispose()
        End If

        Return result
    End Function

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure SHFILEINFO
        Public hIcon As IntPtr
        Public iIcon As IntPtr
        Public dwAttributes As UInteger
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)> _
        Public szDisplayName As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=80)> _
        Public szTypeName As String
    End Structure

    Public Const SHGFI_ICON As UInteger = &H100
    Public Const SHGFI_LARGEICON As UInteger = &H0

    <DllImport("shell32.dll")> _
    Public Shared Function SHGetFileInfo(ByVal path As String, ByVal dwFileAttributes As UInteger, ByRef shfi As SHFILEINFO, ByVal cbSizeFileInfo As UInteger, ByVal uFlags As UInteger) As IntPtr
    End Function
    <DllImport("user32.dll")> _
    Public Shared Function DestroyIcon(ByVal hIcon As IntPtr) As Int32
    End Function
End Class

