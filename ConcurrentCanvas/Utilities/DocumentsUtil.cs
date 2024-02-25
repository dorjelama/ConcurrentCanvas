using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentCanvas.Utilities
{
    public static class DocumentsUtil
    {
        public static List<string> GenerateSampleDocuments(int count)
        {
            List<string> sampleDocuments = new List<string>();
            for (int i = 0; i < count; i++)
            {
                sampleDocuments.Add($"This is document number {i + 1}.");
            }
            return sampleDocuments;
        }
    }
}
