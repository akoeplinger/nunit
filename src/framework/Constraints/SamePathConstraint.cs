
namespace NUnit.Framework.Constraints
{
    /// <summary>
	/// Summary description for SamePathConstraint.
	/// </summary>
	public class SamePathConstraint : PathConstraint
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SamePathConstraint"/> class.
        /// </summary>
        /// <param name="expected">The expected path</param>
		public SamePathConstraint( string expected ) : base( expected ) { }

        /// <summary>
        /// Test whether the constraint is satisfied by a given value
        /// </summary>
        /// <param name="actual">The value to be tested</param>
        /// <returns>True for success, false for failure</returns>
		public override bool Matches(object actual)
		{
			this.actual = actual;

			if ( !(actual is string) )
				return false;

			return IsSamePath( expected, (string)actual );
		}

        /// <summary>
        /// Write the constraint description to a MessageWriter
        /// </summary>
        /// <param name="writer">The writer on which the description is displayed</param>
		public override void WriteDescriptionTo(MessageWriter writer)
		{
			writer.WritePredicate( "Path matching" );
			writer.WriteExpectedValue( expected );
		}
    }
}