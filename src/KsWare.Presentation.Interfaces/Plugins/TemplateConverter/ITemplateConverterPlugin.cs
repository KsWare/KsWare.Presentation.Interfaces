using System.Windows;
using System.Windows.Controls;

namespace KsWare.Presentation.Interfaces.Plugins.TemplateConverter
{
	/// <summary>
	/// Interface ITemplateConverterPlugin
	/// </summary>
	public interface ITemplateConverterPlugin
	{
		/// <summary>
		/// Creates the data template.
		/// </summary>
		/// <param name="content">The content for the template.</param>
		/// <returns><see cref="DataTemplate"/></returns>
		DataTemplate CreateDataTemplate(object content);

		/// <summary>
		/// Creates the control template.
		/// </summary>
		/// <param name="content">The content for the template.</param>
		/// <returns><see cref="ControlTemplate"/></returns>
		ControlTemplate CreateControlTemplate(object content);
	}
}