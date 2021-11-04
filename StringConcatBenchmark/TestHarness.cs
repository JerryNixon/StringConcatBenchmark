
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace StringConcatBenchmark
{
    [ShortRunJob]
    [MemoryDiagnoser]
    public class TestHarness
    {
        private readonly Consumer _consumer = new();

        [Benchmark(Baseline = true)]
        public string StringPlus()
        {
            var result = string.Empty;
            foreach (var item in SampleData.data)
            {
                result = result + item;
            }
            _consumer.Consume(result);
            return result;
        }

        [Benchmark]
        public string StringPlusEquals()
        {
            var result = string.Empty;
            foreach (var item in SampleData.data)
            {
                result += item;
            }
            _consumer.Consume(result);
            return result;
        }

        [Benchmark]
        public string StringInterpolation()
        {
            var result = string.Empty;
            foreach (var item in SampleData.data)
            {
                result = $"{result}{item}";
            }
            _consumer.Consume(result);
            return result;
        }

        [Benchmark]
        public string StringFormat()
        {
            var result = string.Empty;
            foreach (var item in SampleData.data)
            {
                result = string.Format("{0}{1}", result, item);
            }
            _consumer.Consume(result);
            return result;
        }

        [Benchmark]
        public string StringConcat()
        {
            var result = string.Empty;
            foreach (var item in SampleData.data)
            {
                result = string.Concat(result, item);
            }
            _consumer.Consume(result);
            return result;
        }

        [Benchmark]
        public string StringJoin()
        {
            var result = string.Empty;
            foreach (var item in SampleData.data)
            {
                result = string.Join(string.Empty, result, item);
            }
            _consumer.Consume(result);
            return result;
        }

        [Benchmark]
        public string StringBuilder()
        {
            var sb = new System.Text.StringBuilder();
            foreach (var item in SampleData.data)
            {
                sb.Append(item);
            }
            var result = sb.ToString();
            _consumer.Consume(result);
            return result;
        }
    }
}