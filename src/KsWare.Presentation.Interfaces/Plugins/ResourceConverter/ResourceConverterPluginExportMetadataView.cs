using System.Collections.Generic;

namespace KsWare.Presentation.Interfaces.Plugins.ResourceConverter {

	/// <summary>
	/// Metadata view for <see cref="IResourceConverterPlugin"/> export.
	/// </summary>
	public sealed class ResourceConverterPluginExportMetadataView {

		/// <summary>
		/// Gets the array of all metadata attributes.
		/// </summary>
		/// <value>The array.</value>
		public IResourceConverterPluginExportMetadata[] Array { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ResourceConverterPluginExportMetadataView"/> class.
		/// </summary>
		/// <param name="dic">a dictionary with metadata.</param>
		public ResourceConverterPluginExportMetadataView(IDictionary<string, object> dic) {
			var p1 = dic[nameof(IResourceConverterPluginExportMetadata.MimeType)] as string[];
			var p2 = dic[nameof(IResourceConverterPluginExportMetadata.Priority)] as int[];

			Array = new ResourceConverterPluginExportMetadataAttribute[p1.Length];
			for (var i = 0; i < Array.Length; i++)
				Array[i] = new ResourceConverterPluginExportMetadataAttribute(p1[i], p2[i]);
		}
	}
}