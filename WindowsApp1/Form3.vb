Imports System
Imports System.IO
Imports System.Text
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports MessagingToolkit.Barcode

Public Class Form3
    'Dim ServerString As String = "Server=localhost;User Id=root;Password=1234;Database=asambleas"
    Dim b As New Drawing.Bitmap(2200, 1700)
    Dim gr As Graphics = Graphics.FromImage(b)

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

        Dim b As New Drawing.Bitmap(2200, 1700)
        Dim gr As Graphics = Graphics.FromImage(b)
        Dim name As String = ""
        Dim numOrd As Integer = 0
        Dim NumAsamblea = 0
        Dim mLet As Integer = 10 * 2.77
        Dim mSup As Integer = 20 * 2.77
        Dim mLad As Integer = 20 * 2.77
        Dim mVert As Integer = 12 * 2.77
        Dim mHor As Integer = 12 * 2.77
        Dim wBoleta As Integer = 370 * 2.77
        Dim hBoleta As Integer = 280 * 2.77
        Dim hoja As Integer = 0
        Dim altoCode As Integer = 5 '6 * 2.77
        Dim img2 As Bitmap
        Dim count2 As Integer = 0
        Dim num1 As Integer = 1
        Dim marco As Integer = 65
        Dim formato As String = "FO-AD-113"

        My.Computer.FileSystem.CreateDirectory("D:\hubiC\Asambleas\" & G_Build_ID)
        My.Computer.FileSystem.CreateDirectory("D:\hubiC\Asambleas\" & G_Build_ID & "\CodigosGenerados")

        Dim temp As String = ""
        Dim sLine As String = ""
        Dim sLine2 As String = ""
        Dim GenCode As String = ""
        Dim CountA As Integer = 0
        Dim loc As Integer = 145 * 2.77
        Dim loc2 As Integer = 100 * 2.77
        Dim bitmp As Bitmap
        Dim drawRect1 As New RectangleF(mLad, mLet * 9.5, wBoleta, hBoleta)
        Dim drawRect2 As New RectangleF(mLad, mLet * 13.5, wBoleta, hBoleta)
        Dim strFormat As New StringFormat()
        strFormat.Alignment = StringAlignment.Center
        Dim strFormat2 As New StringFormat()
        strFormat2.Alignment = StringAlignment.Far
        Dim L_Puntos As New List(Of String)
        Dim codeW As Integer = 500
        Dim cantProp As Integer = 0

        G_NumAsa += 1

        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.LabelPosition = LabelPositions.BottomCenter
        Generator.CustomLabel = ""
        Generator.Width = 400 * 2.77
        Generator.Height = 100 * 2.77

        'ID ASAMBLEA CODIGOS DE BARRAS
        ' AAAA AA ## #
        ' AAAA = ID ASAMBLEA
        ' AA = ID PROPIEDAD
        ' ## = ID interno Punto
        ' # = voto
        Console.WriteLine("Buscando fecha de asamblea")
        MsgBox("buscando datos...")
        fecha_asamblea = Cbx_fechaAsamblea.SelectedItem
        Console.WriteLine("Buscando Codigo de asamblea")
        code_asamblea = Cbx_Asambleas.SelectedItem
        Console.WriteLine("Buscando Nombre de asamblea")
        nom_asamblea = Get_nom_asamblea(code_asamblea)
        Console.WriteLine("Buscando Cantidad de PRopiedades de asamblea")
        cantProp = Get_prop_number()
        Console.WriteLine("Buscando cantidad de puntos de asamblea")
        cantPuntos = Get_puntos_number(code_asamblea)

        ' Pendiente Solo imprimir un punto!!
        'DisplayPuntos(Cbx_Asambleas.Text)

        For j As Integer = 1 To (cantPuntos - 1)

            Console.WriteLine("Buscando Nombre de Punto")
            nom_punto = Get_nom_punto(j - 1)
            Console.WriteLine("Codigo de Punto")
            code_punto = Get_Punto(nom_punto, code_asamblea)
            Console.WriteLine("Limpiando Punto")
            code_punto = LimpiarPunto(code_punto)
            Console.WriteLine("Generando Codigo")


            For i As Integer = 1 To (cantProp - 1)
                Try
                    If i Mod 4 = 0 Then
                        Console.WriteLine("Imprimiendo Boleta 1 ")
                        Get_PropInfo(i)
                        GenCode = code_asamblea & GL_PropID & code_punto
                        CodeCompLetras = code_asamblea & "-" & GL_PropID & "-" & code_punto & "-"

                        count2 += 1

                        gr.Clear(Color.White)
                        gr.FillRectangle(Brushes.White, 0, 0, b.Width, b.Height) ' Pintar de blanco el Fondo de la imagen

                        GenCode = code_asamblea & code_propiedad & code_punto 'Generando Codigo Base

                        ' pintar primera boleta
                        ' Pintar imagen de votacion
                        img2 = Bitmap.FromFile("D:\hubiC\Asambleas\Votacion.jpg")
                        gr.DrawImage(img2, mLad, Convert.ToSingle(mLad + ((wBoleta / 9) * 4) - 15), wBoleta, img2.Height)
                        gr.DrawImage(Icob, Convert.ToSingle(mLad + wBoleta / 2 - Icob.Width / 2), Convert.ToSingle(mSup + hBoleta / 2 - Icob.Height / 2 - 50),
                                     Convert.ToSingle(Icob.Width), Convert.ToSingle(Icob.Height))

                        'Pintar rectangulo de Boleta
                        gr.DrawRectangle(blackPenL, mLad, mSup, wBoleta, hBoleta)
                        'Pintar Logo del edificio
                        gr.DrawImage(img,
                                     Convert.ToSingle(mLad + wBoleta / 2 - loc / 2),
                                     mSup + mLet, loc, Convert.ToSingle(loc * img.Height / img.Width)) ' Dibujando imagen boleta 1

                        gr.DrawImage(IFormat, mLad + wBoleta - 50, mSup + 25)
                        gr.DrawString(fecha_asamblea, drawFontTer, drawBrush, mLad + 100, mSup + 20, strFormat)

                        'Pintar el nombre de la asamblea 
                        gr.DrawString(nom_asamblea, drawFontMain, drawBrush, New RectangleF(mLad, mLet * 9.5, wBoleta, hBoleta), strFormat)
                        'Pintar el punto a votar
                        gr.DrawString("Punto " & nom_punto, drawFontMain, drawBrush, drawRect2, strFormat)
                        'Pintar el Numero de propiedad e indiviso
                        gr.DrawString(GetTorreYDepa() & "   " & GL_indiviso & "% Indiviso",
                                      drawFontSec, drawBrush, New RectangleF(mLad, mLet * 15.5, wBoleta, hBoleta), strFormat)

                        'Generar codigo de barras a Favor
                        bitmp = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128B, GenCode & f))

                        bitmp.Save("D:\hubiC\Asambleas\" & G_Build_ID & "\CodigosGenerados\" & GenCode & f & ".png", System.Drawing.Imaging.ImageFormat.Png)
                        ' Pintar Codigo de barras A Favor
                        'gr.DrawImage()
                        gr.DrawImage(bitmp, Convert.ToSingle(mLad + wBoleta / 4 - codeW / 2), mSup + hBoleta - Convert.ToSingle(marco * 2.77),
                                         codeW, Convert.ToSingle((bitmp.Height * codeW) / bitmp.Width) - altoCode)
                        gr.DrawString(CodeCompLetras & f, drawFontTer, drawBrush, New RectangleF(Convert.ToSingle(mLad + wBoleta / 4 - codeW / 2), mSup + hBoleta - 23 * 2.77,
                                                                                            codeW, Convert.ToSingle(codeW * bitmp.Height / bitmp.Width)), strFormat) 'Pintar codigo en letras y numeros

                        'Busca Codigo de Brras en contra
                        bitmp = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128B, GenCode & c))
                        bitmp.Save("D:\hubiC\Asambleas\" & G_Build_ID & "\CodigosGenerados\" & GenCode & c & ".png", System.Drawing.Imaging.ImageFormat.Png)
                        ' Pintar Letras de Codigo En Contra
                        gr.DrawImage(bitmp, Convert.ToSingle(mLad + wBoleta * 0.75 - codeW / 2), mSup + hBoleta - Convert.ToSingle(marco * 2.77),
                                         codeW, Convert.ToSingle((bitmp.Height * codeW) / bitmp.Width) - altoCode)
                        gr.DrawString(CodeCompLetras & c, drawFontTer, drawBrush, New RectangleF((mLad + (wBoleta * 0.75) - (codeW / 2)),
                                                                                             mSup + hBoleta - 23 * 2.77, codeW, Convert.ToSingle(codeW * bitmp.Height / bitmp.Width)), strFormat) 'Pintar codigo en letras y numeros


                    ElseIf i Mod 4 = 1 Then
                        Console.WriteLine("Imprimiendo Boleta 2 ")
                        Get_PropInfo(i)
                        GenCode = code_asamblea & GL_PropID & code_punto
                        CodeCompLetras = code_asamblea & "-" & GL_PropID & "-" & code_punto & "-"

                        count2 += 1

                        'Pintar segunda boleta
                        ' Pintar imagen de votacion
                        img2 = Bitmap.FromFile("D:\hubiC\Asambleas\Votacion.jpg")
                        gr.DrawImage(img2, mLad + wBoleta + mVert, Convert.ToSingle(mLad + ((wBoleta / 9) * 4) - 15), wBoleta, img2.Height)

                        gr.DrawImage(Icob, Convert.ToSingle(mLad + wBoleta + mVert + wBoleta / 2 - Icob.Width / 2), Convert.ToSingle(mSup + hBoleta / 2 - Icob.Height / 2 - 50),
                                     Convert.ToSingle(Icob.Width), Convert.ToSingle(Icob.Height))
                        'Pintar rectangulo de Boleta
                        gr.DrawRectangle(blackPenL, mLad + wBoleta + mVert, mSup, wBoleta, hBoleta)
                        'Pintar Logo del edificio
                        gr.DrawImage(img,
                                 Convert.ToSingle(mLad + wBoleta + mVert + (wBoleta / 2) - loc / 2),
                                 mSup + mLet,
                                 loc,
                                 Convert.ToSingle(loc * img.Height / img.Width)) ' Dibujando imagen boleta 2

                        gr.DrawImage(IFormat, mLad + wBoleta + mVert + wBoleta - 50, mSup + 25)

                        gr.DrawString(fecha_asamblea, drawFontTer, drawBrush, mLad + wBoleta + mVert + 100, mSup + 20, strFormat)

                        gr.DrawString(nom_asamblea, drawFontMain, drawBrush, New RectangleF(mLad + wBoleta + mVert, mLet * 9.5, wBoleta, hBoleta), strFormat)
                        gr.DrawString("Punto " & nom_punto, drawFontMain, drawBrush, New RectangleF(mLad + wBoleta + mVert, mLet * 13.5, wBoleta, hBoleta), strFormat)
                        gr.DrawString(GetTorreYDepa() & "   " & GL_indiviso & "% Indiviso",
                                      drawFontSec, drawBrush, New RectangleF(mLad + wBoleta + mVert, mLet * 15.5, wBoleta, hBoleta), strFormat)


                        'Crear Codigo de Barras a Favor
                        bitmp = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128B, GenCode & f))
                        bitmp.Save("D:\hubiC\Asambleas\" & G_Build_ID & "\CodigosGenerados\" & GenCode & f & ".png", System.Drawing.Imaging.ImageFormat.Png)

                        gr.DrawImage(bitmp, Convert.ToSingle(mLad + wBoleta / 4 - codeW / 2) + wBoleta + mVert, mSup + hBoleta - Convert.ToSingle(marco * 2.77),
                                         codeW, Convert.ToSingle((bitmp.Height * codeW) / bitmp.Width) - altoCode)
                        gr.DrawString(CodeCompLetras & f, drawFontTer, drawBrush, New RectangleF(Convert.ToSingle(mLad + wBoleta / 4 - codeW / 2) + wBoleta + mVert,
                                                                                            mSup + hBoleta - 23 * 2.77, codeW, Convert.ToSingle(codeW * bitmp.Height / bitmp.Width)), strFormat) 'Pintar codigo en letras y numeros                                                 


                        'Generar codigo de barras En Contra
                        bitmp = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128B, GenCode & c))
                        bitmp.Save("D:\hubiC\Asambleas\" & G_Build_ID & "\CodigosGenerados\" & GenCode & c & ".png", System.Drawing.Imaging.ImageFormat.Png)
                        gr.DrawImage(bitmp, Convert.ToSingle(mLad + wBoleta * 0.75 - codeW / 2) + wBoleta + mVert, mSup + hBoleta - Convert.ToSingle(marco * 2.77),
                                         codeW, Convert.ToSingle((bitmp.Height * codeW) / bitmp.Width) - altoCode)
                        gr.DrawString(CodeCompLetras & c, drawFontTer, drawBrush, New RectangleF((mLad + (wBoleta * 0.75) - (codeW / 2) + wBoleta + mVert),
                                                                                             mSup + hBoleta - 23 * 2.77, codeW, Convert.ToSingle(codeW * bitmp.Height / bitmp.Width)), strFormat) 'Pintar codigo en letras y numeros                                                 


                    ElseIf i Mod 4 = 2 Then
                        Console.WriteLine("Imprimiendo Boleta 3")
                        Get_PropInfo(i)
                        GenCode = code_asamblea & GL_PropID & code_punto
                        CodeCompLetras = code_asamblea & "-" & GL_PropID & "-" & code_punto & "-"

                        count2 += 1

                        'Pintar tercera boleta
                        img2 = Bitmap.FromFile("D:\hubiC\Asambleas\Votacion.jpg")
                        gr.DrawImage(img2, mLad, Convert.ToSingle(((wBoleta / 9) * 4) - 15) + mSup + hBoleta + mHor, wBoleta, img2.Height)

                        gr.DrawImage(Icob, Convert.ToSingle(mLad + wBoleta / 2 - Icob.Width / 2), Convert.ToSingle(mSup + +hBoleta + mHor + hBoleta / 2 - Icob.Height / 2 - 50),
                                     Convert.ToSingle(Icob.Width), Convert.ToSingle(Icob.Height))

                        'Insertar Gen de Codigo
                        gr.DrawRectangle(blackPenL, mLad, mSup + hBoleta + mHor, wBoleta, hBoleta)
                        gr.DrawImage(img,
                                 Convert.ToSingle(b.Width / 4 - loc / 2),
                                 mSup + hBoleta + mHor + (mLet),
                                 loc,
                                 Convert.ToSingle(loc * img.Height / img.Width)) ' Dibujando imagen boleta 3

                        gr.DrawImage(IFormat, mLad + wBoleta - 50, mSup + hBoleta + mHor + 25)
                        gr.DrawString(fecha_asamblea, drawFontTer, drawBrush, mLad + 100, mSup + hBoleta + mHor + 20, strFormat)

                        gr.DrawString(nom_asamblea, drawFontMain, drawBrush, New RectangleF(mLad, mLet * 9.5 + hBoleta + mHor, wBoleta, hBoleta), strFormat)
                        gr.DrawString("Punto " & nom_punto, drawFontMain, drawBrush, New RectangleF(mLad, mLet * 13.5 + hBoleta + mHor, wBoleta, hBoleta), strFormat)

                        gr.DrawString(GetTorreYDepa() & "   " & GL_indiviso & "% Indiviso",
                                      drawFontSec, drawBrush, New RectangleF(mLad, mLet * 15.5 + hBoleta + mHor, wBoleta, hBoleta), strFormat)

                        'Generar codigo de barras a Favor
                        bitmp = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128B, GenCode & f))
                        bitmp.Save("D:\hubiC\Asambleas\" & G_Build_ID & "\CodigosGenerados\" & GenCode & f & ".png", System.Drawing.Imaging.ImageFormat.Png)
                        gr.DrawImage(bitmp, Convert.ToSingle(mLad + wBoleta / 4 - codeW / 2), mSup + hBoleta - Convert.ToSingle(marco * 2.77) + hBoleta + mVert,
                                         codeW, Convert.ToSingle((bitmp.Height * codeW) / bitmp.Width - altoCode))
                        gr.DrawString(CodeCompLetras & f, drawFontTer, drawBrush, New RectangleF(Convert.ToSingle(mLad + wBoleta / 4 - codeW / 2),
                        mSup + hBoleta - 23 * 2.77 + hBoleta + mVert, codeW, Convert.ToSingle((bitmp.Height * codeW) / bitmp.Width)), strFormat) 'Pintar codigo en letras y numeros


                        'Generar codigo de barras  En contra
                        bitmp = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128B, GenCode & c))
                        bitmp.Save("D:\hubiC\Asambleas\" & G_Build_ID & "\CodigosGenerados\" & GenCode & c & ".png", System.Drawing.Imaging.ImageFormat.Png)
                        gr.DrawImage(bitmp, Convert.ToSingle(mLad + wBoleta * 0.75 - codeW / 2), mSup + hBoleta - Convert.ToSingle(marco * 2.77) + hBoleta + mVert,
                                         codeW, Convert.ToSingle((bitmp.Height * codeW) / bitmp.Width) - altoCode)
                        gr.DrawString(CodeCompLetras & c, drawFontTer, drawBrush, New RectangleF((mLad + (wBoleta * 0.75) - (codeW / 2)),
                                                                                            mSup + hBoleta - 23 * 2.77 + hBoleta + mVert, codeW, Convert.ToSingle((bitmp.Height * codeW) / bitmp.Width)), strFormat) 'Pintar codigo en letras y numeros


                    ElseIf i Mod 4 = 3 Then
                        Console.WriteLine("Imprimiendo Boleta 4")
                        Get_PropInfo(i)
                        GenCode = code_asamblea & GL_PropID & code_punto
                        CodeCompLetras = code_asamblea & "-" & GL_PropID & "-" & code_punto & "-"

                        count2 += 1

                        'Pintar cuarta boleta
                        img2 = Bitmap.FromFile("D:\hubiC\Asambleas\Votacion.jpg")
                        gr.DrawImage(img2, mLad + wBoleta + mVert, Convert.ToSingle(((wBoleta / 9) * 4) - 15) + mSup + hBoleta + mHor, wBoleta, img2.Height)

                        gr.DrawImage(Icob, Convert.ToSingle(mLad + wBoleta + mVert + wBoleta / 2 - Icob.Width / 2), Convert.ToSingle(mSup + +hBoleta + mHor + hBoleta / 2 - Icob.Height / 2 - 50),
                                     Convert.ToSingle(Icob.Width), Convert.ToSingle(Icob.Height))

                        'Insertar Gen de Codigo
                        gr.DrawRectangle(blackPenL, mLad + wBoleta + mVert, mSup + hBoleta + mHor, wBoleta, hBoleta)

                        gr.DrawImage(img,
                                     Convert.ToSingle(mLad + wBoleta + mVert + (wBoleta / 2) - loc / 2),
                                      mSup + hBoleta + mHor + (mLet),
                                     loc,
                                     Convert.ToSingle(loc * img.Height / img.Width)) ' Dibujando imagen boleta 4

                        gr.DrawImage(IFormat, mLad + wBoleta + mVert + wBoleta - 50, mSup + hBoleta + mHor + 25)
                        gr.DrawString(fecha_asamblea, drawFontTer, drawBrush, mLad + wBoleta + mVert + 100, mSup + hBoleta + mHor + 20, strFormat)

                        gr.DrawString(nom_asamblea, drawFontMain, drawBrush, New RectangleF(mLad + wBoleta + mVert, mLet * 9.5 + hBoleta + mHor, wBoleta, hBoleta), strFormat)
                        gr.DrawString("Punto " & nom_punto, drawFontMain, drawBrush, New RectangleF(mLad + wBoleta + mVert, mLet * 13.5 + hBoleta + mHor, wBoleta, hBoleta), strFormat)
                        gr.DrawString(GetTorreYDepa() & "   " & GL_indiviso & "% Indiviso",
                                      drawFontSec, drawBrush, New RectangleF(mLad + wBoleta + mVert, mLet * 15.5 + hBoleta + mHor, wBoleta, hBoleta), strFormat)

                        bitmp = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128B, GenCode & f))
                        bitmp.Save("D:\hubiC\Asambleas\" & G_Build_ID & "\CodigosGenerados\" & GenCode & f & ".png", System.Drawing.Imaging.ImageFormat.Png)
                        ' Pintar Codigo de barras A Favor
                        gr.DrawImage(bitmp, Convert.ToSingle(mLad + wBoleta / 4 - codeW / 2) + wBoleta + mVert, mSup + hBoleta - Convert.ToSingle(marco * 2.77) + hBoleta + mVert,
                                         codeW, Convert.ToSingle((bitmp.Height * codeW) / bitmp.Width) - altoCode)
                        ' Pintar Letras de Codigo A Favor
                        gr.DrawString(CodeCompLetras & f, drawFontTer, drawBrush, New RectangleF(Convert.ToSingle(mLad + wBoleta / 4 - codeW / 2) + wBoleta + mVert,
                                                                                            mSup + hBoleta - 23 * 2.77 + hBoleta + mVert, codeW, Convert.ToSingle((bitmp.Height * codeW) / bitmp.Width)), strFormat) 'Pintar codigo en letras y numeros                                                 


                        'Generar codigo de barras En Contra
                        bitmp = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128B, GenCode & c))
                        bitmp.Save("D:\hubiC\Asambleas\" & G_Build_ID & "\CodigosGenerados\" & GenCode & c & ".png", System.Drawing.Imaging.ImageFormat.Png)
                        gr.DrawImage(bitmp, Convert.ToSingle(mLad + wBoleta * 0.75 - codeW / 2) + wBoleta + mVert, mSup + hBoleta - Convert.ToSingle(marco * 2.77) + hBoleta + mVert,
                                         codeW, Convert.ToSingle((bitmp.Height * codeW) / bitmp.Width) - altoCode)
                        gr.DrawString(CodeCompLetras & c, drawFontTer, drawBrush, New RectangleF(Convert.ToSingle(mLad + wBoleta * 0.75 - codeW / 2) + wBoleta + mVert,
                                                                                             mSup + hBoleta - 23 * 2.77 + hBoleta + mVert, codeW, Convert.ToSingle((bitmp.Height * codeW) / bitmp.Width)), strFormat) 'Pintar codigo en letras y numeros                                                 

                    End If

                    If count2 = 4 Or i = cantProp - 1 Then

                        hoja += 1
                        b.Save("D:\hubiC\Asambleas\" & G_Build_ID & "\" & G_Build_ID & " Asamblea " & nom_asamblea & " Punto " & nom_punto & " Hoja " & hoja & ".png", Imaging.ImageFormat.Png)
                        count2 = 0

                    End If

                Catch ex As Exception
                    MsgBox("Error al imprimir " & ex.Message)
                End Try

            Next
        Next
        name = ""
        NumAsamblea = 0
        b.Dispose()
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
        MsgBox("Listo para imprimir. Da clic en Generar Codigos")

    End Sub
End Class