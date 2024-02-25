using BenchmarkDotNet.Attributes;
using ConcurrentCanvas.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentCanvas.Processes
{
    public class DocumentProcessorUsingParallelForEach
    {
        private List<string> documents;

        [Params(10000)] // Adjust the number of documents for benchmarking
        public int N;

        [GlobalSetup]
        public void Setup()
        {
            documents = DocumentsUtil.GenerateSampleDocuments(N);
        }

        [Benchmark]
        public void ParallelForEachBenchmark()
        {
            Parallel.ForEach(documents, (document) =>
            {
                int wordCount = CountWords(document);
            });
        }

        [Benchmark]
        public void ForeachBenchmark()
        {
            foreach (var document in documents)
            {
                int wordCount = CountWords(document);
            }
        }

        [Benchmark]
        public void ForLoopBenchmark()
        {
            for (int i = 0; i < documents.Count; i++)
            {
                int wordCount = CountWords(documents[i]);
            }
        }
        public int CountWords(string document)
        {
            // Handle special characters by replacing them with spaces
            var cleanedDocument = new string(document.Select(c => char.IsLetterOrDigit(c) ? c : ' ').ToArray());

            // Split the document into words and count them
            return cleanedDocument.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
