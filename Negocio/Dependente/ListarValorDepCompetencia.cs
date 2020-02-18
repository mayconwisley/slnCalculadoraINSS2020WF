﻿using BancoDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Dependente
{
    public static class ListarValorDepCompetencia
    {
        static CRUD Crud;
        static StringBuilder SQL = null;

        public static decimal SalarioCompetencia(DateTime competencia)
        {
            Crud = new CRUD();
            SQL = new StringBuilder();
            SQL.Append("SELECT Valor ");
            SQL.Append("FROM Dependente ");
            SQL.Append("WHERE Competencia = @Competencia ");

            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("Competencia", competencia);
                decimal valDepe = decimal.Parse(Crud.Executar(CommandType.Text, SQL.ToString()).ToString());
                return valDepe;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
