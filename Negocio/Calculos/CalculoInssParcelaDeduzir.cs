using System;
using System.Data;

namespace Negocio.Calculos
{
    public static class CalculoInssParcelaDeduzir
    {
        /*Calculo do desconto com parcela a deduzir*/
        public static decimal ValorContribuicaoFaixa(DateTime dtCompetencia, decimal valBase, int faixa)
        {
            decimal valParcelaDeduzi = Negocio.INSS.ListarParcelaFaixa.ParcelaDeduzir(dtCompetencia, faixa);
            decimal valPercentualFaixa = Negocio.INSS.ListarPorcentagemFaixa.Porcentagem(dtCompetencia, faixa);
            decimal valTetoInss = Negocio.INSS.ListarTeto.Teto(dtCompetencia);

            if (valBase > valTetoInss)
            {
                valBase = valTetoInss;
            }

            decimal valContribuicao = Math.Truncate(100 * (valBase * (valPercentualFaixa / 100) - valParcelaDeduzi)) / 100;
            return valContribuicao;
        }
        /*Popular a grid com o caldulo*/
        public static DataTable ValorContribuicaoFaixaGrid(DateTime dtCompetencia, decimal valBase, int faixa)
        {
            decimal valParcelaDeduzi = Negocio.INSS.ListarParcelaFaixa.ParcelaDeduzir(dtCompetencia, faixa);
            decimal valPercentualFaixa = Negocio.INSS.ListarPorcentagemFaixa.Porcentagem(dtCompetencia, faixa);
            decimal valTetoInss = Negocio.INSS.ListarTeto.Teto(dtCompetencia);
            decimal valFaixaTeto = Negocio.INSS.ListarTetoFaixaFaixa.TetoFaixa(dtCompetencia, faixa);
            decimal valBaseBkp = 0;
            DataTable dtCalcProgressao;
            try
            {
                valBaseBkp = valBase;
                dtCalcProgressao = new DataTable();
                dtCalcProgressao.Columns.Add("Faixa");
                dtCalcProgressao.Columns.Add("Valor_Faixa");
                dtCalcProgressao.Columns.Add("Porcentagem");
                dtCalcProgressao.Columns.Add("Parcela");
                dtCalcProgressao.Columns.Add("Desconto");

                if (valBase > valTetoInss)
                {
                    valBase = valTetoInss;
                }

                decimal valContribuicao = Math.Truncate(100 * (valBase * (valPercentualFaixa / 100) - valParcelaDeduzi)) / 100;
                dtCalcProgressao.Rows.Add(faixa, valFaixaTeto.ToString("#,##0.00"), valPercentualFaixa.ToString("#,##0.00"), valParcelaDeduzi.ToString("#,##0.00"), valContribuicao.ToString("#,##0.00"));

                return dtCalcProgressao;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
