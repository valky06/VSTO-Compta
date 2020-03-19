Imports System.Data
Imports System.Windows.Forms

Public Class pTVA
    Dim init As Boolean = False
    Dim compteur As Integer = 1
    Dim APP As Excel.Application = Globals.CompoXLCompta.Application

    Public Sub initialise()

        Dim APP As Excel.Application = Globals.CompoXLCompta.Application
        My.Settings.Reload()
        Try
            If Not init Then
                APP.StatusBar = "Déconnexion..."
                Me.init = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            APP.StatusBar = ""
            Me.tInit.Text = IIf(init, "Connecté", "Non connecté")
        End Try
    End Sub

    Private Sub tInit_Click(sender As System.Object, e As System.EventArgs) Handles tInit.Click
        Dim a As String = InputBox("Mot de passe")
        If a = "!KEP" Then
            Dim frm As New FrmParam
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                init = False
                Call initialise()
            End If
        End If
    End Sub

    Private Sub ImporteEcrit()
        Dim ConExiste As Boolean
        Dim FeuilExiste As Boolean
        Dim ssql As String = ""

        Try
            APP.Workbooks(Me.cFTVA.Text).Worksheets(Me.cOTVA.Text).activate

            ConExiste = False
            For Each con In APP.ActiveWorkbook.Connections
                If con.Name = "DataSilog" Then ConExiste = True
            Next

            FeuilExiste = False
            For i = 1 To APP.Workbooks(Me.cFTVA.Text).Worksheets.Count
                If APP.Workbooks(Me.cFTVA.Text).Worksheets(i).name = "DataSilog" Then FeuilExiste = True
            Next

            If Not FeuilExiste Then
                APP.Workbooks(Me.cFTVA.Text).Worksheets.Add()
                APP.ActiveSheet.name = "DataSilog"
            End If

            '        With ActiveSheet.ListObjects.Add(SourceType:=0, Source:=Array(
            '    "OLEDB;Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=True;Data Source=sqlc2;Use Procedure for Prepare=1;Auto Trans"     ,    "late=True;Packet Size=4096;Workstation ID=VPDE-83N2XS2;Use Encryption for Data=False;Tag with column collation when possible=Fal" _
            '    , "se;Initial Catalog=KTISSOUCY"), Destination:=Range("$A$1")).QueryTable
            '            .CommandType = xlCmdTable
            '            .CommandText = Array("""KTISSOUCY"".""dbo"".""ABCONSO""")
            '            .RowNumbers = False
            '            .FillAdjacentFormulas = False
            '            .PreserveFormatting = True
            '            .RefreshOnFileOpen = False
            '            .BackgroundQuery = True
            '            .RefreshStyle = xlInsertDeleteCells
            '            .SavePassword = False
            '            .SaveData = True
            '            .AdjustColumnWidth = True
            '            .RefreshPeriod = 0
            '            .PreserveColumnInfo = True
            '            .SourceConnectionFile =
            '    "C:\Users\lvalcasara\Documents\Mes sources de données\sqlc2 KTISSOUCY ABCONSO.odc"
            '            .ListObject.DisplayName = "Tableau_sqlc2_KTISSOUCY_ABCONSO"
            '            .Refresh BackgroundQuery:=False
            'End With

            '        Range("A2").Select
            '        With ActiveWorkbook.Connections("DataSilog").OLEDBConnection
            '            .BackgroundQuery = True
            '            .CommandText = Array(
            '    "SELECT        FAAE.NumeroFacture + FAAE.NoFacture AS PIeceTot, FAAE.NumeroFacture, FAAE.NoFacture, FAAE.CodeFournis" _
            '    ,
            '    "seur, FAAE.DateEffetPiece, FAAE.NomFournisseur, FAAE.MontantHtRemise, FAAE.MontantFrancsTva1, " & Chr(13) & "" & Chr(10) & "                   " _
            '    ,
            '    "      FAAE.MontantFrancsTva2, FAAE.MontantFrancsTva3, FAAE.MontantFrancsTva4, FAAE.MontantFrancsTva5, FAAE.NumeroFa" _
            '    ,
            '    "cture AS Expr1, FAAE.DateFacturation, FAAE.CompteGeneTva1, FAAE.CompteGeneTva2, " & Chr(13) & "" & Chr(10) & "                         FAAE.Com" _
            '    ,
            '    "pteGeneTva3, FAAE.CompteGeneTva4, FAAE.CompteGeneTva5, FAAE.CompteGeneTva6, FOU.CompteFournisseur" & Chr(13) & "" & Chr(10) & "FROM            " _
            '    ,
            '    "FAAE LEFT JOIN" & Chr(13) & "" & Chr(10) & "                         FOU ON FAAE.CodeFournisseur = FOU.CodeFournisseur" & Chr(13) & "" & Chr(10) & "WHERE     (YEAR(FAAE.Da" _
            '    , "teFacturation) = 2019)")
            '            .CommandType = xlCmdSql
            '            .Connection = Array(
            '    "OLEDB;Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=True;Initial Catalog=KTISSOUCY;Data Source=sqlc2;Use Procedur" _
            '    ,
            '    "e for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=VPDE-83N2XS2;Use Encryption for Data=False;Tag with column c" _
            '    , "ollation when possible=False")
            '            .RefreshOnFileOpen = False
            '            .SavePassword = False
            '            .SourceConnectionFile = ""
            '            .SourceDataFile = ""
            '            .ServerCredentialsMethod = xlCredentialsMethodIntegrated
            '            .AlwaysUseConnectionFile = False
            '            .ServerFillColor = False
            '            .ServerFontStyle = False
            '            .ServerNumberFormat = False
            '            .ServerTextColor = False
            '        End With
            '        With ActiveWorkbook.Connections("DataSilog")
            '            .Name = "DataSilog"
            '            .Description = ""
            '        End With
            '        ActiveWorkbook.Connections("DataSilog").Refresh

            'APP.Workbooks(Me.cFTVA.Text).Worksheets.Count

            ssql = "Select FAAE.NumeroFacture + '-' + FAAE.NoFacture As PIeceTot, FAAE.NumeroFacture, FAAE.NoFacture, FAAE.CodeFournisseur, FAAE.DateEffetPiece, FAAE.NomFournisseur, FAAE.MontantHtRemise, FAAE.MontantFrancsTva1, " _
            & " FAAE.MontantFrancsTva2, FAAE.MontantFrancsTva3, FAAE.MontantFrancsTva4, FAAE.MontantFrancsTva5, FAAE.DateFacturation, FAAE.CompteGeneTva1, FAAE.CompteGeneTva2, " _
            & " FAAE.CompteGeneTva3, FAAE.CompteGeneTva4, FAAE.CompteGeneTva5, FAAE.CompteGeneTva6, FOU.CompteFournisseur,'SOU' as Site" _
            & " FROM KTISSOUCY.dbo.FAAE LEFT JOIN KTISSOUCY.dbo.FOU On FAAE.CodeFournisseur = FOU.CodeFournisseur WHERE     (YEAR(FAAE.DateFacturation) = " & Me.tAnnee.Text & ")" _
            & " UNION " _
            & " Select FAAE.NumeroFacture + '-' +  FAAE.NoFacture As PIeceTot, FAAE.NumeroFacture, FAAE.NoFacture, FAAE.CodeFournisseur, FAAE.DateEffetPiece, FAAE.NomFournisseur, FAAE.MontantHtRemise, FAAE.MontantFrancsTva1, " _
            & " FAAE.MontantFrancsTva2, FAAE.MontantFrancsTva3, FAAE.MontantFrancsTva4, FAAE.MontantFrancsTva5, FAAE.DateFacturation, FAAE.CompteGeneTva1, FAAE.CompteGeneTva2, " _
            & " FAAE.CompteGeneTva3, FAAE.CompteGeneTva4, FAAE.CompteGeneTva5, FAAE.CompteGeneTva6, FOU.CompteFournisseur,'LAX' as Site" _
            & " FROM KTISLAXOU.dbo.FAAE LEFT JOIN KTISLAXOU.dbo.FOU On FAAE.CodeFournisseur = FOU.CodeFournisseur WHERE     (YEAR(FAAE.DateFacturation) = " & Me.tAnnee.Text & ")" _
            & " UNION " _
            & " Select FAAE.NumeroFacture + '-' + FAAE.NoFacture As PIeceTot, FAAE.NumeroFacture, FAAE.NoFacture, FAAE.CodeFournisseur, FAAE.DateEffetPiece, FAAE.NomFournisseur, FAAE.MontantHtRemise, FAAE.MontantFrancsTva1, " _
            & " FAAE.MontantFrancsTva2, FAAE.MontantFrancsTva3, FAAE.MontantFrancsTva4, FAAE.MontantFrancsTva5, FAAE.DateFacturation, FAAE.CompteGeneTva1, FAAE.CompteGeneTva2, " _
            & " FAAE.CompteGeneTva3, FAAE.CompteGeneTva4, FAAE.CompteGeneTva5, FAAE.CompteGeneTva6, FOU.CompteFournisseur,'BEN' as Site" _
            & " FROM APL.dbo.FAAE LEFT JOIN APL.dbo.FOU On FAAE.CodeFournisseur = FOU.CodeFournisseur WHERE     (YEAR(FAAE.DateFacturation) = " & Me.tAnnee.Text & ")" _
            & " UNION " _
            & " Select FAAE.NumeroFacture + '-' + FAAE.NoFacture As PIeceTot, FAAE.NumeroFacture, FAAE.NoFacture, FAAE.CodeFournisseur, FAAE.DateEffetPiece, FAAE.NomFournisseur, FAAE.MontantHtRemise, FAAE.MontantFrancsTva1, " _
            & " FAAE.MontantFrancsTva2, FAAE.MontantFrancsTva3, FAAE.MontantFrancsTva4, FAAE.MontantFrancsTva5, FAAE.DateFacturation, FAAE.CompteGeneTva1, FAAE.CompteGeneTva2, " _
            & " FAAE.CompteGeneTva3, FAAE.CompteGeneTva4, FAAE.CompteGeneTva5, FAAE.CompteGeneTva6, FOU.CompteFournisseur,'CAS' as Site" _
            & " FROM KMTM.dbo.FAAE LEFT JOIN KMTM.dbo.FOU On FAAE.CodeFournisseur = FOU.CodeFournisseur WHERE   (YEAR(FAAE.DateFacturation) = " & Me.tAnnee.Text & ")"

            If Not FeuilExiste Then
                My.Settings.Reload()
                With APP.ActiveSheet.ListObjects.Add(SourceType:=0, Source:="OLEDB;" & My.Settings.ConSQLSilog, Destination:=APP.Cells(1, 1)).QueryTable
                    .CommandType = Excel.XlCmdType.xlCmdSql
                    .CommandText = ssql
                    .RowNumbers = False
                    .FillAdjacentFormulas = False
                    .PreserveFormatting = True
                    .RefreshOnFileOpen = False
                    .BackgroundQuery = False
                    .SavePassword = False
                    .SaveData = True
                    .AdjustColumnWidth = True
                    .RefreshPeriod = 0
                    .PreserveColumnInfo = True
                    .Refresh(BackgroundQuery:=False)
                End With
            Else
                APP.ActiveSheet.cells(1, 1).select
                APP.ActiveCell.ListObject.QueryTable.CommandText = ssql
                APP.ActiveCell.ListObject.QueryTable.Refresh()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub RECUPTVA()
        Dim lig As Integer = 2
        Dim Piecetot As String = ""

        Try

            With APP.Workbooks(Me.cFTVA.Text).Worksheets(Me.cOTVA.Text)
                .activate
                .Columns("O:P").Delete
                .cells(1, 15).value = "Lett. Paie."
                .cells(1, 16).value = "Date Paie."

                While .Cells(lig, 1).value <> ""
                    If NZ(.Cells(lig, 10).value, "").ToString.Replace(" ", "").Replace("'", "") = "" Then
                        Piecetot = Trim(.Cells(lig, 11).value) & Trim(.Cells(lig, 4).value.ToString.Split(" ")(0))
                        '[GL2019.xlsx]Gd livre Fournisseurs'!$A:$L;2;)
                        .Cells(lig, 10).formula = "=IFERROR(VLOOKUP(""" & Piecetot & """ ,'DataSilog'!A:U,20,FALSE),"""")"


                        If NZ(.Cells(lig, 10).value, "") <> "" Then
                            .Cells(lig, 10).interior.color = RGB(180, 255, 180)
                        Else
                            .Cells(lig, 10).interior.color = RGB(255, 180, 180)
                        End If
                    End If

                    .Cells(lig, 15).formula = "=IFERROR(VLOOKUP(J" & lig & " & ""-"" & K" & lig & ",'[" & Me.cFGL.Text & "]" & Me.cOGL.Text & "'!A:L,12,FALSE),"""")"
                    .Cells(lig, 16).formula = "=IFERROR(VLOOKUP(J" & lig & " & ""-"" & O" & lig & ",'[" & Me.cFGL.Text & "]" & Me.cOGL.Text & "'!B:C,2,FALSE),"""")"

                    lig += 1
                End While
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub MEF_GL()
        Dim lig As Integer = 2
        Dim CodeFour As String = ""
        Try
            APP.Workbooks(Me.cFTVA.Text).Worksheets(Me.cOTVA.Text).Columns("O:P").Delete

            With APP.Workbooks(Me.cFGL.Text).Worksheets(Me.cOGL.Text)
                .Activate

                If .cells(1, 1).value = "Four-Piece" Then Exit Sub
                If .cells(1, 1).value = "Date" Then
                    .Columns("A:B").Select
                    APP.Selection.Insert(Excel.XlInsertShiftDirection.xlShiftToRight)
                End If

                APP.ScreenUpdating = False

                .cells(1, 1).value = "Four-Piece"
                .cells(1, 2).value = "Four-Let"
                While NZ(.Cells(lig, 5).value, "") <> ""
                    If NZ(.Cells(lig, 3).value, "") = "" And NZ(.Cells(lig, 4).value, "") <> "" Then CodeFour = NZ(.Cells(lig, 4).value, "")
                    .Cells(lig, 1).value = CodeFour & "-" & NZ(.Cells(lig, 6).value, "")

                    If (NZ(.Cells(lig, 5).value, "").ToString.Contains("Vir") Or NZ(.Cells(lig, 5).value, "").ToString.Contains("Chè") Or NZ(.Cells(lig, 5).value, "").ToString.Contains("Pré")) Then
                        .Cells(lig, 2).value = CodeFour & "-" & NZ(.Cells(lig, 12).value, "")
                    End If

                    If NZ(.Cells(lig, 3).value, "") = "" Then .Rows(lig).delete Else lig += 1
                    APP.StatusBar = lig
                End While
                APP.ScreenUpdating = True
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        APP.StatusBar = ""
    End Sub


    Private Sub PTVA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.i_info.Enabled = (Me.i_info.Tag <> "")
        Try
            Me.cFGL.Items.Clear()
            Me.cFTVA.Items.Clear()
            For i = 1 To APP.Workbooks.Count
                Me.cFTVA.Items.Add(APP.Workbooks(i).Name)
                Me.cFGL.Items.Add(APP.Workbooks(i).Name)
            Next i
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CFTVA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cFTVA.SelectedIndexChanged
        Try
            Me.cOTVA.Items.Clear()
            With APP.Workbooks(Me.cFTVA.Text)
                For i = 1 To .Worksheets.Count : Me.cOTVA.Items.Add(.Worksheets(i).name) : Next
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CFGL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cFGL.SelectedIndexChanged
        Try
            Me.cOGL.Items.Clear()
            With APP.Workbooks(Me.cFGL.Text)
                For i = 1 To .Worksheets.Count : Me.cOGL.Items.Add(.Worksheets(i).name) : Next
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call MEF_GL()
        Call ImporteEcrit()
        Call RECUPTVA()
        'todo
    End Sub

    Private Sub TAnnee_TextChanged(sender As Object, e As EventArgs) Handles tAnnee.TextChanged

    End Sub

    Private Sub pTVA_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Call PTVA_Load(Nothing, Nothing)
    End Sub

    Private Sub cFTVA_GotFocus(sender As Object, e As EventArgs) Handles cFTVA.GotFocus
        Try
            Me.cFTVA.Items.Clear()
            For i = 1 To APP.Workbooks.Count
                Me.cFTVA.Items.Add(APP.Workbooks(i).Name)
            Next i
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cFGL_GotFocus(sender As Object, e As EventArgs) Handles cFGL.GotFocus
        Try
            Me.cFGL.Items.Clear()
            For i = 1 To APP.Workbooks.Count
                Me.cFGL.Items.Add(APP.Workbooks(i).Name)
            Next i
        Catch ex As Exception
        End Try
    End Sub

    Private Sub info(sender As Object, e As EventArgs) Handles i_info.Click
        System.Diagnostics.Process.Start(Me.i_info.Tag)

    End Sub
End Class
