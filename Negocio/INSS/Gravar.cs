using BancoDados;
using Objetos;
using System;
using System.Data;
using System.Text;

namespace Negocio.INSS
{
    public static class Gravar
    {
        static CRUD Crud;
        static StringBuilder SQL = null;

        public static bool Cadastro(INSSObj InssObj)
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("INSERT INTO Inss (Competencia, Faixa, Teto_Faixa, Porcentagem, Parcela_Deduzir) ");
            SQL.Append("VALUES (@Competencia, @Faixa, @Teto_Faixa, @Porcentagem, @Parcela_Deduzir)");
            try
            {
                Crud.LimparParametro();

                Crud.AdicionarParamentro("Competencia", InssObj.Competencia);
                Crud.AdicionarParamentro("Faixa", InssObj.Faixa);
                Crud.AdicionarParamentro("Teto_Faixa", InssObj.Teto_Faixa);
                Crud.AdicionarParamentro("Porcentagem", InssObj.Porcentagem);
                Crud.AdicionarParamentro("Parcela_Deduzir", InssObj.Parcela_Deduzir);
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
