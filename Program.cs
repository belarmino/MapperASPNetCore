
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using MapperASPNetCore;


//new Maps().AutoMapper();
Summary summary = BenchmarkRunner.Run<Map>();

//Console.WriteLine("OLA");
