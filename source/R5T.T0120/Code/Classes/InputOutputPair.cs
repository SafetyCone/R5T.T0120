using System;


namespace R5T.T0120
{
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

        #endregion


        public TInput Input { get; set; }
        public TOutput Output { get; set; }


        public override string ToString()
        {
            var representation = $"{this.Output}: {this.Input}";
            return representation;
        }
    }
}