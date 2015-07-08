using System;
using System.IO;
using Xunit;

namespace StreamWriterTests
{
    public class FlushTests
    {
        [Fact]
        public static void AutoFlushSetTrue()
        {
            // [] Set the autoflush to true
            var sw2 = new StreamWriter(new MemoryStream());
            sw2.AutoFlush = true;
            Assert.True(sw2.AutoFlush);
        }

        [Fact]
        public static void AutoFlushSetFalse()
        {
            // [] Set autoflush to false
            var sw2 = new StreamWriter(new MemoryStream());
            sw2.AutoFlush = false;
            Assert.False(sw2.AutoFlush);
        }
    }
}
