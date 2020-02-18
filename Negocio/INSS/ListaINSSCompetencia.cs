using BancoDados;
using System;
using System.Data;
using System.Text;

namespace Negocio.INSS
{
    public static class ListaINSSCompetencia
    {
        static CRUD Crud;
        static StringBuilder SQL = null;

        public static DataTable Consulta(DateTime Competencia)
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("SELECT Id, Competencia, Faixa, Teto_Faixa, Porcentagem, Parcela_Deduzir ");
            SQL.Append("FROM Inss ");
            SQL.Append("WHERE Competencia >= @Competencia ");
            SQL.Append("ORDER BY Faixa ASC");

            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("Competencia", Competencia);
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
