namespace ExemploDI;

public class ServicoScoped : IScopedService
{
    Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
}