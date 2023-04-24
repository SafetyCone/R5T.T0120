using System;

using R5T.F0000.T000;
using R5T.T0142;


namespace R5T.T0120
{
    /// <inheritdoc cref="IExpectation{TInput, TOutput}"/>
    [UtilityTypeMarker]
    public class Expectation<TInput, TOutput> : IExpectation<TInput, TOutput>
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


        public Expectation()
        {
        }



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
