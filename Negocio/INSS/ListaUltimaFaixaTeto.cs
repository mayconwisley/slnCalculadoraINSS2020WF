using BancoDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.INSS
{
    public static class ListaUltimaFaixaTeto
    {
        static CRUD Crud;
        static StringBuilder SQL = null;

        public static decimal FaixaTeto()
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("SELECT Faixa ");
            SQL.Append("FROM Inss ");
            SQL.Append("ORDER BY Faixa DESC ");
            SQL.Append("LIMIT 1");

            try
            {
                Crud.LimparParametro();
                decimal vaFaixalTeto = decimal.Parse(Crud.Executar(CommandType.Text, SQL.ToString()).ToString());
                return vaFaixalTeto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
