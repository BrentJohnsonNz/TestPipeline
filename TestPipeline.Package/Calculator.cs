// Copyright 2022 Brent Johnson.
// Licensed under the Apache License, Version 2.0 (refer to the LICENSE file in the solution folder).

using TestPipeline.Common;

namespace TestPipeline.Package
{
    /// <summary>
    /// A calculator.
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        /// An enumerator.
        /// </summary>
        public enum Operator
        {
            /// <summary>None.</summary>
            None = 0,

            /// <summary>Add.</summary>
            Add = 1,
        }

        /// <summary>
        /// A calculation method.
        /// </summary>
        /// <param name="value1">Value number 1.</param>
        /// <param name="value2">Value number 2.</param>
        /// <param name="op">The operator.</param>
        /// <returns>An integer result.</returns>
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
