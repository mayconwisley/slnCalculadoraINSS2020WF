using BancoDados;
using Objetos;
using System;
using System.Data;
using System.Text;

namespace Negocio.SalMin
{
    public static class Gravar
    {
        static CRUD Crud;
        static StringBuilder SQL = null;

        public static bool Cadastro(SalarioMinimoObj salarioMinimoObj)
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("INSERT INTO SalMin (Competencia, Salario) ");
            SQL.Append("VALUES (@Competencia, @Salario)");
            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("Competencia", salarioMinimoObj.Competencia);
                Crud.AdicionarParamentro("Salario", salarioMinimoObj.Salario);
                Crud.Executar(CommandType.Text, SQL.ToString());
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
