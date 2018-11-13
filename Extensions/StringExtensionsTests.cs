using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Extensions
{
    public class StringExtensionsTests
    {
        [Fact]
        public void RemoveSpacesTest_Pass()
        {
            var inputString = "This is a test";
            var desiredOutput = "Thisisatest";

            Assert.Equal(desiredOutput, inputString.RemoveSpaces());
        }
    }
}
