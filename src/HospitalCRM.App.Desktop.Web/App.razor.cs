using Avalonia.ReactiveUI;
using Avalonia.Web.Blazor;

namespace HospitalCRM.App.Desktop.Web;

public partial class App
{
    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        WebAppBuilder.Configure<HospitalCRM.App.Desktop.App>()
            .UseReactiveUI()
            .SetupWithSingleViewLifetime();
    }
}