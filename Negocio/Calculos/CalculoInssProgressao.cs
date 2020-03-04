using System;
using System.Data;

namespace Negocio.Calculos
{
    public static class CalculoInssProgressao
    {

        /*Calculo do INSS em forma de Progressão*/
        public static DataTable CalculoProgressao(DateTime dtCompetencia, decimal valBase)
        {
            decimal valPorcFaixa = 0, numFaixa = 0, valFaixaTeto = 0, valDesconto = 0, valBaseBkp = 0, valFaixaTeto1 = 0;
            DataTable dtCalcProgressao;
            try
            {
                numFaixa = Negocio.INSS.ListarFaixaTeto.Faixa(dtCompetencia, valBase);
                valBaseBkp = valBase;
                dtCalcProgressao = new DataTable();
                dtCalcProgressao.Columns.Add("Faixa");
                dtCalcProgressao.Columns.Add("Valor_Faixa");
                dtCalcProgressao.Columns.Add("Porcentagem");
                dtCalcProgressao.Columns.Add("Desconto");

                for (int i = 1; i <= numFaixa; i++)
                {
                    valPorcFaixa = Negocio.INSS.ListarPorcentagemFaixa.Porcentagem(dtCompetencia, i);
                    valFaixaTeto = Negocio.INSS.ListarTetoFaixaFaixa.TetoFaixa(dtCompetencia, i);
                    valFaixaTeto1 = Negocio.INSS.ListarTetoFaixaFaixa.TetoFaixa(dtCompetencia, i - 1);

                    if (valFaixaTeto > valBase)
                    {
                        valFaixaTeto = valBase;
                    }

                    valFaixaTeto1 = valFaixaTeto - valFaixaTeto1;
                    valDesconto = Math.Truncate(100 * (valFaixaTeto1 * (valPorcFaixa / 100))) / 100;

                    dtCalcProgressao.Rows.Add(i, valFaixaTeto1.ToString("#,##0.00"), valPorcFaixa.ToString("#,##0.00"), valDesconto.ToString("#,##0.00"));
                }
                return dtCalcProgressao;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
