using BancoDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.INSS
{
    public static class ListarUltimaFaixa
    {
        static CRUD Crud;
        static StringBuilder SQL = null;
        /*Listar sempre a ultima faixa mesmo que a competencia seja menor que a cadastrada na tabela*/
        public static int UltimaFaixa(DateTime dtCompetencia)
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("SELECT Faixa ");
            SQL.Append("FROM Inss ");
            SQL.Append("WHERE Competencia >= @Competencia ");
            SQL.Append("ORDER BY Faixa DESC ");
            SQL.Append("LIMIT 1");

            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("Competencia", dtCompetencia);
                int numFaixa = int.Parse(Crud.Executar(CommandType.Text, SQL.ToString()).ToString());
                return numFaixa;
            }
            catch (Exception ex)
            {
                return 0;
                throw new Exception(ex.Message);
            }
        }
    }
}
