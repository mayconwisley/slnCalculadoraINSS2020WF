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
        public FrmPrincipalCalcInss()
        {
            InitializeComponent();
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
    }
}
