using System;
using System.Linq;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Running;

using Perfolizer.Mathematics.OutlierDetection;

namespace StringConcatBenchmark
{
    public class Program
    {
        public static string[] data = Enumerable
            .Range(1, 1000).Select(x => Guid.NewGuid().ToString()).ToArray();

        public static void Main(string[] args)
            => BenchmarkRunner.Run<Tests>();
    }

    public class Tests
    {
        [Benchmark(Baseline = true)]
        public void _1() 
        {
            var result = string.Empty;
            foreach (var item in Program.data)
            {
                result += item;
            }
        }

        [Benchmark]
        public void _2()
        {
            var result = string.Empty;
            foreach (var item in Program.data)
            {
                result = result + item;
            }
        }

        [Benchmark]
        public void _3()
        {
            var result = string.Empty;
            foreach (var item in Program.data)
            {
                result = string.Concat(result, item);
            }
        }

        [Benchmark]
        public void _4()
        {
            var result = string.Empty;
            foreach (var item in Program.data)
            {
                result = result.Concat(item).ToString();
            }
        }


        [Benchmark]
        public void _5()
        {
            var result = string.Empty;
            foreach (var item in Program.data)
            {
                result = string.Join(string.Empty, result, item);
            }
        }
    }
}