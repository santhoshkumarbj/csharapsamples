using Czm.Czi.Maui.Aggregator.ExportPdf.Implementations;
using Czm.Czi.Maui.Aggregator.ExportPdf.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czm.Czi.Maui.Aggregator.ExportPdf.BootStrapper;

public static class PdfBootStraper
{
    public static void RegisterDependencies(this IServiceCollection services)
    {
        // Register three implementations
        services.AddScoped<ISectionService, PdfTextService>();
        services.AddScoped<ISectionService, PdfImageService>();
        services.AddScoped<ISectionService, PdfDataRowService>();
        services.AddScoped<ISectionServiceFactory, SectionServiceFactory>();
    }
}
