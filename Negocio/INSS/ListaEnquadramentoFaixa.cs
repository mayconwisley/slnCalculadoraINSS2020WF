using BancoDados;
using System;
using System.Data;
using System.Text;

namespace Negocio.INSS
{
    public static class ListaEnquadramentoFaixa
    {
        static CRUD Crud;
        static StringBuilder SQL = null;

        public static Decimal Porcentagem(decimal valBase)
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("SELECT  Porcentagem ");
            SQL.Append("FROM Inss ");
            SQL.Append("WHERE Teto_Faixa >= @valBase ");
            SQL.Append("ORDER BY Teto_Faixa ASC ");
            SQL.Append("LIMIT 1");

            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("valBase", valBase);
                decimal valPorcentagem = decimal.Parse(Crud.Executar(CommandType.Text, SQL.ToString()).ToString());
                return valPorcentagem;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
