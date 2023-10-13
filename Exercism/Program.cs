// See https://aka.ms/new-console-template for more information
using Exercism.IntegralNumbers;

byte[] arr = HyperOptimizedTelemetry.ToBuffer(Int16.MaxValue);
Console.WriteLine(BitConverter.ToString(arr));
Console.WriteLine(HyperOptimizedTelemetry.FromBuffer(arr));
