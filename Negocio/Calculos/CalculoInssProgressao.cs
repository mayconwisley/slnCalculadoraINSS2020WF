using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Calculos
{
    public static class CalculoInssProgressao
    {

        /*Calculo do INSS em forma de Progessão*/
        public static DataTable CalculoProgressao(decimal valBase)
        {
            decimal valPorcFaixa = 0, numFaixa = 0, valFaixaTeto = 0, valDesconto = 0, valBaseBkp = 0, valFaixaTeto1 = 0;
            DataTable dtCalcProgressao;
            try
            {
                numFaixa = Negocio.INSS.ListarFaixaTeto.Faixa(valBase);
                valBaseBkp = valBase;
                dtCalcProgressao = new DataTable();
                dtCalcProgressao.Columns.Add("Faixa");
                dtCalcProgressao.Columns.Add("Valor_Faixa");
                dtCalcProgressao.Columns.Add("Porcentagem");
                dtCalcProgressao.Columns.Add("Desconto");

                for (int i = 1; i <= numFaixa; i++)
                {
                    valPorcFaixa = Negocio.INSS.ListarPorcentagemFaixa.Porcentagem(i);
                    valFaixaTeto = Negocio.INSS.ListarTetoFaixaFaixa.TetoFaixa(i);
                    valFaixaTeto1 = Negocio.INSS.ListarTetoFaixaFaixa.TetoFaixa(i - 1);

                    if (valFaixaTeto > valBase)
                    {
                        valFaixaTeto = valBase;
                    }

                    valFaixaTeto1 = Math.Round(valFaixaTeto - valFaixaTeto1, 2);
                    valDesconto = Math.Round(valFaixaTeto1 * (valPorcFaixa / 100), 2);

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
