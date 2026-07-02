using DesignPatternsCsharp.PatternsCriacao.FactoryMethod.Interfaces;

namespace DesignPatternsCsharp.PatternsCriacao.FactoryMethod.Servicos;

public class CoberturaServico : IServico
{
    public CoberturaServico()
    {
        System.Console.WriteLine("Produto Cobertura Criado com Sucesso!");
    }

    public void ExecutaCobrancaServico()
    {
        //Lógica de cobrança de serviços para cobertura.
    }
    
}