# KsWare.Presentation.Interfaces
Interfaces for KsWare Presentation Framework

| |Master|Develop|Kux|
|---|---|---|---|
|Build|[![Build status](https://ci.appveyor.com/api/projects/status/4ctrpqfljbjyoe7i/branch/master?svg=true)](https://ci.appveyor.com/project/KsWare/ksware-presentation-interfaces/branch/master)|[![Build status](https://ci.appveyor.com/api/projects/status/4ctrpqfljbjyoe7i/branch/develop?svg=true)](https://ci.appveyor.com/project/KsWare/ksware-presentation-interfaces/branch/develop)|[![Build status](https://ci.appveyor.com/api/projects/status/4ctrpqfljbjyoe7i/branch/features/kux?svg=true)](https://ci.appveyor.com/project/KsWare/ksware-presentation-interfaces/branch/features/kux)|
|Test|![AppVeyor tests (branch)](https://img.shields.io/appveyor/tests/ksware/ksware-presentation-Interfaces/master)|![AppVeyor tests (branch)](https://img.shields.io/appveyor/tests/ksware/ksware-presentation-Interfaces/develop)|![AppVeyor tests (branch)](https://img.shields.io/appveyor/tests/ksware/ksware-presentation-Interfaces/features/kux)|
|Nuget|[![NuGet Badge](https://buildstats.info/nuget/KsWare.Presentation.Interfaces)](https://www.nuget.org/packages/KsWare.Presentation.Interfaces/)|

- [IResourceConverterPlugin](##IResourceConverterPlugin)

## IResourceConverterPlugin
The Plugin interface. Derives from IValueConverter, so the implementation is the same.
TargetType must support DataTemplate/ControlTemplate and UIEement(and derived)

```csharp
[Export(typeof(IResourceConverterPlugin))]
[ResourceConverterPluginExportMetadata("text/html")]
public class MyPlugin : IResourceConverterPlugin {

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
		// ...
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
		throw new NotImplementedException();
	}

}
```