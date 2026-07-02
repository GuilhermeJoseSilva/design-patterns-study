using DesignPatternsCsharp.PatternsCriacao.FactoryMethod.Interfaces;

namespace DesignPatternsCsharp.PatternsCriacao.FactoryMethod.Servicos;

public class MasterServico : IServico
{
    public MasterServico()
    {
        System.Console.WriteLine("Produto Master criado com Sucesso!");
    }
    public void ExecutaCobrancaServico()
    {
        //logica de cobranca suite master
    }
}