using System;

namespace Negocio.Calculos
{
    public static class CalculoIrrf
    {
        /*Calculo do desconto do imposto de renda*/
        public static decimal DescontoIrrf(DateTime dtCompetencia, int dep, decimal valBase, decimal valInss, decimal valDep)
        {
            valBase = valBase - valInss;
            decimal valAliquita = Negocio.IRRF.ListaPorceIrrfValBase.PorcentagemIRRF(dtCompetencia, valBase);
            decimal valDesconto = Negocio.IRRF.ListaDescontoIrrf.DescontoIRRF(dtCompetencia, valBase);

            decimal valBaseIrrf = 0, valDescontoIrrf = 0;

            try
            {
                valBaseIrrf = valBase - (dep * valDep);
                valDescontoIrrf = Math.Truncate(100 * (valBaseIrrf * (valAliquita / 100) - valDesconto)) / 100;

                return valDescontoIrrf;
            }
            catch (Exception ex)
            {
                return 0;
                throw new Exception(ex.Message);
            }

        }
    }
}
