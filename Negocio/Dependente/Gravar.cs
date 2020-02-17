using BancoDados;
using Objetos;
using System;
using System.Data;
using System.Text;

namespace Negocio.Dependente
{
    public static class Gravar
    {
        static CRUD Crud;
        static StringBuilder SQL = null;

        public static bool Cadastro(DependenteObj dependenteObj)
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("INSERT INTO Dependente (Competencia, Valor) ");
            SQL.Append("VALUES (@Competencia, @Valor)");
            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("Competencia", dependenteObj.Competencia);
                Crud.AdicionarParamentro("Valor", dependenteObj.Valor);
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
