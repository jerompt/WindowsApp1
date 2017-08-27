Module GlobalVariables

    Public G_Depto As New List(Of String)
    Public G_Torre As New List(Of String)
    Public G_Propietario As New List(Of String)
    Public G_Indiviso As New List(Of Double)
    Public G_BuildingName As String
    Public G_CodeGen As New List(Of String)
    Public G_PropiedadID As New List(Of String)
    Public G_NAsamblea As String
    Public G_AsambleaPuntos As New List(Of String)
    Public G_NumAsa As Integer

End Module


Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub btnCargarProyecto_Click(sender As Object, e As EventArgs) Handles btnCargarProyecto.Click
        Dim proyecto As String
        Dim LookFor As String = ""
        Dim pass As Boolean
        Dim cancel As Integer = 0
        'Console.WriteLine("Varaibles")
        proyecto = ComboBox1.SelectedItem
        ''Bosques = BOS
        ''Belmont = BEL
        ''Comunidad Torres III y IV = COM
        ''Cova 1 = CO1
        ''Cova 2 = CO2
        'Del Angel = ANG
        'Kalah = KA1
        'Kalah 2 = KA2
        'La Admiranza = ADM
        'Levita = LTA
        'Las Vistas = VIS
        'Levant Boca = BOC
        'Levana = LEV
        'Los Arcangeles = ARC
        'Lucena = LUC
        'Magma Towers = MTO
        'Plaza 401 = 401
        'Punto Central = PCE
        'SAQQARA = SAQ
        'Torre Alberi = TAL
        'Torre AURUM = TAU
        'Torre AVE = TAV
        'Torre Ixco = TIX
        'Torre Planetario = TPL
        'Torre Compostela = TCO
        'San Patricio = PAT
        'Torres Verona = TVE

        'Console.WriteLine("busqueda de Proyecto")
        Select Case proyecto
            Case "Bosques"
                LookFor = "bosques.csv"
                G_BuildingName = "BOS"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
               ' Console.WriteLine(LookFor)
            Case "Belmont"
                LookFor = "belmont.csv"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                G_BuildingName = "BEL"
                pass = True
                'Console.WriteLine(LookFor)
            Case "Comunidad Torres III y IV"
                LookFor = "comunidad.csv"
                G_BuildingName = "COM"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
                'Console.WriteLine(LookFor)
            Case "Cova 1"
                LookFor = "cova1.csv"
                G_BuildingName = "CO1"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
                'Console.WriteLine(LookFor)
            Case "Cova 2"
                LookFor = "cova2.csv"
                G_BuildingName = "CO2"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
               ' Console.WriteLine(LookFor)
            Case "Del Angel"
                LookFor = "delAngel.csv"
                G_BuildingName = "ANG"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
               ' Console.WriteLine(LookFor)
            Case "Kalah"
                LookFor = "kalah.csv"
                G_BuildingName = "KA1"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
               ' Console.WriteLine(LookFor)
            Case "Kalah 2"
                LookFor = "kalah2.csv"
                G_BuildingName = "KA2"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
               ' Console.WriteLine(LookFor)
            Case "La Admiranza"
                LookFor = "laAdmiranza.csv"
                G_BuildingName = "ADM"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
               ' Console.WriteLine(LookFor)
            Case "Levita"
                LookFor = "levita.csv"
                G_BuildingName = "LTA"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
                'Console.WriteLine(LookFor)
            Case "Las Vistas"
                LookFor = "lasVistas.csv"
                G_BuildingName = "VIS"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
                'Console.WriteLine(LookFor)
            Case "Levant Boca"
                LookFor = "levantBoca.csv"
                G_BuildingName = "BOC"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
                'Console.WriteLine(LookFor)
            Case "Levana"
                LookFor = "levana.csv"
                G_BuildingName = "LEV"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
                'Console.WriteLine(LookFor)
            Case "Los Arcangeles"
                LookFor = "losArcangeles.csv"
                G_BuildingName = "ARC"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
               ' Console.WriteLine(LookFor)
            Case "Magma Towers"
                LookFor = "magmaTowers.csv"
                G_BuildingName = "MTO"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
                'Console.WriteLine(LookFor)
            Case "Plaza 401"
                LookFor = "plaza401.csv"
                G_BuildingName = "401"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
                'Console.WriteLine(LookFor)
            Case "Punto Central"
                LookFor = "puntoCentral.csv"
                G_BuildingName = "PCE"
                MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
                'Console.WriteLine(LookFor)
            Case "SAQQARA"
                LookFor = "saqqara.csv"
                G_BuildingName = "SAQ"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
                'Console.WriteLine(LookFor)
            Case "Torre Alberi"
                LookFor = "torreAlberi.csv"
                G_BuildingName = "TAL"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
                'Console.WriteLine(LookFor)
            Case "Torre Aurum"
                LookFor = "torreAurum.csv"
                G_BuildingName = "TAU"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
               ' Console.WriteLine(LookFor)
            Case "SAQQARA"
                LookFor = "saqqara.csv"
                G_BuildingName = "SAQ"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
                'Console.WriteLine(LookFor)
            Case "Torre Ave"
                LookFor = "torreAve.csv"
                G_BuildingName = "TAV"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
                'Console.WriteLine(LookFor)
            Case "Torre Ixco"
                LookFor = "torreIxco.csv"
                G_BuildingName = "TAU"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
                'Console.WriteLine(LookFor)
            Case "SAQQARA"
                LookFor = "saqqara.csv"
                G_BuildingName = "SAQ"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
                'Console.WriteLine(LookFor)
            Case "Torre Planetario"
                LookFor = "torrePlanetario.csv"
                G_BuildingName = "TPL"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
               ' Console.WriteLine(LookFor)
            Case "Torres Compostela"
                LookFor = "torresCompostela.csv"
                G_BuildingName = "TCO"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
                'Console.WriteLine(LookFor)
            Case "San Patricio"
                LookFor = "sanPatricio.csv"
                G_BuildingName = "PAT"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
                'Console.WriteLine(LookFor)
            Case "Torres Verona"
                LookFor = "torresVerona.csv"
                G_BuildingName = "TVE"
                cancel = MsgBox("Deseas cargar " & proyecto & "?", MsgBoxStyle.OkCancel, "Notificación")
                pass = True
                'Console.WriteLine(LookFor)
            Case Else
                MsgBox("No se selecciono el proyecto")
                GoTo A
                pass = False
        End Select
        If cancel = 2 Then
            GoTo A
        End If
        'Console.WriteLine("Cargar Tabla")
        If pass Then
            Form1.Show()
            Form1.AddBuilding(LookFor)
            'Console.WriteLine("Cerrando Ventana")
            Me.Hide()
        End If
        ' Console.WriteLine(LookFor)
A:
    End Sub
End Class