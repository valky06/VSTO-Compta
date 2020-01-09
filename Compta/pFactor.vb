Imports System.Data
Imports System.Windows.Forms
Imports System.IO
Imports System.IO.File
Imports System.IO.Compression

Public Class pFactor


    Dim init As Boolean = False
    Dim APP As Excel.Application = Globals.CompoXLCompta.Application
    Dim letiersId As Integer
    Dim lexportId

    Public Sub initialise()
        Dim APP As Excel.Application = Globals.CompoXLCompta.Application
        My.Settings.Reload()
        Try
            If Not init Then
                Try
                    ConnexionFerme(conSqlFactor)
                    ConnexionInit(My.Settings.ConSQLFactor, conSqlFactor)

                    Me.init = True
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            APP.StatusBar = ""
            Me.tInit.Text = IIf(init, "Connecté", "Non connecté")
        End Try
    End Sub

    Sub Export_Liste(sender As Object, e As EventArgs) Handles lTiers.SelectedIndexChanged
        Dim ssql As String = ""
        Dim leRs As OleDb.OleDbDataReader

        If Me.lTiers.SelectedIndex < 0 Then Exit Sub

        Me.letiersId = Me.lTiers.SelectedItem.value
        Me.gExport.Rows.Clear()
        ssql = "Select top 30 exportid,exportdate from export where tiersid=" & Me.letiersId & " order by exportdate desc"
        leRs = SqlLit(ssql, conSqlFactor)
        While leRs.Read
            Me.gExport.Rows.Add(leRs("ExportId"), leRs("ExportDate"))
        End While
        leRs.Close()
        Me.bExport.Enabled = False

    End Sub

    Private Sub i_info_DoubleClick(sender As Object, e As EventArgs) Handles i_info.DoubleClick
        System.Diagnostics.Process.Start(Me.i_info.Tag)
    End Sub

    Private Sub tInit_DoubleClick(sender As Object, e As EventArgs) Handles tInit.DoubleClick
        Dim a As String = InputBox("Mot de passe")
        If a = "!KEP" Then
            Dim frm As New FrmParam
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                init = False
                Call initialise()
            End If
        End If
    End Sub


    Private Sub pFactor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.i_info.Enabled = (Me.i_info.Tag <> "")
        Try
            Call initialise()
            Call ComboRempli("Select tiersid,tiersnom from tiers", Me.lTiers, conSqlFactor)
            Call listeOnglet(Nothing, Nothing)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tTiers_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles tTiers.LinkClicked
        Dim f As New FrmTiers
        If Me.lTiers.SelectedIndex >= 0 Then
            f.leTiersid = Me.lTiers.SelectedItem.value
            If f.ShowDialog = DialogResult.OK Then Call ComboRempli("Select tiersid,tiersnom from tiers", Me.lTiers, conSqlFactor)
        End If
    End Sub

    Private Sub gExport_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gExport.CellContentClick

    End Sub

    Private Sub cFGL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lFGL.SelectedIndexChanged
        If Me.lFGL.SelectedIndex >= 0 Then Me.bMEF.Enabled = True
        Me.bExport.Enabled = False
    End Sub

    Private Sub bMEF_Click(sender As Object, e As EventArgs) Handles bMEF.Click
        Dim WDest As Excel.Worksheet
        Dim Wsource As Excel.Worksheet = Nothing
        Dim b As Boolean
        Dim lers As OleDb.OleDbDataReader
        Dim li As Integer
        Dim liSource As Integer
        Dim Solde As Decimal = 0
        Dim montant As Decimal
        Dim leSiret As String = ""
        Dim lecompte As String = ""
        Dim Leclient As String = ""
        Dim pos As Integer
        Dim leTXt As String = ""
        Dim Numcontrat As String

        'Création de l'onglet
        b = False
        For i = 1 To APP.Sheets.Count
            If APP.Sheets(i).name = "Factor" Then b = True
            If APP.Sheets(i).name = Me.lFGL.Text Then Wsource = APP.Sheets(i)
        Next

        Try

            If b Then APP.Sheets("Factor").delete
            WDest = APP.Sheets.Add()
            WDest.Name = "Factor"
            If Wsource Is Nothing Then Exit Sub

            'Cherche le Num d'export
            lexportId = 0
            lers = SqlLit("select max(exportid) as exportId from export where year(exportdate)=" & Now.Year & " and tiersid=" & Me.letiersId, conSqlFactor)
            While lers.Read
                lexportId = Nz(lers("exportid"), 0)
            End While
            lers.Close()
            lexportid += 1

            'cherche les données client
            lers = SqlLit("SELECT Siret,RaisonSociale FROM Tiers where tiersid=" & Me.letiersId, conSqlFactor)
            While lers.Read
                leSiret = lers("Siret")
                Leclient = lers("RaisonSociale")
            End While
            lers.Close()
            If Nz(Wsource.Cells(3, 2).value, "") <> "" Then
                If Wsource.Cells(3, 2).value.ToString.Contains("Compte ") Then
                    lecompte = Nz(Wsource.Cells(3, 2).value, "").ToString.Replace("Compte ", "@")
                    pos = lecompte.LastIndexOf("@")
                    lecompte = lecompte.Substring(pos + 1, lecompte.Length - pos - 1)
                End If
            End If

            'Genère le fichier
            My.Settings.Reload()
            Numcontrat = My.Settings.NumContrat
            With WDest
                '1ere ligne
                li = 1
                .Cells(li, 1).value = "01" & num2Fact(li, 6) & "138" & txt2Fact(NumContrat, 6) & "EUR" & txt2Fact(RaisonSociale, 25) & Now.ToString("ddMMyyyy") & Now.ToString("ddMMyyyy") & num2Fact(lexportid, 3) & "7.0" & "".PadRight(208, " ")

                'lignes détails
                liSource = 7
                While Wsource.Cells(liSource, 2).value <> ""
                    If Nz(Wsource.Cells(liSource, 7).value, "") = "" Then
                        If Wsource.Cells(liSource, 2).value >= My.Settings.DateDebutFactor Then
                            li += 1
                            leTXt = "02" & num2Fact(li, 6) & txt2Fact(leSiret, 14) & txt2Fact(Leclient, 15) & txt2Fact(lecompte, 10) & txt2Fact("", 5) & "D" & txt2Fact("", 29) _
                            & txt2Fact(Nz(Wsource.Cells(liSource, 12).value, ""), 30)

                            montant = 0
                            If Nz(Wsource.Cells(liSource, 6).value, 0) <> "" Then montant += Nz(Wsource.Cells(liSource, 6).value, 0)
                            If Nz(Wsource.Cells(liSource, 8).value, 0) <> "" Then montant -= Nz(Wsource.Cells(liSource, 8).value, 0)
                            Solde += montant
                            Select Case Nz(Wsource.Cells(liSource, 4).value, "")
                                Case "F"
                                    leTXt &= txt2Fact(Nz(Wsource.Cells(liSource, 12).value, "") + Nz(Wsource.Cells(liSource, 13).value, "").Replace("/", ""), 30) & "FACVIR"
                                    leTXt &= date2Fact(Nz(Wsource.Cells(liSource, 2).value, "")) & date2Fact(Nz(Wsource.Cells(liSource, 13).value, ""))
                                Case "A"
                                    leTXt &= txt2Fact(Nz(Wsource.Cells(liSource, 12).value, "") + Nz(Wsource.Cells(liSource, 13).value, "").Replace("/", ""), 30) & "AVO   "
                                    leTXt &= date2Fact(Nz(Wsource.Cells(liSource, 2).value, "")) & txt2Fact("", 8)
                                Case "OD"
                                    leTXt &= txt2Fact(Nz(Wsource.Cells(liSource, 12).value, "") + Nz(Wsource.Cells(liSource, 13).value, "").Replace("/", ""), 30)
                                    If Nz(Wsource.Cells(li, 6).value, "") <> "" Then leTXt &= "ODD   " Else leTXt &= "ODC   "
                                    leTXt &= date2Fact(Nz(Wsource.Cells(liSource, 2).value, "")) & txt2Fact("", 8)
                                Case "V", "C", "T"
                                    If montant > 0 Then
                                        leTXt &= txt2Fact(Nz(Wsource.Cells(liSource, 12).value, "") + Nz(Wsource.Cells(liSource, 2).value, "").Replace("/", ""), 30) & "FACVIR"
                                        leTXt &= date2Fact(Nz(Wsource.Cells(liSource, 2).value, "")) & date2Fact(Nz(Wsource.Cells(liSource, 2).value, ""))
                                    Else
                                        leTXt &= txt2Fact(Nz(Wsource.Cells(liSource, 12).value, ""), 15) & txt2Fact("", 15) & "RNI   "
                                        leTXt &= date2Fact(Nz(Wsource.Cells(liSource, 2).value, "")) & txt2Fact("", 8)
                                    End If

                                Case Else
                                    leTXt &= txt2Fact("", 41)
                            End Select
                            leTXt &= mnt2Fact(Math.Abs(montant), 13) & "EUR" & txt2Fact("", 95)
                            .Cells(li, 1).value = leTXt

                        End If
                    End If
                    liSource += 1

                End While

                'Ligne fin
                li += 1
                .Cells(li, 1).value = "09" & num2Fact(li, 6) & "138" & txt2Fact(NumContrat, 6) & txt2Fact(RaisonSociale, 25) & mnt2Fact(Math.Abs(Solde), 13) & txt2Fact(" ", 220)
            End With
            Me.bExport.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub bExport_Click(sender As Object, e As EventArgs) Handles bExport.Click

        Dim wsource As Excel.Worksheet = Nothing
        Dim leTXt As String
        Dim fs As FileStream = Nothing
        Dim li As Integer
        Dim lefichier As String
        Dim ssql As String

        My.Settings.Reload()
        lefichier = "Factor" & Now.ToString("ddMMyyyy_HHmmss")

        'cherche la feuille "FACTOR"
        For i = 1 To APP.Sheets.Count
            If APP.Sheets(i).name = "Factor" Then wsource = APP.Sheets(i)
        Next
        If Not wsource Is Nothing Then

            'Génère le fichier TXT
            leTXt = ""
            li = 1
            While wsource.Cells(li, 1).value <> ""
                leTXt &= wsource.Cells(li, 1).value & Chr(13) & Chr(10)
                li += 1
            End While
            System.IO.File.WriteAllText(My.Settings.ChemFactor & "\" & lefichier & ".txt", leTXt)

            'Compression du fichier
            If File.Exists(My.Settings.ChemFactor & "\Factor.zip") Then File.Delete(My.Settings.ChemFactor & "\Factor.zip")
            Using archive As ZipArchive = ZipFile.Open(My.Settings.ChemFactor & "\Factor.zip", ZipArchiveMode.Update)
                archive.CreateEntryFromFile(My.Settings.ChemFactor & "\" & lefichier & ".txt", lefichier & ".txt", CompressionLevel.Optimal)
            End Using

            If MsgBox("Enregistrer l'export ?", MsgBoxStyle.OkCancel, "Attention") = MsgBoxResult.Ok Then
                ssql = "Insert into export (exportid,exportdate,ExportFile,tiersid) values(" & lexportId & ",'" & Now & "','" & lefichier & ".txt'," & letiersId & ")"
                SqlDo(ssql, conSqlFactor)
                wsource.Delete()
                Me.bExport.Enabled = False
                Call Export_Liste(Nothing, Nothing)
                MsgBox("Export Terminé")
                System.Diagnostics.Process.Start(My.Settings.ChemFactor)
            End If
        End If
    End Sub

    Private Sub listeOnglet(sender As Object, e As EventArgs) Handles lFGL.DropDown
        Me.lFGL.Items.Clear()

        For i = 1 To APP.ActiveWorkbook.Sheets.Count
            If APP.ActiveWorkbook.Sheets(i).Name <> "Factor" Then Me.lFGL.Items.Add(APP.ActiveWorkbook.Sheets(i).Name)
        Next i

    End Sub

    Private Sub tInit_Click(sender As Object, e As EventArgs) Handles tInit.Click

    End Sub
End Class
