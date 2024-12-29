using Czm.Czi.Maui.Aggregator.ExportPdf.Interfaces;
using Czm.Czi.Maui.Aggregator.ExportPdf.Model;
using iText.Kernel.Font;
using iText.Layout.Element;
using iText.Layout;
using Czm.Czi.Maui.Aggregator.ExportPdf.Constants;

namespace Czm.Czi.Maui.Aggregator.ExportPdf.Implementations
{
    /// <summary>
    /// Text which needs to be added in pdf will be processed. Only Direct text will be processed.
    /// </summary>
    /// <seealso cref="Czm.Czi.Maui.Aggregator.ExportPdf.Interfaces.ISectionService" />
    public class PdfTextService : ISectionService
    {
        /// <summary>
        /// Processes the fields.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <param name="section">The section.</param>
        public void ProcessFields(Document document, Section section, Dictionary<string, object> data)
        {
            foreach (var line in section.Lines)
            {
                var paragraph = ProcessTexts(line.Texts);
                if (line.Margin != null)
                {
                    paragraph.SetMargins(line.Margin.Top, line.Margin.Right, line.Margin.Bottom, line.Margin.Left);
                }
                document.Add(paragraph);
            }
        }

        /// <summary>
        /// Processes the texts.
        /// </summary>
        /// <param name="documentTexts">The document texts.</param>
        /// <returns>Paragraph details</returns>
        private Paragraph ProcessTexts(List<DocumentText> documentTexts)
        {
            Paragraph paragraph = new Paragraph();
            foreach (var text in documentTexts)
            {
                Style style = new Style();
                PdfFont font = PdfFontFactory.CreateFont(SectionConstants.FontsFolder + text.FontDescription.FontFamily + SectionConstants.FontExtension);

                style.SetFont(font).SetFontSize(text.FontDescription.Size).SetTextAlignment(text.FontDescription.Alignment);

                if (text.FontDescription.FontStyle == TextFontStyle.Bold)
                {
                    style.SetBold();
                }
                Text textElelement = new Text(text.Text).AddStyle(style);
                paragraph.Add(textElelement);
            }
            return paragraph;
        }
    }
}
