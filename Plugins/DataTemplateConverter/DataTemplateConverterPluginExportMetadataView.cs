using System.Collections.Generic;

namespace KsWare.Presentation.Interfaces.Plugins.DataTemplateConverter
{
	/// <summary>
	/// Metadata view for DataTemplateConverterPlugin export.
	/// </summary>
	public sealed class DataTemplateConverterPluginExportMetadataView
	{
		/// <summary>
		/// Gets the array of all metadata attributes.
		/// </summary>
		/// <value>The array.</value>
		public IDataTemplateConverterPluginExportMetadata[] Array { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="DataTemplateConverterPluginExportMetadataView"/> class.
		/// </summary>
		/// <param name="dic">a dictionary with metadata.</param>
		public DataTemplateConverterPluginExportMetadataView(IDictionary<string, object> dic)
		{
			var p1 = dic[nameof(IDataTemplateConverterPluginExportMetadata.MimeType)] as string[];
			var p2 = dic[nameof(IDataTemplateConverterPluginExportMetadata.Priority)] as int[];

			Array = new DataTemplateConverterPluginExportMetadataAttribute[p1.Length];
			for (var i = 0; i < Array.Length; i++)
				Array[i] = new DataTemplateConverterPluginExportMetadataAttribute(p1[i], p2[1]);
		}
	}
}