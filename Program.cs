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
            = Enumerable.Range(1, 1000).Select(x => Guid.NewGuid().ToString()).ToArray();

        public static string result 
            = data.Aggregate((a, b) => string.Concat(a, b));

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
                result = result + item;
            }
            result.Should().BeEquivalentTo(Program.result);
        }

        [Benchmark]
        public void _2()
        {
            var result = string.Empty;
            foreach (var item in Program.data)
            {
                result += item;
            }
            result.Should().BeEquivalentTo(Program.result);
        }

        [Benchmark]
        public void _3()
        {
            var result = string.Empty;
            foreach (var item in Program.data)
            {
                result = string.Concat(result, item);
            }
            result.Should().BeEquivalentTo(Program.result);
        }

        [Benchmark]
        public void _4()
        {
            var result = string.Empty;
            foreach (var item in Program.data)
            {
                result = $"{result}{item}";
            }
            result.Should().BeEquivalentTo(Program.result);
        }


        [Benchmark]
        public void _5()
        {
            var result = string.Empty;
            foreach (var item in Program.data)
            {
                result = string.Join(string.Empty, result, item);
            }
            result.Should().BeEquivalentTo(Program.result);
        }
    }
}