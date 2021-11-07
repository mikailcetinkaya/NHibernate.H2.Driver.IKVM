using NHibernate.AdoNet;
using NHibernate.Engine.Query;
using NHibernate.SqlTypes;
using NHibernate.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace NHibernate.Driver.H2
{

	/// <summary>
	/// A NHibernate driver base for using H2SharpADO.NET50.
	/// </summary>
	/// <remarks>
	/// Original code was contributed by <a href="https://github.com/mikailcetinkaya/NHibernate.H2.Driver.IKVM">Mikail Çetinkaya</a>
	/// </remarks>
	public class H2ClientDriverBase : ReflectionBasedDriver, IEmbeddedBatcherFactoryProvider
	{
		private const string _commandClassName = "H2Command";
		private const string _connectionClassName = "H2Connection";


		public H2ClientDriverBase(string driverAssemblyName, string clientNamespace)
			: base(clientNamespace, driverAssemblyName, clientNamespace + "."+ _connectionClassName, clientNamespace + "." + _commandClassName)
		{
			org.h2.Driver.load();

		}
		
		/// <inheritdoc/>
		public override bool UseNamedPrefixInSql => true;

		/// <inheritdoc/>
		public override bool UseNamedPrefixInParameter => true;

		/// <inheritdoc/>
		public override string NamedPrefix => ":";

		System.Type IEmbeddedBatcherFactoryProvider.BatcherFactoryClass => typeof(OracleDataClientBatchingBatcherFactory);
	}
}