Public Class FrmTiers
    Public leTiersid As Integer = 0

    Private Sub FrmTiers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FormVide(Me)
        If Me.leTiersid <> 0 Then
            Call FormRempli(Me, "Select * from tiers where tiersid=" & Me.leTiersid, conSqlFactor)
        End If
    End Sub

    Private Sub bOK_Click(sender As Object, e As EventArgs) Handles bOK.Click
        If FormVerif(Me, Nothing) Then leTiersid = FormEnreg(Me, "Tiers", conSqlFactor)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub bAnnul_Click(sender As Object, e As EventArgs) Handles bAnnul.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class