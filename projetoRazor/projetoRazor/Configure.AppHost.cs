[assembly: HostingStartup(typeof(projetoRazor.AppHost))]

namespace projetoRazor;

public class AppHost() : AppHostBase("projetoRazor"), IHostingStartup
{
    public void Configure(IWebHostBuilder builder) => builder
        .ConfigureServices((context,services) => {
            // Configure ASP.NET Core IOC Dependencies
        });

    // Configure your AppHost with the necessary configuration and dependencies your App needs
    public override void Configure()
    {
        SetConfig(new HostConfig {
        });
        
        //Allow Referencing in #Script expressions, e.g. [Input(EvalAllowableEntries)]
        ScriptContext.Args[nameof(AppData)] = AppData.Instance;
    }
}

// Shared App Data
public class AppData
{
    public static readonly AppData Instance = new();
}
