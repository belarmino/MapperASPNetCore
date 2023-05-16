
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using MapperASPNetCore;

Summary summary = BenchmarkRunner.Run<Map>();