using Czm.Czi.Maui.Aggregator.ExportPdf.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czm.Czi.Maui.Aggregator.ExportPdf.Implementations
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Czm.Czi.Maui.Aggregator.ExportPdf.Interfaces.ISectionServiceFactory" />
    public class SectionServiceFactory : ISectionServiceFactory
    {
        private readonly IEnumerable<ISectionService> _sectionService;

        public SectionServiceFactory(IEnumerable<ISectionService> sectionService)
        {
            this._sectionService = sectionService;
        }
        public ISectionService GetService(string token)
        {
            return this._sectionService?.FirstOrDefault(x => x.GetType().ToString().Contains(token));
        }
    }
}
