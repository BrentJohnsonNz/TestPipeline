// Copyright 2022 Brent Johnson.
// Licensed under the Apache License, Version 2.0 (refer to the LICENSE file in the solution folder).

namespace TestPipeline.Common.Test
{
    [TestClass]
    public class AdderTest
    {
        [TestMethod]
        public void Adder()
        {
            Assert.AreEqual(3, Common.Adder.Add(1, 2));
        }

        [TestMethod]
        public void Adder3()
        {
            Assert.AreEqual(6, Common.Adder.Add(1, 2, 3));
        }
    }
}
