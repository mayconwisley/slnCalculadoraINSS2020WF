using System;

namespace Objetos
{
    public class INSSObj
    {
        public int Id { get; set; }
        public DateTime Competencia { get; set; }
        public int Faixa { get; set; }
        public decimal Teto_Faixa { get; set; }
        public decimal Porcentagem { get; set; }
        public decimal Parcela_Deduzir { get; set; }
    }
}
