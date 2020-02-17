using BancoDados;
using System;
using System.Data;
using System.Text;

namespace Negocio.Dependente
{
    public static class ListaDepCompetencia
    {
        static CRUD Crud;
        static StringBuilder SQL = null;

        public static DataTable Consulta(DateTime competencia)
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("SELECT Id, Competencia, Valor ");
            SQL.Append("FROM Dependente ");
            SQL.Append("WHERE Competencia = @Competencia ");
            SQL.Append("ORDER BY Competencia DESC");

            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("Competencia", competencia);
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
