Imports System
Imports System.IO
Imports System.Text
Imports MySql.Data
Imports MySql.Data.MySqlClient
' Imports MessagingToolkit.Barcode
Imports Zen.Barcode



Public Class Form3
    'Dim ServerString As String = "Server=localhost;User Id=root;Password=1234;Database=asambleas"
    Dim b As New Drawing.Bitmap(1100, 850)
    Dim b2 As New Drawing.Bitmap(2200, 1700)
    Dim gr As Graphics = Graphics.FromImage(b)
    Dim gra As Graphics = Graphics.FromImage(b2)

    ' Open Building logo
    Dim img As Image = Image.FromFile("D:\hubiC\Asambleas\logos\" & G_Build_ID & ".jpg")
    Dim Icob As Image = Image.FromFile("D:\hubiC\Asambleas\logos\MarcaDeAguaCobalto.png")
    Dim IFormat As Image = Image.FromFile("D:\hubiC\Asambleas\logos\formato.jpg")

    'Create Fonts and brush
    Dim drawFontMain As New Font("Century Gothic", 13 * 2.77)
    Dim drawFontSec As New Font("Century Gothic", 11 * 2.77)
    Dim drawFontTer As New Font("Century Gothic", 9 * 2.77)
    Dim drawBrush As New SolidBrush(Color.Black)
    Dim blackPenL As New Pen(Color.Black, 10)
    Dim blackPenM As New Pen(Color.Black, 7)
    Dim blackPenS As New Pen(Color.Black, 5)

    'Set Format of String
    Dim drawFormat As New StringFormat

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        Dim Code_base As String
        Dim cantPuntos As Integer = 0
        Dim counter As Integer = 0
        Dim code_asamblea As String = ""
        Dim code_propiedad As String = ""
        Dim code_punto As String = ""
        Dim fecha_asamblea As String = ""
        Dim nom_asamblea As String = ""
        Dim nom_punto As String = ""
        Dim CodeCompLetras As String = ""

        Dim f As Integer = 1
        Dim c As Integer = 2

        Dim name As String = ""
        Dim numOrd As Integer = 0
        Dim NumAsamblea = 0

        Dim tempGenCode As String
        Dim tempCodeBase As String


        Dim mVert As Integer = 20
        Dim mHor As Integer = 20
        Dim wBoleta As Integer = 1060
        Dim hBoleta As Integer = 810
        Dim hoja As Integer = 1
        Dim altoCode As Integer = 5 '6 * 2.77
        Dim img2 As Bitmap
        Dim count2 As Integer = 0
        Dim num1 As Integer = 1
        Dim marco As Integer = 65
        Dim formato As String = "FO-AD-113"

        My.Computer.FileSystem.CreateDirectory("D:\hubiC\Asambleas\" & G_Build_ID)
        My.Computer.FileSystem.CreateDirectory("D:\hubiC\Asambleas\" & G_Build_ID & "\CodigosGenerados")
        My.Computer.FileSystem.CreateDirectory("D:\hubiC\Asambleas\" & G_Build_ID & "\BoletasGenerados")

        Dim temp As String = ""
        Dim sLine As String = ""
        Dim sLine2 As String = ""
        Dim GenCode As String = ""
        Dim CountA As Integer = 0
        Dim loc As Integer = 145 * 2.77
        Dim loc2 As Integer = 100 * 2.77
        Dim mLet As Integer = 25
        Dim bitmp As Bitmap
        Dim drawRect1 As New RectangleF(mVert, mLet * 9.5, wBoleta, hBoleta)
        Dim drawRect2 As New RectangleF(mVert, mLet * 13.5, wBoleta, hBoleta)
        Dim strFormat As New StringFormat()
        strFormat.Alignment = StringAlignment.Center
        Dim strFormat2 As New StringFormat()
        strFormat2.Alignment = StringAlignment.Far
        Dim L_Puntos As New List(Of String)
        Dim codeW As Integer = 500
        Dim cantProp As Integer = 0


        Dim m_hor As Integer = 20
        Dim m_vert As Integer = 20


        'Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        'Generator.LabelPosition = LabelPositions.BottomCenter
        'Generator.CustomLabel = ""
        'Generator.Width = 400 * 2.77
        'Generator.Height = 100 * 2.77

        'ID ASAMBLEA CODIGOS DE BARRAS
        ' AAAA AA ## #
        ' AAAA = ID ASAMBLEA
        ' AA = ID PROPIEDAD
        ' ## = ID interno Punto
        ' # = voto
        Console.WriteLine("Buscando fecha de asamblea")
        fecha_asamblea = Cbx_fechaAsamblea.SelectedItem
        Console.WriteLine("Buscando Codigo de asamblea")
        code_asamblea = Cbx_Asambleas.SelectedItem
        Console.WriteLine("Buscando Nombre de asamblea")
        nom_asamblea = Get_nom_asamblea(code_asamblea)
        Console.WriteLine("Buscando Cantidad de PRopiedades de asamblea")
        cantProp = Get_prop_number()
        Dim boletas As New List(Of String)

        Console.WriteLine("Buscando cantidad de puntos de asamblea")
        cantPuntos = Get_puntos_number(code_asamblea)

        ' Pendiente Solo imprimir un punto!!
        'DisplayPuntos(Cbx_Asambleas.Text)

        For j As Integer = 1 To (cantPuntos - 1)


            nom_punto = Get_nom_punto(j - 1)
            code_punto = Get_Punto(nom_punto, code_asamblea)
            code_punto = LimpiarPunto(code_punto)
            Console.WriteLine("Punto: " & nom_punto)

            For i As Integer = 0 To (cantProp - 1)
                Try
                    Get_PropInfo(i)
                    GenCode = code_asamblea & GL_PropID & code_punto
                    CodeCompLetras = code_asamblea & "-" & GL_PropID & "-" & code_punto & "-"
                    Code_base = CodeCompLetras & "0.png"
                    boletas.Add(Code_base)

                    gr.Clear(Color.White)
                    gr.FillRectangle(Brushes.White, 0, 0, b.Width, b.Height) ' Pintar de blanco el Fondo de la imagen

                    img2 = Bitmap.FromFile("D:\hubiC\Asambleas\logos\votacion.jpg")

                    gr.DrawImage(img2, mVert + Convert.ToSingle(wBoleta / 2 - img2.Width / 2), mHor + Convert.ToSingle(hBoleta / 5 * 3.2), img2.Width, img2.Height)

                    gr.DrawImage(Icob, Convert.ToSingle(mVert + wBoleta / 2 - Icob.Width / 2), Convert.ToSingle(mVert + hBoleta / 2 - Icob.Height / 2 - 50),
                                 Convert.ToSingle(Icob.Width), Convert.ToSingle(Icob.Height))

                    gr.DrawRectangle(blackPenL, mVert, mHor, wBoleta, hBoleta)

                    gr.DrawRectangle(blackPenM, mVert, mHor + Convert.ToSingle(hBoleta / 2) - 50, 150, Convert.ToSingle(hBoleta / 2) + 50)

                    gr.DrawRectangle(blackPenM, mVert + wBoleta - 150, mHor + Convert.ToSingle(hBoleta / 2) - 50, 150, Convert.ToSingle(hBoleta / 2) + 50)
                    'Pintar Logo del edificio
                    gr.DrawImage(img, Convert.ToSingle(mVert + wBoleta / 2 - loc / 2), mHor + mVert, loc, Convert.ToSingle(loc * img.Height / img.Width)) ' Dibujando imagen boleta 1

                    gr.DrawImage(IFormat, mVert + wBoleta - 50, mVert + 25)

                    gr.DrawString(fecha_asamblea, drawFontTer, drawBrush, mVert + 100, mHor + 20, strFormat)

                    'Pintar el nombre de la asamblea 
                    gr.DrawString(nom_asamblea, drawFontMain, drawBrush, New RectangleF(mVert, mLet * 9.3, wBoleta, hBoleta), strFormat)
                    'Pintar el punto a votar
                    gr.DrawString("Punto " & nom_punto, drawFontMain, drawBrush, drawRect2, strFormat)
                    'Pintar el Numero de propiedad e indiviso
                    gr.DrawString(GetTorreYDepa() & "   " & GL_indiviso & "% Indiviso", drawFontSec, drawBrush, New RectangleF(mVert, mLet * 16, wBoleta, hBoleta), strFormat)

                    Dim barcode128 As Code128BarcodeDraw = BarcodeDrawFactory.Code128WithChecksum

                    tempGenCode = GenCode & f
                    bitmp = New Bitmap(barcode128.Draw(tempGenCode, 85, 2))
                    bitmp = Image.FromFile("D:\hubiC\Asambleas\" & G_Build_ID & "\CodigosGenerados\" & GenCode & f & ".png")
                    gr.DrawImage(bitmp,
                                 Convert.ToSingle(mVert + wBoleta / 4 - codeW / 2),
                                 mHor + hBoleta - Convert.ToSingle(marco * 2.77),
                                 codeW,
                                 Convert.ToSingle((bitmp.Height * codeW) / bitmp.Width) - altoCode)

                    gr.DrawString(CodeCompLetras & f,
                                  drawFontTer,
                                  drawBrush,
                                  New RectangleF(Convert.ToSingle(mVert + wBoleta / 4 - codeW / 2),
                                                 mHor + hBoleta - 23 * 2.77,
                                                 codeW,
                                                 Convert.ToSingle(codeW * bitmp.Height / bitmp.Width)),
                                  strFormat) 'Pintar codigo en letras y numeros

                    tempGenCode = GenCode & f



                    Dim originalbarcodeimage As Image = barcode128.Draw(tempGenCode, 100, 5)
                    'create a new image with extra height
                    Dim ImagewithText As Image = New Bitmap(originalbarcodeimage.Width, originalbarcodeimage.Height + 50)
                    'obtain the graphics object for the image
                    Dim gr2 As Graphics = Graphics.FromImage(ImagewithText)
                    gr2.DrawImageUnscaled(originalbarcodeimage, 3, 25)

                    'draw the additional text
                    gr2.DrawString(tempGenCode, drawFontTer,
                                  drawBrush,
                          New RectangleF(0, 10, originalbarcodeimage.Width, 50))

                    Dim originalbarcodeimage2 As Image = barcode128.Draw(tempGenCode, 100, 3)

                    gr2.DrawString(tempGenCode, drawFontTer,
                                  drawBrush,
                          New RectangleF(0, originalbarcodeimage.Height + 23, originalbarcodeimage.Width + 10, 50))


                    'set the image with text on the picture box
                    pic.Image = ImagewithText

                    Dim CodeBitmap As Bitmap
                    CodeBitmap = New Bitmap(pic.Image)
                    CodeBitmap.Save(Application.StartupPath & "\" & "001.png")


                    ' bitmp = New Bitmap(barcode128.Draw(tempGenCode, 85, 2))
                    bitmp.Save("D:\hubiC\Asambleas\" & G_Build_ID & "\CodigosGenerados\" & GenCode & c & ".png", System.Drawing.Imaging.ImageFormat.Png)

                    gr.DrawImage(bitmp,
                                 Convert.ToSingle(mVert + ((wBoleta / 4) * 3) - codeW / 2),
                                 mHor + hBoleta - Convert.ToSingle(marco * 2.77),
                                 codeW,
                                 Convert.ToSingle((bitmp.Height * codeW) / bitmp.Width) - altoCode)

                    gr.DrawString(CodeCompLetras & c,
                                  drawFontTer,
                                  drawBrush,
                                  New RectangleF(Convert.ToSingle(mVert + ((wBoleta / 4) * 3) - codeW / 2),
                                                 mHor + hBoleta - 23 * 2.77,
                                                 codeW,
                                                 Convert.ToSingle(codeW * bitmp.Height / bitmp.Width)),
                                  strFormat) 'Pintar codigo en letras y numeros

                    Console.WriteLine("Imprimiendo Boleta")

                    b.Save("D:\hubiC\Asambleas\" & G_Build_ID & "\BoletasGenerados\" & Code_base, Imaging.ImageFormat.Png)

                Catch ex As Exception
                    MsgBox("Error al imprimir " & ex.Message)
                End Try
            Next
            CountA = 0
            For a As Integer = 0 To boletas.Count - 1

                img2 = Bitmap.FromFile("D:\hubiC\Asambleas\" & G_Build_ID & "\BoletasGenerados\" & boletas(a))
                If a Mod 4 = 0 Then
                    gra.DrawImage(img2, 0, 0, img2.Width, img2.Height)
                    CountA = CountA + 1

                ElseIf a Mod 4 = 1 Then
                    gra.DrawImage(img2, 1100, 0, img2.Width, img2.Height)
                    CountA = CountA + 1

                ElseIf a Mod 4 = 2 Then
                    gra.DrawImage(img2, 0, 850, img2.Width, img2.Height)
                    CountA = CountA + 1

                ElseIf a Mod 4 = 3 Then
                    gra.DrawImage(img2, 1100, 850, img2.Width, img2.Height)
                    CountA = CountA + 1

                End If

                If CountA = 4 Or a = boletas.Count - 1 Then

                    b2.Save("D:\hubiC\Asambleas\" & G_Build_ID & "\" & nom_asamblea & " Punto " & nom_punto & " hoja " & hoja & ".png ", Imaging.ImageFormat.Png)
                    hoja = hoja + 1
                    If a = boletas.Count - 1 Then
                        GoTo D
                    End If
                    CountA = 0
                End If
D:
            Next
            boletas.Clear()
            hoja = 1

        Next

        hoja = 0
        count2 = 0
        cantProp = 0
        cantPuntos = 0
        name = ""
        NumAsamblea = 0
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Hide()

        Cbx_Ipuntos.Visible = False
        btnGenerate.Location = New Point(50, 264)

        Dim dbCon As MySqlConnection
        Dim strQuerry As String = ""
        Dim SQLCmd As MySqlCommand
        Dim DR As MySqlDataReader
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Dim id As String = gen_ids(4, G_Build_ID)
        Try
            dbCon = New MySqlConnection("Server=localhost;Database=asambleas_db;Uid=root;Pwd=1234")
            strQuerry = "SELECT fecha_asamblea FROM asambleas_db.asambleas WHERE asambleas.proyecto_id = " & G_Build_ID & " GROUP BY fecha_asamblea ORDER BY fecha_asamblea;"
            SQLCmd = New MySqlCommand(strQuerry, dbCon)
            ' OPEN the DB and Kickoff the Query
            dbCon.Open()
            DR = SQLCmd.ExecuteReader

            While DR.Read

                Cbx_fechaAsamblea.Items.Add(DR.Item("fecha_asamblea"))

            End While
        Catch ex As Exception
            MsgBox("Failure to communicate! 4...." & vbCrLf & ex.Message)
        End Try


    End Sub

    Private Sub Form3_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

    End Sub

    Private Sub pbxCode_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pbxCode_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click

        Form1.Show()
    End Sub

    Private Sub tbx_Asamblea_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbx_Asambleas.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckStateChanged

        If CheckBox1.Checked = True Then

            btnGenerate.Location = New Point(55, 350)
            Cbx_Ipuntos.Visible = True

        ElseIf CheckBox1.Checked = False Then

            Cbx_Ipuntos.Visible = False
            btnGenerate.Location = New Point(55, 255)

        End If



    End Sub

    Private Sub Cbx_fechaAsamblea_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cbx_fechaAsamblea.SelectionChangeCommitted

        LoadAsambleas(Cbx_fechaAsamblea.SelectedItem)
    End Sub

    Private Sub Cbx_Asambleas_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cbx_Asambleas.SelectionChangeCommitted

        Dim dbCon As MySqlConnection
        dbCon = New MySqlConnection("Server=localhost;Database=asambleas_db;Uid=root;Pwd=1234")
        Dim LookFor As String = ""

        Dim strQuerry As String = ""
        Dim SQLCmd As MySqlCommand
        Dim DR As MySqlDataReader
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        LookFor = Cbx_fechaAsamblea.SelectedItem

        Try

            strQuerry = "SELECT id_asamblea FROM asambleas_db.asambleas WHERE fecha_asamblea = '" & LookFor & "';"
            SQLCmd = New MySqlCommand(strQuerry, dbCon)
            dbCon.Open()
            DR = SQLCmd.ExecuteReader
            DR.Read()
            G_Asamb_ID = DR.Item("id_asamblea")
            dbCon.Close()
        Catch ex As Exception
            MsgBox("Failure to communicate!" & vbCrLf & ex.Message)

        End Try

    End Sub
End Class