using System;

using R5T.T0142;


namespace R5T.T0120
{
    /// <summary>
    /// OBSOLETE - See R5T.L0087.T000.
    /// </summary>
    [DataTypeMarker]
    public class InputOutputPair<TInput, TOutput>
    {
        #region Static

        /// <summary>
        /// <inheritdoc cref="Documentation.ConvenientConversionToInputType"/>
        /// </summary>
        public static implicit operator TInput(InputOutputPair<TInput, TOutput> pair)
        {
            return pair.Input;
        }

        /// <inheritdoc cref="Documentation.NoImplicitConversionToOutputType"/>

        #endregion


        public TInput Input { get; set; }
        public TOutput Output { get; set; }


        public override string ToString()
        {
            var representation = $"'{this.Output}' from '{this.Input}'";
            return representation;
        }
    }


    public static class InputOutputPair
    {
        public static InputOutputPair<TInput, TOutput> From<TInput, TOutput>(
            TInput input,
            TOutput output)
        {
            var pair = new InputOutputPair<TInput, TOutput>
            {
                Input = input,
                Output = output,
            };

            return pair;
        }
    }
}