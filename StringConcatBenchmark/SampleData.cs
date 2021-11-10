using System;
using System.Collections.Generic;
using System.Linq;

namespace StringConcatBenchmark
{
    public static class SampleData
    {
        public static readonly List<string> Source
            = Enumerable
                .Range(1, 1000)
                .Select(x => Guid.NewGuid().ToString())
                .ToList();

        public static readonly string Result
            = Source.Aggregate((a, b) => string.Concat(a, b));
    }
}