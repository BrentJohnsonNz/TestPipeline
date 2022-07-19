// Copyright 2022 Brent Johnson.
// Licensed under the Apache License, Version 2.0 (refer to the LICENSE file in the solution folder).

namespace TestPipeline.Common
{
    public static class Adder
    {
        public static int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        public static int Add(int value1, int value2, int value3)
        {
            return value1 + value2 + value3;
        }
    }
}
