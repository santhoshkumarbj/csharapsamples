using pdfwriter.Interface;
using pdfwriter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdfwriter.Implementations
{
    public class SectionServiceFactory : ISectionServiceFactory
    {
        private readonly IEnumerable<ISectionService> _sectionService;

        public SectionServiceFactory(IEnumerable<ISectionService> sectionService)
        {
            this._sectionService = sectionService;
        }

        

        public ISectionService GetService(string token)
        {
            return this._sectionService.FirstOrDefault(x => x.GetType().ToString().Contains(token))!;
        }
    }
}
