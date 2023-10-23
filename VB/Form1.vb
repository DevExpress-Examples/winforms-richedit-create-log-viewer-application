Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit
Imports DevExpress.Office.Utils
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.Portable

Namespace RichEditLogViewer

    Public Partial Class Form1
        Inherits Form

        Private rnd As Random = New Random()

        Private mesageFormat As String = "{0}: {1,-20} - {2}"

        Public Sub New()
            InitializeComponent()
            richEditControl1.ReadOnly = True
            richEditControl1.ActiveViewType = RichEditViewType.Draft
            richEditControl1.Options.HorizontalRuler.Visibility = RichEditRulerVisibility.Hidden
            richEditControl1.Views.DraftView.BackColor = Color.Black
            richEditControl1.Views.DraftView.Padding = New PortablePadding(0)
            richEditControl1.CreateNewDocument()
        End Sub

        Private Sub richEditControl1_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs)
            ApplyDefaultDocumentFormat()
        End Sub

        Private Sub richEditControl1_EmptyDocumentCreated(ByVal sender As Object, ByVal e As EventArgs)
            ApplyDefaultDocumentFormat()
        End Sub

        Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
            Dim document As Document = richEditControl1.Document
            Dim prefix As String = Microsoft.VisualBasic.Constants.vbCrLf & "New message"
            If document.Paragraphs(0).Range.Length <= 1 Then prefix = prefix.TrimStart()
            document.AppendText(String.Format(mesageFormat, prefix, GetActualMessage(), Date.Now.ToString()))
            document.CaretPosition = document.Paragraphs.Get(document.Range.End).Range.Start
            richEditControl1.ScrollToCaret()
        End Sub

        Private Function GetActualMessage() As String
            Dim index As Integer = rnd.Next(3)
            Select Case index
                Case 0
                    Return "Information"
                Case 1
                    Return "Warning"
                Case 2
                    Return "Error"
                Case Else
                    Return "Unknown"
            End Select
        End Function

        Private Sub ApplyDefaultDocumentFormat()
            richEditControl1.Document.DefaultCharacterProperties.FontName = "Courier New"
            richEditControl1.Document.DefaultCharacterProperties.FontSize = 12
            richEditControl1.Document.DefaultCharacterProperties.Bold = True
            richEditControl1.Document.DefaultCharacterProperties.ForeColor = Color.Blue
            richEditControl1.Document.Sections(0).Page.Width = Units.InchesToDocumentsF(10F)
        End Sub
    End Class
End Namespace
