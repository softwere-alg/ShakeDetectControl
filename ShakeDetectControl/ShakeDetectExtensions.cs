namespace ShakeDetectControl;

public static class ShakeDetectExtensions
{
    public static MauiAppBuilder UseShakeDetect(this MauiAppBuilder builder)
    {
        return builder.ConfigureMauiHandlers(handlers =>
        {
            handlers.AddHandler<ShakeDetect, ShakeDetectHandler>();
        });
    }
}
