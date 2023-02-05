using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using R5T.T0119;
using R5T.T0120;


namespace System
{
    public static class IAssertionExtensions
    {
        [Obsolete("Use R5T.F01010")]
        public static void AreEqual<TInput, TOutput>(this IAssertion _,
            InputOutputPair<TInput, TOutput> expectedValue,
            TOutput encounteredValue)
        {
            Assert.AreEqual(expectedValue.Output, encounteredValue);
        }

        [Obsolete("Use R5T.F01010")]
        public static void AreEqual<TInput, TOutput>(this IAssertion _,
            IEnumerable<InputOutputPair<TInput, TOutput>> expectedValues,
            IEnumerable<TOutput> encounteredValues)
        {
            var pairs = expectedValues.ZipWithEqualLengthRequirement(encounteredValues);

            foreach (var pair in pairs)
            {
                _.AreEqual(pair.Item1, pair.Item2);
            }
        }

        [Obsolete("Use R5T.F01010")]
        public static void AreEqual<TInput, TOutput>(this IAssertion _,
            Expectation<TInput, TOutput> expectation,
            TOutput encounteredValue)
        {
            var areEqual = expectation.Verify(encounteredValue);

            Assert.IsTrue(areEqual);
        }

        [Obsolete("Use R5T.F01010")]
        public static void AreEqual<TInput, TOutput>(this IAssertion _,
            IEnumerable<Expectation<TInput, TOutput>> expectations,
            IEnumerable<TOutput> encounteredValues)
        {
            var pairs = expectations.ZipWithEqualLengthRequirement(encounteredValues);

            foreach (var pair in pairs)
            {
                _.AreEqual(pair.Item1, pair.Item2);
            }
        }
    }
}