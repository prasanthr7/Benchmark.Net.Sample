﻿using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark.NET.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = BenchmarkRunner.Run<ClaculatorBenchmarkTest>();
        }
    }
}
