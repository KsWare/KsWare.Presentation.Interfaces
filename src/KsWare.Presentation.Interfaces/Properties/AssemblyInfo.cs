using System.Reflection;

// namespace must equal to assembly name
// ReSharper disable once CheckNamespace
namespace KsWare.Presentation.Interfaces {

	/// <summary>
	/// Provides assembly information
	/// </summary>
	public static class AssemblyInfo {

		/// <summary>
		/// Gets this assembly.
		/// </summary>
		/// <value>The assembly.</value>
		public static Assembly Assembly => Assembly.GetExecutingAssembly();

		/// <summary>
		/// The XML namespace for this assembly
		/// </summary>
		public const string XmlNamespace = "http://ksware.de/Presentation/Interfaces";

		/// <summary>
		/// The root namespace for this assembly
		/// </summary>
		public const string RootNamespace = "KsWare.Presentation.Interfaces";

	}
}
