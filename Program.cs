using System;
using System.Linq;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

using FluentAssertions;

namespace StringConcatBenchmark
{
    public class Program
    {
        public static string[] data
            = Enumerable.Range(1, 10).Select(x => Guid.NewGuid().ToString()).ToArray();

        public static string result
            = data.Aggregate((a, b) => string.Concat(a, b));

        public static void Main(string[] args)
            => BenchmarkRunner.Run<Tests>();
    }

    public class Tests
    {
        [Benchmark(Baseline = true)]
        public void StringPlusString()
        {
            var result = string.Empty;
            foreach (var item in Program.data)
            {
                result = result + item;
            }
            result.Should().BeEquivalentTo(Program.result);
        }

        [Benchmark]
        public void StringPlusEqualsString()
        {
            var result = string.Empty;
            foreach (var item in Program.data)
            {
                result += item;
            }
            result.Should().BeEquivalentTo(Program.result);
        }

        [Benchmark]
        public void StringInterpolation()
        {
            var result = string.Empty;
            foreach (var item in Program.data)
            {
                result = $"{result}{item}";
            }
            result.Should().BeEquivalentTo(Program.result);
        }

        [Benchmark]
        public void StringFormat()
        {
            var result = string.Empty;
            foreach (var item in Program.data)
            {
                result = string.Format("{0}{1}", result, item);
            }
            result.Should().BeEquivalentTo(Program.result);
        }

        [Benchmark]
        public void StringConcat()
        {
            var result = string.Empty;
            foreach (var item in Program.data)
            {
                result = string.Concat(result, item);
            }
            result.Should().BeEquivalentTo(Program.result);
        }

        [Benchmark]
        public void StringJoin()
        {
            var result = string.Empty;
            foreach (var item in Program.data)
            {
                result = string.Join(string.Empty, result, item);
            }
            result.Should().BeEquivalentTo(Program.result);
        }

        [Benchmark]
        public void StringBuilder()
        {
            var sb = new System.Text.StringBuilder();
            foreach (var item in Program.data)
            {
                sb.Append(item);
            }
            var result = sb.ToString();
            result.Should().BeEquivalentTo(Program.result);
        }
    }
}