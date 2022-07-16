// Copyright 2022 Brent Johnson.
// Licensed under the Apache License, Version 2.0 (refer to the LICENSE file in the solution folder).

namespace TestPipeline.Package.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Calc_Add()
        {
            Assert.AreEqual(5, Calculator.Calc(2, 3, Calculator.Operator.Add));
        }

        // [TestMethod]
        // public void Calc_Exception()
        // {
        //     Assert.ThrowsException<NotImplementedException>(() => Calculator.Calc(2, 3, Calculator.Operator.None));
        // }
    }
}
