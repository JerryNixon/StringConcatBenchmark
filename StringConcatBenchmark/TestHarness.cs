
using BenchmarkDotNet.Attributes;

namespace StringConcatBenchmark
{
    [ShortRunJob]
    [MemoryDiagnoser]
    public class TestHarness
    {
        [Benchmark(Baseline = true)]
        public string StringPlus()
        {
            var result = string.Empty;
            foreach (var item in Program.data)
            {
                result = result + item;
            }
            return result;
        }

        [Benchmark]
        public string StringPlusEquals()
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