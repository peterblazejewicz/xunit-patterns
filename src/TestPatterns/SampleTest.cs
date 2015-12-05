using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace TestPatterns
{

    public class SampleTest
    {
        [Fact(DisplayName = "Passing Test")]
        public void PassingTest()
        {
            Assert.True(true);
        }

        [Fact(DisplayName = "Failing test")]
        public void FailingTest()
        {
            Assert.True(false);
        }


    }
}
