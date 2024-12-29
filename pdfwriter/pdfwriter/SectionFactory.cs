using Microsoft.Extensions.DependencyInjection;
using pdfwriter.Implementations;
using pdfwriter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdfwriter;

public static class DependencyRegistrationBoostrapper
{
    //public static void RegisterDependencies(this IServiceCollection services)
    //{
    //    // Register three implementations
    //    services.AddScoped<ISectionService, PdfTextService>();
    //    services.AddScoped<ISectionService, PdfImageService>();
    //    services.AddScoped<ISectionService, Pdf>();

    //}

}
