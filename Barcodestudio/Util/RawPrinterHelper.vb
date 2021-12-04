Imports System.Runtime.InteropServices

Public Class RawPrinterHelper
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)>
    Public Class DOCINFOA
        <MarshalAs(UnmanagedType.LPStr)>
        Public pDocName As String
        <MarshalAs(UnmanagedType.LPStr)>
        Public pOutputFile As String
        <MarshalAs(UnmanagedType.LPStr)>
        Public pDataType As String
    End Class

    <DllImport("winspool.Drv", EntryPoint:="OpenPrinterA", SetLastError:=True, CharSet:=CharSet.Ansi, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function OpenPrinter(
    <MarshalAs(UnmanagedType.LPStr)> ByVal szPrinter As String, <Out> ByRef hPrinter As IntPtr, ByVal pd As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="ClosePrinter", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function ClosePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="StartDocPrinterA", SetLastError:=True, CharSet:=CharSet.Ansi, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function StartDocPrinter(ByVal hPrinter As IntPtr, ByVal level As Int32,
    <[In], MarshalAs(UnmanagedType.LPStruct)> ByVal di As DOCINFOA) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="EndDocPrinter", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function EndDocPrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="StartPagePrinter", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function StartPagePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="EndPagePrinter", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function EndPagePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="WritePrinter", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function WritePrinter(ByVal hPrinter As IntPtr, ByVal pBytes As IntPtr, ByVal dwCount As Int32, <Out> ByRef dwWritten As Int32) As Boolean
    End Function

    Public Shared Function SendBytesToPrinter(ByVal szPrinterName As String, ByVal pBytes As IntPtr, ByVal dwCount As Int32) As Boolean
        Try
            Dim dwError As Int32 = 0, dwWritten As Int32 = 0
            Dim hPrinter As IntPtr = New IntPtr(0)
            Dim di As DOCINFOA = New DOCINFOA()
            Dim bSuccess As Boolean = False
            di.pDocName = "QL_BARCODE_STUDIO"
            di.pDataType = "RAW"

            If OpenPrinter(szPrinterName.Normalize(), hPrinter, IntPtr.Zero) Then

                If StartDocPrinter(hPrinter, 1, di) Then

                    If StartPagePrinter(hPrinter) Then
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, dwWritten)
                        EndPagePrinter(hPrinter)
                    End If

                    EndDocPrinter(hPrinter)
                End If

                ClosePrinter(hPrinter)
            End If

            If bSuccess = False Then
                dwError = Marshal.GetLastWin32Error()
            End If

            Return bSuccess
        Catch ex As Exception
            MsgBox(ex.ToString())
            Return False
        End Try
    End Function

    Public Shared Function SendStringToPrinter(ByVal szPrinterName As String, ByVal szString As String) As Boolean
        Dim pBytes As IntPtr
        Dim dwCount As Int32
        dwCount = szString.Length
        pBytes = Marshal.StringToCoTaskMemAnsi(szString)
        SendBytesToPrinter(szPrinterName, pBytes, dwCount)
        Marshal.FreeCoTaskMem(pBytes)
        Return True
    End Function
End Class
