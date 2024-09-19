using Microsoft.Extensions.DependencyInjection;

namespace ExemploDI;

public interface ISingletonService : IReportServiceLifetime
{
    ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Singleton;
}