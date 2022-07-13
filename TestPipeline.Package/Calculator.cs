// Copyright 2022 Brent Johnson.
// Licensed under the Apache License, Version 2.0 (refer to the LICENSE file in the solution folder).

using TestPipeline.Common;

namespace TestPipeline.Package
{
    public static class Calculator
    {
        public enum Operator
        {
            None = 0,
            Add = 1,
        }

        public static int Calc(int value1, int value2, Operator op)
        {
            return op switch
            {
                Operator.Add => Adder.Add(value1, value2),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
