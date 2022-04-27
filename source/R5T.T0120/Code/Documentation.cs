using System;


namespace R5T.T0120
{
    /// <summary>
    /// Testing-related data types.
    /// </summary>
    public static class Documentation
    {
        /// <summary>
        /// Convenient conversion to input type to allow:
        /// <code>
        /// var expected = GetExpected();
        /// var actual = TestObject.TestMethod(expected);
        /// </code>
        /// </summary>
        public static readonly object ConvenientConversionToInputType;
    }
}