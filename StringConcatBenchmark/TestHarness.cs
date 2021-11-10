
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

using System;

namespace StringConcatBenchmark
{
    [MemoryDiagnoser]
    public class TestHarness
    {
        private readonly Consumer _consumer = new();

        [Benchmark(Baseline = true)]
        public string StringPlus() => RunLoop((a, b) => a + b);

        [Benchmark]
        public string StringPlusEquals() => RunLoop((a, b) => a += b);

        [Benchmark]
        public string StringPlusEqualsScrewy() => RunLoop((a, b) => a = a += b);

        [Benchmark]
        public string StringInterpolation() => RunLoop((a, b) => $"{a}{b}");

        [Benchmark]
        public string StringFormat() => RunLoop((a, b) => string.Format("{0}{1}", a, b));

        [Benchmark]
        public string StringConcat() => RunLoop((a, b) => string.Concat(a, b));

        [Benchmark]
        public string StringJoin() => RunLoop((a, b) => string.Join(string.Empty, a, b));

        [Benchmark]
        public string StringBuilder()
        {
            var sb = new System.Text.StringBuilder();
            foreach (var item in SampleData.Source)
            {
                sb.Append(item);
            }
            return Consume(sb.ToString());
        }

        private string Consume(string value)
        {
            _consumer.Consume(value);
            return value;
        }

        private string RunLoop(Func<string, string, string> func)
        {
            var result = string.Empty;
            foreach (var item in SampleData.Source)
            {
                result = func(result, item);
            }
            return Consume(result);
        }
    }
}