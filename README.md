Jump to the [script](StringConcatBenchmark/TestHarness.cs).

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1288 (21H1/May2021Update)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.403
  [Host]     : .NET 5.0.12 (5.0.1221.52207), X64 RyuJIT
  DefaultJob : .NET 5.0.12 (5.0.1221.52207), X64 RyuJIT


```
|                 Method |        Mean |     Error |    StdDev | Ratio | RatioSD |     Gen 0 |    Gen 1 | Allocated |
|----------------------- |------------:|----------:|----------:|------:|--------:|----------:|---------:|----------:|
|             StringPlus | 2,125.08 μs | 40.367 μs | 39.646 μs | 1.000 |    0.00 | 5710.9375 | 996.0938 | 35,215 KB |
|       StringPlusEquals | 2,074.72 μs | 38.058 μs | 31.780 μs | 0.977 |    0.03 | 5710.9375 | 996.0938 | 35,215 KB |
| StringPlusEqualsScrewy | 2,023.71 μs | 10.490 μs |  8.760 μs | 0.953 |    0.02 | 5710.9375 | 996.0938 | 35,215 KB |
|    StringInterpolation | 2,054.35 μs | 39.600 μs | 40.666 μs | 0.968 |    0.03 | 5710.9375 | 996.0938 | 35,215 KB |
|           StringFormat | 2,919.17 μs | 54.434 μs | 48.254 μs | 1.374 |    0.02 | 5710.9375 | 996.0938 | 35,215 KB |
|           StringConcat | 2,067.46 μs | 34.648 μs | 32.410 μs | 0.973 |    0.03 | 5710.9375 | 996.0938 | 35,215 KB |
|             StringJoin | 2,192.57 μs | 41.060 μs | 84.797 μs | 1.017 |    0.03 | 5718.7500 | 996.0938 | 35,254 KB |
|          StringBuilder |    14.00 μs |  0.247 μs |  0.243 μs | 0.007 |    0.00 |   24.6887 |   6.1646 |    152 KB |
