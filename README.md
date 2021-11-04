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
|              Method |        Mean |        Error |    StdDev | Ratio | RatioSD |     Gen 0 |    Gen 1 | Allocated |
|-------------------- |------------:|-------------:|----------:|------:|--------:|----------:|---------:|----------:|
|          StringPlus | 2,593.18 μs | 1,039.173 μs | 56.961 μs | 1.000 |    0.00 | 5710.9375 | 996.0938 | 35,215 KB |
|    StringPlusEquals | 2,591.22 μs | 1,686.077 μs | 92.420 μs | 1.000 |    0.06 | 5710.9375 | 996.0938 | 35,215 KB |
| StringInterpolation | 2,420.02 μs |   204.510 μs | 11.210 μs | 0.934 |    0.02 | 5710.9375 | 996.0938 | 35,215 KB |
|        StringFormat | 3,347.90 μs |   303.823 μs | 16.654 μs | 1.292 |    0.03 | 5710.9375 | 996.0938 | 35,215 KB |
|        StringConcat | 2,450.88 μs |   431.706 μs | 23.663 μs | 0.945 |    0.03 | 5710.9375 | 996.0938 | 35,215 KB |
|          StringJoin | 2,568.47 μs |   660.999 μs | 36.232 μs | 0.991 |    0.01 | 5718.7500 | 996.0938 | 35,254 KB |
|       StringBuilder |    16.62 μs |     2.496 μs |  0.137 μs | 0.006 |    0.00 |   24.6887 |   6.1646 |    152 KB |
