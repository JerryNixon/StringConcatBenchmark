using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

using System;

namespace StringConcatBenchmark
{
    [SimpleJob]
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
            SampleData.Source.ForEach(x => sb.Append(x));
            var result = sb.ToString();
            _consumer.Consume(result);
            return result;
        }

        private string RunLoop(Func<string, string, string> func)
        {
            var result = string.Empty;
            SampleData.Source.ForEach(x => result = func(result, x));
            _consumer.Consume(result);
            return result;
        }
    }
}