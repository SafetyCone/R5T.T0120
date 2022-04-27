using System;

using R5T.T0120;


namespace System
{
    public static class ExpectationExtensions
    {
        public static bool Verify<TInput, TOutput>(this Expectation<TInput, TOutput> expectation,
            TOutput output)
        {
            var areEqual = expectation.OutputEqualityComparer.Equals(output, expectation.Output);
            return areEqual;
        }
    }
}
