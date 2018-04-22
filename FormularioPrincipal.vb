Imports System
Imports System.IO
Imports System.Text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.parser

Public Class FormularioPrincipal
    Private Sub btnPaginarTXT_Click(sender As Object, e As EventArgs) Handles btnPaginarTXT.Click
        LeerTxt()
    End Sub

    Private Sub LeerTxt()

        ' El formato es %%LA VANGUARDIA / 20180416 / 1~

        Dim Cadena As String
        Dim NumPaginas As Integer = 0, RutaNombreFichero As String, NombreFichero As String, ResultadoPaginacion As Integer

        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Text Files|*.txt"
        openFileDialog1.Title = "Selecciona un fichero"
        openFileDialog1.Multiselect = True
        If openFileDialog1.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If
        Dim file As String, i As Integer = 0
        For Each file In openFileDialog1.FileNames

            RutaNombreFichero = openFileDialog1.FileNames(i)
            NombreFichero = Strings.Left(openFileDialog1.SafeFileNames(i), 8)
            NumPaginas = ObtenerCuentaPaginas(RutaNombreFichero)

            Cadena = "%%" & ObtenerPublicacion() & " / " & NombreFichero & " / "

            Select Case NumPaginas
                Case -1
                    MsgBox("El fichero " & RutaNombreFichero & " no existe", vbCritical, "Doc-it")
                Case -2
                    MsgBox("El fichero " & RutaNombreFichero & " ya está paginado", vbCritical, "Doc-it")
                Case 1
                    MsgBox("El fichero " & RutaNombreFichero & " no tiene nínguna página reconocida. Asegúrate de haber incluido el carácter de salto de página", vbCritical, "Doc-it")
                Case 0
                    MsgBox("El fichero " & RutaNombreFichero & " no tiene nínguna página reconocida. Asegúrate de haber incluido el carácter de salto de página", vbCritical, "Doc-it")
                Case Else
                    Dim Result As Integer = MsgBox("Se va a paginar el fichero " & RutaNombreFichero & " con " & NumPaginas & " páginas perteneciente a la publicación " & ObtenerPublicacion() & ". ¿Estás de acuerdo?", vbOKCancel, "Doc-it")
                    If Result = 1 Then
                        ResultadoPaginacion = Paginar(RutaNombreFichero, Cadena)
                        If ResultadoPaginacion < 1 Then
                            MessageBox.Show("Error número: " & ResultadoPaginacion)
                        Else
                            MessageBox.Show("Fichero paginado (" & NumPaginas & " páginas) correctamente: " & RutaNombreFichero)
                        End If
                    End If
            End Select
            i = i + 1
        Next

    End Sub

    Private Function ObtenerCuentaPaginas(Ruta As String) As Integer

        Dim ContenidoFichero As String, Contador As Integer = 0

        If File.Exists(Ruta) = False Then  ' Si no existe el fichero devuelve -1
            Return -1
        End If

        ContenidoFichero = My.Computer.FileSystem.ReadAllText(Ruta)

        If Mid(ContenidoFichero, 1, 2) = "%%" Then  ' Si ya está paginado devuelve -2
            Return -2
        End If

        For i = 1 To ContenidoFichero.Length
            Dim xx As String = Mid(ContenidoFichero, i, 1)
            If xx = vbFormFeed Then
                Contador = Contador + 1
            End If
        Next

        If chkSaltoFinal.Checked = True Then
            Return Contador
        Else
            Return Contador + 1
        End If

    End Function

    Private Function Paginar(Ruta As String, MarcaPagina As String) As Integer
        Dim ContenidoFichero As String, NumPaginas As Integer = 0, Contador As Integer
        Dim SaltarPrimera As Boolean = False

        NumPaginas = ObtenerCuentaPaginas(Ruta)

        If NumPaginas = -1 Then
            Return -1
        ElseIf NumPaginas = -2 Then
            Return -2
        ElseIf NumPaginas = 0 Then
            Return 0
        End If

        ContenidoFichero = My.Computer.FileSystem.ReadAllText(Ruta, Encoding.UTF7)
        Contador = NumPaginas

        If chkSaltoFinal.Checked = False Then
            SaltarPrimera = True
        End If

        For i = ContenidoFichero.Length To 1 Step -1
            Dim xx As String = Mid(ContenidoFichero, i, 1)
            If xx = Chr(12) Then
                If SaltarPrimera = True Then
                    ContenidoFichero = ContenidoFichero.Insert(i, MarcaPagina & NumPaginas & "~")
                    NumPaginas = NumPaginas - 1
                Else
                    SaltarPrimera = True
                End If
            End If
        Next
        ContenidoFichero = ContenidoFichero.Insert(0, MarcaPagina & NumPaginas & "~")

        Try
            File.WriteAllText(Ruta, ContenidoFichero, Encoding.UTF8)
            Return NumPaginas
        Catch ex As Exception
            MessageBox.Show("Error en la escritura del fichero " & Ruta & " - Descripción: " & ex.Message)
            Return -3
        End Try
    End Function

    Private Function ObtenerPublicacion() As String
        If rbPA.Checked = True Then
            Return "EL PAIS"
        ElseIf rbCO.Checked = True Then
            Return "CORREO"
        ElseIf rbPE.Checked = True Then
            Return "PERIODICO DE CATALUÑA"
        ElseIf rbMD.Checked = True Then
            Return "EL MUNDO"
        ElseIf rbRZ.Checked = True Then
            Return "LA RAZON"
        ElseIf rbMO.Checked = True Then
            Return "LE MONDE"
        ElseIf rbMA.Checked = True Then
            Return "MARCA"
        ElseIf rb5D.Checked = True Then
            Return "CINCO DIAS"
        ElseIf rbVG.Checked = True Then
            Return "LA VANGUARDIA"
        ElseIf rbSG.Checked = True Then
            Return "SIGLO"
        ElseIf rbLX.Checked = True Then
            Return "L'EXPRESS"
        ElseIf rbTM.Checked = True Then
            Return "TIME"
        ElseIf rbCA16.Checked = True Then
            Return "CAMBIO 16"
        ElseIf rbHL.Checked = True Then
            Return "HOLA"
        ElseIf rbSM.Checked = True Then
            Return "SEMANA"
        ElseIf rbLIBROS.Checked = True Then
            Return "LIBROS"
        End If
        Return "Error"
    End Function

    Private Sub btnTXTdesdePDF_Click(sender As Object, e As EventArgs) Handles btnTXTdesdePDF.Click
        LeerPDF()
    End Sub

    Private Sub LeerPDF()
        ' El formato es %%LA VANGUARDIA / 20180416 / 1~

        Dim Cadena As String
        Dim NumPaginas As Integer = 0, RutaNombreFichero As String, NombreFichero As String, TextoPDF As String = "", RutaNombreFicheroTXT As String

        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "PDF Files|*.pdf"
        openFileDialog1.Title = "Selecciona un fichero"
        openFileDialog1.Multiselect = True
        If openFileDialog1.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If
        Dim Fichero As String, i As Integer = 0
        For Each Fichero In openFileDialog1.FileNames

            TextoPDF = ""

            RutaNombreFichero = openFileDialog1.FileNames(i)
            NombreFichero = Strings.Left(openFileDialog1.SafeFileNames(i), 8)
            Dim LectorPDF As New PdfReader(openFileDialog1.FileNames(i))
            NumPaginas = LectorPDF.NumberOfPages

            Cadena = "%%" & ObtenerPublicacion() & " / " & NombreFichero & " / "
            RutaNombreFicheroTXT = Strings.Left(RutaNombreFichero, RutaNombreFichero.Length - 3) & "txt"

            For j = 1 To NumPaginas
                Dim ExtractorPDF As ITextExtractionStrategy = New iTextSharp.text.pdf.parser.SimpleTextExtractionStrategy()
                Dim TextoPagina As String = PdfTextExtractor.GetTextFromPage(LectorPDF, j, ExtractorPDF)
                TextoPDF += Cadena & j & "~" & vbCrLf & TextoPagina & vbCrLf
                If j < NumPaginas Then
                    TextoPDF += vbFormFeed
                End If
                ProgressBar1.Value = j / NumPaginas * 100
            Next

            Try
                File.WriteAllText(RutaNombreFicheroTXT, TextoPDF, Encoding.UTF8)
                MsgBox("Guardado " & RutaNombreFicheroTXT)
            Catch ex As Exception
                MessageBox.Show("Error en la escritura del fichero " & RutaNombreFicheroTXT & " - Descripción: " & ex.Message)
            End Try

            i = i + 1
        Next
    End Sub
End Class
