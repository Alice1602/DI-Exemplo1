using Microsoft.Extensions.DependencyInjection;

namespace ExemploDI;

public interface IReportServiceLifetime
{
    public Guid Id { get; }
    public ServiceLifetime Lifetime { get;}
}