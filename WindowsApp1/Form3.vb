Imports System
Imports System.IO
Imports System.Text

Imports MessagingToolkit.Barcode



Public Class Form3
    'Dim img As Image = Image.FromFile("C:\Users\Jerónimo\hubiC\Asambleas\Boleta-de-Votacion-Nueva.jpg")
    Dim b As New Drawing.Bitmap(2200, 1700)
    Dim gr As Graphics = Graphics.FromImage(b)

    ' Open Building logo
    Dim img As Image = Image.FromFile("D:\hubiC\Asambleas\logos\" & G_BuildingName & ".jpg")
    Dim Icob As Image = Image.FromFile("D:\hubiC\Asambleas\logos\marcaCobalto.jpg")

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
        '
        ' N EEE III A PPPP V
        ' N = numero
        ' EEE = Edificio
        ' III = ID de Propiedad
        ' A = Asamblea
        ' PPPP = Punto a Votar
        ' V = Valor del Voto

        'Dim barcodeEncoder As New BarcodeEncoder()
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
        Dim fecha As String = "05/09/2017"


        Dim temp As String = ""
        Dim sLine As String = ""
        Dim sLine2 As String = ""
        Dim GenCode As String = ""
        Dim CountA As Integer = 0
        Dim loc As Integer = 145 * 2.77
        Dim loc2 As Integer = 100 * 2.77
        Dim bitmp As Bitmap
        Dim punto As String

        Dim drawRect1 As New RectangleF(mLad, mLet * 9.5, wBoleta, hBoleta)
        Dim drawRect2 As New RectangleF(mLad, mLet * 13.5, wBoleta, hBoleta)
        Dim strFormat As New StringFormat()
        strFormat.Alignment = StringAlignment.Center
        Dim strFormat2 As New StringFormat()
        strFormat2.Alignment = StringAlignment.Far

        Dim L_Puntos As New List(Of String)


        Dim codeW As Integer = 500
        'strFormat.LineAlignment = StringAlignment.Center

        ' Create or overwrite the file.
        Dim fileWrt As System.IO.StreamWriter
        'Dim fileRd As System.IO.StreamReader

        If My.Computer.FileSystem.FileExists("D:\hubiC\Asambleas" & G_BuildingName & ".txt") Then

        Else
            fileWrt = My.Computer.FileSystem.OpenTextFileWriter("D:\hubiC\Asambleas" & G_BuildingName & ".txt", True)
            fileWrt.WriteLine("Here is the first string.")
            fileWrt.Close()
        End If

        Try

        Catch ex As Exception

        End Try

        ' Leer Nombre de Asamblea
        G_NAsamblea = tbx_Asamblea.Text
        G_NumAsa += 1
        tbx_Asamblea.Clear()


        ' Leer Linea de Puntos de Asamblea
        sLine = txtbxOrdinaria.Text

        Dim words() As String = sLine.Split(",")
        txtbxOrdinaria.Clear()

        For i = 0 To words.Count - 1
            L_Puntos.Add(words(i))
        Next

        Do

            If CountA = words.Count Then Exit Do

            If words(CountA).Contains(".") Then
                sLine2 = words(CountA)
                Dim subWords() As String = sLine2.Split(".")

                If subWords(0).Count = 2 And subWords(1).Count = 2 Then ' Revisa si ambos lados tienen 2 digito
                    G_AsambleaPuntos.Add(subWords(0) & subWords(1))

                ElseIf subWords(0).Count = 1 And subWords(1).Count = 2 Then ' Si Lado izquierdo tiene 1 digito y lado derecho 2
                    G_AsambleaPuntos.Add("0" & subWords(0) & subWords(1))

                ElseIf subWords(0).Count = 2 And subWords(1).Count = 1 Then ' Si Lado izquierdo tiene 2 digito y lado derecho 1
                    G_AsambleaPuntos.Add(subWords(0) & "0" & subWords(1))

                ElseIf subWords(0).Count = 1 And subWords(1).Count = 1 Then ' Revisa si ambos lados tienen 1 digito
                    G_AsambleaPuntos.Add("0" & subWords(0) & "0" & subWords(1))

                End If

            ElseIf words(CountA).Count = 1 Then
                G_AsambleaPuntos.Add("0" & words(CountA) & "00")

            ElseIf words(CountA).Count = 2 Then
                G_AsambleaPuntos.Add(words(CountA) & "00")

            End If
            CountA += 1



        Loop
        ' Dim imge As Image = Image.FromFile("D:\hubiC\Asambleas\Boleta.jpg")

        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.LabelPosition = LabelPositions.BottomCenter
        Generator.CustomLabel = ""
        Generator.Width = 400 * 2.77
        Generator.Height = 100 * 2.77
        Dim date1 As String = "05/08/2017"

        ' Empezar a generar codigos de Barras
        For j As Integer = 0 To (G_AsambleaPuntos.Count - 1)
            punto = LimpiarPunto(j)

            For i As Integer = 0 To (G_PropiedadID.Count - 1)
                Try
                    If i Mod 4 = 0 Then
                        gr.Clear(Color.White)
                        gr.FillRectangle(Brushes.White, 0, 0, b.Width, b.Height) ' Pintar de blanco el Fondo de la imagen

                        count2 += 1
                        GenCode = num1 & G_BuildingName & G_PropiedadID(i) & G_NumAsa & G_AsambleaPuntos(j) 'Generando Codigo Base

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
                        strFormat.FormatFlags = StringFormatFlags.DirectionVertical
                        gr.DrawString(formato, drawFontTer, drawBrush, mLad + wBoleta - 50, mSup + 100, strFormat)
                        strFormat.FormatFlags = StringFormatFlags.FitBlackBox
                        gr.DrawString(fecha, drawFontTer, drawBrush, mLad + 100, mSup + 20, strFormat)

                        'Pintar el nombre de la asamblea 
                        gr.DrawString(G_NAsamblea, drawFontMain, drawBrush, New RectangleF(mLad, mLet * 9.5, wBoleta, hBoleta), strFormat)
                        'Pintar el punto a votar
                        gr.DrawString("Punto " & punto, drawFontMain, drawBrush, drawRect2, strFormat)
                        'Pintar el Numero de propiedad e indiviso
                        gr.DrawString(GetTorreYDepa(i) & "   " & G_Indiviso(i) & "% Indiviso",
                                      drawFontSec, drawBrush, New RectangleF(mLad, mLet * 15.5, wBoleta, hBoleta), strFormat)

                        'Generar codigo de barras a Favor
                        bitmp = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, GenCode & "1"))
                        bitmp.Save("D:\hubiC\Asambleas\CodigosGenerados\" & GenCode & "1.png", System.Drawing.Imaging.ImageFormat.Png)
                        ' Pintar Codigo de barras A Favor
                        'gr.DrawImage()
                        gr.DrawImage(bitmp, Convert.ToSingle(mLad + wBoleta / 4 - codeW / 2), mSup + hBoleta - Convert.ToSingle(marco * 2.77),
                                         codeW, Convert.ToSingle((bitmp.Height * codeW) / bitmp.Width) - altoCode)
                        gr.DrawString(GenCode & "1", drawFontTer, drawBrush, New RectangleF(Convert.ToSingle(mLad + wBoleta / 4 - codeW / 2), mSup + hBoleta - 23 * 2.77,
                                                                                            codeW, Convert.ToSingle(codeW * bitmp.Height / bitmp.Width)), strFormat) 'Pintar codigo en letras y numeros

                        'Busca Codigo de Brras en contra
                        bitmp = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, GenCode & "2"))
                        bitmp.Save("D:\hubiC\Asambleas\CodigosGenerados\" & GenCode & "2.png", System.Drawing.Imaging.ImageFormat.Png)
                        ' Pintar Letras de Codigo En Contra
                        gr.DrawImage(bitmp, Convert.ToSingle(mLad + wBoleta * 0.75 - codeW / 2), mSup + hBoleta - Convert.ToSingle(marco * 2.77),
                                         codeW, Convert.ToSingle((bitmp.Height * codeW) / bitmp.Width) - altoCode)
                        gr.DrawString(GenCode & "2", drawFontTer, drawBrush, New RectangleF((mLad + (wBoleta * 0.75) - (codeW / 2)),
                                                                                             mSup + hBoleta - 23 * 2.77, codeW, Convert.ToSingle(codeW * bitmp.Height / bitmp.Width)), strFormat) 'Pintar codigo en letras y numeros


                    ElseIf i Mod 4 = 1 Then
                        count2 += 1
                        GenCode = num1 & G_BuildingName & G_PropiedadID(i) & G_NumAsa & G_AsambleaPuntos(j) 'Generando Codigo Base
                        'Pintar segunda boleta
                        ' Pintar imagen de votacion
                        img2 = Bitmap.FromFile("D:\hubiC\Asambleas\Votacion.jpg")
                        gr.DrawImage(img2, mLad + wBoleta + mVert, Convert.ToSingle(mLad + ((wBoleta / 9) * 4) - 15), wBoleta, img2.Height)

                        'Pintar rectangulo de Boleta
                        gr.DrawRectangle(blackPenL, mLad + wBoleta + mVert, mSup, wBoleta, hBoleta)
                        'Pintar Logo del edificio
                        gr.DrawImage(img,
                                 Convert.ToSingle(mLad + wBoleta + mVert + (wBoleta / 2) - loc / 2),
                                 mSup + mLet,
                                 loc,
                                 Convert.ToSingle(loc * img.Height / img.Width)) ' Dibujando imagen boleta 2

                        strFormat.FormatFlags = StringFormatFlags.DirectionVertical
                        gr.DrawString(formato, drawFontTer, drawBrush, mLad + wBoleta * 2 + mVert - 50, mSup + 100, strFormat)
                        strFormat.FormatFlags = StringFormatFlags.NoWrap
                        gr.DrawString(fecha, drawFontTer, drawBrush, mLad + wBoleta + mVert + 100, mSup + 20, strFormat)

                        gr.DrawString(G_NAsamblea, drawFontMain, drawBrush, New RectangleF(mLad + wBoleta + mVert, mLet * 9.5, wBoleta, hBoleta), strFormat)
                        gr.DrawString("Punto " & punto, drawFontMain, drawBrush, New RectangleF(mLad + wBoleta + mVert, mLet * 13.5, wBoleta, hBoleta), strFormat)
                        gr.DrawString(GetTorreYDepa(i) & "   " & G_Indiviso(i) & "% Indiviso",
                                      drawFontSec, drawBrush, New RectangleF(mLad + wBoleta + mVert, mLet * 15.5, wBoleta, hBoleta), strFormat)


                        'Crear Codigo de Barras a Favor
                        bitmp = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, GenCode & "1"))
                        bitmp.Save("D:\hubiC\Asambleas\CodigosGenerados\" & GenCode & "1.png", System.Drawing.Imaging.ImageFormat.Png)

                        gr.DrawImage(bitmp, Convert.ToSingle(mLad + wBoleta / 4 - codeW / 2) + wBoleta + mVert, mSup + hBoleta - Convert.ToSingle(marco * 2.77),
                                         codeW, Convert.ToSingle((bitmp.Height * codeW) / bitmp.Width) - altoCode)
                        gr.DrawString(GenCode & "1", drawFontTer, drawBrush, New RectangleF(Convert.ToSingle(mLad + wBoleta / 4 - codeW / 2) + wBoleta + mVert,
                                                                                            mSup + hBoleta - 23 * 2.77, codeW, Convert.ToSingle(codeW * bitmp.Height / bitmp.Width)), strFormat) 'Pintar codigo en letras y numeros                                                 


                        'Generar codigo de barras En Contra
                        bitmp = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, GenCode & "2"))
                        bitmp.Save("D:\hubiC\Asambleas\CodigosGenerados\" & GenCode & "2.png", System.Drawing.Imaging.ImageFormat.Png)
                        gr.DrawImage(bitmp, Convert.ToSingle(mLad + wBoleta * 0.75 - codeW / 2) + wBoleta + mVert, mSup + hBoleta - Convert.ToSingle(marco * 2.77),
                                         codeW, Convert.ToSingle((bitmp.Height * codeW) / bitmp.Width) - altoCode)
                        gr.DrawString(GenCode & "2", drawFontTer, drawBrush, New RectangleF((mLad + (wBoleta * 0.75) - (codeW / 2) + wBoleta + mVert),
                                                                                             mSup + hBoleta - 23 * 2.77, codeW, Convert.ToSingle(codeW * bitmp.Height / bitmp.Width)), strFormat) 'Pintar codigo en letras y numeros                                                 


                    ElseIf i Mod 4 = 2 Then
                        count2 += 1
                        GenCode = num1 & G_BuildingName & G_PropiedadID(i) & G_NumAsa & G_AsambleaPuntos(j) 'Generando Codigo Base
                        'Pintar tercera boleta
                        img2 = Bitmap.FromFile("D:\hubiC\Asambleas\Votacion.jpg")
                        gr.DrawImage(img2, mLad, Convert.ToSingle(((wBoleta / 9) * 4) - 15) + mSup + hBoleta + mHor, wBoleta, img2.Height)

                        'Insertar Gen de Codigo
                        gr.DrawRectangle(blackPenL, mLad, mSup + hBoleta + mHor, wBoleta, hBoleta)
                        gr.DrawImage(img,
                                 Convert.ToSingle(b.Width / 4 - loc / 2),
                                 mSup + hBoleta + mHor + (mLet),
                                 loc,
                                 Convert.ToSingle(loc * img.Height / img.Width)) ' Dibujando imagen boleta 3

                        strFormat.FormatFlags = StringFormatFlags.DirectionVertical
                        gr.DrawString(formato, drawFontTer, drawBrush, mLad + wBoleta - 50, mSup + hBoleta + mHor + 100, strFormat)
                        strFormat.FormatFlags = StringFormatFlags.NoWrap
                        gr.DrawString(fecha, drawFontTer, drawBrush, mLad + 100, mSup + hBoleta + mHor + 20, strFormat)

                        gr.DrawString(G_NAsamblea, drawFontMain, drawBrush, New RectangleF(mLad, mLet * 9.5 + hBoleta + mHor, wBoleta, hBoleta), strFormat)
                        gr.DrawString("Punto " & punto, drawFontMain, drawBrush, New RectangleF(mLad, mLet * 13.5 + hBoleta + mHor, wBoleta, hBoleta), strFormat)

                        gr.DrawString(GetTorreYDepa(i) & "   " & G_Indiviso(i) & "% Indiviso",
                                      drawFontSec, drawBrush, New RectangleF(mLad, mLet * 15.5 + hBoleta + mHor, wBoleta, hBoleta), strFormat)


                        'Generar codigo de barras a Favor
                        bitmp = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, GenCode & "1"))
                        bitmp.Save("D:\hubiC\Asambleas\CodigosGenerados\" & GenCode & "1.png", System.Drawing.Imaging.ImageFormat.Png)
                        gr.DrawImage(bitmp, Convert.ToSingle(mLad + wBoleta / 4 - codeW / 2), mSup + hBoleta - Convert.ToSingle(marco * 2.77) + hBoleta + mVert,
                                         codeW, Convert.ToSingle((bitmp.Height * codeW) / bitmp.Width - altoCode))
                        gr.DrawString(GenCode & "1", drawFontTer, drawBrush, New RectangleF(Convert.ToSingle(mLad + wBoleta / 4 - codeW / 2),
                        mSup + hBoleta - 23 * 2.77 + hBoleta + mVert, codeW, Convert.ToSingle((bitmp.Height * codeW) / bitmp.Width)), strFormat) 'Pintar codigo en letras y numeros





                        'Generar codigo de barras  En contra
                        bitmp = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, GenCode & "2"))
                        bitmp.Save("D:\hubiC\Asambleas\CodigosGenerados\" & GenCode & "2.png", System.Drawing.Imaging.ImageFormat.Png)
                        gr.DrawImage(bitmp, Convert.ToSingle(mLad + wBoleta * 0.75 - codeW / 2), mSup + hBoleta - Convert.ToSingle(marco * 2.77) + hBoleta + mVert,
                                         codeW, Convert.ToSingle((bitmp.Height * codeW) / bitmp.Width) - altoCode)
                        gr.DrawString(GenCode & "2", drawFontTer, drawBrush, New RectangleF((mLad + (wBoleta * 0.75) - (codeW / 2)),
                                                                                            mSup + hBoleta - 23 * 2.77 + hBoleta + mVert, codeW, Convert.ToSingle((bitmp.Height * codeW) / bitmp.Width)), strFormat) 'Pintar codigo en letras y numeros


                    ElseIf i Mod 4 = 3 Then
                        count2 += 1
                        GenCode = num1 & G_BuildingName & G_PropiedadID(i) & G_NumAsa & G_AsambleaPuntos(j) 'Generando Codigo Base
                        'Pintar cuarta boleta
                        img2 = Bitmap.FromFile("D:\hubiC\Asambleas\Votacion.jpg")
                        gr.DrawImage(img2, mLad + wBoleta + mVert, Convert.ToSingle(((wBoleta / 9) * 4) - 15) + mSup + hBoleta + mHor, wBoleta, img2.Height)

                        'Insertar Gen de Codigo
                        gr.DrawRectangle(blackPenL, mLad + wBoleta + mVert, mSup + hBoleta + mHor, wBoleta, hBoleta)

                        gr.DrawImage(img,
                                     Convert.ToSingle(mLad + wBoleta + mVert + (wBoleta / 2) - loc / 2),
                                      mSup + hBoleta + mHor + (mLet),
                                     loc,
                                     Convert.ToSingle(loc * img.Height / img.Width)) ' Dibujando imagen boleta 4

                        strFormat.FormatFlags = StringFormatFlags.DirectionVertical
                        gr.DrawString(formato, drawFontTer, drawBrush, mLad + wBoleta * 2 + mVert - 50, mSup + hBoleta + mHor + 100, strFormat)
                        strFormat.FormatFlags = StringFormatFlags.NoWrap
                        gr.DrawString(fecha, drawFontTer, drawBrush, mLad + wBoleta + mVert + 100, mSup + hBoleta + mHor + 20, strFormat)

                        gr.DrawString(G_NAsamblea, drawFontMain, drawBrush, New RectangleF(mLad + wBoleta + mVert, mLet * 9.5 + hBoleta + mHor, wBoleta, hBoleta), strFormat)
                        gr.DrawString("Punto " & punto, drawFontMain, drawBrush, New RectangleF(mLad + wBoleta + mVert, mLet * 13.5 + hBoleta + mHor, wBoleta, hBoleta), strFormat)
                        gr.DrawString(GetTorreYDepa(i) & "   " & G_Indiviso(i) & "% Indiviso",
                                      drawFontSec, drawBrush, New RectangleF(mLad + wBoleta + mVert, mLet * 15.5 + hBoleta + mHor, wBoleta, hBoleta), strFormat)

                        bitmp = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, GenCode & "1"))
                        bitmp.Save("D:\hubiC\Asambleas\CodigosGenerados\" & GenCode & "1.png", System.Drawing.Imaging.ImageFormat.Png)
                        ' Pintar Codigo de barras A Favor
                        gr.DrawImage(bitmp, Convert.ToSingle(mLad + wBoleta / 4 - codeW / 2) + wBoleta + mVert, mSup + hBoleta - Convert.ToSingle(marco * 2.77) + hBoleta + mVert,
                                         codeW, Convert.ToSingle((bitmp.Height * codeW) / bitmp.Width) - altoCode)
                        ' Pintar Letras de Codigo A Favor
                        gr.DrawString(GenCode & "1", drawFontTer, drawBrush, New RectangleF(Convert.ToSingle(mLad + wBoleta / 4 - codeW / 2) + wBoleta + mVert,
                                                                                            mSup + hBoleta - 23 * 2.77 + hBoleta + mVert, codeW, Convert.ToSingle((bitmp.Height * codeW) / bitmp.Width)), strFormat) 'Pintar codigo en letras y numeros                                                 




                        'Generar codigo de barras En Contra
                        bitmp = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, GenCode & "2"))
                        bitmp.Save("D:\hubiC\Asambleas\CodigosGenerados\" & GenCode & "2.png", System.Drawing.Imaging.ImageFormat.Png)
                        gr.DrawImage(bitmp, Convert.ToSingle(mLad + wBoleta * 0.75 - codeW / 2) + wBoleta + mVert, mSup + hBoleta - Convert.ToSingle(marco * 2.77) + hBoleta + mVert,
                                         codeW, Convert.ToSingle((bitmp.Height * codeW) / bitmp.Width) - altoCode)
                        gr.DrawString(GenCode & "2", drawFontTer, drawBrush, New RectangleF(Convert.ToSingle(mLad + wBoleta * 0.75 - codeW / 2) + wBoleta + mVert,
                                                                                             mSup + hBoleta - 23 * 2.77 + hBoleta + mVert, codeW, Convert.ToSingle((bitmp.Height * codeW) / bitmp.Width)), strFormat) 'Pintar codigo en letras y numeros                                                 



                    End If

                    If count2 = 4 Or i = (G_PropiedadID.Count - 1) Then

                        hoja += 1

                        b.Save("D:\hubiC\Asambleas\Imprimir\" & G_BuildingName & " Asamblea " & G_NumAsa & " Punto " & punto & " Hoja " & hoja & ".png", Imaging.ImageFormat.Png)

                        'b.Dispose()
                        'gr.Clear(Color.White)

                        count2 = 0
                    End If

                Catch ex As Exception

                End Try

            Next
        Next
        name = ""
        NumAsamblea = 0
        b.Dispose()
    End Sub


    ' Funcion para desplegar correctamente La torre y el Departamento
    Public Function GetTorreYDepa(ByVal i As Integer)
        ' Se limpia al pintar Torre y Depa
        Dim torreYdepa As String = ""

        If G_Torre(i) = "" Then
            torreYdepa = G_Depto(i)
        Else
            torreYdepa = G_Torre(i) & " - " & G_Depto(i)
        End If

        Return torreYdepa

    End Function
    ' Funcion para desplegar correctamente el Punto de la asamblea
    Public Function LimpiarPunto(ByVal i As Integer)

        Dim code As String = ""
        Dim myString As String
        Dim minStr As String
        Dim f As Integer
        Dim g As Integer


        myString = G_AsambleaPuntos(i)
        minStr = myString.Chars(0) & myString.Chars(1)
        f = Convert.ToInt32(minStr)
        minStr = myString.Chars(2) & myString.Chars(3)
        g = Convert.ToInt32(minStr)

        If f > 0 Then
            code = f.ToString
        End If

        If g > 0 Then
            code = code & "." & g.ToString
        End If

        Return code

    End Function

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Hide()
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

    Private Sub tbx_Asamblea_TextChanged(sender As Object, e As EventArgs) Handles tbx_Asamblea.TextChanged

    End Sub
End Class