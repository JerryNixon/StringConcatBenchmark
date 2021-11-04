Jump to the [script](Program.cs).

<!--
<style>
  th { white-space: nowrap; }
  td { white-space: nowrap; }
</style>
-->

# Benchmark results

|              Method |        Mean |        Error |     StdDev | Ratio | RatioSD |     Gen 0 |    Gen 1 | Allocated |
|-------------------- |------------:|-------------:|-----------:|------:|--------:|----------:|---------:|----------:|
|          StringPlus | 2,479.65 us |   227.904 us |  12.492 us | 1.000 |    0.00 | 5710.9375 | 996.0938 | 35,215 KB |
|    StringPlusEquals | 2,589.00 us | 1,307.516 us |  71.669 us | 1.044 |    0.03 | 5710.9375 | 996.0938 | 35,215 KB |
| StringInterpolation | 2,519.11 us | 1,423.543 us |  78.029 us | 1.016 |    0.04 | 5710.9375 | 996.0938 | 35,215 KB |
|        StringFormat | 3,394.15 us | 2,452.455 us | 134.427 us | 1.369 |    0.06 | 5710.9375 | 996.0938 | 35,215 KB |
|        StringConcat | 2,498.38 us |    98.618 us |   5.406 us | 1.008 |    0.01 | 5710.9375 | 996.0938 | 35,215 KB |
|          StringJoin | 2,633.26 us |   146.095 us |   8.008 us | 1.062 |    0.00 | 5718.7500 | 996.0938 | 35,254 KB |
|       StringBuilder |    16.68 us |     1.683 us |   0.092 us | 0.007 |    0.00 |   24.6887 |   6.9885 |    152 KB |
