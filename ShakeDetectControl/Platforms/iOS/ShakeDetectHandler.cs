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

public partial class ShakeDetectHandler : ViewHandler<IShakeDetect, ShakeDetectUIView>
{
    protected override ShakeDetectUIView CreatePlatformView()
    {
        return new ShakeDetectUIView();
    }

    protected override void ConnectHandler(ShakeDetectUIView platformView)
    {
        base.ConnectHandler(platformView);

        // ネイティブのイベント登録
        platformView.OnDetectShake += VirtualView.OnDetectShake;
    }

    protected override void DisconnectHandler(ShakeDetectUIView platformView)
    {
        platformView.Dispose();
        base.DisconnectHandler(platformView);

        // ネイティブのイベント登録解除
        platformView.OnDetectShake -= VirtualView.OnDetectShake;
    }
}
