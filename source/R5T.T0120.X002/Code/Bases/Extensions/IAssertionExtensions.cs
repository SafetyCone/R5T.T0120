using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using R5T.T0119;
using R5T.T0120;


namespace System
{
    public static class IAssertionExtensions
    {
        public static void AreEqual<TInput, TOutput>(this IAssertion _,
            InputOutputPair<TInput, TOutput> expectedValue,
            TOutput actualValue)
        {
            Assert.AreEqual(expectedValue.Output, actualValue);
        }

        public static void AreEqual<TInput, TOutput>(this IAssertion _,
            IEnumerable<InputOutputPair<TInput, TOutput>> expectedValues,
            IEnumerable<TOutput> actualValues)
        {
            var pairs = expectedValues.ZipWithEqualLengthRequirement(actualValues);

            foreach (var pair in pairs)
            {
                _.AreEqual(pair.Item1, pair.Item2);
            }
        }
    }
}