using System;

using R5T.F0000.T000;
using R5T.T0132;


namespace R5T.T0120
{
	[FunctionalityMarker]
	public partial interface IExpectationOperator : IFunctionalityMarker
	{
        public Expectation<TInput, TOutput> From<TInput, TOutput>(
            TInput input,
            TOutput output,
            IEqualityComparer<TOutput> outputEqualityComparer)
        {
            var expectation = new Expectation<TInput, TOutput>
            {
                Input = input,
                Output = output,
                OutputEqualityComparer = outputEqualityComparer,
            };

            return expectation;
        }

        public Expectation<TInput, TOutput> From<TInput, TOutput>(
            TInput input,
            TOutput output,
            System.Collections.Generic.IEqualityComparer<TOutput> systemOutputEqualityComparer)
        {
            var outputEqualityComparer = EqualityComparerBasedEqualityComparer<TOutput>.From(systemOutputEqualityComparer);

            var expectation = new Expectation<TInput, TOutput>
            {
                Input = input,
                Output = output,
                OutputEqualityComparer = outputEqualityComparer,
            };

            return expectation;
        }

        public Expectation<TInput, TOutput> From<TInput, TOutput>(
            TInput input,
            TOutput output)
        {
            var expectation = this.From(
                input,
                output,
                EqualityComparerBasedEqualityComparer<TOutput>.Default);

            return expectation;
        }

        public bool Verify<TInput, TOutput>(
            Expectation<TInput, TOutput> expectation,
            TOutput output)
        {
            var areEqual = expectation.OutputEqualityComparer.Equals(output, expectation.Output);
            return areEqual;
        }

        /// <summary>
        /// Either the output is verified, or an exception is thrown.
        /// </summary>
        public void Verify_OrThrow<TInput, TOutput>(
            Expectation<TInput, TOutput> expectation,
            TOutput output)
        {
            var verified = this.Verify(expectation, output);
            if(!verified)
            {
                throw new Exception("The output was failed verification against the expected output.");
            }
        }
    }
}