﻿namespace ExemploDI;

public class ServicoSingleton : ISingletonService
{
    Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
}