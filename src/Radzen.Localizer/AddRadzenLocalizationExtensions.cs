using Microsoft.Extensions.DependencyInjection;

namespace Radzen.Localizer;

public static class RadzenLocalizationExtensions
{
    public static IServiceCollection AddRadzenLocalization(this IServiceCollection services)
    {
        var componentActivator = new OverridableComponentActivator();

        //Register localized components here
        componentActivator.RegisterOverride(typeof(RadzenDataGrid<>), typeof(RadzenDataGridLocalized<>));
        componentActivator.RegisterOverride(typeof(PagedDataBoundComponent<>), typeof(PagedDataBoundComponentLocalized<>));
        componentActivator.RegisterOverride(typeof(RadzenButton), typeof(RadzenButtonLocalized));
        componentActivator.RegisterOverride(typeof(RadzenCheckBoxList<>), typeof(RadzenCheckBoxListLocalized<>));
        componentActivator.RegisterOverride(typeof(RadzenColorPicker), typeof(RadzenColorPickerLocalized));
        componentActivator.RegisterOverride(typeof(RadzenDataFilter<>), typeof(RadzenDataFilterLocalized<>));
        componentActivator.RegisterOverride(typeof(RadzenDataGrid<>), typeof(RadzenDataGridLocalized<>));
        componentActivator.RegisterOverride(typeof(RadzenDataList<>), typeof(RadzenDataListLocalized<>));
        componentActivator.RegisterOverride(typeof(RadzenDropDown<>), typeof(RadzenDropDownLocalized<>));
        componentActivator.RegisterOverride(typeof(RadzenDropDownDataGrid<>), typeof(RadzenDropDownDataGridLocalized<>));
        componentActivator.RegisterOverride(typeof(RadzenFileInput<>), typeof(RadzenFileInputLocalized<>));
        componentActivator.RegisterOverride(typeof(RadzenLogin), typeof(RadzenLoginLocalized));
        componentActivator.RegisterOverride(typeof(RadzenPager), typeof(RadzenPagerLocalized));
        componentActivator.RegisterOverride(typeof(RadzenScheduler<>), typeof(RadzenSchedulerLocalized<>));
        componentActivator.RegisterOverride(typeof(RadzenSteps), typeof(RadzenStepsLocalized));
        componentActivator.RegisterOverride(typeof(RadzenUpload), typeof(RadzenUploadLocalized));
        componentActivator.RegisterOverride(typeof(RadzenGrid<>), typeof(RadzenGridLocalized<>));

        services.AddSingleton<RadzenLocalizer>();
        services.AddSingleton<IComponentActivator>(componentActivator);
        return services;
    }
    
    
}
