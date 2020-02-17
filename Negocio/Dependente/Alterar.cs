using BancoDados;
using Objetos;
using System;
using System.Data;
using System.Text;

namespace Negocio.Dependente
{
    public static class Alterar
    {
        static CRUD Crud;
        static StringBuilder SQL = null;

        public static bool Cadastro(DependenteObj dependenteObj)
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("UPDATE Dependente ");
            SQL.Append("SET Competencia = @Competencia, Valor = @Valor ");
            SQL.Append("WHERE Id = @Id");
            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("Competencia", dependenteObj.Competencia);
                Crud.AdicionarParamentro("Valor", dependenteObj.Valor);
                Crud.AdicionarParamentro("Id", dependenteObj.Id);
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
