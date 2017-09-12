Imports System.IO
Imports System.Text
Imports System.Drawing
Imports System.Drawing.Image
Imports System.Drawing.Drawing2D
Imports MySql.Data
Imports MySql.Data.MySqlClient




Public Class Form1
    Private Sub btnAddBuilding_Click(sender As Object, e As EventArgs)


    End Sub

    Public Sub AddBuilding(ByVal ProyId As String)
        Try
            Dim counter1 As Integer = 0
            Dim readFile As New StreamReader("D:\hubiC\Asambleas\Proyectos\" & ProyId & ".csv", Encoding.Default)
            Dim sLine As String = ""
            Dim dbCon As MySqlConnection
            Dim strQuerry As String = ""
            Dim SQLCmd As MySqlCommand
            Dim DR As MySqlDataReader
            Dim depto As String = ""
            Dim torre As String = ""
            Dim nombre As String = ""
            Dim indiviso As String
            Dim Prop_id As String
            Dim pass As Integer = 0
            dbCon = New MySqlConnection("Server=localhost;Database=asambleas_db;Uid=root;Pwd=1234")
            Try
                strQuerry = "SELECT COUNT(*) FROM asambleas_db.propiedades WHERE propiedades.proyecto_id = " & ProyId & ";"
                SQLCmd = New MySqlCommand(strQuerry, dbCon)

                ' OPEN the DB and Kickoff the Query
                dbCon.Open()
                DR = SQLCmd.ExecuteReader
                DR.Read()
                pass = DR.Item("COUNT(*)")
                dbCon.Close()
            Catch ex As Exception
                MsgBox("ERROR 2 !!!... " & ex.Message)

            End Try

            If pass = 0 Then
                Do
                    depto = ""
                    torre = ""
                    nombre = ""
                    indiviso = ""
                    Prop_id = ""
                    sLine = readFile.ReadLine
                    If sLine Is Nothing Then Exit Do
                    Dim words() As String = sLine.Split(",")
                    dgvAsistencia.Rows.Add("")
                    For i As Integer = 0 To 3
                        If i = 0 Then
                            depto = words(i)

                        ElseIf i = 1 Then
                            torre = words(i)

                        ElseIf i = 2 Then
                            nombre = words(i)

                        ElseIf i = 3 Then
                            indiviso = words(i)

                        End If
                    Next
                    Prop_id = gen_ids(2, ProyId)
                    Try
                        strQuerry = "INSERT INTO asambleas_db.propiedades (proyecto_id,n_propiedad,nom_propietario,torre,depto,indiviso) 
                             VALUES (" & ProyId & ",'" & Prop_id & "','" & nombre & "','" & torre & "','" & depto & "'," & indiviso & ");"
                        SQLCmd = New MySqlCommand(strQuerry, dbCon)

                        ' OPEN the DB and Kickoff the Query
                        dbCon.Open()
                        DR = SQLCmd.ExecuteReader
                        dbCon.Close()
                    Catch ex As Exception
                        MsgBox("ERROR 1 !!!... " & ex.Message)

                    End Try
                Loop
                readFile.Close()
            End If
            Read_prop_from_DB(ProyId)
        Catch ex As Exception
            MsgBox("Un Error Ocurrió. Favor de revisar los datos. " & ex.Message)
        End Try

    End Sub


    Private Sub btnGen_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Asambleas_dbDataSet.propiedades' table. You can move, or remove it, as needed.
        Me.PropiedadesTableAdapter.Fill(Me.Asambleas_dbDataSet.propiedades)
        'TODO: This line of code loads data into the 'Asambleas_dbDataSet.proyectos' table. You can move, or remove it, as needed.
        Me.ProyectosTableAdapter.Fill(Me.Asambleas_dbDataSet.proyectos)
        Form2.Hide()
        AddBuilding(G_Build_ID)
        'Get_data()

    End Sub


    Private Sub btnGenerarCodigos_Click(sender As Object, e As EventArgs) Handles btnGenerarCodigos.Click

        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub btnVotacion_Click(sender As Object, e As EventArgs) Handles btnVotacion.Click
        Form3.Hide()
    End Sub

    Private Sub dgvAsistencia_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAsistencia.CellContentClick

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_CAsamblea_Click(sender As Object, e As EventArgs) Handles btn_CAsamblea.Click
        AgregarAsamblea.Show()
    End Sub
End Class
