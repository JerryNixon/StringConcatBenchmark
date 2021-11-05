Jump to the [script](StringConcatBenchmark/TestHarness.cs).

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1288 (21H1/May2021Update)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.208
  [Host]     : .NET 5.0.11 (5.0.1121.47308), X64 RyuJIT
  DefaultJob : .NET 5.0.11 (5.0.1121.47308), X64 RyuJIT


```
|              Method |        Mean |     Error |    StdDev | Ratio | RatioSD |     Gen 0 |    Gen 1 | Allocated |
|-------------------- |------------:|----------:|----------:|------:|--------:|----------:|---------:|----------:|
|          StringPlus | 2,471.13 μs | 32.002 μs | 29.934 μs | 1.000 |    0.00 | 5710.9375 | 996.0938 | 35,215 KB |
|    StringPlusEquals | 2,543.84 μs | 47.184 μs | 86.280 μs | 1.034 |    0.05 | 5710.9375 | 996.0938 | 35,215 KB |
| StringInterpolation | 2,452.96 μs | 33.213 μs | 31.068 μs | 0.993 |    0.02 | 5710.9375 | 996.0938 | 35,215 KB |
|        StringFormat | 3,351.85 μs | 65.407 μs | 82.719 μs | 1.354 |    0.03 | 5710.9375 | 996.0938 | 35,215 KB |
|        StringConcat | 2,485.60 μs | 49.401 μs | 43.792 μs | 1.007 |    0.02 | 5710.9375 | 996.0938 | 35,215 KB |
|          StringJoin | 2,558.27 μs | 48.466 μs | 53.870 μs | 1.036 |    0.03 | 5718.7500 | 996.0938 | 35,254 KB |
|       StringBuilder |    16.58 μs |  0.319 μs |  0.283 μs | 0.007 |    0.00 |   24.6887 |   6.1646 |    152 KB |
