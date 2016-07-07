Public Class frmSelection
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim ratio As Double

    Private Sub frmSelection_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub frmSelection_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            SharedVars.x = Me.Left
            SharedVars.y = Me.Top
            frmMain.updatePositionLabels()
        End If
    End Sub

    Private Sub frmSelection_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        drag = False
    End Sub

    Private Sub frmSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TransparencyKey = Color.LightBlue
        Me.BackColor = Color.LightBlue
    End Sub

    Private Sub frm_show() Handles Me.Shown
        ratio = Me.Height / Me.Width

        AddHandler Me.Resize, AddressOf Form_SizeChanged
    End Sub

    Private Sub Form_SizeChanged(sender As Object, e As EventArgs)
        'Resize while maintaining aspect ratio
        Me.ClientSize = New System.Drawing.Size(Me.Height / ratio, Me.ClientSize.Height)
        SharedVars.Width = Me.Width
        SharedVars.Height = Me.Height
    End Sub
    
End Class