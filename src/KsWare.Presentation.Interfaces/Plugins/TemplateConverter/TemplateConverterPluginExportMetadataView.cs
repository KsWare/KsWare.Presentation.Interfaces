using System.Collections.Generic;

namespace KsWare.Presentation.Interfaces.Plugins.TemplateConverter
{
	/// <summary>
	/// Metadata view for DataTemplateConverterPlugin export.
	/// </summary>
	public sealed class TemplateConverterPluginExportMetadataView
	{
		/// <summary>
		/// Gets the array of all metadata attributes.
		/// </summary>
		/// <value>The array.</value>
		public ITemplateConverterPluginExportMetadata[] Array { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="TemplateConverterPluginExportMetadataView"/> class.
		/// </summary>
		/// <param name="dic">a dictionary with metadata.</param>
		public TemplateConverterPluginExportMetadataView(IDictionary<string, object> dic)
		{
			var p1 = dic[nameof(ITemplateConverterPluginExportMetadata.MimeType)] as string[];
			var p2 = dic[nameof(ITemplateConverterPluginExportMetadata.Priority)] as int[];

			Array = new TemplateConverterPluginExportMetadataAttribute[p1.Length];
			for (var i = 0; i < Array.Length; i++)
				Array[i] = new TemplateConverterPluginExportMetadataAttribute(p1[i], p2[i]);
		}
	}
}