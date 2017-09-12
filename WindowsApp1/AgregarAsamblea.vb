Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class AgregarAsamblea
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim fecha As String = tbx_FechaA.Text
        Dim nombre As String = tbx_nombreA.Text

        Crear_asamblea(nombre, fecha)
        CargarAsambleas()
    End Sub

    Private Sub AgregarAsamblea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
        CargarAsambleas()
        CargarAsamb()
        CargarPunto()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim punto As String = tbx_punto.Text
        Crear_punto()
        CargarPunto()

    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click

        CargarAsambleas()
        CargarAsamb()
        CargarPunto()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub
End Class