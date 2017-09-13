Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports BarcodeLib

Module GlobalVariables


    Public G_NumAsa As Integer
    Public G_Build_ID As Integer
    Public G_Asamb_ID As Integer
    Public GL_depto As String
    Public GL_torre As String
    Public GL_indiviso As String
    Public GL_PropID As String


End Module

Module Module1

    'Checa que el ID sea unico
    Public Function CheckUniqueID(id, numbers, id1)
        Dim dbCon As MySqlConnection
        dbCon = New MySqlConnection("Server=localhost;Database=asambleas_db;Uid=root;Pwd=1234")
        Dim strQuerry As String = ""
        Dim SQLCmd As MySqlCommand
        Dim DR As MySqlDataReader

        Try
            If numbers = 2 Then
                strQuerry = "SELECT COUNT(*) FROM asambleas_db.propiedades WHERE propiedades.n_propiedad = '" & id & "' AND propiedades.proyecto_id = " & id1 & ";"
            ElseIf numbers = 4 Then
                strQuerry = "SELECT COUNT(*) FROM asambleas_db.asambleas WHERE asambleas.n_asamblea = '" & id & "';"
            End If

            SQLCmd = New MySqlCommand(strQuerry, dbCon)
            ' OPEN the DB and Kickoff the Query
            dbCon.Open()
            DR = SQLCmd.ExecuteReader
            DR.Read()
            If DR.Item("COUNT(*)") = 0 Then
                Console.WriteLine("No duplicate Found")
                Return True
            Else
                Return False
            End If
            dbCon.Close()
        Catch ex As Exception
            MsgBox("24" & vbCrLf & ex.Message)
        End Try

    End Function

    'Checa que el ID sea unico para el punto
    Public Function CheckUniqueNum(id, asambleaID)
        Dim dbCon As MySqlConnection
        dbCon = New MySqlConnection("Server=localhost;Database=asambleas_db;Uid=root;Pwd=1234")
        Dim strQuerry As String = ""
        Dim SQLCmd As MySqlCommand
        Dim DR As MySqlDataReader

        Try

            strQuerry = "SELECT COUNT(*) FROM asambleas_db.puntos
			            JOIN asambleas_db.asambleas
			            ON asambleas.id_asamblea = puntos.asamblea_id AND asambleas.n_asamblea = '" & asambleaID & "' AND id_int_punto = " & id & ";"

            SQLCmd = New MySqlCommand(strQuerry, dbCon)
            ' OPEN the DB and Kickoff the Query
            dbCon.Open()
            DR = SQLCmd.ExecuteReader
            DR.Read()
            If DR.Item("COUNT(*)") = 0 Then
                Console.WriteLine("No duplicate Found")
                Return True
            Else
                Return False
            End If

            dbCon.Close()
        Catch ex As Exception
            MsgBox("23" & vbCrLf & ex.Message)
        End Try

    End Function

    'Genera ID's
    Public Function gen_ids(Numbers, id1)
        Randomize()

        Dim randomValue As Integer
        Dim pass As Boolean = False

        Dim upperbound As Integer = 3
        Dim lowerbound As Integer = 1
