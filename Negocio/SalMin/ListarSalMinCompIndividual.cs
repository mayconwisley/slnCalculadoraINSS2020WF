using BancoDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.SalMin
{
    public static class ListarSalMinCompIndividual
    {
        static CRUD Crud;
        static StringBuilder SQL = null;

        public static decimal SalarioCompetencia(DateTime competencia)
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("SELECT Salario ");
            SQL.Append("FROM SalMin ");
            SQL.Append("WHERE Competencia = @Competencia ");

            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("Competencia", competencia);
                decimal valSalario = decimal.Parse(Crud.Executar(CommandType.Text, SQL.ToString()).ToString());
                return valSalario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
