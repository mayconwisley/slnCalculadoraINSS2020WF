using System;
using System.Data;

namespace Negocio.Calculos
{
    public static class CalculoInssParcelaDeduzir
    {
        /*Calculo do desconto com parcela a deduzir*/
        public static decimal ValorContribuicaoFaixa(DateTime dtCompetencia, decimal valBase, int faixa)
        {
            decimal valParcelaDeduzi = Math.Round(Negocio.INSS.ListarParcelaFaixa.ParcelaDeduzir(dtCompetencia,faixa), 2);
            decimal valPercentualFaixa = Math.Round(Negocio.INSS.ListarPorcentagemFaixa.Porcentagem(dtCompetencia, faixa), 2);
            decimal valTetoInss = Math.Round(Negocio.INSS.ListarTeto.Teto(dtCompetencia), 2);

            if (valBase > valTetoInss)
            {
                valBase = valTetoInss;
            }

            decimal valContribuicao = Math.Round(valBase * (valPercentualFaixa / 100) - valParcelaDeduzi, 2);
            return valContribuicao;
        }

        public static DataTable ValorContribuicaoFaixaGrid(DateTime dtCompetencia, decimal valBase, int faixa)
        {
            decimal valParcelaDeduzi = Math.Round(Negocio.INSS.ListarParcelaFaixa.ParcelaDeduzir(dtCompetencia,faixa), 2);
            decimal valPercentualFaixa = Math.Round(Negocio.INSS.ListarPorcentagemFaixa.Porcentagem(dtCompetencia,faixa), 2);
            decimal valTetoInss = Math.Round(Negocio.INSS.ListarTeto.Teto(dtCompetencia), 2);
            decimal valFaixaTeto = Math.Round(Negocio.INSS.ListarTetoFaixaFaixa.TetoFaixa(dtCompetencia,faixa), 2);
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

                decimal valContribuicao = Math.Round(valBase * (valPercentualFaixa / 100) - valParcelaDeduzi, 2);
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
