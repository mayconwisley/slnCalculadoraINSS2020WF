using System;

namespace Negocio.Utilitarios
{
    public static class ValidarNumero
    {
        static string strValor = string.Empty;
        static int posicao = 0;

        public static string ApenasValor(string valor)
        {
            try
            {
                strValor = string.Empty;
                foreach (char x in valor)
                {
                    posicao = "1234567890,.".IndexOf(x);
                    if (posicao >= 0)
                    {
                        if (x == Convert.ToChar(","))
                        {
                            if (strValor.IndexOf(",") < 0)
                            {
                                strValor += x;
                            }
                        }
                        else
                        {
                            strValor += x;
                        }
                    }
                }
                return strValor;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string FormatarParaValor(string valor)
        {
            decimal formatar = decimal.Parse(valor);
            strValor = formatar.ToString("#,##0.00");
            if (strValor == "0,00")
            {
                strValor = "0,00";
            }
            return strValor;
        }

        public static string FormatarParaNumero(string valor)
        {
            decimal formatar = decimal.Parse(valor);
            strValor = formatar.ToString("#,##0");
            if (strValor == "0")
            {
                strValor = "0";
            }
            return strValor;
        }

        public static string ApenasNumero(string valor)
        {
            try
            {
                strValor = string.Empty;
                foreach (char x in valor)
                {
                    posicao = "1234567890".IndexOf(x);
                    if (posicao >= 0)
                    {
                        strValor += x;
                    }
                }
                return strValor;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string ZeroValor(string valor)
        {
            strValor = valor;
            if (valor == "")
            {
                strValor = "0,00";
            }
            return strValor;
        }
        public static string ZeroNumero(string valor)
        {
            strValor = valor;
            if (valor == "")
            {
                strValor = "0";
            }
            return strValor;
        }
    }
}