A:
        Dim id As String = ""
        For i As Integer = 1 To Numbers
            randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
            Console.WriteLine(randomValue)
            If randomValue = 1 Then
                id = id & gen_lowCase()
            ElseIf randomValue = 2 Then
                id = id & gen_UpCase()
            ElseIf randomValue = 3 Then
                id = id & gen_num()
            End If
        Next
        pass = CheckUniqueID(id, Numbers, id1)
        If pass = False Then
            GoTo A
        Else
            Return id
        End If

    End Function

    'Lee Base de datos y despliega informacion
    Public Function Read_prop_from_DB(ProyID)
        Dim dbCon As MySqlConnection
        dbCon = New MySqlConnection("Server=localhost;Database=asambleas_db;Uid=root;Pwd=1234")
        Dim strQuerry As String = ""
        Dim SQLCmd As MySqlCommand
        'Dim DR As MySqlDataReader
        Dim a As Integer = 0
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            dbCon.Open()
            strQuerry = "SELECT propiedades.depto AS 'Unidad', 
                            propiedades.torre AS 'Torre', 
                            propiedades.nom_propietario AS 'Propietario',
                            propiedades.indiviso AS 'Indiviso'
                            FROM asambleas_db.propiedades WHERE propiedades.proyecto_id = " & ProyID & ";"
            SQLCmd = New MySqlCommand(strQuerry, dbCon)
            SDA.SelectCommand = SQLCmd
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            Form1.dgvAsistencia.DataSource = bSource
            SDA.Update(dbDataSet)


            dbCon.Close()
        Catch ex As Exception
            MsgBox("22" & vbCrLf & ex.Message)
        End Try

    End Function

    ' Genera Valor Aleatoreo minusculas
    Public Function gen_lowCase()
        Randomize()
        Dim randomValue As Integer
        Dim upperbound As Integer = 26
        Dim lowerbound As Integer = 1

        randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        Select Case randomValue
            Case 1
                Return "a"
            Case 2
                Return "b"
            Case 3
                Return "c"
            Case 4
                Return "d"
            Case 5
                Return "e"
            Case 6
                Return "f"
            Case 7
                Return "g"
            Case 8
                Return "h"
            Case 9
                Return "i"
            Case 10
                Return "j"
            Case 11
                Return "k"
            Case 12
                Return "l"
            Case 13
                Return "m"
            Case 14
                Return "n"
            Case 15
                Return "o"
            Case 16
                Return "p"
            Case 17
                Return "q"
            Case 18
                Return "r"
            Case 19
                Return "s"
            Case 20
                Return "t"
            Case 21
                Return "u"
            Case 22
                Return "v"
            Case 23
                Return "w"
            Case 24
                Return "x"
            Case 25
                Return "y"
            Case 26
                Return "z"
        End Select

    End Function

    ' Genera Valor Aleatoreo Mayuculas
    Public Function gen_UpCase()
        Randomize()
        Dim randomValue As Integer
        Dim upperbound As Integer = 26
        Dim lowerbound As Integer = 1

        randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        Select Case randomValue
            Case 1
                Return "A"
            Case 2
                Return "B"
            Case 3
                Return "C"
            Case 4
                Return "D"
            Case 5
                Return "E"
            Case 6
                Return "F"
            Case 7
                Return "G"
            Case 8
                Return "H"
            Case 9
                Return "I"
            Case 10
                Return "J"
            Case 11
                Return "K"
            Case 12
                Return "L"
            Case 13
                Return "M"
            Case 14
                Return "N"
            Case 15
                Return "O"
            Case 16
                Return "P"
            Case 17
                Return "Q"
            Case 18
                Return "R"
            Case 19
                Return "S"
            Case 20
                Return "T"
            Case 21
                Return "U"
            Case 22
                Return "V"
            Case 23
                Return "W"
            Case 24
                Return "X"
            Case 25
                Return "Y"
            Case 26
                Return "Z"
        End Select
    End Function
    ' Genera Valor Aleatoreo numero
    Public Function gen_num()
        Randomize()
        Dim randomValue As Integer
        Dim upperbound As Integer = 9
        Dim lowerbound As Integer = 0
        Dim value As Integer

        randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        value = randomValue

        Return value
    End Function

    Public Function LimpiarPunto(i)

        Dim code As String = ""

        If i < 10 Then
            code = "0" & i
        End If

        Return code

    End Function

    Public Function Get_Punto(n)
        Dim numP As Integer
        Dim dbCon As MySqlConnection
        Dim strQuerry As String = ""
        Dim SQLCmd As MySqlCommand
        Dim DR As MySqlDataReader

        Try
            dbCon = New MySqlConnection("Server=localhost;Database=asambleas_db;Uid=root;Pwd=1234")
            strQuerry = "SELECT nom_asamblea FROM asambleas_db.asambleas WHERE asambleas.n_asamblea = '" & n & "';"
            SQLCmd = New MySqlCommand(strQuerry, dbCon)
            ' OPEN the DB and Kickoff the Query
            dbCon.Open()
            DR = SQLCmd.ExecuteReader

            Return DR.Item("nom_asamblea")

            dbCon.Close()

        Catch ex As Exception
            MsgBox("22" & vbCrLf & ex.Message)
        End Try


        Return numP
    End Function

    ' Obtiene informacion de Propiedad para generar Codigos
    Public Sub Get_PropInfo(n)
        GL_depto = ""
        GL_torre = ""
        GL_indiviso = ""
        GL_PropID = ""

        Dim dbCon As MySqlConnection
        dbCon = New MySqlConnection("Server=localhost;Database=asambleas_db;Uid=root;Pwd=1234")
        Dim strQuerry As String = ""
        Dim SQLCmd As MySqlCommand
        Dim DR As MySqlDataReader
        Try
            strQuerry = "SELECT n_propiedad, torre, depto, indiviso FROM asambleas_db.propiedades WHERE proyecto_id = " & G_Build_ID & "
                            LIMIT " & n & ",1 ;"
            SQLCmd = New MySqlCommand(strQuerry, dbCon)
            ' OPEN the DB and Kickoff the Query
            dbCon.Open()
            DR = SQLCmd.ExecuteReader
            DR.Read()
            GL_PropID = DR.Item("n_propiedad")
            GL_torre = DR.Item("torre")
            GL_depto = DR.Item("depto")
            GL_indiviso = DR.Item("indiviso")
            dbCon.Close()
        Catch ex As Exception
            MsgBox("21" & vbCrLf & ex.Message)
        End Try

    End Sub

    Public Function GetTorreYDepa()
        Dim torreYdepa As String = ""

        If GL_torre = "" Then
            torreYdepa = GL_depto
        Else
            torreYdepa = GL_torre & " - " & GL_depto
        End If

        Return torreYdepa

    End Function

    Public Function Get_nom_punto(n)
        Dim dbCon As MySqlConnection
        dbCon = New MySqlConnection("Server=localhost;Database=asambleas_db;Uid=root;Pwd=1234")
        Dim strQuerry As String = ""
        Dim SQLCmd As MySqlCommand
        Dim DR As MySqlDataReader
        Dim a As String
        Try
            strQuerry = "SELECT num_punto FROM asambleas_db.puntos WHERE asamblea_id = " & G_Asamb_ID & "
                            LIMIT " & n & ",1 ;"
            SQLCmd = New MySqlCommand(strQuerry, dbCon)
            Console.WriteLine(SQLCmd)
            ' OPEN the DB and Kickoff the Query
            dbCon.Open()
            DR = SQLCmd.ExecuteReader
            DR.Read()
            a = DR.Item("num_punto")
        Catch ex As Exception
            MsgBox("20" & vbCrLf & ex.Message)
        End Try
        Return a
    End Function

    Public Function Get_nom_asamblea(n)
        Dim dbCon As MySqlConnection
        Dim strQuerry As String = ""
        Dim SQLCmd As MySqlCommand
        Dim DR As MySqlDataReader

        Try
            dbCon = New MySqlConnection("Server=localhost;Database=asambleas_db;Uid=root;Pwd=1234")
            strQuerry = "SELECT nom_asamblea FROM asambleas_db.asambleas WHERE asambleas.n_asamblea = '" & n & "';"
            SQLCmd = New MySqlCommand(strQuerry, dbCon)
            ' OPEN the DB and Kickoff the Query
            dbCon.Open()
            DR = SQLCmd.ExecuteReader
            DR.Read()
            Return DR.Item("nom_asamblea")
            dbCon.Close()
        Catch ex As Exception
            MsgBox("19" & vbCrLf & ex.Message)
        End Try

    End Function

    Public Function Get_code(n)
        Dim code As String = ""
        Dim dbCon As MySqlConnection
        Dim strQuerry As String = ""
        Dim SQLCmd As MySqlCommand
        Dim DR As MySqlDataReader

        Try
            dbCon = New MySqlConnection("Server=localhost;Database=asambleas_db;Uid=root;Pwd=1234")
            strQuerry = "SELECT nom_asamblea FROM asambleas_db.asambleas WHERE asambleas.n_asamblea = '" & n & "';"
            SQLCmd = New MySqlCommand(strQuerry, dbCon)
            ' OPEN the DB and Kickoff the Query
            dbCon.Open()
            DR = SQLCmd.ExecuteReader

            Return DR.Item("nom_asamblea")

            dbCon.Close()

        Catch ex As Exception
            MsgBox("18" & vbCrLf & ex.Message)
        End Try



        code = code & GL_PropID


        Return code

    End Function

    Public Function GetNombre(nombre2)

        Try
            Dim nombre As String = ""
            If nombre2.ToString = "" Then
                MsgBox("Espacio vacio")
            Else
                Return nombre = nombre2
            End If
        Catch ex As Exception
            MsgBox("null Exception " & vbCrLf & ex.Message)
        End Try

    End Function

    Public Function GetNum(num2)
        Dim num As Integer
        Try
            num = Convert.ToSingle(num2.ToString)
        Catch ex As Exception
            MsgBox("Valor no es un numero" & vbCrLf & ex.Message)
        End Try

    End Function

    Public Sub Load_proyectos()
        Dim dbCon As MySqlConnection
        Dim strQuerry As String = ""
        Dim SQLCmd As MySqlCommand
        Dim DR As MySqlDataReader

        Try
            dbCon = New MySqlConnection("Server=localhost;Database=asambleas_db;Uid=root;Pwd=1234")
            strQuerry = "SELECT proyectos.nom_proyecto FROM asambleas_db.proyectos"
            SQLCmd = New MySqlCommand(strQuerry, dbCon)
            ' OPEN the DB and Kickoff the Query
            dbCon.Open()
            DR = SQLCmd.ExecuteReader

            While DR.Read

                Form2.ComboBox1.Items.Add(DR.Item("nom_proyecto"))

            End While

            dbCon.Close()

        Catch ex As Exception
            MsgBox("17" & vbCrLf & ex.Message)
        End Try
    End Sub

    Public Sub LoadPuntos()
        Dim dbCon As MySqlConnection
        Dim strQuerry As String = ""
        Dim SQLCmd As MySqlCommand
        Dim DR As MySqlDataReader

        Try
            dbCon = New MySqlConnection("Server=localhost;Database=asambleas_db;Uid=root;Pwd=1234")
            strQuerry = "SELECT DISTINCT n_asamblea FROM asambleas_db.asambleas WHERE proyecto_id =" & G_Build_ID & ";"
            SQLCmd = New MySqlCommand(strQuerry, dbCon)
            ' OPEN the DB and Kickoff the Query
            dbCon.Open()
            DR = SQLCmd.ExecuteReader

            While DR.Read

                AgregarAsamblea.cbx_Asambleas.Items.Add(DR.Item("n_asamblea"))

            End While

            dbCon.Close()

        Catch ex As Exception
            MsgBox("16" & vbCrLf & ex.Message)
        End Try
    End Sub

    ' Obtiene el punto para desplegar en boleta
    Public Function Get_Punto(n, a)
        Dim dbCon As MySqlConnection
        dbCon = New MySqlConnection("Server=localhost;Database=asambleas_db;Uid=root;Pwd=1234")

        Dim strQuerry As String = ""
        Dim SQLCmd As MySqlCommand
        Dim DR As MySqlDataReader
        Dim num As Integer = 0

        Try
            strQuerry = "SELECT id_int_punto FROM asambleas_db.puntos 
                            WHERE puntos.num_punto = '" & n & "' 
                            AND puntos.asamblea_id = 
                            (SELECT id_asamblea FROM asambleas_db.asambleas WHERE asambleas.n_asamblea = '" & a & "');"
            SQLCmd = New MySqlCommand(strQuerry, dbCon)
            dbCon.Open()
            DR = SQLCmd.ExecuteReader
            DR.Read()
            num = DR.Item("id_int_punto")
            dbCon.Close()
        Catch ex As Exception
            MsgBox("15" & vbCrLf & ex.Message)
        End Try
        Return num
    End Function

    'Obtiene el numero de propiedades
    Public Function Get_prop_number()

        Dim dbCon As MySqlConnection
        Dim strQuerry As String = ""
        Dim SQLCmd As MySqlCommand
        Dim DR As MySqlDataReader
        Dim n As Integer = 0
        Try
            dbCon = New MySqlConnection("Server=localhost;Database=asambleas_db;Uid=root;Pwd=1234")
            strQuerry = "SELECT COUNT(*) FROM asambleas_db.propiedades WHERE propiedades.proyecto_id = " & G_Build_ID & ";"
            SQLCmd = New MySqlCommand(strQuerry, dbCon)
            Console.WriteLine(SQLCmd)
            ' OPEN the DB and Kickoff the Query
            dbCon.Open()
            DR = SQLCmd.ExecuteReader
            DR.Read()
            n = DR.Item("COUNT(*)")
            dbCon.Close()
        Catch ex As Exception
            MsgBox("14" & vbCrLf & ex.Message)
        End Try
        Return n
    End Function
    'Crea asamblea para proyecto
    Public Function Crear_asamblea(name, dte)

        Dim dbCon As MySqlConnection
        Dim strQuerry As String = ""
        Dim SQLCmd As MySqlCommand
        Dim DR As MySqlDataReader
        Dim id As String = gen_ids(4, G_Build_ID)
        Try
            dbCon = New MySqlConnection("Server=localhost;Database=asambleas_db;Uid=root;Pwd=1234")
            strQuerry = "INSERT INTO asambleas_db.asambleas (proyecto_id ,n_asamblea ,nom_asamblea ,fecha_asamblea) 
                            VALUES(" & G_Build_ID & ",'" & id & "','" & name & "','" & dte & "');"
            SQLCmd = New MySqlCommand(strQuerry, dbCon)
            Console.WriteLine(SQLCmd)
            ' OPEN the DB and Kickoff the Query
            dbCon.Open()
            DR = SQLCmd.ExecuteReader
            dbCon.Close()
            Load_proyectos()
        Catch ex As Exception
            MsgBox("13" & vbCrLf & ex.Message)
        End Try

    End Function

    ' Carga Lista de asambleas en Data grid View
    Public Sub CargarAsambleas()

        Dim dbCon As MySqlConnection
        dbCon = New MySqlConnection("Server=localhost;Database=asambleas_db;Uid=root;Pwd=1234")
        Dim DR As MySqlDataReader
        Dim strQuerry As String = ""
        Dim SQLCmd As MySqlCommand
        Dim a As Integer = 0
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Dim tempCount As Integer = 0

        dbCon.Open()
        strQuerry = "SELECT COUNT(*) FROM asambleas_db.asambleas WHERE asambleas.proyecto_id = " & G_Build_ID & ";"
        SQLCmd = New MySqlCommand(strQuerry, dbCon)
        DR = SQLCmd.ExecuteReader
        DR.Read()
        tempCount = DR.Item("COUNT(*)")
        dbCon.Close()
        If tempCount = 0 Then

        Else
            Try
                dbCon.Open()
                If AgregarAsamblea.Cbx_display.Checked Then
                    strQuerry = "SELECT asambleas.nom_asamblea AS 'Nombre Asamblea',
                            asambleas.n_asamblea AS 'Identificador',
                            asambleas.fecha_asamblea AS 'Fecha'
                            FROM asambleas_db.asambleas WHERE asambleas.proyecto_id = " & G_Build_ID & " ORDER BY asambleas.fecha_asamblea, asambleas.nom_asamblea;"

                Else
                    strQuerry = "SELECT  CONCAT(SUBSTRING(asambleas.nom_asamblea, 1, 40),' ...') AS 'Nombre Asamblea',
                            asambleas.n_asamblea AS 'Identificador',
                            asambleas.fecha_asamblea AS 'Fecha'
                            FROM asambleas_db.asambleas WHERE asambleas.proyecto_id = " & G_Build_ID & " ORDER BY asambleas.fecha_asamblea, asambleas.nom_asamblea;"
                End If
                SQLCmd = New MySqlCommand(strQuerry, dbCon)
                SDA.SelectCommand = SQLCmd
                SDA.Fill(dbDataSet)
                bSource.DataSource = dbDataSet
                AgregarAsamblea.dgvAsamblea.DataSource = bSource
                SDA.Update(dbDataSet)
                dbCon.Close()
            Catch ex As Exception
                MsgBox("12" & vbCrLf & ex.Message)
            End Try
        End If
    End Sub

    ' Carga lista de Asambleas del Proyecto
    Public Sub CargarAsamb()
        Dim dbCon As MySqlConnection
        dbCon = New MySqlConnection("Server=localhost;Database=asambleas_db;Uid=root;Pwd=1234")
        Dim LookFor As String = ""
        Dim pass As Boolean = False
        Dim cancel As Integer = 0
        Dim strQuerry As String = ""
        Dim SQLCmd As MySqlCommand
        Dim DR As MySqlDataReader


        Try
            dbCon = New MySqlConnection("Server=localhost;Database=asambleas_db;Uid=root;Pwd=1234")
            strQuerry = "SELECT n_asamblea FROM asambleas_db.asambleas WHERE asambleas.proyecto_id = '" & G_Build_ID & "';"
            SQLCmd = New MySqlCommand(strQuerry, dbCon)
            ' OPEN the DB and Kickoff the Query
            dbCon.Open()
            DR = SQLCmd.ExecuteReader

            While DR.Read

                AgregarAsamblea.cbx_Asambleas.Items.Add(DR.Item("n_asamblea"))

            End While

            dbCon.Close()

        Catch ex As Exception
            MsgBox("11" & vbCrLf & ex.Message)
        End Try

    End Sub

    ' Cargar puntos en Data Grid View 
    Public Sub CargarPunto()
        Dim dbCon As MySqlConnection
        dbCon = New MySqlConnection("Server=localhost;Database=asambleas_db;Uid=root;Pwd=1234")
        Dim asamblea As String
        Dim tempCount As String
        Dim LookFor As String = ""
        Dim pass As Boolean = False
        Dim cancel As Integer = 0

        Dim strQuerry As String = ""
        Dim SQLCmd As MySqlCommand
        Dim DR As MySqlDataReader
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        asamblea = AgregarAsamblea.cbx_Asambleas.SelectedItem

        dbCon.Open()
        strQuerry = "SELECT COUNT(*) FROM asambleas_db.asambleas
	                    JOIN asambleas_db.puntos 
	                    ON asambleas.n_asamblea = '" & asamblea & "' AND puntos.asamblea_id = 
		                    (SELECT id_asamblea FROM asambleas_db.asambleas WHERE n_asamblea = '" & asamblea & "');"
        SQLCmd = New MySqlCommand(strQuerry, dbCon)
        DR = SQLCmd.ExecuteReader
        DR.Read()
        tempCount = DR.Item("COUNT(*)")
        dbCon.Close()

        If tempCount = 0 Then
        Else
            Try
                dbCon.Open()
                strQuerry = "SELECT num_punto AS 'Punto de Asamblea' FROM asambleas_db.asambleas
	                    JOIN asambleas_db.puntos 
	                    ON asambleas.n_asamblea = '" & asamblea & "' AND puntos.asamblea_id = 
		                    (SELECT id_asamblea FROM asambleas_db.asambleas WHERE n_asamblea = '" & asamblea & "') ORDER BY puntos.num_punto;"
                SQLCmd = New MySqlCommand(strQuerry, dbCon)
                SDA.SelectCommand = SQLCmd
                SDA.Fill(dbDataSet)
                bSource.DataSource = dbDataSet
                AgregarAsamblea.dgv_numPunto.DataSource = bSource
                SDA.Update(dbDataSet)
                dbCon.Close()
            Catch ex As Exception
                MsgBox("10" & vbCrLf & ex.Message)
            End Try
        End If
    End Sub
    ' Crear puntos de Asamblea Seleccionada
    Public Sub Crear_punto()
        Dim dbCon As MySqlConnection
        dbCon = New MySqlConnection("Server=localhost;Database=asambleas_db;Uid=root;Pwd=1234")
        Dim asamblea As String
        Dim asambID As String = ""
        Dim LookFor As String = ""
        Dim pass As Boolean = False
        Dim cancel As Integer = 0
        Dim strQuerry As String = ""
        Dim SQLCmd As MySqlCommand
        Dim DR As MySqlDataReader
        Dim id As Integer = 1
        Dim upperbound As Integer = 9
        Dim lowerbound As Integer = 0
        asamblea = AgregarAsamblea.cbx_Asambleas.SelectedItem
        Dim s As String = ""

        s = AgregarAsamblea.tbx_punto.Text
        If s = "" Or asamblea = "" Then
            MsgBox("Espacio Vacio... no se Crea punto")
            GoTo B
        End If

        Do While pass = False
            id = id + 1
            pass = CheckUniqueNum(id, asamblea)
        Loop

        Try
            strQuerry = "INSERT INTO asambleas_db.puntos (asamblea_id, id_int_punto, num_punto)  
        	                            VALUES( 
                (SELECT asambleas.id_asamblea FROM asambleas_db.asambleas WHERE n_asamblea = '" & asamblea & "'),
                " & id & ",
                " & s & ");"
            SQLCmd = New MySqlCommand(strQuerry, dbCon)
            ' OPEN the DB and Kickoff the Query
            dbCon.Open()
            DR = SQLCmd.ExecuteReader
            dbCon.Close()

        Catch ex As Exception
            MsgBox("9" & vbCrLf & ex.Message)
        End Try

