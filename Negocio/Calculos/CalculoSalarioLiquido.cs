using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Calculos
{
    public static class CalculoSalarioLiquido
    {
        public static decimal SalarioLiquido(decimal valBase, decimal valDescInss, decimal valDescIrrf)
        {
            try
            {
                return valBase - valDescInss - valDescIrrf;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
