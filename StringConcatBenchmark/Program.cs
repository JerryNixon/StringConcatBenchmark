using System;
using System.Linq;

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
}