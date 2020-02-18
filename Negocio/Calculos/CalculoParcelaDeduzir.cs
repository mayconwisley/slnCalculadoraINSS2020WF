using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDados;
namespace Negocio.Calculos
{
    public static class CalculoParcelaDeduzir
    {
        /*Selecionar a faixa anterior*/
        public static decimal CalcParcDeduzir(int valFaixa, decimal decPorcentagem)
        {
            try
            {
                decimal valDiferenca = 0, valFaixaTeto = 0, valCalcParcDeduzir = 0, valParceDeduzir = 0;

                if (valFaixa == 1)
                {
                    valDiferenca = 0;
                }
                else
                {
                    valDiferenca = decPorcentagem -
                                   Math.Round(Negocio.INSS.ListarPorcentagemFaixa.Porcentagem(valFaixa - 1), 2);
                }

                valFaixaTeto = Math.Round(Negocio.INSS.ListarTetoFaixaFaixa.TetoFaixa(valFaixa - 1), 2);
                valParceDeduzir = Math.Round(Negocio.INSS.ListarParcelaFaixa.ParcelaDeduzir(valFaixa - 1), 2);

                valCalcParcDeduzir = Math.Round(valFaixaTeto * (valDiferenca / 100) + valParceDeduzir, 5);

                return valCalcParcDeduzir;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
