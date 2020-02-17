using BancoDados;
using Objetos;
using System;
using System.Data;
using System.Text;

namespace Negocio.INSS
{
    public static class Excluir
    {
        static CRUD Crud;
        static StringBuilder SQL = null;
        public static bool Cadastro(INSSObj InssObj)
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("DELETE FROM Inss ");
            SQL.Append("WHERE Id = @Id");
            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("Id", InssObj.Id);
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
