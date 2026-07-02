using DesignPatternsCsharp.PatternsCriacao.FactoryMethod.Enums;
using DesignPatternsCsharp.PatternsCriacao.FactoryMethod.Interfaces;

namespace DesignPatternsCsharp.PatternsCriacao.FactoryMethod;

public abstract class ServicoFactory
{
    public abstract IServico FabricarProduto(eTiposServicos tipoServicos);
}