using BancoDados;
using System;
using System.Data;
using System.Text;
namespace Negocio.Calculos
{
    public static class SelUltCompTabelas
    {
        static CRUD Crud;
        static StringBuilder SQL = null;

        public static DateTime UltCompentencia()
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("SELECT Competencia FROM( ");
            SQL.Append("SELECT Competencia FROM Inss ");
            SQL.Append("UNION ");
            SQL.Append("SELECT Competencia FROM Irrf ");
            SQL.Append("UNION ");
            SQL.Append("SELECT Competencia FROM SalMin ");
            SQL.Append("UNION ");
            SQL.Append("SELECT Competencia FROM Dependente) ");
            SQL.Append("ORDER BY Competencia DESC ");
            SQL.Append("LIMIT 1");

            try
            {
                DateTime dt = DateTime.Parse(Crud.Executar(CommandType.Text, SQL.ToString()).ToString());
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
