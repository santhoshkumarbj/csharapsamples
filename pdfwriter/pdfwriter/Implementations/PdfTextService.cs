using iText.Kernel.Font;
using iText.Layout.Element;
using iText.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pdfwriter.Interface;
using iText.Kernel.Geom;
using System.Data;
using System.Text.RegularExpressions;

namespace pdfwriter.Implementations
{
    public class PdfTextService : ISectionService
    {
        public object DataRow { get; set; }
        public void ProcessFields(Document document, Section section)
        {
            foreach (var line in section.Lines)
            {
                var paragraph = ProcessTexts(line.Texts);
                if (line.Margin != null)
                {
                    paragraph.SetMargins(line.Margin.Top,line.Margin.Right,line.Margin.Bottom,line.Margin.Left);
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
                text.Text = ReplaceText(text);
                Style style = new Style();
                PdfFont font = PdfFontFactory.CreateFont(text.FontDescription.FontFamily + ".ttf");

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

        private string ReplaceText(DocumentText text)
        {
            var regex = new Regex("{(.*?)}");
            var matches = regex.Matches(text.Text);
            foreach (Match match in matches) //you can loop through your matches like this
            {
                var propName = match.Groups[1].Value;
                string? value = DataRow?.GetType().GetProperty(propName)?.GetValue(DataRow, null).ToString();
                if (value != null)
                {
                    text.Text = text.Text.Replace(match.Value, value);
                }
            }
            return text.Text;
        }
    }
}
