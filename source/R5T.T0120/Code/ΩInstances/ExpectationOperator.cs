using System;


namespace R5T.T0120
{
	public class ExpectationOperator : IExpectationOperator
	{
		#region Infrastructure

	    public static IExpectationOperator Instance { get; } = new ExpectationOperator();

	    private ExpectationOperator()
	    {
        }

	    #endregion
	}
}