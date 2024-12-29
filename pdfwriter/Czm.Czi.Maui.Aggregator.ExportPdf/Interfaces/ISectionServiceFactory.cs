using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czm.Czi.Maui.Aggregator.ExportPdf.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISectionServiceFactory
    {
        ISectionService GetService(string token);
    }
}
