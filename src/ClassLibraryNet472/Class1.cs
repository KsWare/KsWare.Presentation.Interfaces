using System;
using System.ComponentModel.Composition;
using System.Globalization;
using KsWare.Presentation.Interfaces.Plugins.ResourceConverter;

namespace ClassLibraryNet472
{
	[Export(typeof(IResourceConverterPlugin))]
	[ResourceConverterPluginExportMetadata("test/test")]
	public class Class1 : IResourceConverterPlugin {

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
			throw new NotImplementedException();
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
			throw new NotImplementedException();
		}

	}
}
