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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSalario = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.DgvCalcProgre = new System.Windows.Forms.DataGridView();
            this.DgvTbInss = new System.Windows.Forms.DataGridView();
            this.DgvTbIrrf = new System.Windows.Forms.DataGridView();
            this.LblInfoCalcProgr = new System.Windows.Forms.Label();
            this.LkLblCadTabela = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.LkLblProjetoGitHub = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.LblInfTabelas = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IdIrrf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompIrrf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimiteIrrf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcIrrf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescIrrf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdInss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompInss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaixaInss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teto_FaixaInss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcInss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParcDeduInss = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
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
            this.DgvTbInss.AllowUserToAddRows = false;
            this.DgvTbInss.AllowUserToDeleteRows = false;
            this.DgvTbInss.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvTbInss.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvTbInss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTbInss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdInss,
            this.CompInss,
            this.FaixaInss,
            this.Teto_FaixaInss,
            this.PorcInss,
            this.ParcDeduInss});
            this.DgvTbInss.Location = new System.Drawing.Point(479, 41);
            this.DgvTbInss.MultiSelect = false;
            this.DgvTbInss.Name = "DgvTbInss";
            this.DgvTbInss.ReadOnly = true;
            this.DgvTbInss.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTbInss.Size = new System.Drawing.Size(461, 191);
            this.DgvTbInss.TabIndex = 4;
            // 
            // DgvTbIrrf
            // 
            this.DgvTbIrrf.AllowUserToAddRows = false;
            this.DgvTbIrrf.AllowUserToDeleteRows = false;
            this.DgvTbIrrf.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvTbIrrf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvTbIrrf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTbIrrf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdIrrf,
            this.CompIrrf,
            this.LimiteIrrf,
            this.PorcIrrf,
            this.DescIrrf});
            this.DgvTbIrrf.Location = new System.Drawing.Point(479, 238);
            this.DgvTbIrrf.MultiSelect = false;
            this.DgvTbIrrf.Name = "DgvTbIrrf";
            this.DgvTbIrrf.ReadOnly = true;
            this.DgvTbIrrf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTbIrrf.Size = new System.Drawing.Size(461, 191);
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
            this.label7.Location = new System.Drawing.Point(474, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tabelas INSS e IRRF";
            // 
            // IdIrrf
            // 
            this.IdIrrf.DataPropertyName = "Id";
            this.IdIrrf.HeaderText = "Id";
            this.IdIrrf.Name = "IdIrrf";
            this.IdIrrf.ReadOnly = true;
            this.IdIrrf.Visible = false;
            // 
            // CompIrrf
            // 
            this.CompIrrf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CompIrrf.DataPropertyName = "Competencia";
            dataGridViewCellStyle6.Format = "MM/yyyy";
            this.CompIrrf.DefaultCellStyle = dataGridViewCellStyle6;
            this.CompIrrf.HeaderText = "Competencia";
            this.CompIrrf.Name = "CompIrrf";
            this.CompIrrf.ReadOnly = true;
            this.CompIrrf.Width = 181;
            // 
            // LimiteIrrf
            // 
            this.LimiteIrrf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LimiteIrrf.DataPropertyName = "Limite";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.LimiteIrrf.DefaultCellStyle = dataGridViewCellStyle7;
            this.LimiteIrrf.HeaderText = "Limite";
            this.LimiteIrrf.Name = "LimiteIrrf";
            this.LimiteIrrf.ReadOnly = true;
            this.LimiteIrrf.Width = 103;
            // 
            // PorcIrrf
            // 
            this.PorcIrrf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PorcIrrf.DataPropertyName = "Porcentagem";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            this.PorcIrrf.DefaultCellStyle = dataGridViewCellStyle8;
            this.PorcIrrf.HeaderText = "Porcentagem";
            this.PorcIrrf.Name = "PorcIrrf";
            this.PorcIrrf.ReadOnly = true;
            this.PorcIrrf.Width = 182;
            // 
            // DescIrrf
            // 
            this.DescIrrf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DescIrrf.DataPropertyName = "Desconto";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            this.DescIrrf.DefaultCellStyle = dataGridViewCellStyle9;
            this.DescIrrf.HeaderText = "Desconto";
            this.DescIrrf.Name = "DescIrrf";
            this.DescIrrf.ReadOnly = true;
            this.DescIrrf.Width = 140;
            // 
            // IdInss
            // 
            this.IdInss.DataPropertyName = "Id";
            this.IdInss.HeaderText = "Id";
            this.IdInss.Name = "IdInss";
            this.IdInss.ReadOnly = true;
            this.IdInss.Visible = false;
            // 
            // CompInss
            // 
            this.CompInss.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CompInss.DataPropertyName = "Competencia";
            dataGridViewCellStyle1.Format = "MM/yyyy";
            this.CompInss.DefaultCellStyle = dataGridViewCellStyle1;
            this.CompInss.HeaderText = "Competencia";
            this.CompInss.Name = "CompInss";
            this.CompInss.ReadOnly = true;
            this.CompInss.Width = 181;
            // 
            // FaixaInss
            // 
            this.FaixaInss.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FaixaInss.DataPropertyName = "Faixa";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.NullValue = null;
            this.FaixaInss.DefaultCellStyle = dataGridViewCellStyle2;
            this.FaixaInss.HeaderText = "Faixa";
            this.FaixaInss.Name = "FaixaInss";
            this.FaixaInss.ReadOnly = true;
            this.FaixaInss.Width = 96;
            // 
            // Teto_FaixaInss
            // 
            this.Teto_FaixaInss.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Teto_FaixaInss.DataPropertyName = "Teto_Faixa";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.Teto_FaixaInss.DefaultCellStyle = dataGridViewCellStyle3;
            this.Teto_FaixaInss.HeaderText = "Teto_Faixa";
            this.Teto_FaixaInss.Name = "Teto_FaixaInss";
            this.Teto_FaixaInss.ReadOnly = true;
            this.Teto_FaixaInss.Width = 159;
            // 
            // PorcInss
            // 
            this.PorcInss.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PorcInss.DataPropertyName = "Porcentagem";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.PorcInss.DefaultCellStyle = dataGridViewCellStyle4;
            this.PorcInss.HeaderText = "Porcentagem";
            this.PorcInss.Name = "PorcInss";
            this.PorcInss.ReadOnly = true;
            this.PorcInss.Width = 182;
            // 
            // ParcDeduInss
            // 
            this.ParcDeduInss.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ParcDeduInss.DataPropertyName = "Parcela_Deduzir";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.ParcDeduInss.DefaultCellStyle = dataGridViewCellStyle5;
            this.ParcDeduInss.HeaderText = "Parcela_Deduzir";
            this.ParcDeduInss.Name = "ParcDeduInss";
            this.ParcDeduInss.ReadOnly = true;
            this.ParcDeduInss.Width = 216;
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
            this.Controls.Add(this.DgvTbIrrf);
            this.Controls.Add(this.DgvTbInss);
            this.Controls.Add(this.DgvCalcProgre);
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
            this.Load += new System.EventHandler(this.FrmPrincipalCalcInss_Load);
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
        private System.Windows.Forms.DataGridView DgvTbIrrf;
        private System.Windows.Forms.Label LblInfoCalcProgr;
        private System.Windows.Forms.LinkLabel LkLblCadTabela;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel LkLblProjetoGitHub;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblInfTabelas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdIrrf;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompIrrf;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimiteIrrf;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcIrrf;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescIrrf;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInss;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompInss;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaixaInss;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teto_FaixaInss;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcInss;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcDeduInss;
    }
}

