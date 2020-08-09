using BancoDados;
using System;
using System.Data;
using System.Text;

namespace Negocio.INSS
{
    public static class ListarTetoFaixaFaixa
    {
        static CRUD Crud;
        static StringBuilder SQL = null;

        public static Decimal TetoFaixa(DateTime dtCompetencia, int faixa)
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("SELECT  Teto_Faixa ");
            SQL.Append("FROM Inss ");
            SQL.Append("WHERE Faixa = @Faixa ");
            SQL.Append("AND Competencia = @Competencia ");


            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("Faixa", faixa);
                Crud.AdicionarParamentro("Competencia", dtCompetencia);

                decimal valTetoFaixa = (Crud.Executar(CommandType.Text, SQL.ToString()) != null) ?
                        (valTetoFaixa = decimal.Parse(Crud.Executar(CommandType.Text, SQL.ToString()).ToString())) :
                        0;

                return valTetoFaixa;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
