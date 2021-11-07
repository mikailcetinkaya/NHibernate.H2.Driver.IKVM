using System;

namespace NHibernate.Driver.H2
{
	/// <summary>
	/// A NHibernate Driver for using the H2 DataProvider
	/// </summary>
	public class H2Driver : H2ClientDriverBase
	{
		/// <summary>
		/// Initializes a new instance of <see cref="H2Driver"/>.
		/// </summary>
		/// <exception cref="HibernateException">
		/// Thrown when the <c>Oracle.ManagedDataAccess</c> assembly can not be loaded.
		/// </exception>
		public H2Driver()
			: base("H2SharpADO.NET50", "System.Data.H2")
		{
		}

		public override bool HasDelayedDistributedTransactionCompletion => true;
	}
}
