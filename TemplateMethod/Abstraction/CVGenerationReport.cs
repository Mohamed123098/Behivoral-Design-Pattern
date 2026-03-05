using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal abstract class CVGenerationReport
    {
        public string FilePath { get; set; }
        public string ReadFile()
        {
            return $"Reading File {FilePath}";
        }
        public abstract Data ExtractData(string file);
        public DataAnalyzed AnalyzedData(Data data)
        {
            return new() { Message = "Analyzing Data from file" };
        }
        public GeneratedReport GenerateReport(DataAnalyzed dataAnalyzed)
        {
            return new() { Message = "Generating Report" };
        }
    }
}
