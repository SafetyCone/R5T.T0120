using System;

using R5T.T0120;


namespace System
{
    public static class IExpectationExtensions
    {
        public static bool Verify<TInput, TOutput>(this IExpectation<TInput, TOutput> expectation,
            TOutput output)
        {
            var areEqual = ExpectationOperator.Instance.Verify(expectation, output);
            return areEqual;
        }

        public static void Verify_OrThrow<TInput, TOutput>(this IExpectation<TInput, TOutput> expectation,
            TOutput output)
        {
            ExpectationOperator.Instance.Verify_OrThrow(expectation, output);
        }
    }
}
