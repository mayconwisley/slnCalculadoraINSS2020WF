using BancoDados;
using System;
using System.Data;
using System.Text;

namespace Negocio.INSS
{
    public static class ListaUltimaFaixaTeto
    {
        static CRUD Crud;
        static StringBuilder SQL = null;
        /*Listar ultima faixa onde o é o teto do INSS*/
        public static decimal FaixaTeto(DateTime dtComptencia)
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("SELECT Faixa ");
            SQL.Append("FROM Inss ");
            SQL.Append("WHERE Competencia = @Competencia ");
            SQL.Append("ORDER BY Faixa DESC ");
            SQL.Append("LIMIT 1");

            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("Competencia", dtComptencia);
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
