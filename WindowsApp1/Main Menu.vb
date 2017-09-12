Imports MySql.Data
Imports MySql.Data.MySqlClient



Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_proyectos()


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub btnCargarProyecto_Click(sender As Object, e As EventArgs) Handles btnCargarProyecto.Click


        Dim proyecto As String
        Dim LookFor As String = ""
        Dim pass As Boolean = False
        Dim cancel As Integer = 0
        Dim dbCon As MySqlConnection
        Dim strQuerry As String = ""
        Dim SQLCmd As MySqlCommand
        Dim DR As MySqlDataReader

        proyecto = ComboBox1.SelectedItem
        Console.WriteLine(proyecto)

        Try
            dbCon = New MySqlConnection("Server=localhost;Database=asambleas_db;Uid=root;Pwd=1234")
            strQuerry = "SELECT proyectos.id_proyecto FROM asambleas_db.proyectos WHERE proyectos.nom_proyecto = '" & proyecto & "';"
            SQLCmd = New MySqlCommand(strQuerry, dbCon)
            ' OPEN the DB and Kickoff the Query
            dbCon.Open()
            DR = SQLCmd.ExecuteReader
            DR.Read()
            G_Build_ID = DR.Item("id_proyecto")
            If IsNumeric(G_Build_ID) Then
                pass = True
            Else
            End If
            dbCon.Close()

        Catch ex As Exception
            MsgBox("Failure to communicate!" & vbCrLf & ex.Message)
        End Try

        If pass Then
            Form1.Show()
            Me.Hide()
        End If
        ' Console.WriteLine(LookFor)
A:
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_addProy.Click
        Console.WriteLine("Button Add")
        If tbx_nombre.Enabled = True And tbx_num.Enabled = True Then

            Dim dbCon As MySqlConnection
            Dim strQuerry As String = ""
            Dim SQLCmd As MySqlCommand
            Dim DR As MySqlDataReader
            Try
                dbCon = New MySqlConnection("Server=localhost;Database=asambleas_db;Uid=root;Pwd=1234")
                strQuerry = "INSERT INTO asambleas_db.proyectos (nom_proyecto, num_prop) VALUES('" & tbx_nombre.Text & "'," & tbx_num.Text & ");"
                SQLCmd = New MySqlCommand(strQuerry, dbCon)
                Console.WriteLine(SQLCmd)
                ' OPEN the DB and Kickoff the Query
                dbCon.Open()
                DR = SQLCmd.ExecuteReader
                dbCon.Close()
                Load_proyectos()
            Catch ex As Exception
                MsgBox("Failure to communicate!" & vbCrLf & ex.Message)
            End Try
            tbx_nombre.Text = ""
            tbx_num.Text = ""
        Else
            tbx_nombre.Enabled = True
            tbx_num.Enabled = True
        End If
    End Sub


End Class