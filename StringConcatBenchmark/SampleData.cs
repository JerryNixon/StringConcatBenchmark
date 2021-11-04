using System;
using System.Linq;

namespace StringConcatBenchmark
{
    public static class SampleData
    {
        public static readonly string[] data
            = Enumerable
                .Range(1, 1000)
                .Select(x => Guid.NewGuid().ToString())
                .ToArray();

        public static readonly string result
            = data.Aggregate((a, b) => string.Concat(a, b));
    }
}