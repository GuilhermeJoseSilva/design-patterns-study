using DesignPatternsCsharp.PatternsCriacao.FactoryMethod.Interfaces;

namespace DesignPatternsCsharp.PatternsCriacao.FactoryMethod.Servicos;

public class TradicionalServico : IServico
{
    public TradicionalServico()
    {
        System.Console.WriteLine("Produto Tradicional criado com Sucesso!");
    }
    public void ExecutaCobrancaServico()
    {
     // lógica de Cobrança de suite tradicional
    }
}