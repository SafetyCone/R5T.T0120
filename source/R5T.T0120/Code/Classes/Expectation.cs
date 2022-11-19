using System;

using R5T.F0000.T000;
using R5T.T0142;


namespace R5T.T0120
{
    /// <summary>
    /// Represents an expectation tying together an input, an expected output, and the means to verify encounted output instances against the expected output instance.
    /// An expectation provides all the information required to verify an operation transforming a <typeparamref name="TInput"/> into a <typeparamref name="TOutput"/>.
    /// </summary>
    [DataTypeMarker]
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

        /// <inheritdoc cref="Documentation.NoImplicitConversionToOutputType"/>

        #endregion


        public TInput Input { get; set; }
        public TOutput Output { get; set; }
        public IEqualityComparer<TOutput> OutputEqualityComparer { get; set; }


        public override string ToString()
        {
            var representation = $"'{this.Output}' expected from '{this.Input}'";
            return representation;
        }
    }
}
