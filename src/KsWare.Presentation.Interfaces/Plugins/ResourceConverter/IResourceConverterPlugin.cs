using System.Windows.Data;

namespace KsWare.Presentation.Interfaces.Plugins.ResourceConverter
{
	/// <summary>
	/// Interface IResourceConverterPlugin
	/// </summary>
	/// <remarks><para>For TargetType must support DataTemplate/ControlTemplate and UIElement(and derived)</para></remarks>
	public interface IResourceConverterPlugin : IValueConverter
	{
	}
}