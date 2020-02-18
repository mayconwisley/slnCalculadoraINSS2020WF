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
using Objetos;
namespace CalculadoraINSS2020WF
{
    public partial class FrmCadTabela : Form
    {
        public FrmCadTabela()
        {
            InitializeComponent();
        }

        #region Objetos
        INSSObj inssObj;
        IRRFObj irrfObj;
        SalarioMinimoObj salarioMinimoObj;
        DependenteObj dependenteObj;
        #endregion

        #region Variaveis e Constantes
        int inssId = 0, irrfId = 0, salMinId = 0, depenId = 0;

        DateTime dtCompetencia;
        #endregion

        #region Lista Tabelas
        private void ListarSalMin()
        {
            try
            {
                dtCompetencia = DateTime.Parse(MktCompSalMin.Text.Trim());
                DgvSalMin.DataSource = Negocio.SalMin.ListaSalMinCompetencia.Consulta(dtCompetencia);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarInss()
        {
            try
            {
                dtCompetencia = DateTime.Parse(MktCompInss.Text.Trim());
                DgvInss.DataSource = Negocio.INSS.ListaINSSCompetencia.Consulta(dtCompetencia);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarIrrf()
        {
            try
            {
                dtCompetencia = DateTime.Parse(MktCompIrrf.Text.Trim());
                DgvIrrf.DataSource = Negocio.IRRF.ListaIRRFCompetencia.Consulta(dtCompetencia);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarDependente()
        {
            try
            {
                dtCompetencia = DateTime.Parse(MktCompDep.Text.Trim());
                DgvDep.DataSource = Negocio.Dependente.ListaDepCompetencia.Consulta(dtCompetencia);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Cadastro das Tabelas
        private void CadastroInss(OpcCadastro opcCadastro)
        {
            inssObj = new INSSObj();
            try
            {
                inssObj.Id = inssId;
                inssObj.Competencia = DateTime.Parse(MktCompInss.Text.Trim());
                inssObj.Faixa = int.Parse(TxtFaixaInss.Text.Trim());
                inssObj.Teto_Faixa = decimal.Parse(TxtTetoFaixaInss.Text.Trim());
                inssObj.Porcentagem = decimal.Parse(TxtPorcInss.Text.Trim());
                inssObj.Parcela_Deduzir = Math.Round(Negocio.Calculos.CalculoParcelaDeduzir.CalcParcDeduzir(int.Parse(TxtFaixaInss.Text.Trim()), decimal.Parse(TxtPorcInss.Text.Trim())), 2);
                switch (opcCadastro)
                {
                    case OpcCadastro.Gravar:
                        Negocio.INSS.Gravar.Cadastro(inssObj);
                        break;
                    case OpcCadastro.Alterar:
                        Negocio.INSS.Alterar.Cadastro(inssObj);
                        break;
                    case OpcCadastro.Excluir:
                        Negocio.INSS.Excluir.Cadastro(inssObj);
                        break;
                    case OpcCadastro.Listar:
                        break;
                    default:
                        MessageBox.Show("Opção não habilitada.");
                        break;
                }
                ListarInss();
                Formulario.Limpar.Campos(PnlInss);
                BtnGravarInss.Enabled = true;
                BtnAlterarInss.Enabled = false;
                BtnExcluirInss.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CadastroIrrf(OpcCadastro opcCadastro)
        {
            irrfObj = new IRRFObj();
            try
            {
                irrfObj.Id = irrfId;
                irrfObj.Competencia = DateTime.Parse(MktCompIrrf.Text.Trim());
                irrfObj.Limite = decimal.Parse(TxtLimiteIrrf.Text.Trim());
                irrfObj.Porcentagem = decimal.Parse(TxtPorcIrrf.Text.Trim());
                irrfObj.Desconto = decimal.Parse(TxtDescIrrf.Text.Trim());

                switch (opcCadastro)
                {
                    case OpcCadastro.Gravar:
                        Negocio.IRRF.Gravar.Cadastro(irrfObj);
                        break;
                    case OpcCadastro.Alterar:
                        Negocio.IRRF.Alterar.Cadastro(irrfObj);
                        break;
                    case OpcCadastro.Excluir:
                        Negocio.IRRF.Excluir.Cadastro(irrfObj);
                        break;
                    case OpcCadastro.Listar:
                        break;
                    default:
                        MessageBox.Show("Opção não habilitada.");
                        break;
                }
                ListarIrrf();
                Formulario.Limpar.Campos(this);
                BtnGravarIrrf.Enabled = true;
                BtnAlterarIrrf.Enabled = false;
                BtnExcluirIrrf.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CadastroSalMin(OpcCadastro opcCadastro)
        {
            salarioMinimoObj = new SalarioMinimoObj();
            try
            {
                salarioMinimoObj.Id = salMinId;
                salarioMinimoObj.Competencia = DateTime.Parse(MktCompSalMin.Text.Trim());
                salarioMinimoObj.Salario = Decimal.Parse(TxtSalario.Text.Trim());


                switch (opcCadastro)
                {
                    case OpcCadastro.Gravar:
                        Negocio.SalMin.Gravar.Cadastro(salarioMinimoObj);
                        break;
                    case OpcCadastro.Alterar:
                        Negocio.SalMin.Alterar.Cadastro(salarioMinimoObj);
                        break;
                    case OpcCadastro.Excluir:
                        Negocio.SalMin.Excluir.Cadastro(salarioMinimoObj);
                        break;
                    case OpcCadastro.Listar:
                        break;
                    default:
                        MessageBox.Show("Opção não habilitada.");
                        break;
                }
                ListarSalMin();
                Formulario.Limpar.Campos(PnlSalMin);
                BtnGravarSalMin.Enabled = true;
                BtnExcluirSalMin.Enabled = false;
                BtnAlterarSalMin.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CadastroDependente(OpcCadastro opcCadastro)
        {
            dependenteObj = new DependenteObj();
            try
            {
                dependenteObj.Id = depenId;
                dependenteObj.Competencia = DateTime.Parse(MktCompDep.Text.Trim());
                dependenteObj.Valor = Decimal.Parse(TxtValorDep.Text.Trim());


                switch (opcCadastro)
                {
                    case OpcCadastro.Gravar:
                        Negocio.Dependente.Gravar.Cadastro(dependenteObj);
                        break;
                    case OpcCadastro.Alterar:
                        Negocio.Dependente.Alterar.Cadastro(dependenteObj);
                        break;
                    case OpcCadastro.Excluir:
                        Negocio.Dependente.Excluir.Cadastro(dependenteObj);
                        break;
                    case OpcCadastro.Listar:
                        break;
                    default:
                        MessageBox.Show("Opção não habilitada.");
                        break;
                }
                ListarDependente();
                Formulario.Limpar.Campos(this);
                BtnGravarDep.Enabled = true;
                BtnExcluirDep.Enabled = false;
                BtnAlterarDep.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Outras Funções
        private void CompetenciaInss()
        {
            try
            {
                MktCompInss.Text = Negocio.INSS.ListarUtimaCompetencia.Competencia().ToString("MM/yyyy");
                ListarInss();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CompetenciaIrrf()
        {
            try
            {
                MktCompIrrf.Text = Negocio.IRRF.ListarUtimaCompetencia.Competencia().ToString("MM/yyyy");
                ListarIrrf();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CompetenciaDep()
        {
            try
            {
                MktCompDep.Text = Negocio.Dependente.ListarUtimaCompetencia.Competencia().ToString("MM/yyyy");
                ListarDependente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CompetenciaSalMin()
        {
            try
            {
                MktCompSalMin.Text = Negocio.SalMin.ListarUtimaCompetencia.Competencia().ToString("MM/yyyy");
                ListarSalMin();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Padrao
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

        private void TxtFaixaInss_TextChanged(object sender, EventArgs e)
        {
            TxtFaixaInss.Text = ValidarNumero.ApenasNumero(TxtFaixaInss.Text.Trim());
            TxtFaixaInss.Select(TxtFaixaInss.Text.Length, 0);
        }

        private void TxtFaixaInss_Leave(object sender, EventArgs e)
        {
            TxtFaixaInss.Text = ValidarNumero.ZeroNumero(TxtFaixaInss.Text.Trim());
            TxtFaixaInss.Text = ValidarNumero.FormatarParaNumero(TxtFaixaInss.Text.Trim());
        }

        private void TxtFaixaInss_Enter(object sender, EventArgs e)
        {
            if (TxtFaixaInss.Text == "0")
            {
                TxtFaixaInss.Text = "";
            }
        }

        private void TxtTetoFaixaInss_TextChanged(object sender, EventArgs e)
        {
            TxtTetoFaixaInss.Text = ValidarNumero.ApenasValor(TxtTetoFaixaInss.Text.Trim());
            TxtTetoFaixaInss.Select(TxtTetoFaixaInss.Text.Length, 0);
        }

        private void TxtTetoFaixaInss_Leave(object sender, EventArgs e)
        {
            TxtTetoFaixaInss.Text = ValidarNumero.ZeroValor(TxtTetoFaixaInss.Text.Trim());
            TxtTetoFaixaInss.Text = ValidarNumero.FormatarParaValor(TxtTetoFaixaInss.Text.Trim());
        }

        private void TxtTetoFaixaInss_Enter(object sender, EventArgs e)
        {
            if (TxtTetoFaixaInss.Text == "0,00")
            {
                TxtTetoFaixaInss.Text = "";
            }
        }

        private void TxtPorcInss_TextChanged(object sender, EventArgs e)
        {
            TxtPorcInss.Text = ValidarNumero.ApenasValor(TxtPorcInss.Text.Trim());
            TxtPorcInss.Select(TxtPorcInss.Text.Length, 0);
        }

        private void TxtPorcInss_Leave(object sender, EventArgs e)
        {
            TxtPorcInss.Text = ValidarNumero.ZeroValor(TxtPorcInss.Text.Trim());
            TxtPorcInss.Text = ValidarNumero.FormatarParaValor(TxtPorcInss.Text.Trim());
        }

        private void TxtPorcInss_Enter(object sender, EventArgs e)
        {
            if (TxtPorcInss.Text == "0,00")
            {
                TxtPorcInss.Text = "";
            }
        }

        private void TxtLimiteIrrf_TextChanged(object sender, EventArgs e)
        {
            TxtLimiteIrrf.Text = ValidarNumero.ApenasValor(TxtLimiteIrrf.Text.Trim());
            TxtLimiteIrrf.Select(TxtLimiteIrrf.Text.Length, 0);
        }

        private void TxtLimiteIrrf_Leave(object sender, EventArgs e)
        {
            TxtLimiteIrrf.Text = ValidarNumero.ZeroValor(TxtLimiteIrrf.Text.Trim());
            TxtLimiteIrrf.Text = ValidarNumero.FormatarParaValor(TxtLimiteIrrf.Text.Trim());
        }

        private void TxtLimiteIrrf_Enter(object sender, EventArgs e)
        {
            if (TxtLimiteIrrf.Text == "0,00")
            {
                TxtLimiteIrrf.Text = "";
            }
        }

        private void TxtPorcIrrf_TextChanged(object sender, EventArgs e)
        {
            TxtPorcIrrf.Text = ValidarNumero.ApenasValor(TxtPorcIrrf.Text.Trim());
            TxtPorcIrrf.Select(TxtPorcIrrf.Text.Length, 0);
        }

        private void TxtPorcIrrf_Leave(object sender, EventArgs e)
        {
            TxtPorcIrrf.Text = ValidarNumero.ZeroValor(TxtPorcIrrf.Text.Trim());
            TxtPorcIrrf.Text = ValidarNumero.FormatarParaValor(TxtPorcIrrf.Text.Trim());
        }

        private void TxtPorcIrrf_Enter(object sender, EventArgs e)
        {
            if (TxtPorcIrrf.Text == "0,00")
            {
                TxtPorcIrrf.Text = "";
            }
        }

        private void TxtDescIrrf_TextChanged(object sender, EventArgs e)
        {
            TxtDescIrrf.Text = ValidarNumero.ApenasValor(TxtDescIrrf.Text.Trim());
            TxtDescIrrf.Select(TxtDescIrrf.Text.Length, 0);
        }

        private void TxtDescIrrf_Leave(object sender, EventArgs e)
        {
            TxtDescIrrf.Text = ValidarNumero.ZeroValor(TxtDescIrrf.Text.Trim());
            TxtDescIrrf.Text = ValidarNumero.FormatarParaValor(TxtDescIrrf.Text.Trim());
        }

        private void TxtDescIrrf_Enter(object sender, EventArgs e)
        {
            if (TxtDescIrrf.Text == "0,00")
            {
                TxtDescIrrf.Text = "";
            }
        }

        private void TxtValorDep_TextChanged(object sender, EventArgs e)
        {
            TxtValorDep.Text = ValidarNumero.ApenasValor(TxtValorDep.Text.Trim());
            TxtValorDep.Select(TxtValorDep.Text.Length, 0);
        }

        private void BtnGravarSalMin_Click(object sender, EventArgs e)
        {
            CadastroSalMin(OpcCadastro.Gravar);
        }

        private void BtnAlterarSalMin_Click(object sender, EventArgs e)
        {
            CadastroSalMin(OpcCadastro.Alterar);
        }

        private void BtnExcluirSalMin_Click(object sender, EventArgs e)
        {
            CadastroSalMin(OpcCadastro.Excluir);
        }

        private void BtnGravarInss_Click(object sender, EventArgs e)
        {
            CadastroInss(OpcCadastro.Gravar);
        }

        private void BtnAlterarInss_Click(object sender, EventArgs e)
        {
            CadastroInss(OpcCadastro.Alterar);
        }

        private void BtnExcluirInss_Click(object sender, EventArgs e)
        {
            CadastroInss(OpcCadastro.Excluir);
        }

        private void BtnGravarIrrf_Click(object sender, EventArgs e)
        {
            CadastroIrrf(OpcCadastro.Gravar);
        }

        private void BtnAlterarIrrf_Click(object sender, EventArgs e)
        {
            CadastroIrrf(OpcCadastro.Alterar);
        }

        private void BtnExcluirIrrf_Click(object sender, EventArgs e)
        {
            CadastroIrrf(OpcCadastro.Excluir);
        }

        private void BtnGravarDep_Click(object sender, EventArgs e)
        {
            CadastroDependente(OpcCadastro.Gravar);
        }

        private void BtnAlterarDep_Click(object sender, EventArgs e)
        {
            CadastroDependente(OpcCadastro.Alterar);
        }

        private void BtnExcluirDep_Click(object sender, EventArgs e)
        {
            CadastroDependente(OpcCadastro.Excluir);
        }

        private void FrmCadTabela_Load(object sender, EventArgs e)
        {
            CompetenciaInss();
            CompetenciaIrrf();
            CompetenciaSalMin();
            CompetenciaDep();
        }

        private void MktCompInss_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListarInss();
            }
        }

        private void MktCompSalMin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListarSalMin();
            }
        }

        private void MktCompIrrf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListarIrrf();
            }
        }

        private void MktCompDep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListarDependente();
            }
        }

        private void DgvSalMin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dtCompetencia = DateTime.Parse(DgvSalMin.Rows[e.RowIndex].Cells["CompSalMin"].Value.ToString());
                decimal valSalario = decimal.Parse(DgvSalMin.Rows[e.RowIndex].Cells["SalarioSalMin"].Value.ToString());
                salMinId = int.Parse(DgvSalMin.Rows[e.RowIndex].Cells["IdSalMin"].Value.ToString());
                MktCompSalMin.Text = dtCompetencia.ToString("MM/yyyy");
                TxtSalario.Text = valSalario.ToString("#,##0.00");

                BtnGravarSalMin.Enabled = false;
                BtnExcluirSalMin.Enabled = true;
                BtnAlterarSalMin.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvInss_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                inssId = int.Parse(DgvInss.Rows[e.RowIndex].Cells["IdInss"].Value.ToString());
                dtCompetencia = DateTime.Parse(DgvInss.Rows[e.RowIndex].Cells["CompInss"].Value.ToString());
                decimal valTetoFaixa = decimal.Parse(DgvInss.Rows[e.RowIndex].Cells["TetoFaixaInss"].Value.ToString());
                decimal porcemtagem = decimal.Parse(DgvInss.Rows[e.RowIndex].Cells["PorcInss"].Value.ToString());

                MktCompInss.Text = dtCompetencia.ToString("MM/yyyy");
                TxtFaixaInss.Text = DgvInss.Rows[e.RowIndex].Cells["FaixaInss"].Value.ToString();
                TxtTetoFaixaInss.Text = valTetoFaixa.ToString("#,##0.00");
                TxtPorcInss.Text = porcemtagem.ToString("#,##0.00");

                BtnGravarInss.Enabled = false;
                BtnAlterarInss.Enabled = true;
                BtnExcluirInss.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvIrrf_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                irrfId = int.Parse(DgvIrrf.Rows[e.RowIndex].Cells["IdIrrf"].Value.ToString());
                dtCompetencia = DateTime.Parse(DgvIrrf.Rows[e.RowIndex].Cells["CompIrrf"].Value.ToString());
                decimal valLimite = decimal.Parse(DgvIrrf.Rows[e.RowIndex].Cells["LimiteIrrf"].Value.ToString());
                decimal porcemtagem = decimal.Parse(DgvIrrf.Rows[e.RowIndex].Cells["PorcIrrf"].Value.ToString());
                decimal valDesconto = decimal.Parse(DgvIrrf.Rows[e.RowIndex].Cells["DescIrrf"].Value.ToString());

                MktCompIrrf.Text = dtCompetencia.ToString("MM/yyyy");
                TxtLimiteIrrf.Text = valLimite.ToString("#,##0.00");
                TxtPorcIrrf.Text = porcemtagem.ToString("#,##0.00");
                TxtDescIrrf.Text = valDesconto.ToString("#,##0.00");

                BtnGravarIrrf.Enabled = false;
                BtnAlterarIrrf.Enabled = true;
                BtnExcluirIrrf.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvDep_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                depenId = int.Parse(DgvDep.Rows[e.RowIndex].Cells["IdDep"].Value.ToString());
                dtCompetencia = DateTime.Parse(DgvDep.Rows[e.RowIndex].Cells["CompDep"].Value.ToString());
                decimal valValor = decimal.Parse(DgvDep.Rows[e.RowIndex].Cells["ValorDep"].Value.ToString());
                BtnGravarDep.Enabled = false;
                BtnExcluirDep.Enabled = true;
                BtnAlterarDep.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmCadTabela_KeyPress(object sender, KeyPressEventArgs e)
        {
            //***** Ao pressionar Enter, muda de TextBox SEM O SOM*****//
            //***** KeyPreview = true na propriedade do FORM *****//
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        private void TxtValorDep_Leave(object sender, EventArgs e)
        {
            TxtValorDep.Text = ValidarNumero.ZeroValor(TxtValorDep.Text.Trim());
            TxtValorDep.Text = ValidarNumero.FormatarParaValor(TxtValorDep.Text.Trim());
        }

        private void TxtValorDep_Enter(object sender, EventArgs e)
        {
            if (TxtValorDep.Text == "0,00")
            {
                TxtValorDep.Text = "";
            }
        }

        private void TabControle_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompetenciaInss();
            CompetenciaIrrf();
            CompetenciaSalMin();
            CompetenciaDep();
        }
        #endregion
    }
}
