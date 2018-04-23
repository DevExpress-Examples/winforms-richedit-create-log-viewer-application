using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;
using DevExpress.Office.Utils;
using DevExpress.XtraRichEdit.API.Native;

namespace RichEditLogViewer {
    public partial class Form1 : Form {
        Random rnd = new Random();
        string mesageFormat = "{0}: {1,-20} - {2}";

        public Form1() {
            InitializeComponent();

            richEditControl1.ReadOnly = true;
            richEditControl1.ActiveViewType = RichEditViewType.Draft;
            richEditControl1.Options.HorizontalRuler.Visibility = RichEditRulerVisibility.Hidden;
            richEditControl1.Views.DraftView.BackColor = Color.Black;
            richEditControl1.Views.DraftView.Padding = new Padding(0);
            richEditControl1.CreateNewDocument();
        }

        private void richEditControl1_DocumentLoaded(object sender, EventArgs e) {
            ApplyDefaultDocumentFormat();
        }

        private void richEditControl1_EmptyDocumentCreated(object sender, EventArgs e) {
            ApplyDefaultDocumentFormat();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            Document document = richEditControl1.Document;
            string prefix = "\r\nNew message";

            if (document.Paragraphs[0].Range.Length <= 1)
                prefix = prefix.TrimStart();

            document.AppendText(string.Format(mesageFormat, prefix, GetActualMessage(), DateTime.Now.ToString()));

            document.CaretPosition = document.Paragraphs.Get( document.Range.End).Range.Start;
            richEditControl1.ScrollToCaret();
        }

        private string GetActualMessage() {
            int index = rnd.Next(3);

            switch (index) {
                case 0:
                    return "Information";
                case 1:
                    return "Warning";
                case 2:
                    return "Error";
                default:
                    return "Unknown";
            }
        }

        private void ApplyDefaultDocumentFormat() {
            richEditControl1.Document.DefaultCharacterProperties.FontName = "Courier New";
            richEditControl1.Document.DefaultCharacterProperties.FontSize = 12;
            richEditControl1.Document.DefaultCharacterProperties.Bold = true;
            richEditControl1.Document.DefaultCharacterProperties.ForeColor = Color.Blue;
            richEditControl1.Document.Sections[0].Page.Width = Units.InchesToDocumentsF(10f);
        }
    }
}