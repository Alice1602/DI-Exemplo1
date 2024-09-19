namespace ExemploDI;

public class ServicoTransient : ITransientService
{
    Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
}
