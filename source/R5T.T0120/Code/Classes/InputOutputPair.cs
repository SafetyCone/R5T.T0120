using System;


namespace R5T.T0120
{
    public class InputOutputPair<TInput, TOutput>
    {
        #region Static

        /// <summary>
        /// Convenient conversion to input type to allow:
        /// <code>
        /// InputOutputPair expected = GetExpected();
        /// var actual = TestObject.TestMethod(expected);
        /// </code>
        /// </summary>
        /// <param name="pair"></param>
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