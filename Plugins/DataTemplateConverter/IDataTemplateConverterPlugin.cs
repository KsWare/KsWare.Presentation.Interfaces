using System.Windows;

namespace KsWare.Presentation.Interfaces.Plugins.DataTemplateConverter
{
	/// <summary>
	/// Interface IDataTemplateConverterPlugin
	/// </summary>
	public interface IDataTemplateConverterPlugin
	{
		/// <summary>
		/// Creates the data template.
		/// </summary>
		/// <param name="content">The content for the <see cref="DataTemplate"/></param>
		/// <returns><see cref="DataTemplate"/></returns>
		DataTemplate CreateDataTemplate(object content);
	}
}