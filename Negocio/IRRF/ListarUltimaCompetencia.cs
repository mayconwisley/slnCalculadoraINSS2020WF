using BancoDados;
using System;
using System.Data;
using System.Text;

namespace Negocio.IRRF
{
    public static class ListarUltimaCompetencia
    {
        static CRUD Crud;
        static StringBuilder SQL = null;

        public static DateTime Competencia()
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("SELECT Competencia ");
            SQL.Append("FROM Irrf ");
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
