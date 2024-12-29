using pdfwriter.Interface;

namespace pdfwriter.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISectionServiceFactory
    {
        ISectionService GetService(string token);
    }
}
