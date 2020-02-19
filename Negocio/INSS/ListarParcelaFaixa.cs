using BancoDados;
using System;
using System.Data;
using System.Text;

namespace Negocio.INSS
{
    public static class ListarParcelaFaixa
    {
        static CRUD Crud;
        static StringBuilder SQL = null;

        public static Decimal ParcelaDeduzir(DateTime dtCompetencia, int faixa)
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("SELECT  Parcela_Deduzir ");
            SQL.Append("FROM Inss ");
            SQL.Append("WHERE Faixa = @Faixa ");
            SQL.Append("AND Competencia = @Competencia");

            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("Faixa", faixa);
                Crud.AdicionarParamentro("Competencia", dtCompetencia);
                decimal valParcelaDeduzir = Math.Round(decimal.Parse(Crud.Executar(CommandType.Text, SQL.ToString()).ToString()), 2);
                return valParcelaDeduzir;
            }
            catch (Exception ex)
            {
                return 0;
                throw new Exception(ex.Message);
            }
        }
    }
}
