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
        DateTime dtCompInss, dtCompIrrf, dtSalMin, dtDependente;
        decimal valSalarioMinimo = 0, valValorDependente = 0;

        public FrmPrincipalCalcInss()
        {
            InitializeComponent();
        }

        private void Calculo(decimal valBase)
        {
            try
            {
                decimal faixa = Negocio.INSS.ListarFaixaTeto.Faixa(valBase);
                int numFaixa = int.Parse(faixa.ToString());
                int numDep = int.Parse(TxtNumDep.Text.Trim());

                decimal valDescInss = Math.Round(Negocio.Calculos.CalculoInssParcelaDeduzir.ValorContribuicaoFaixa(valBase, numFaixa), 2);
                decimal valDescIrrf = Math.Round(Negocio.Calculos.CalculoIrrf.DescontoIrrf(numDep, valBase, valDescInss, valValorDependente), 2);
                decimal valDescProg = 0;

                if (valDescIrrf < 0)
                {
                    valDescIrrf = 0;
                }

                decimal valSalarioLiquido = Math.Round(Negocio.Calculos.CalculoSalarioLiquido.SalarioLiquido(valBase, valDescInss, valDescIrrf), 2);

                DgvCalcProgre.DataSource = Negocio.Calculos.CalculoInssProgressao.CalculoProgressao(valBase);

                foreach (DataGridViewRow item in DgvCalcProgre.Rows)
                {
                    valDescProg += decimal.Parse(item.Cells["DescontoProgr"].Value.ToString());
                }

                DgvListParcDeduzir.DataSource = Negocio.Calculos.CalculoInssParcelaDeduzir.ValorContribuicaoFaixaGrid(valBase, numFaixa);

                LblInfoCalcProgr.Text = "Desc. INSS Progressiva: " + valDescProg.ToString("#,##0.00") +
                                        "\nDesc. INSS Parc. Deduzir: " + valDescInss.ToString("#,##0.00") +
                                        "\nDesconto IRRF: " + valDescIrrf.ToString("#,##0.00") +
                                        "\nSalário Líquido: " + valSalarioLiquido.ToString("#,##0.00");
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
                dtSalMin = Negocio.SalMin.ListarUtimaCompetencia.Competencia();
                dtDependente = Negocio.Dependente.ListarUtimaCompetencia.Competencia();


                DgvTbInss.DataSource = Negocio.INSS.ListaINSSCompetencia.Consulta(dtCompInss);
                DgvTbIrrf.DataSource = Negocio.IRRF.ListaIRRFCompetencia.Consulta(dtCompIrrf);

                valSalarioMinimo = Negocio.SalMin.ListarSalMinCompIndividual.SalarioCompetencia(dtSalMin);
                valValorDependente = Negocio.Dependente.ListarValorDepCompetencia.SalarioCompetencia(dtDependente);

                LblInfTabelas.Text = "Salário Mínimo: " + valSalarioMinimo.ToString("#,##0.00") +
                                     "\nValor Dependente: " + valValorDependente.ToString("#,##0.00");

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

        private void TxtNumDep_TextChanged(object sender, EventArgs e)
        {
            TxtNumDep.Text = ValidarNumero.ApenasNumero(TxtNumDep.Text.Trim());
            TxtNumDep.Select(TxtNumDep.Text.Length, 0);
        }

        private void TxtNumDep_Leave(object sender, EventArgs e)
        {
            TxtNumDep.Text = ValidarNumero.ZeroNumero(TxtNumDep.Text.Trim());
            TxtNumDep.Text = ValidarNumero.FormatarParaNumero(TxtNumDep.Text.Trim());
        }

        private void TxtNumDep_Enter(object sender, EventArgs e)
        {
            if (TxtNumDep.Text == "0")
            {
                TxtNumDep.Text = "";
            }
        }

        private void LkLblAtualizarTabelas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListarTabela();
        }

        private void LkLblProjetoGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start("https://github.com/mayconwisley/slnCalculadoraINSS2020WF");
        }

        private void TxtSalario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decimal valBase = decimal.Parse(TxtSalario.Text.Trim());
                Calculo(valBase);
            }
        }

        private void FrmPrincipalCalcInss_KeyPress(object sender, KeyPressEventArgs e)
        {
            //***** Ao pressionar Enter, muda de TextBox SEM O SOM*****//
            //***** KeyPreview = true na propriedade do FORM *****//
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
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
