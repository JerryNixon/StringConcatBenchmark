
using BenchmarkDotNet.Running;

namespace StringConcatBenchmark
{
    public static class Program 
    {
        public static void Main(string[] args)
        => BenchmarkRunner.Run<TestHarness>();
    }
}