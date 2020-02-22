using BancoDados;
using System;
using System.Data;
using System.Text;

namespace Negocio.IRRF
{
    public static class ListaPorceIrrfValBase
    {
        static CRUD Crud;
        static StringBuilder SQL = null;

        public static decimal PorcentagemIRRF(DateTime dtCompetencia, decimal valBase)
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("SELECT Porcentagem ");
            SQL.Append("FROM Irrf ");
            SQL.Append("WHERE Limite >= @valBase ");
            SQL.Append("AND Competencia = @Competencia ");
            SQL.Append("ORDER BY Limite ASC ");
            SQL.Append("LIMIT 1");

            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("valBase", valBase);
                Crud.AdicionarParamentro("Competencia", dtCompetencia);
                decimal numPorcemtagem = decimal.Parse(Crud.Executar(CommandType.Text, SQL.ToString()).ToString());
                return numPorcemtagem;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
