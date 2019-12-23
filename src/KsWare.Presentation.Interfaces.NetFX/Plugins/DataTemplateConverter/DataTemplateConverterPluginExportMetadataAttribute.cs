using System;
using System.ComponentModel.Composition;

namespace KsWare.Presentation.Interfaces.Plugins.DataTemplateConverter
{
	/// <summary>
	/// Class DataTemplateConverterPluginExportMetadataAttribute. This class cannot be inherited.
	/// Implements the <see cref="System.Attribute" />
	/// Implements the <see cref="KsWare.Presentation.Interfaces.Plugins.DataTemplateConverter.IDataTemplateConverterPluginExportMetadata" />
	/// </summary>
	/// <seealso cref="System.Attribute" />
	/// <seealso cref="KsWare.Presentation.Interfaces.Plugins.DataTemplateConverter.IDataTemplateConverterPluginExportMetadata" />
	/// <example>
	/// Export a converter plugin for MIME type "image/gif"
	/// <code language="csharp">
	/// [Export(typeof(IDataTemplateConverterPlugin)), DataTemplateConverterPluginExportMetadata("image/gif")]
	/// public sealed class DataTemplateConverterPlugin : IDataTemplateConverterPlugin {
	///     public DataTemplate CreateDataTemplate(object content) {...}
	/// }
	/// </code>
	/// </example>
	[MetadataAttribute]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public sealed class DataTemplateConverterPluginExportMetadataAttribute : Attribute, IDataTemplateConverterPluginExportMetadata
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DataTemplateConverterPluginExportMetadataAttribute"/> class.
		/// </summary>
		/// <param name="mimeType">The <see cref="MimeType"/>.</param>
		/// <param name="priority">The <see cref="Priority"/>.</param>
		public DataTemplateConverterPluginExportMetadataAttribute(string mimeType, int priority = 0)

		{
			MimeType = mimeType;
			Priority = priority;
		}

		/// <summary>
		/// Gets the MIME type.
		/// </summary>
		/// <value>The MIME type.</value>
		/// <remarks>
		/// <para>Indicates that the plugin supports the specified MIME type.</para>
		/// <para>For more information about MIME types see: https://en.wikipedia.org/wiki/Media_type </para>
		/// </remarks>
		/// <example>
		/// The MIME for e GIF image is "<c>image/gif</c>"
		/// </example>
		public string MimeType { get; }

		/// <summary>
		/// Gets the priority.
		/// </summary>
		/// <value>The priority.</value>
		/// <remarks>If more than one plugin exists for the same MIME mimeType, the plugin with the highest priority will be used.</remarks>
		public int Priority { get; }
	}
}

// https://stackoverflow.com/questions/10988447/mef-getexportst-tmetadataview-returning-nothing-with-allowmultiple-true