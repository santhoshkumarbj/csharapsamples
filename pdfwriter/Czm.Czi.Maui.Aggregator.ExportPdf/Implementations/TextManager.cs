using Czm.Czi.Maui.Aggregator.ExportPdf.Interfaces;
using Czm.Czi.Maui.Aggregator.ExportPdf.Model;
using iText.Kernel.Pdf;
using iText.Layout;
using Newtonsoft.Json;

namespace Czm.Czi.Maui.Aggregator.ExportPdf.Implementations
{
    public class TextManager : ITemplateManager
    { 
        ISectionServiceFactory _sectionServiceFactory;
        public TextManager(ISectionServiceFactory sectionServiceFactory) 
        {
            _sectionServiceFactory = sectionServiceFactory;
        }

        public void ProcessTemplate(string fileName, Dictionary<string, object> data)
        {
            string chatTemplate = File.ReadAllText("Templates/ChatTemplate.json");
            var chatHistory = JsonConvert.DeserializeObject<ChatHistory>(chatTemplate);
            PdfWriter writer = new PdfWriter(fileName);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            foreach (var section in chatHistory.Sections)
            {
                var sectionType = Enum.GetName(typeof(SectionType), section.Type);
                var sectionService = _sectionServiceFactory.GetService(sectionType);
                sectionService.ProcessFields(document, section,data);
                
            }
        }
    }
}
