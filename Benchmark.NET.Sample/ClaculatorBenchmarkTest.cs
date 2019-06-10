using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark.NET.Sample
{
    [MinColumn, MaxColumn]
    [MarkdownExporter, AsciiDocExporter, HtmlExporter, CsvExporter, RPlotExporter]
    public class ClaculatorBenchmarkTest
    {
        [Params(1,2)]
        public long Number { get; set; }

        [Benchmark]
        public  long  Square_Performace_Test()
        {
            return Calculator.Square(Number);
        }
    }
}
