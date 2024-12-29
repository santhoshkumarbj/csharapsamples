using Czm.Czi.Maui.Aggregator.ExportPdf.BootStrapper;
using Czm.Czi.Maui.Aggregator.ExportPdf.Interfaces;
using Czm.Czi.Maui.Aggregator.ExportPdf.Model;
using iText.Kernel.Pdf;
using iText.Layout;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czm.Czi.Maui.Aggregator.ExportPdf.Implementations;

/// <summary>
/// Entry point for the chat export.
/// </summary>
public class PdfManager : IPdfManager
{
    TextManager _pdfManager;
    public PdfManager(IServiceCollection serviceCollection,TextManager pdfManager) 
    { 
        serviceCollection.RegisterDependencies();
        _pdfManager = pdfManager;
    }

    public void GeneratePdf(string fileName, Dictionary<string, object> data)
    {
        _pdfManager.ProcessTemplate(fileName, data);
    }
}
