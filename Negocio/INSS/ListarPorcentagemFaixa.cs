using BancoDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.INSS
{
   public static class ListarPorcentagemFaixa
    {
        static CRUD Crud;
        static StringBuilder SQL = null;

        public static Decimal Porcentagem(int faixa)
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("SELECT  Porcentagem ");
            SQL.Append("FROM Inss ");
            SQL.Append("WHERE Faixa = @Faixa");


            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("Faixa", faixa);
                decimal valPorcentagem = decimal.Parse(Crud.Executar(CommandType.Text, SQL.ToString()).ToString());
                return valPorcentagem;
            }
            catch (Exception ex)
            {
                return 0;
                throw new Exception(ex.Message);
            }
        }
    }
}
