Public Class frm_OfficePage

    Dim statGBManajemen, StatGBPelayanan As String

    Private Sub PbPosition()
        Dim x As Integer
        Dim y As Integer
        x = GBDashBoard.Left + 100
        y = GBDashBoard.Top
        PbDashBoard.Location = New Point(x, y)
        PbDashBoard.Width = 480
        PbDashBoard.Height = 480
        PbDashBoard.SizeMode = PictureBoxSizeMode.Zoom
    End Sub
    Private Sub FormSize()
        Me.WindowState = FormWindowState.Maximized
        Me.MaximizeBox = False
        GroupBox1.Height = Me.Height - 150
        GBDashBoard.Width = Me.Width - 225
        GBDashBoard.Height = Me.Height - 150
    End Sub

    Private Sub Dashboard()
        Call HideGBPelayanan()
        Call HideGBKependudukan()
        Call HideGBManajemen()
        Call HideGBWilayah()
        Call HideGBDatasheet()
        Call HideGBRefrensi()
    End Sub
    Private Sub HideGBManajemen()
        GBManajemen.Hide()
    End Sub
    Private Sub HideGBPelayanan()
        GBPelayanan.Hide()

    End Sub
    Private Sub HideGBKependudukan()
        GBKependudukan.Hide()
    End Sub

    Private Sub HideGBWilayah()
        GBWilayah.Hide()
    End Sub
    Private Sub HideGBDatasheet()
        GBDatasheet.Hide()
    End Sub
    Private Sub HideGBRefrensi()
        GBRefrensi.Hide()
    End Sub

    Private Sub TSBtnManajemen_Click(sender As Object, e As EventArgs) Handles TSBtnManajemen.Click
        Dashboard()
        GBManajemen.Show()
    End Sub

    Private Sub TSBtnPelayanan_Click(sender As Object, e As EventArgs) Handles TSBtnPelayanan.Click
        Dashboard()
        GBPelayanan.Show()
    End Sub
    Private Sub btnWilayahBack_Click(sender As Object, e As EventArgs) Handles btnWilayahBack.Click
        GBWilayah.Hide()
    End Sub
    Private Sub btnDatasheetBack_Click(sender As Object, e As EventArgs) Handles btnDatasheetBack.Click
        GBDatasheet.Hide()
    End Sub
    Private Sub btnRefrensiBack_Click(sender As Object, e As EventArgs) Handles btnRefrensiBack.Click
        GBRefrensi.Hide()
    End Sub
    Private Sub btnKependudukanBack_Click(sender As Object, e As EventArgs) Handles btnKependudukanBack.Click
        GBKependudukan.Hide()
    End Sub
    Private Sub btnWilayah_Click(sender As Object, e As EventArgs) Handles btnWilayah.Click
        GBWilayah.Show()
    End Sub
    Private Sub btnDataSheet_Click(sender As Object, e As EventArgs) Handles btnDataSheet.Click
        GBDatasheet.Show()
    End Sub
    Private Sub btnRefrensi_Click(sender As Object, e As EventArgs) Handles btnRefrensi.Click
        GBRefrensi.Show()
    End Sub
    Private Sub btnKependudukan_Click(sender As Object, e As EventArgs) Handles btnKependudukan.Click
        GBKependudukan.Show()
    End Sub

    Private Sub frm_OfficePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FormSize()
        Call PbPosition()
        Call Dashboard()
    End Sub





    
    
    
    
    
   
   
    
    
    
    
End Class
