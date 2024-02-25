using BenchmarkDotNet.Running;
using ConcurrentCanvas.Processes;

namespace ConcurrentCanvas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Running Benchmark for Document Processor to compare performance using different loop approaches.
            BenchmarkRunner.Run<DocumentProcessorUsingParallelForEach>();

        }
    }
}
