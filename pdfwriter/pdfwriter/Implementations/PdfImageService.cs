using iText.IO.Image;
using iText.Layout;
using iText.Layout.Element;
using pdfwriter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdfwriter.Implementations
{
    public class PdfImageService : ISectionService
    {
        public void ProcessFields(Document document, Section section)
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
