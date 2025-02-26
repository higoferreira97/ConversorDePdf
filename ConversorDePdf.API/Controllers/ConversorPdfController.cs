using ConversorDePdf.API.Controllers.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace ConversorDePdf.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConversorPdfController : Controller
    {
        [HttpGet]
        public async Task<ActionResult> converterArquivo()
        {
            var basePath = Directory.GetCurrentDirectory();
            var arquivo = Path.Combine(basePath, "uploads", "teste.docx");

            var arquivoPdf = PdfHelper.convertToPdf(arquivo);

            return File(arquivoPdf, "application/pdf", "teste.pdf");
        }
    }
}
