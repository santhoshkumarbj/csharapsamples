// See https://aka.ms/new-console-template for more information

using Czm.Czi.Maui.Aggregator.ExportPdf.BootStrapper;
using Czm.Czi.Maui.Aggregator.ExportPdf.Implementations;
using Czm.Czi.Maui.Aggregator.ExportPdf.Interfaces;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Org.BouncyCastle.Asn1.Mozilla;
using Org.BouncyCastle.Asn1.X509;
using pdfwriter;
using pdfwriter.Implementations;
using System.Drawing;
using System.Reflection.PortableExecutable;
using System.Text.Json;
using System.Text.Json.Serialization;

Console.WriteLine("Hello, World!");

//var serviceProvider = new ServiceCollection().RegisterDependencies();
var eventDetails = new EventDetails()
{
    EventName = "First treatment for covid",
    EventStartedDateTime = DateTime.Now.ToString(),
    Prefix = "Mr",
    FirstName = "Karthigeyan",
    MiddleName = "Gunaseelan"
};

var data = new Dictionary<string, object>();
data.Add(eventDetails.GetType().ToString(), eventDetails);
var serviceProvider = new ServiceCollection();
serviceProvider.AddScoped<ITemplateManager, TextManager>();
serviceProvider.AddScoped<IPdfManager, PdfManager>();

var pdfManager = serviceProvider.FirstOrDefault(item => item.ImplementationType == typeof(PdfManager));
pdfManager.get
//pdfManager.GeneratePdf("Demo.pdf", data);
//Font font = new PdfFont();
//string chatTemplate = File.ReadAllText("ChatTemplate.json");
//var chatHistory = JsonConvert.DeserializeObject<ChatHistory>(chatTemplate);
//PdfWriter writer = new PdfWriter("demo.pdf");
//PdfDocument pdf = new PdfDocument(writer);
//Document document = new Document(pdf);
//foreach(var section in chatHistory.Sections)
//{
//    if (section.Type == SectionType.Image)
//    {
//        PdfImageService imageService = new PdfImageService();
//        imageService.ProcessFields(document, section);
//    }
//    else if (section.Type == SectionType.DataRow)
//    {

//        PdfTextService textService = new PdfTextService();
//        textService.DataRow = 
//        textService.ProcessFields(document, section);
//    }
//    else
//    {
//        PdfTextService textService = new PdfTextService();
//        textService.ProcessFields(document, section);   
//    }
//}
//document.Close();
Console.ReadLine();

public class EventDetails
{
    public string EventName { get; set; }

    public string Prefix { get; set; }

    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public string EventStartedDateTime { get; set; }
}
    public class ChatHistory
{
    public List<Section> Sections { get; set; }


}

public class Section
{
    public string Name { get; set; }

    public SectionType Type { get; set; }

    public List<DocumentLine> Lines { get; set; }

}

//Wrap need to check
public class DocumentLine
{
    public List<DocumentText> Texts { get; set; }

    public List<DocumentImage> Images { get; set; }

    public DocumentMargin Margin { get; set; }

}

public class DocumentMargin
{
    public int Top { get; set; }

    public int Bottom { get; set; }

    public int Left { get; set; }

    public int Right { get; set; }
}

public class DocumentImage
{
    public string ImagePath { get; set; }

    public DocumentImageDescription ImageDescription { get;set; }
}

public class DocumentImageDescription
{
    public DocumentSize Size { get; set; }

    public DocumentPosition Position { get; set; }
}

public class DocumentSize
{
    public int Height { get; set; }

    public int Width { get; set; }
}

public class DocumentPosition
{
    public int Left { get; set; }

    public int Bottom { get; set; }

    public int PageNumber { get; set; }
}


public class DocumentText
{
    public string Text { get; set; }

    public DocumentFont FontDescription { get; set; }
}

public class DocumentFont
{
    public int Size { get; set; }

    public string FontFamily { get; set; }

    public TextAlignment Alignment { get; set; }

    public TextFontStyle FontStyle { get; set; }
}

public enum TextFontStyle
{
    Bold,
    Normal,
    Italic
}

public enum SectionType
{
    Text,
    Image,
    DataRow,
    DataRows
}
