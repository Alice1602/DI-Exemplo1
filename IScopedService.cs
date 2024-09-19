using Microsoft.Extensions.DependencyInjection;

namespace ExemploDI;

public interface IScopedService : IReportServiceLifetime
{
   ServiceLifetime IReportServiceLifetime.Lifetime =>
      ServiceLifetime.Scoped;
}