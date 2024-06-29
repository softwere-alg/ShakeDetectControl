using Microsoft.Maui.Handlers;

namespace ShakeDetectControl;

public partial class ShakeDetectHandler
{
    public static IPropertyMapper<IShakeDetect, ShakeDetectHandler> Mapper =
        new PropertyMapper<IShakeDetect, ShakeDetectHandler>(ViewMapper)
        {
        };

    public static CommandMapper<IShakeDetect, ShakeDetectHandler> CommandMapper = new(ViewCommandMapper);

    public ShakeDetectHandler() : base(Mapper, CommandMapper)
    {
    }
}
