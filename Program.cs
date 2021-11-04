using System;
using System.Linq;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace StringConcatBenchmark
{
    public class Program
    {
        public static string[] data
            = Enumerable.Range(1, 1000).Select(x => Guid.NewGuid().ToString()).ToArray();

        public static string result
            = data.Aggregate((a, b) => string.Concat(a, b));

        public static void Main(string[] args)
            => BenchmarkRunner.Run<TestHarness>();
    }

    public class TestHarness
    {
        [Benchmark(Baseline = true)]
        public string StringPlusString()
        {
            var result = string.Empty;
            foreach (var item in Program.data)
            {
                result = result + item;
            }
            return result;
        }

        [Benchmark]
        public string StringPlusEqualsString()
        {
            var result = string.Empty;
            foreach (var item in Program.data)
            {
                result += item;
            }
            return result;
        }

        [Benchmark]
        public string StringInterpolation()
        {
            var result = string.Empty;
            foreach (var item in Program.data)
            {
                result = $"{result}{item}";
            }
            return result;
        }

        [Benchmark]
        public string StringFormat()
        {
            var result = string.Empty;
            foreach (var item in Program.data)
            {
                result = string.Format("{0}{1}", result, item);
            }
            return result;
        }

        [Benchmark]
        public string StringConcat()
        {
            var result = string.Empty;
            foreach (var item in Program.data)
            {
                result = string.Concat(result, item);
            }
            return result;
        }

        [Benchmark]
        public string StringJoin()
        {
            var result = string.Empty;
            foreach (var item in Program.data)
            {
                result = string.Join(string.Empty, result, item);
            }
            return result;
        }

        [Benchmark]
        public string StringBuilder()
        {
            var sb = new System.Text.StringBuilder();
            foreach (var item in Program.data)
            {
                sb.Append(item);
            }
            return sb.ToString();
        }
    }
}