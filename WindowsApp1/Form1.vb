Imports System.IO
Imports System.Text
Imports System.Drawing
Imports System.Drawing.Image
Imports System.Drawing.Drawing2D




Public Class Form1
    Private Sub btnAddBuilding_Click(sender As Object, e As EventArgs)


    End Sub

    Public Sub AddBuilding(ByVal fileName As String)
        Try
            Dim counter1 As Integer = 0
            Dim readFile As New StreamReader("D:\hubiC\Asambleas\" & fileName, Encoding.Default)
            Dim sLine As String = ""
            Dim propCode As Integer = 100

            Do
                sLine = readFile.ReadLine
                If sLine Is Nothing Then Exit Do
                Dim words() As String = sLine.Split(",")
                dgvAsistencia.Rows.Add("")
                For i As Integer = 0 To 3
                    If i = 0 Then
                        dgvAsistencia.Rows(dgvAsistencia.Rows.Count - 1).Cells(i).Value = words(i)
                        G_Depto.Add(words(i))
                        'Console.Write(words(i) & " ")
                    ElseIf i = 1 Then
                        dgvAsistencia.Rows(dgvAsistencia.Rows.Count - 1).Cells(i).Value = words(i)
                        G_Torre.Add(words(i))
                        'Console.Write(words(i) & " ")
                    ElseIf i = 2 Then
                        dgvAsistencia.Rows(dgvAsistencia.Rows.Count - 1).Cells(i).Value = words(i)
                        G_Propietario.Add(words(i))
                        'Console.Write(words(i) & " ")
                    ElseIf i = 3 Then
                        dgvAsistencia.Rows(dgvAsistencia.Rows.Count - 1).Cells(i).Value = words(i)
                        G_Indiviso.Add(words(i))
                        'Console.WriteLine(words(i))

                    End If
                Next
                G_PropiedadID.Add(propCode)
                propCode += 1
            Loop

            readFile.Close()

        Catch ex As Exception
            MsgBox("Un Error Ocurrió. Favor de revisar los datos." & ex.Message)
        End Try
    End Sub


    Private Sub btnGen_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Hide()

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
End Class