B:
    End Sub

    Public Sub DisplayPuntos(n)
        Dim dbCon As MySqlConnection
        dbCon = New MySqlConnection("Server=localhost;Database=asambleas_db;Uid=root;Pwd=1234")
        Dim LookFor As String = ""
        Dim pass As Boolean = False
        Dim cancel As Integer = 0

        Dim strQuerry As String = ""
        Dim SQLCmd As MySqlCommand
        Dim DR As MySqlDataReader
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            strQuerry = "SELECT num_punto FROM asambleas_db.asambleas
		                             JOIN asambleas_db.puntos
                                     ON asambleas.id_asamblea = puntos.asamblea_id AND asambleas.n_asamblea = " & n & "' ORDER BY puntos.num_punto;"
            SQLCmd = New MySqlCommand(strQuerry, dbCon)
            dbCon.Open()
            DR = SQLCmd.ExecuteReader

            While DR.Read

                AgregarAsamblea.cbx_Asambleas.Items.Add(DR.Item("num_punto"))

            End While

            dbCon.Close()
        Catch ex As Exception
            MsgBox("8" & vbCrLf & ex.Message)
        End Try
    End Sub

    Public Sub LoadAsambleas(n)
        Dim dbCon As MySqlConnection
        dbCon = New MySqlConnection("Server=localhost;Database=asambleas_db;Uid=root;Pwd=1234")
        Dim LookFor As String = ""
        Dim pass As Boolean = False
        Dim cancel As Integer = 0

        Dim strQuerry As String = ""
        Dim SQLCmd As MySqlCommand
        Dim DR As MySqlDataReader
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            Form3.Cbx_Asambleas.Items.Clear()
            Form3.Cbx_Asambleas.ResetText()

            strQuerry = "SELECT n_asamblea FROM asambleas_db.asambleas WHERE fecha_asamblea = '" & n & "';"
            SQLCmd = New MySqlCommand(strQuerry, dbCon)
            dbCon.Open()
            DR = SQLCmd.ExecuteReader

            While DR.Read

                Form3.Cbx_Asambleas.Items.Add(DR.Item("n_asamblea"))

            End While

            dbCon.Close()
        Catch ex As Exception
            MsgBox("7" & vbCrLf & ex.Message)
        End Try
    End Sub

    Public Function Get_puntos_number(n)
        Dim dbCon As MySqlConnection
        Dim strQuerry As String = ""
        Dim SQLCmd As MySqlCommand
        Dim DR As MySqlDataReader
        Try
            dbCon = New MySqlConnection("Server=localhost;Database=asambleas_db;Uid=root;Pwd=1234")
            strQuerry = "SELECT COUNT(*) FROM asambleas_db.puntos
			        JOIN asambleas_db.asambleas
		            ON asambleas.id_asamblea = puntos.asamblea_id AND asambleas.n_asamblea = '" & n & "';"
            SQLCmd = New MySqlCommand(strQuerry, dbCon)
            Console.WriteLine(SQLCmd)
            ' OPEN the DB and Kickoff the Query
            dbCon.Open()
            DR = SQLCmd.ExecuteReader
            DR.Read()
            n = DR.Item("COUNT(*)")
            dbCon.Close()
        Catch ex As Exception
            MsgBox("6" & vbCrLf & ex.Message)
        End Try
        Return n

    End Function

    Public Sub GenBarCode(tempGenCode As String)
        Dim bar As New Barcode
        Dim s As Integer = 3

        bar.RotateFlipType = RotateFlipType.Rotate90FlipX
        bar.Encode(BarcodeLib.TYPE.CODE128B, tempGenCode, 150 * s, 40 * s)
        bar.SaveImage("D:\hubiC\Asambleas\" & G_Build_ID & "\CodigosGenerados\" & tempGenCode & ".png", SaveTypes.PNG)


    End Sub

End Module
