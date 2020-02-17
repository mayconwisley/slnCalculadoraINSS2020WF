using BancoDados;
using Objetos;
using System;
using System.Data;
using System.Text;

namespace Negocio.SalMin
{
    public static class Alterar
    {
        static CRUD Crud;
        static StringBuilder SQL = null;

        public static bool Cadastro(SalarioMinimoObj salarioMinimoObj)
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("UPDATE SalMin ");
            SQL.Append("SET Competencia = @Competencia, Salario = @Salario) ");
            SQL.Append("WHERE Id = @Id");

            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("Competencia", salarioMinimoObj.Competencia);
                Crud.AdicionarParamentro("Salario", salarioMinimoObj.Salario);
                Crud.AdicionarParamentro("Id", salarioMinimoObj.Id);
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
