Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class AgregarAsamblea
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbl_date.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim fecha As String = tbx_FechaA.Text
        Dim nombre As String = tbx_nombreA.Text
        If fecha = "" Or nombre = "" Then
            If fecha = "" Then
                lbl_date.ForeColor = Color.Red
            End If

            If nombre = "" Then
                lbl_Nombre.ForeColor = Color.Red
            End If
            MsgBox("Campos vacios. Favor de revisar los datos")
        Else
            lbl_date.ForeColor = Color.Black
            lbl_Nombre.ForeColor = Color.Black
            Crear_asamblea(nombre, fecha)
            CargarAsambleas()
        End If

    End Sub

    Private Sub AgregarAsamblea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
        CargarAsambleas()
        CargarAsamb()
        CargarPunto()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim punto As String = tbx_punto.Text
        If punto = "" Then
            lbl_num.ForeColor = Color.Red
            MsgBox("Campos vacios. Favor de revisar los datos")
        Else
            lbl_num.ForeColor = Color.Black
            Crear_punto()
            CargarPunto()

        End If


    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        lbl_date.ForeColor = Color.Black
        lbl_Nombre.ForeColor = Color.Black
        lbl_num.ForeColor = Color.Black

        cbx_Asambleas.Items.Clear()
        cbx_Asambleas.ResetText()

        CargarAsambleas()
        CargarAsamb()
        CargarPunto()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class