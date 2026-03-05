using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class ImgGenerationReport:CVGenerationReport
    {
        public override Data ExtractData(string file)
        {
            return new() { Message = "Extracting using AI Model and convert to string" };
        }

        public void PdfGenerateReport()
        {
            Console.WriteLine(ReadFile());
            Console.WriteLine(ExtractData(ReadFile()).Message);
            Console.WriteLine(AnalyzedData(ExtractData(ReadFile())));
            Console.WriteLine(GenerateReport(AnalyzedData(ExtractData(ReadFile()))));

        }
    }
}
