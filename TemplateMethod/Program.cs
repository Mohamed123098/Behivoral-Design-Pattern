namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new PdfGenerationReport() { FilePath = "Pdfs/cvs.pdf" }.PdfGenerateReport();
        }
    }
}
