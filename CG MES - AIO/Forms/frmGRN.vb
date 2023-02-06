Public Class frmGRN
    Private Sub frmGRN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebView21.Source = New Uri("https://docs.google.com/spreadsheets/d/122IXeEhR_ZZ2fV7Kxo_qRBkch_NZ2qGEcmDAtSs9rDc/edit?usp=sharing")
    End Sub

    Private Sub btnBrowser_Click(sender As Object, e As EventArgs) Handles btnBrowser.Click
        Process.Start("https://docs.google.com/spreadsheets/d/122IXeEhR_ZZ2fV7Kxo_qRBkch_NZ2qGEcmDAtSs9rDc/edit?usp=sharing")
    End Sub
End Class