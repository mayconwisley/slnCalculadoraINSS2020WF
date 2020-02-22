using Negocio.Utilitarios;
using System;
using System.Windows.Forms;


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
                decimal faixa = Negocio.INSS.ListarFaixaTeto.Faixa(dtCompInss, valBase);
                int numFaixa = int.Parse(faixa.ToString());
                int numDep = int.Parse(TxtNumDep.Text.Trim());

                decimal valDescInss = Math.Round(Negocio.Calculos.CalculoInssParcelaDeduzir.ValorContribuicaoFaixa(dtCompInss, valBase, numFaixa), 2);
                decimal valDescIrrf = Math.Round(Negocio.Calculos.CalculoIrrf.DescontoIrrf(dtCompIrrf, numDep, valBase, valDescInss, valValorDependente), 2);
                decimal valDescProg = 0;

                if (valDescIrrf < 0)
                {
                    valDescIrrf = 0;
                }

                decimal valSalarioLiquido = Math.Round(Negocio.Calculos.CalculoSalarioLiquido.SalarioLiquido(valBase, valDescInss, valDescIrrf), 2);


                DgvCalcProgre.DataSource = Negocio.Calculos.CalculoInssProgressao.CalculoProgressao(dtCompInss, valBase);

                foreach (DataGridViewRow item in DgvCalcProgre.Rows)
                {
                    valDescProg += decimal.Parse(item.Cells["DescontoProgr"].Value.ToString());
                }

                decimal valSalarioLiquido1 = Math.Round(Negocio.Calculos.CalculoSalarioLiquido.SalarioLiquido(valBase, valDescProg, valDescIrrf), 2);

                DgvListParcDeduzir.DataSource = Negocio.Calculos.CalculoInssParcelaDeduzir.ValorContribuicaoFaixaGrid(dtCompInss, valBase, numFaixa);

                LblInfoCalcProgr.Text = "Desc. INSS Progressivo: " + valDescProg.ToString("#,##0.00") +
                                        "\nDesc. INSS Parc. Deduzir: " + valDescInss.ToString("#,##0.00") +
                                        "\nDesconto IRRF: " + valDescIrrf.ToString("#,##0.00") +
                                        "\nSalário Líquido - Progressivo: " + valSalarioLiquido1.ToString("#,##0.00") +
                                        "\nSalário Líquido - Parc. Deduzir: " + valSalarioLiquido.ToString("#,##0.00");

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
                dtCompInss = Negocio.INSS.ListarUltimaCompetencia.Competencia();
                dtCompIrrf = Negocio.IRRF.ListarUltimaCompetencia.Competencia();
                dtSalMin = Negocio.SalMin.ListarUltimaCompetencia.Competencia();
                dtDependente = Negocio.Dependente.ListarUltimaCompetencia.Competencia();


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
