``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Unknown processor
.NET Core SDK=3.1.400
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-GUNMTB : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=JsonSerializer  

```
|      Method | CollectionCount |         Mean |      Error |     StdDev |    Gen 0 |    Gen 1 |    Gen 2 |  Allocated |
|------------ |---------------- |-------------:|-----------:|-----------:|---------:|---------:|---------:|-----------:|
| **Deserialize** |              **25** |    **270.09 μs** |   **3.649 μs** |   **3.413 μs** |   **7.3242** |   **0.4883** |        **-** |   **69.93 KB** |
| Deserialize |              25 |    264.34 μs |   2.919 μs |   2.730 μs |   9.2773 |        - |        - |   89.17 KB |
| Deserialize |              50 |    539.74 μs |   8.906 μs |   8.747 μs |  13.6719 |   0.9766 |        - |  132.03 KB |
| Deserialize |              50 |    549.33 μs |   0.360 μs |   0.301 μs |  18.5547 |        - |        - |   178.1 KB |
| Deserialize |             100 |  1,109.78 μs |  11.922 μs |   9.955 μs |  25.3906 |        - |        - |  242.93 KB |
| Deserialize |             100 |  1,041.52 μs |   2.084 μs |   1.741 μs |  37.1094 |        - |        - |  355.53 KB |
| Deserialize |             250 |  2,681.45 μs |  11.379 μs |   9.502 μs |  54.6875 |  27.3438 |   7.8125 |  573.27 KB |
| Deserialize |             250 |  2,528.86 μs |   4.726 μs |   4.189 μs |  93.7500 |        - |        - |  884.57 KB |
| Deserialize |             500 |  5,396.97 μs |  66.744 μs |  55.734 μs |  54.6875 |  39.0625 |  15.6250 | 1137.68 KB |
| Deserialize |             500 |  5,154.73 μs |  54.347 μs |  48.177 μs | 187.5000 |        - |        - | 1776.85 KB |
| Deserialize |            1000 | 10,908.04 μs |  43.156 μs |  38.257 μs |  78.1250 |  62.5000 |  31.2500 | 2290.21 KB |
| Deserialize |            1000 | 10,159.18 μs |  25.091 μs |  20.952 μs | 390.6250 |        - |        - | 3553.63 KB |
|   **Serialize** |              **25** |     **83.29 μs** |   **0.715 μs** |   **0.634 μs** |   **7.6904** |   **0.2441** |        **-** |   **72.88 KB** |
|   Serialize |              50 |    161.99 μs |   0.220 μs |   0.172 μs |  16.6016 |   1.7090 |        - |  147.72 KB |
|   Serialize |             100 |    367.31 μs |   7.260 μs |  15.936 μs |  31.2500 |  12.2070 |   9.2773 |  288.84 KB |
|   Serialize |             250 |  1,047.57 μs |  22.007 μs |  64.542 μs |  70.3125 |  60.5469 |  60.5469 |  670.05 KB |
|   Serialize |             500 |  1,883.92 μs |  37.431 μs |  45.968 μs | 134.7656 | 132.8125 | 132.8125 | 1321.98 KB |
|   Serialize |            1000 |  4,917.42 μs | 104.913 μs | 307.693 μs | 257.8125 | 242.1875 | 242.1875 | 2712.52 KB |
