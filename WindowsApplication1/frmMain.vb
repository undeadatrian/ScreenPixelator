Imports System.Net.Sockets
Imports System.Text

Public Class frmMain
    Dim frmSelection As Form = New frmSelection
    Dim tcpClient As System.Net.Sockets.TcpClient = Nothing
    Dim WithEvents timer As Timer = New Timer
    Dim netStream As NetworkStream = Nothing

    Private Sub frm_load() Handles Me.Load
        timer.Interval = 1000 / 6
    End Sub

    Private Sub btnShowSelection_Click(sender As Object, e As EventArgs) Handles btnShowSelection.Click
        If (SharedVars.Width = 0 And SharedVars.Height = 0) Then
            frmSelection.Width = nmbMatrixX.Value
            frmSelection.Height = nmbMatrixY.Value
        Else
            frmSelection.Width = SharedVars.Width
            frmSelection.Height = SharedVars.Height
        End If

        frmSelection.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        frmSelection.ControlBox = False
        frmSelection.Text = String.Empty
        If (Not frmSelection.Visible) Then
            frmSelection.Show()
            btnShowSelection.Text = "Hide"
        Else
            frmSelection.Hide()
            btnShowSelection.Text = "Show"
        End If
    End Sub

    Sub updatePositionLabels()
        lblMatrixX.Text = SharedVars.x
        lblMatrixY.Text = SharedVars.y
    End Sub

    Private Sub getPixels(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnPixels.Click
        Dim sizex As Integer = nmbMatrixX.Value
        Dim sizey As Integer = nmbMatrixY.Value

        Dim watch As Stopwatch = Stopwatch.StartNew()

        Dim pixels As String = getPixelData(SharedVars.x, SharedVars.y, sizex, sizey)

        watch.Stop()

        lblTime.Text = watch.ElapsedMilliseconds
        rtbPixels.Text = pixels
    End Sub

    Function getPixelData(ByVal x As Integer, ByVal y As Integer, ByVal sizex As Integer, ByVal sizey As Integer)
        ' set the size we want (1x1)
        Dim region As New Rectangle(0, 0, frmSelection.Width, frmSelection.Height)
        ' create a bitmap to store the image
        Dim screenBitmap As New Bitmap(region.Width, region.Height, Imaging.PixelFormat.Format64bppPArgb)
        ' code to copy image from the screen
        Dim bitmapGraphics As Graphics
        bitmapGraphics = Graphics.FromImage(screenBitmap)
        Using bitmapGraphics
            ' actual copying, setting the are to be were the click was and to the size we set before
            bitmapGraphics.CopyFromScreen(x, y, 0, 0, region.Size)
        End Using

        Dim resizedBitmap As New Bitmap(sizex, sizey, Imaging.PixelFormat.Format64bppPArgb)

        Dim gr_dest As Graphics = Graphics.FromImage(resizedBitmap)
        gr_dest.DrawImage(screenBitmap, 0, 0, _
        resizedBitmap.Width + 1, _
        resizedBitmap.Height + 1)
        ' get the color of the that one pixel
        Dim pixels As String = ""

        For sy As Integer = 0 To sizey - 1
            For sx As Integer = 0 To sizex - 1
                Dim c As Color = resizedBitmap.GetPixel(sx, sy)
                pixels &= "[" & sx & ";" & sy & "][" & c.R & ";" & c.G & ";" & c.B & "]"
            Next
            pixels &= vbCr
        Next

        Return pixels
    End Function

    Function getPixelBytes(ByVal x As Integer, ByVal y As Integer, ByVal sizex As Integer, ByVal sizey As Integer)
        Dim size = sizex * sizey * 3
        Dim pixels(size) As Byte

        ' set the size we want (1x1)
        Dim region As New Rectangle(0, 0, SharedVars.Width, SharedVars.Height)
        ' create a bitmap to store the image
        Dim screenBitmap As New Bitmap(region.Width, region.Height, Imaging.PixelFormat.Format64bppPArgb)
        ' code to copy image from the screen
        Dim bitmapGraphics As Graphics
        bitmapGraphics = Graphics.FromImage(screenBitmap)
        Using bitmapGraphics
            ' actual copying, setting the are to be were the click was and to the size we set before
            bitmapGraphics.CopyFromScreen(x, y, 0, 0, region.Size)
        End Using

        Dim resizedBitmap As New Bitmap(sizex, sizey, Imaging.PixelFormat.Format64bppPArgb)

        Dim gr_dest As Graphics = Graphics.FromImage(resizedBitmap)
        gr_dest.DrawImage(screenBitmap, 0, 0, _
        resizedBitmap.Width + 1, _
        resizedBitmap.Height + 1)

        For sy As Integer = 0 To sizey - 1
            For sx As Integer = 0 To sizex - 1
                Dim c As Color = resizedBitmap.GetPixel(sx, sy)
                Dim r As Byte() = BitConverter.GetBytes(c.R)
                Dim g As Byte() = BitConverter.GetBytes(c.G)
                Dim b As Byte() = BitConverter.GetBytes(c.B)
                pixels(sy * sizex * 3 + sx * 3) = r(0)
                pixels(sy * sizex * 3 + sx * 3 + 1) = g(0)
                pixels(sy * sizex * 3 + sx * 3 + 2) = b(0)
            Next
        Next

        Return pixels
    End Function

    Private Sub btnOutput_Click(sender As Object, e As EventArgs) Handles btnOutput.Click
        If tcpClient Is Nothing Then
            tcpClient = New TcpClient
        End If
        If Not tcpClient.Connected Then
            tcpClient.Connect(tbxServerIP.Text, nmbServerPort.Value)
            netStream = tcpClient.GetStream()
            timer.Start()
            btnOutput.Text = "Stop Output"
        Else
            tcpClient.Close()
            timer.Stop()
            btnOutput.Text = "Start Output"
        End If
    End Sub

    Private Sub sendPixels() Handles timer.Tick
        Dim sizex As Integer = nmbMatrixX.Value
        Dim sizey As Integer = nmbMatrixY.Value
        If netStream.CanWrite And netStream.CanRead Then
            Dim sendBytes As [Byte]() = getPixelBytes(SharedVars.x, SharedVars.y, sizex, sizey)
            Dim size As UInt32 = sendBytes.Length + 3
            Dim packet(size) As Byte
            Dim sizeBytes As Byte() = BitConverter.GetBytes(size)
            Array.Reverse(sizeBytes)
            Array.Copy(sizeBytes, packet, BitConverter.GetBytes(size).Length)
            Array.Copy(sendBytes, 0, packet, 4, sendBytes.Length)
            netStream.Write(packet, 0, packet.Length)
            'rtbPixels.Text &= "Send message" & vbCr
        Else
            If Not netStream.CanRead Then
                rtbPixels.Text &= "cannot not write data to this stream" & vbCr
                tcpClient.Close()
            Else
                If Not netStream.CanWrite Then
                    rtbPixels.Text &= "cannot read data from this stream" & vbCr
                    tcpClient.Close()
                End If
            End If
        End If
    End Sub
End Class
