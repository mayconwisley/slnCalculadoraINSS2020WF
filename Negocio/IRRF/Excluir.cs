using BancoDados;
using Objetos;
using System;
using System.Data;
using System.Text;

namespace Negocio.IRRF
{
    public static class Excluir
    {
        static CRUD Crud;
        static StringBuilder SQL = null;

        public static bool Cadastro(IRRFObj IrrfObj)
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("DELETE FROM Irrf ");
            SQL.Append("WHERE Id = @Id");
            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("Id", IrrfObj.Id);
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
