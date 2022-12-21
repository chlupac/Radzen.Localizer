using Microsoft.Extensions.DependencyInjection;

namespace Radzen.Localizer;

public static class RadzenLocalizationExtensions
{
    public static IServiceCollection AddRadzenLocalization(this IServiceCollection services)
    {
        var componentActivator = new OverridableComponentActivator();

        //Register localized components here
        componentActivator.RegisterOverride(typeof(RadzenDataGrid<>), typeof(RadzenDataGridLocalized<>));

        services.AddSingleton<RadzenLocalizer>();
        services.AddSingleton<IComponentActivator>(componentActivator);
        return services;
    }
    
    
}
