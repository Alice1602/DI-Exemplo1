using Microsoft.Extensions.DependencyInjection;

namespace ExemploDI;

public interface ITransientService : IReportServiceLifetime
{
    ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Transient;
}