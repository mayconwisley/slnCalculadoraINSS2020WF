using BancoDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.IRRF
{
    public static class ListaParceDeduzirIrrf
    {
        static CRUD Crud;
        static StringBuilder SQL = null;

        public static decimal DescontoIRRF(decimal valBase)
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("SELECT Desconto ");
            SQL.Append("FROM Irrf ");
            SQL.Append("WHERE Limite >= @valBase ");
            SQL.Append("ORDER BY Limite ASC ");
            SQL.Append("LIMIT 1");

            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("valBase", valBase);
                decimal numDesconto = decimal.Parse(Crud.Executar(CommandType.Text, SQL.ToString()).ToString());
                return numDesconto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
