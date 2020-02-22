using System;
namespace Negocio.Calculos
{
    public static class CalculoParcelaDeduzir
    {
        /*Selecionar a faixa anterior e fazer o calculo da parcela a deduzir*/
        public static decimal CalcParcDeduzir(DateTime dtCompetencia, int valFaixa, decimal decPorcentagem)
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
                                   Math.Round(Negocio.INSS.ListarPorcentagemFaixa.Porcentagem(dtCompetencia, valFaixa - 1), 2);
                }

                valFaixaTeto = Math.Round(Negocio.INSS.ListarTetoFaixaFaixa.TetoFaixa(dtCompetencia, valFaixa - 1), 2);
                valParceDeduzir = Math.Round(Negocio.INSS.ListarParcelaFaixa.ParcelaDeduzir(dtCompetencia, valFaixa - 1), 2);

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
