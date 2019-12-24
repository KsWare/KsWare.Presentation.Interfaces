using System;
using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Controls;
using KsWare.Presentation.Interfaces.Plugins.TemplateConverter;

namespace ClassLibraryNetCore30 {

	[Export(typeof(ITemplateConverterPlugin))]
	[TemplateConverterPluginExportMetadata("test/test")]
	public class Class1 : ITemplateConverterPlugin {

		public DataTemplate CreateDataTemplate(object content) {
			throw new NotImplementedException();
		}

		public ControlTemplate CreateControlTemplate(object content) {
			throw new NotImplementedException();
		}

	}
}
