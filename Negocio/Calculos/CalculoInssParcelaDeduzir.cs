using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Calculos
{
    public static class CalculoInssParcelaDeduzir
    {
        /*Calculo do desconto com parcela a deduzir*/
        public static decimal ValorContribuicaoFaixa(decimal valBase, int faixa)
        {
            decimal valParcelaDeduzi = Negocio.INSS.ListarParcelaFaixa.ParcelaDeduzir(faixa);
            decimal valPercentualFaixa = Negocio.INSS.ListarPorcentagemFaixa.Porcentagem(faixa);
            decimal valTetoInss = Negocio.INSS.ListarTeto.Teto();

            if (valBase > valTetoInss)
            {
                valBase = valTetoInss;
            }


            decimal valContribuicao = valBase * (valPercentualFaixa / 100) - valParcelaDeduzi;
            return valContribuicao;
        }
    }
}
