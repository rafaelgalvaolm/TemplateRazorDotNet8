using ServiceStack;
using projetoRazor.ServiceModel;

namespace projetoRazor.ServiceInterface;

public class MyServices : Service
{
    public object Any(Hello request)
    {
        return new HelloResponse { Result = $"Hello, {request.Name}!" };
    }
}