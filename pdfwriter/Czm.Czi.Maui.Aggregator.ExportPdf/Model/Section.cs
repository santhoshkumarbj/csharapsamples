using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czm.Czi.Maui.Aggregator.ExportPdf.Model
{
    public class Section
    {
        public string Name { get; set; }

        public SectionType Type { get; set; }

        public List<DocumentLine> Lines { get; set; }

    }
}
