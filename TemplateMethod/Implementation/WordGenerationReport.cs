using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class WordGenerationReport:CVGenerationReport
    {
        public override Data ExtractData(string file)
        {
            return new() { Message = "Extracting to string directly" };
        }

        public void WordGenerateReport()
        {
            Console.WriteLine(ReadFile());
            Console.WriteLine(ExtractData(ReadFile()).Message);
            Console.WriteLine(AnalyzedData(ExtractData(ReadFile())));
            Console.WriteLine(GenerateReport(AnalyzedData(ExtractData(ReadFile()))));

        }
    }
}
