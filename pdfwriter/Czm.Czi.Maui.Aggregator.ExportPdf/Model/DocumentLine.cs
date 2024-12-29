using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czm.Czi.Maui.Aggregator.ExportPdf.Model
{

    /// <summary>
    /// Properties of Line
    /// </summary>
    public class DocumentLine
    {
        public List<DocumentText> Texts { get; set; }

        public List<DocumentImage> Images { get; set; }

        public DocumentMargin Margin { get; set; }

    }
}
