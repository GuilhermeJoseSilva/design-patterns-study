using DesignPatternsCsharp.PatternsCriacao.FactoryMethod.Enums;
using DesignPatternsCsharp.PatternsCriacao.FactoryMethod.Interfaces;
using DesignPatternsCsharp.PatternsCriacao.FactoryMethod.Servicos;

namespace DesignPatternsCsharp.PatternsCriacao.FactoryMethod;

public class SelecionaServico : ServicoFactory
{
    public override IServico FabricarProduto(eTiposServicos tipoServicos)
    {
        switch (tipoServicos)
        {
            case eTiposServicos.tradicional:
                return new TradicionalServico();
            case eTiposServicos.premium:
                return new PremiumServico();
            case eTiposServicos.master:
                return new MasterServico();
            case eTiposServicos.cobertura:
                return new CoberturaServico();
            default:
                return null;
        }
    }
}