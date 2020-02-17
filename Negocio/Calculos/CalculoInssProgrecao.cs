using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Calculos
{
    public static class CalculoInssProgrecao
    {
        #region Variaveis
        static decimal decSalario = 0M;
        #endregion

        public static decimal ValorContribuicaoFaixa(decimal valBase, decimal valFaixa)
        {
            decimal valContribuicao = (valBase * (valFaixa / 100));
            return valContribuicao;
        }
    }
}
