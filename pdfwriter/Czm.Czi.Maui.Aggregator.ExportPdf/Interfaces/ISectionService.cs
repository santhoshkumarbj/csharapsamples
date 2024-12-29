using Czm.Czi.Maui.Aggregator.ExportPdf.Model;
using iText.Layout;

namespace Czm.Czi.Maui.Aggregator.ExportPdf.Interfaces;

/// <summary>
/// Process the Section.
/// </summary>
public interface ISectionService
{
    public void ProcessFields(Document document, Section section,Dictionary<string,object> data);
}
