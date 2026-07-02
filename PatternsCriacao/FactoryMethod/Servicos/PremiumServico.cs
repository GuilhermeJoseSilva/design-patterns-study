using DesignPatternsCsharp.PatternsCriacao.FactoryMethod.Interfaces;

namespace DesignPatternsCsharp.PatternsCriacao.FactoryMethod.Servicos;

public class PremiumServico : IServico
{

    public PremiumServico()
    {
        System.Console.WriteLine("Produto Premium criado com sucesso!");
    }
    public void ExecutaCobrancaServico()
    {
        // Lógica de cobrança de suite premium
    }
}