using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czm.Czi.Maui.Aggregator.ExportPdf.Interfaces
{
    public interface ITemplateManager
    {
        void ProcessTemplate(string fileName, Dictionary<string, object> data);
    }
}
