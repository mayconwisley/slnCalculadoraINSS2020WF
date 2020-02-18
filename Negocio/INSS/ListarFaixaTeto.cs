using BancoDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.INSS
{
    public static class ListarFaixaTeto
    {
        static CRUD Crud;
        static StringBuilder SQL = null;

        public static decimal Faixa(decimal valBase)
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("SELECT Faixa ");
            SQL.Append("FROM Inss ");
            SQL.Append("WHERE Teto_Faixa >= @valBase ");
            SQL.Append("ORDER BY Teto_Faixa ASC ");
            SQL.Append("LIMIT 1");

            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("valBase", valBase);
                int numFaixa = int.Parse(Crud.Executar(CommandType.Text, SQL.ToString()).ToString());
                return numFaixa;
            }
            catch (Exception ex)
            {
                return Negocio.INSS.ListaUltimaFaixaTeto.FaixaTeto();
                throw new Exception(ex.Message);
            }
        }
    }
}
