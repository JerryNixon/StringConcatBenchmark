Jump to the [script](StringConcatBenchmark/Program.cs).

<!--
<style>
  th { white-space: nowrap; }
  td { white-space: nowrap; }
</style>
-->

### Benchmark results

|              Method |        Mean |        Error |     StdDev | Ratio | RatioSD |     Gen 0 |    Gen 1 | Allocated |
|-------------------- |------------:|-------------:|-----------:|------:|--------:|----------:|---------:|----------:|
|          StringPlus | 2,479.65    |   227.904    |  12.492    | 1.000 |    0.00 | 5710.9375 | 996.0938 | 35,215KB |
|    StringPlusEquals | 2,589.00    | 1,307.516    |  71.669    | 1.044 |    0.03 | 5710.9375 | 996.0938 | 35,215KB |
| StringInterpolation | 2,519.11    | 1,423.543    |  78.029    | 1.016 |    0.04 | 5710.9375 | 996.0938 | 35,215KB |
|        StringFormat | 3,394.15    | 2,452.455    | 134.427    | 1.369 |    0.06 | 5710.9375 | 996.0938 | 35,215KB |
|        StringConcat | 2,498.38    |    98.618    |   5.406    | 1.008 |    0.01 | 5710.9375 | 996.0938 | 35,215KB |
|          StringJoin | 2,633.26    |   146.095    |   8.008    | 1.062 |    0.00 | 5718.7500 | 996.0938 | 35,254KB |
|       StringBuilder |    16.68    |     1.683    |   0.092    | 0.007 |    0.00 |   24.6887 |   6.9885 |    152KB |
