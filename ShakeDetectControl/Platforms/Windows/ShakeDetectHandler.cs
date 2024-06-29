#if IOS || MACCATALYST
using PlatformView = UIKit.UIView;
#elif MONOANDROID
using PlatformView = Android.Views.View;
#elif WINDOWS
using PlatformView = Microsoft.UI.Xaml.FrameworkElement;
#elif TIZEN
using PlatformView = Tizen.NUI.BaseComponents.View;
#elif (NETSTANDARD || !PLATFORM) || (NET6_0_OR_GREATER && !IOS && !ANDROID && !TIZEN)
using PlatformView = System.Object;
#endif

using Microsoft.Maui.Handlers;

namespace ShakeDetectControl;

public partial class ShakeDetectHandler : ViewHandler<IShakeDetect, PlatformView>
{
    protected override PlatformView CreatePlatformView()
    {
        return new PlatformView();
    }
}
