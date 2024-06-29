# Shake Detect Control

## Getting Started

In order to use the Shake Detect Control you need to call the extension method in your `MauiProgram.cs` file as follows:

```csharp
using ShakeDetectControl;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			// Initialize the Shake Detect Control by adding the below line of code
			.UseShakeDetect()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		// Continue initializing your .NET MAUI App here

		return builder.Build();
	}
}
```

### XAML usage

In order to make use of the Shake Detect Control within XAML you can use this namespace:

```xml
xmlns:detectShake="clr-namespace:ShakeDetectControl;assembly=ShakeDetectControl"
```
