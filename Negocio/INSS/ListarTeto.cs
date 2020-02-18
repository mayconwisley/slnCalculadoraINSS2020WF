using BancoDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.INSS
{
    public static class ListarTeto
    {
        static CRUD Crud;
        static StringBuilder SQL = null;

        public static decimal Teto()
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("SELECT Teto_Faixa ");
            SQL.Append("FROM Inss ");
            SQL.Append("ORDER BY Teto_Faixa DESC ");
            SQL.Append("LIMIT 1");

            try
            {
                Crud.LimparParametro();
                decimal valTeto = decimal.Parse(Crud.Executar(CommandType.Text, SQL.ToString()).ToString());
                return valTeto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
