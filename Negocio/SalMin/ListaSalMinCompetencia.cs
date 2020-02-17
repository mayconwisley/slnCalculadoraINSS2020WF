using BancoDados;
using System;
using System.Data;
using System.Text;

namespace Negocio.SalMin
{
    public static class ListaSalMinCompetencia
    {
        static CRUD Crud;
        static StringBuilder SQL = null;

        public static DataTable Consulta(DateTime competencia)
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("SELECT Id, Competencia, Salario ");
            SQL.Append("FROM SalMin ");
            SQL.Append("WHERE Competencia = @Competencia ");
            SQL.Append("ORDER BY Competencia DESC");

            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("competencia", competencia);
                DataTable dataTable = Crud.Consulta(CommandType.Text, SQL.ToString());
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
