using BancoDados;
using Objetos;
using System;
using System.Data;
using System.Text;

namespace Negocio.INSS
{
    public static class Alterar
    {
        static CRUD Crud;
        static StringBuilder SQL = null;

        public static bool Cadastro(INSSObj InssObj)
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("UPDATE Inss ");
            SQL.Append("SET Competencia = @Competencia, Faixa = @Faixa, Teto_Faixa = @Teto_Faixa, Porcentagem = @Porcentagem, Parcela_Deduzir = @Parcela_Deduzir ");
            SQL.Append("WHERE Id = @Id");
            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("Competencia", InssObj.Competencia);
                Crud.AdicionarParamentro("Faixa", InssObj.Faixa);
                Crud.AdicionarParamentro("Teto_Faixa", InssObj.Teto_Faixa);
                Crud.AdicionarParamentro("Porcentagem", InssObj.Porcentagem);
                Crud.AdicionarParamentro("Parcela_Deduzir", InssObj.Parcela_Deduzir);
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
