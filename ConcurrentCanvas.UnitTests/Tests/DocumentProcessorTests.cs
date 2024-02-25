using ConcurrentCanvas.Processes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentCanvas.UnitTests.Tests
{
    public class DocumentProcessorTests
    {
        DocumentProcessorUsingParallelForEach documentProcessor = new();

        [Fact]
        public void CountWords_ShouldReturnCorrectWordCount()
        {
            // Arrange
            var document = "This is a sample document for testing.";

            // Act
            var wordCount = documentProcessor.CountWords(document);

            // Assert
            Assert.Equal(7, wordCount);
        }

        [Fact]
        public void CountWords_ShouldReturnZeroForEmptyDocument()
        {
            // Arrange
            var emptyDocument = string.Empty;

            // Act
            var wordCount = documentProcessor.CountWords(emptyDocument);

            // Assert
            Assert.Equal(0, wordCount);
        }
    }
}
