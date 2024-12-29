using iText.Layout;

namespace pdfwriter.Interface
{
    /// <summary>
    /// Process the Section.
    /// </summary>
    public interface ISectionService
    {
        public void ProcessFields(Document document, Section section);
    }
}
