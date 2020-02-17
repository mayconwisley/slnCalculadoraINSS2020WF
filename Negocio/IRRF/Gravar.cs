using BancoDados;
using Objetos;
using System;
using System.Data;
using System.Text;

namespace Negocio.IRRF
{
    public static class Gravar
    {
        static CRUD Crud;
        static StringBuilder SQL = null;
        public static bool Cadastro(IRRFObj IrrfObj)
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("INSERT INTO Irrf (Competencia, Limite, Porcentagem, Desconto) ");
            SQL.Append("VALUES (@Competencia, @Limite, @Porcentagem, @Desconto)");
            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("Competencia", IrrfObj.Competencia);
                Crud.AdicionarParamentro("Limite", IrrfObj.Limite);
                Crud.AdicionarParamentro("Porcentagem", IrrfObj.Porcentagem);
                Crud.AdicionarParamentro("Desconto", IrrfObj.Desconto);
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
