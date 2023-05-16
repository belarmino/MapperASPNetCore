﻿# ASP.NET Core object mapper 
## Benchmarks AutoMapper versus Mapster

## Run a project
```
dotnet run --configuration Release 
```

## To create a new project
### Create a console project
```
dotnet new console -o MapperASPNetCore
cd MapperASPNetCore
dotnet new gitignore
```

### Benchmarks result

|     Method |            Mean |         Error |        StdDev |   Gen0 |   Gen1 | Allocated |
|----------- |----------------:|--------------:|--------------:|-------:|-------:|----------:|
|    Mapster |        53.12 ns |      0.737 ns |      0.616 ns | 0.0191 |      - |     160 B |
| AutoMapper | 1,093,140.90 ns | 20,669.889 ns | 19,334.627 ns | 9.7656 | 3.9063 |   90678 B |

### Libraries
```
dotnet add package AutoMapper
dotnet add package Mapster
dotnet add package BenchmarkDotNet
```