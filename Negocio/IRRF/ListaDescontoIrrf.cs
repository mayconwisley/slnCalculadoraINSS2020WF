using BancoDados;
using System;
using System.Data;
using System.Text;

namespace Negocio.IRRF
{
    public static class ListaDescontoIrrf
    {
        static CRUD Crud;
        static StringBuilder SQL = null;

        public static decimal DescontoIRRF(DateTime dtCompetencia, decimal valBase)
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("SELECT Desconto ");
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
                decimal numDesconto = (Crud.Executar(CommandType.Text, SQL.ToString()) != null) ?
                                       decimal.Parse(Crud.Executar(CommandType.Text, SQL.ToString()).ToString()) :
                                       0;
                return numDesconto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
