namespace KsWare.Presentation.Interfaces.Plugins.ResourceConverter {

	/// <summary>
	/// Interface IResourceConverterPluginExportMetadata
	/// </summary>
	public interface IResourceConverterPluginExportMetadata {

		/// <summary>
		/// Gets the MIME type.
		/// </summary>
		/// <value>The MIME type.</value>
		/// <remarks>Indicates that the plugin supports the specified MIME type.</remarks>
		string MimeType { get; }

		/// <summary>
		/// Gets the priority.
		/// </summary>
		/// <value>The priority.</value>
		/// <remarks>If more than one plugin exists for the same MIME type, the plugin with the highest priority will be used.</remarks>
		int Priority { get; }
	}
}