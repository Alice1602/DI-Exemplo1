namespace ExemploDI;

internal sealed class ServicoMostrarCicloDeVida(
    ITransientService ServicoTransient, 
    IScopedService ServicoScoped, 
    ISingletonService ServicoSingleton)
{
    public static void MostrarServico<T>(T servico, string mensagem) where T : IReportServiceLifetime => Console.WriteLine(
        $"{typeof(T).Name}: {servico.Id} ({mensagem})");
    
    public void MostrarDetalhes(string detalhes)
    {
        Console.WriteLine(detalhes);
        MostrarServico(ServicoTransient, "Muda sempre");
        MostrarServico(ServicoScoped, "Muda no escopo");
        MostrarServico(ServicoSingleton, "Nunca muda");
    }
}