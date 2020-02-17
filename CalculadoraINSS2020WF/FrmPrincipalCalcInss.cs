using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Utilitarios;


namespace CalculadoraINSS2020WF
{
    public partial class FrmPrincipalCalcInss : Form
    {
        DateTime dtCompInss, dtCompIrrf;

        public FrmPrincipalCalcInss()
        {
            InitializeComponent();
        }

        private void Calculo(decimal valBase)
        {
            try
            {
                LblInfoCalcProgr.Text = Negocio.INSS.ListaEnquadramentoFaixa.Porcentagem(valBase).ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarTabela()
        {
            try
            {
                dtCompInss = Negocio.INSS.ListarUtimaCompetencia.Competencia();
                dtCompIrrf = Negocio.IRRF.ListarUtimaCompetencia.Competencia();

                DgvTbInss.DataSource = Negocio.INSS.ListaINSSCompetencia.Consulta(dtCompInss);
                DgvTbIrrf.DataSource = Negocio.IRRF.ListaIRRFCompetencia.Consulta(dtCompIrrf);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LkLblCadTabela_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCadTabela frmCadTabela = new FrmCadTabela();
            frmCadTabela.ShowDialog();
        }

        private void TxtSalario_TextChanged(object sender, EventArgs e)
        {
            TxtSalario.Text = ValidarNumero.ApenasValor(TxtSalario.Text.Trim());
            TxtSalario.Select(TxtSalario.Text.Length, 0);
        }

        private void TxtSalario_Leave(object sender, EventArgs e)
        {
            TxtSalario.Text = ValidarNumero.ZeroValor(TxtSalario.Text.Trim());
            TxtSalario.Text = ValidarNumero.FormatarParaValor(TxtSalario.Text.Trim());
        }

        private void TxtSalario_Enter(object sender, EventArgs e)
        {
            if (TxtSalario.Text == "0,00")
            {
                TxtSalario.Text = "";
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            decimal valBase = decimal.Parse(TxtSalario.Text.Trim());
            Calculo(valBase);
        }

        private void FrmPrincipalCalcInss_Load(object sender, EventArgs e)
        {
            ListarTabela();
        }
    }
}
