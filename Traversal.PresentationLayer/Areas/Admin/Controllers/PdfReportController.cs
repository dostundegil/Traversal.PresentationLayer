using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace Traversal.PresentationLayer.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StaticPdfResult()
        {
            var name = Guid.NewGuid().ToString();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + name + ".pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();
            Paragraph paragraph = new Paragraph("Traversal Rezervasyon Pdf Raporu");
            document.Add(paragraph);
            document.Close();
            return File("/pdfreports/"+name + ".pdf","application/pdf",name+".pdf");

        }

        public IActionResult StaticCustomerReport()
        {
            var name = Guid.NewGuid().ToString();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + name + ".pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();

            PdfPTable pdfPTable = new PdfPTable(2);

            pdfPTable.AddCell("Misafir Adı");
            pdfPTable.AddCell("Misafir Tc");

            pdfPTable.AddCell("Eylül Yücedağ");
            pdfPTable.AddCell("11111111111");

            pdfPTable.AddCell("Kelam Yıldırım");
            pdfPTable.AddCell("11111111111");

            pdfPTable.AddCell("Mehmet Kızılcık");
            pdfPTable.AddCell("11111111111");

            document.Add(pdfPTable);
            document.Close();
            return File("/pdfreports/" + name + ".pdf", "application/pdf", name + ".pdf");
        }
    }
}
