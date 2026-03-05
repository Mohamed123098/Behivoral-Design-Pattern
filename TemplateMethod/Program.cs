namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new PdfGenerationReport() { FilePath = "Pdfs/cvs.pdf" }.PdfGenerateReport();
            Console.WriteLine("========================================");
            new WordGenerationReport() { FilePath = "Words/cvs.pdf" }.WordGenerateReport();
            Console.WriteLine("========================================");
            new ImgGenerationReport() { FilePath = "Images/cvs.pdf" }.ImgGenerateReport();

        }
    }
}
