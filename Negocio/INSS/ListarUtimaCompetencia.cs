using BancoDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.INSS
{
    public static class ListarUtimaCompetencia
    {
        static CRUD Crud;
        static StringBuilder SQL = null;

        public static DateTime Competencia()
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("SELECT Competencia ");
            SQL.Append("FROM Inss ");
            SQL.Append("GROUP BY Competencia ");
            SQL.Append("ORDER BY Competencia DESC");

            try
            {
                Crud.LimparParametro();
                DateTime dtCompetencia = DateTime.Parse(Crud.Executar(CommandType.Text, SQL.ToString()).ToString());
                return dtCompetencia;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
