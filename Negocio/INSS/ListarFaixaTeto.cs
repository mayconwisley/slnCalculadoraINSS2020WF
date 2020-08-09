using BancoDados;
using System;
using System.Data;
using System.Text;

namespace Negocio.INSS
{
    public static class ListarFaixaTeto
    {
        static CRUD Crud;
        static StringBuilder SQL = null;

        public static decimal Faixa(DateTime dtCompetencia, decimal valBase)
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("SELECT Faixa ");
            SQL.Append("FROM Inss ");
            SQL.Append("WHERE Teto_Faixa >= @valBase ");
            SQL.Append("AND Competencia >= @Competencia ");
            SQL.Append("ORDER BY Teto_Faixa ASC ");
            SQL.Append("LIMIT 1");

            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("valBase", valBase);
                Crud.AdicionarParamentro("Competencia", dtCompetencia);
                int numFaixa = (Crud.Executar(CommandType.Text, SQL.ToString()) != null) ?
                                int.Parse(Crud.Executar(CommandType.Text, SQL.ToString()).ToString()) :
                                int.Parse(Negocio.INSS.ListarUltimaFaixaTeto.FaixaTeto(dtCompetencia).ToString());
                return numFaixa;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
