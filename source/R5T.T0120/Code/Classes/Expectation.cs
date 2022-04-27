using System;
using System.Additions;


namespace R5T.T0120
{
    /// <summary>
    /// Represents an expectation tying together an input, an expected output, and the means to verify encounted output instances against the expected output instance.
    /// An expectation provides all the information required to verify an operation transforming a <typeparamref name="TInput"/> into a <typeparamref name="TOutput"/>.
    /// </summary>
    public class Expectation<TInput, TOutput>
    {
        #region Static

        /// <summary>
        /// <inheritdoc cref="Documentation.ConvenientConversionToInputType"/>
        /// </summary>
        public static implicit operator TInput(Expectation<TInput, TOutput> pair)
        {
            return pair.Input;
        }

        // No implicit converstion to output to avoid trouble when TInput is the same as TOutput, and an expectation is given to a method requring TOutput.

        #endregion


        public TInput Input { get; set; }
        public TOutput Output { get; set; }
        public IEqualityComparer<TOutput> OutputEqualityComparer { get; set; }
    }
}
