Jump to the [script](StringConcatBenchmark/TestHarness.cs).

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1288 (21H1/May2021Update)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.208
  [Host]   : .NET 5.0.11 (5.0.1121.47308), X64 RyuJIT
  ShortRun : .NET 5.0.11 (5.0.1121.47308), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|              Method |        Mean |       Error |     StdDev | Ratio | RatioSD |     Gen 0 |    Gen 1 | Allocated |
|-------------------- |------------:|------------:|-----------:|------:|--------:|----------:|---------:|----------:|
|          StringPlus | 2,592.44 μs |   793.79 μs |  43.510 μs | 1.000 |    0.00 | 5710.9375 | 996.0938 | 35,215 KB |
|    StringPlusEquals | 2,688.16 μs | 1,510.27 μs |  82.783 μs | 1.037 |    0.05 | 5710.9375 | 996.0938 | 35,215 KB |
| StringInterpolation | 2,905.44 μs | 1,869.63 μs | 102.480 μs | 1.121 |    0.04 | 5710.9375 | 996.0938 | 35,215 KB |
|        StringFormat | 3,465.17 μs | 1,369.66 μs |  75.076 μs | 1.337 |    0.02 | 5710.9375 | 992.1875 | 35,215 KB |
|        StringConcat | 2,927.40 μs | 3,236.47 μs | 177.402 μs | 1.129 |    0.05 | 5710.9375 | 996.0938 | 35,215 KB |
|          StringJoin | 4,033.19 μs | 8,600.80 μs | 471.439 μs | 1.557 |    0.20 | 5718.7500 | 996.0938 | 35,254 KB |
|       StringBuilder |    20.71 μs |    13.61 μs |   0.746 μs | 0.008 |    0.00 |   24.6887 |   6.1646 |    152 KB |
