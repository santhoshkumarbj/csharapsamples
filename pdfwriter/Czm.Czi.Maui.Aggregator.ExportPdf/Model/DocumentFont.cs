using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czm.Czi.Maui.Aggregator.ExportPdf.Model
{
    public class DocumentFont
    {
        public int Size { get; set; }

        public string FontFamily { get; set; }

        public TextAlignment Alignment { get; set; }

        public TextFontStyle FontStyle { get; set; }
    }
}
