using System;

namespace Negocio.Calculos
{
    public static class CalculoIrrf
    {
        public static decimal DescontoIrrf(DateTime dtCompetencia, int dep, decimal valBase, decimal valInss, decimal valDep)
        {
            decimal valAliquita = Negocio.IRRF.ListaPorceIrrfValBase.PorcemtagemIRRF(dtCompetencia,valBase);
            decimal valDesconto = Negocio.IRRF.ListaParceDeduzirIrrf.DescontoIRRF(dtCompetencia, valBase);

            decimal valBaseIrrf = 0, valDescontoIrrf = 0;

            try
            {
                valBaseIrrf = Math.Round(valBase - valInss - (dep * valDep), 2);
                valDescontoIrrf = Math.Round(valBaseIrrf * (valAliquita / 100) - valDesconto, 2);

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
