using System.Reflection;

namespace Radzen.Localizer;

public class RadzenLocalizer  :  StringLocalizer<SharedResources>
{
    public RadzenLocalizer(IStringLocalizerFactory factory) : base(factory)
    {
    }

    public override LocalizedString this[string name] => base[name] == name ? null : base[name];
}
