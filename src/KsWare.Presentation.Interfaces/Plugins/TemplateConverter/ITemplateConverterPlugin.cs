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
		/// <returns><see cref="DataTemplate"/><see cref="ControlTemplate"/></returns>
		object CreateTemplate(object content);
	}
}