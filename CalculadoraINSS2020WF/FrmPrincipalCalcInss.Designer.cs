namespace CalculadoraINSS2020WF
{
    partial class FrmPrincipalCalcInss
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSalario = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.DgvCalcProgre = new System.Windows.Forms.DataGridView();
            this.DgvTbInss = new System.Windows.Forms.DataGridView();
            this.MktCompetencia = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvTbIrrf = new System.Windows.Forms.DataGridView();
            this.LblInfoCalcProgr = new System.Windows.Forms.Label();
            this.LkLblCadTabela = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.LkLblProjetoGitHub = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.LblInfTabelas = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCalcProgre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTbInss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTbIrrf)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salário";
            // 
            // TxtSalario
            // 
            this.TxtSalario.Location = new System.Drawing.Point(12, 41);
            this.TxtSalario.Name = "TxtSalario";
            this.TxtSalario.Size = new System.Drawing.Size(257, 35);
            this.TxtSalario.TabIndex = 1;
            this.TxtSalario.Text = "0,00";
            this.TxtSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtSalario.TextChanged += new System.EventHandler(this.TxtSalario_TextChanged);
            this.TxtSalario.Enter += new System.EventHandler(this.TxtSalario_Enter);
            this.TxtSalario.Leave += new System.EventHandler(this.TxtSalario_Leave);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.BtnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcular.Location = new System.Drawing.Point(275, 37);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(198, 42);
            this.BtnCalcular.TabIndex = 2;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            // 
            // DgvCalcProgre
            // 
            this.DgvCalcProgre.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvCalcProgre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvCalcProgre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCalcProgre.Location = new System.Drawing.Point(12, 161);
            this.DgvCalcProgre.Name = "DgvCalcProgre";
            this.DgvCalcProgre.Size = new System.Drawing.Size(461, 268);
            this.DgvCalcProgre.TabIndex = 3;
            // 
            // DgvTbInss
            // 
            this.DgvTbInss.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvTbInss.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvTbInss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTbInss.Location = new System.Drawing.Point(479, 161);
            this.DgvTbInss.Name = "DgvTbInss";
            this.DgvTbInss.Size = new System.Drawing.Size(461, 132);
            this.DgvTbInss.TabIndex = 4;
            // 
            // MktCompetencia
            // 
            this.MktCompetencia.Location = new System.Drawing.Point(479, 41);
            this.MktCompetencia.Mask = "00/0000";
            this.MktCompetencia.Name = "MktCompetencia";
            this.MktCompetencia.Size = new System.Drawing.Size(114, 35);
            this.MktCompetencia.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tabelas";
            // 
            // DgvTbIrrf
            // 
            this.DgvTbIrrf.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvTbIrrf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvTbIrrf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTbIrrf.Location = new System.Drawing.Point(479, 297);
            this.DgvTbIrrf.Name = "DgvTbIrrf";
            this.DgvTbIrrf.Size = new System.Drawing.Size(461, 132);
            this.DgvTbIrrf.TabIndex = 4;
            // 
            // LblInfoCalcProgr
            // 
            this.LblInfoCalcProgr.AutoSize = true;
            this.LblInfoCalcProgr.Location = new System.Drawing.Point(17, 432);
            this.LblInfoCalcProgr.Name = "LblInfoCalcProgr";
            this.LblInfoCalcProgr.Size = new System.Drawing.Size(52, 29);
            this.LblInfoCalcProgr.TabIndex = 7;
            this.LblInfoCalcProgr.Text = "info";
            // 
            // LkLblCadTabela
            // 
            this.LkLblCadTabela.AutoSize = true;
            this.LkLblCadTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LkLblCadTabela.Location = new System.Drawing.Point(808, 9);
            this.LkLblCadTabela.Name = "LkLblCadTabela";
            this.LkLblCadTabela.Size = new System.Drawing.Size(134, 20);
            this.LkLblCadTabela.TabIndex = 8;
            this.LkLblCadTabela.TabStop = true;
            this.LkLblCadTabela.Text = "Cadastro Tabelas";
            this.LkLblCadTabela.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LkLblCadTabela_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(722, 492);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Desenvolvido por: Maycon Wisley";
            // 
            // LkLblProjetoGitHub
            // 
            this.LkLblProjetoGitHub.AutoSize = true;
            this.LkLblProjetoGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LkLblProjetoGitHub.Location = new System.Drawing.Point(821, 509);
            this.LkLblProjetoGitHub.Name = "LkLblProjetoGitHub";
            this.LkLblProjetoGitHub.Size = new System.Drawing.Size(121, 17);
            this.LkLblProjetoGitHub.TabIndex = 10;
            this.LkLblProjetoGitHub.TabStop = true;
            this.LkLblProjetoGitHub.Text = "Projeto no GitHub";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Calculo Progressivo";
            // 
            // LblInfTabelas
            // 
            this.LblInfTabelas.AutoSize = true;
            this.LblInfTabelas.Location = new System.Drawing.Point(474, 432);
            this.LblInfTabelas.Name = "LblInfTabelas";
            this.LblInfTabelas.Size = new System.Drawing.Size(52, 29);
            this.LblInfTabelas.TabIndex = 12;
            this.LblInfTabelas.Text = "Info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(474, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tabelas INSS e IRRF";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(599, 37);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(97, 42);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipalCalcInss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(954, 535);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblInfTabelas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LkLblProjetoGitHub);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LkLblCadTabela);
            this.Controls.Add(this.LblInfoCalcProgr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MktCompetencia);
            this.Controls.Add(this.DgvTbIrrf);
            this.Controls.Add(this.DgvTbInss);
            this.Controls.Add(this.DgvCalcProgre);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtSalario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipalCalcInss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora INSS 2020";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCalcProgre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTbInss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTbIrrf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSalario;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.DataGridView DgvCalcProgre;
        private System.Windows.Forms.DataGridView DgvTbInss;
        private System.Windows.Forms.MaskedTextBox MktCompetencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvTbIrrf;
        private System.Windows.Forms.Label LblInfoCalcProgr;
        private System.Windows.Forms.LinkLabel LkLblCadTabela;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel LkLblProjetoGitHub;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblInfTabelas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnBuscar;
    }
}

