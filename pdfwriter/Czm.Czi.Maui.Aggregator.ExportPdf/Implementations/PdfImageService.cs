using Czm.Czi.Maui.Aggregator.ExportPdf.Interfaces;
using Czm.Czi.Maui.Aggregator.ExportPdf.Model;
using iText.IO.Image;
using iText.Layout;
using iText.Layout.Element;

namespace Czm.Czi.Maui.Aggregator.ExportPdf.Implementations
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Czm.Czi.Maui.Aggregator.ExportPdf.Interfaces.ISectionService" />
    public class PdfImageService : ISectionService
    {
        public void ProcessFields(Document document, Section section, Dictionary<string, object> data)
        {
            // throw new NotImplementedException();
            foreach (var item in section.Lines)
            {
                foreach (var documentImage in item.Images)
                {
                    ImageData imageData = ImageDataFactory.Create(documentImage.ImagePath);
                    // Create layout image object and provide parameters. Page number = 1
                    var imageProperty = documentImage.ImageDescription;
                    Image image = new Image(imageData).
                        ScaleAbsolute(imageProperty.Size.Width, imageProperty.Size.Height).
                        SetFixedPosition(imageProperty.Position.PageNumber,
                            imageProperty.Position.Left, imageProperty.Position.Bottom);
                    // This adds the image to the page
                    document.Add(image);
                }
            }
        }
    }
}
