using System.ComponentModel.Composition.Hosting;

namespace KsWare.Presentation.Interfaces {

	/// <summary>
	/// Interface IModuleInitializer
	/// </summary>
	public interface IModuleInitializer {

		/// <summary>
		/// Registers the module services.
		/// </summary>
		/// <param name="container">The CompositionContainer.</param>
		void RegisterServices(CompositionContainer container);

	}

}