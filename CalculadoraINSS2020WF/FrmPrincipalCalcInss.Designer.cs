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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipalCalcInss));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSalario = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.DgvCalcProgre = new System.Windows.Forms.DataGridView();
            this.FaixaProgr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_FaixaProgr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcProgr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescontoProgr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvTbInss = new System.Windows.Forms.DataGridView();
            this.IdInss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompInss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaixaInss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teto_FaixaInss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcInss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParcDeduInss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvTbIrrf = new System.Windows.Forms.DataGridView();
            this.IdIrrf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompIrrf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimiteIrrf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcIrrf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescIrrf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblInfoCalcProgr = new System.Windows.Forms.Label();
            this.LkLblCadTabela = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.LkLblProjetoGitHub = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.LblInfTabelas = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNumDep = new System.Windows.Forms.TextBox();
            this.LkLblAtualizarTabelas = new System.Windows.Forms.LinkLabel();
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
            this.DgvCalcProgre.AllowUserToAddRows = false;
            this.DgvCalcProgre.AllowUserToDeleteRows = false;
            this.DgvCalcProgre.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvCalcProgre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvCalcProgre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCalcProgre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FaixaProgr,
            this.Valor_FaixaProgr,
            this.PorcProgr,
            this.DescontoProgr});
            this.DgvCalcProgre.Location = new System.Drawing.Point(12, 161);
            this.DgvCalcProgre.MultiSelect = false;
            this.DgvCalcProgre.Name = "DgvCalcProgre";
            this.DgvCalcProgre.ReadOnly = true;
            this.DgvCalcProgre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCalcProgre.Size = new System.Drawing.Size(461, 268);
            this.DgvCalcProgre.TabIndex = 3;
            // 
            // FaixaProgr
            // 
            this.FaixaProgr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FaixaProgr.DataPropertyName = "Faixa";
            this.FaixaProgr.HeaderText = "Faixa";
            this.FaixaProgr.Name = "FaixaProgr";
            this.FaixaProgr.ReadOnly = true;
            this.FaixaProgr.Width = 96;
            // 
            // Valor_FaixaProgr
            // 
            this.Valor_FaixaProgr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Valor_FaixaProgr.DataPropertyName = "Valor_Faixa";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Valor_FaixaProgr.DefaultCellStyle = dataGridViewCellStyle1;
            this.Valor_FaixaProgr.HeaderText = "Valor_Faixa";
            this.Valor_FaixaProgr.Name = "Valor_FaixaProgr";
            this.Valor_FaixaProgr.ReadOnly = true;
            this.Valor_FaixaProgr.Width = 165;
            // 
            // PorcProgr
            // 
            this.PorcProgr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PorcProgr.DataPropertyName = "Porcentagem";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.PorcProgr.DefaultCellStyle = dataGridViewCellStyle2;
            this.PorcProgr.HeaderText = "Porcentagem";
            this.PorcProgr.Name = "PorcProgr";
            this.PorcProgr.ReadOnly = true;
            this.PorcProgr.Width = 182;
            // 
            // DescontoProgr
            // 
            this.DescontoProgr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DescontoProgr.DataPropertyName = "Desconto";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.DescontoProgr.DefaultCellStyle = dataGridViewCellStyle3;
            this.DescontoProgr.HeaderText = "Desconto";
            this.DescontoProgr.Name = "DescontoProgr";
            this.DescontoProgr.ReadOnly = true;
            this.DescontoProgr.Width = 140;
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
            dataGridViewCellStyle4.Format = "MM/yyyy";
            this.CompInss.DefaultCellStyle = dataGridViewCellStyle4;
            this.CompInss.HeaderText = "Competencia";
            this.CompInss.Name = "CompInss";
            this.CompInss.ReadOnly = true;
            this.CompInss.Width = 181;
            // 
            // FaixaInss
            // 
            this.FaixaInss.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FaixaInss.DataPropertyName = "Faixa";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.NullValue = null;
            this.FaixaInss.DefaultCellStyle = dataGridViewCellStyle5;
            this.FaixaInss.HeaderText = "Faixa";
            this.FaixaInss.Name = "FaixaInss";
            this.FaixaInss.ReadOnly = true;
            this.FaixaInss.Width = 96;
            // 
            // Teto_FaixaInss
            // 
            this.Teto_FaixaInss.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Teto_FaixaInss.DataPropertyName = "Teto_Faixa";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.Teto_FaixaInss.DefaultCellStyle = dataGridViewCellStyle6;
            this.Teto_FaixaInss.HeaderText = "Teto_Faixa";
            this.Teto_FaixaInss.Name = "Teto_FaixaInss";
            this.Teto_FaixaInss.ReadOnly = true;
            this.Teto_FaixaInss.Width = 159;
            // 
            // PorcInss
            // 
            this.PorcInss.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PorcInss.DataPropertyName = "Porcentagem";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.PorcInss.DefaultCellStyle = dataGridViewCellStyle7;
            this.PorcInss.HeaderText = "Porcentagem";
            this.PorcInss.Name = "PorcInss";
            this.PorcInss.ReadOnly = true;
            this.PorcInss.Width = 182;
            // 
            // ParcDeduInss
            // 
            this.ParcDeduInss.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ParcDeduInss.DataPropertyName = "Parcela_Deduzir";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            this.ParcDeduInss.DefaultCellStyle = dataGridViewCellStyle8;
            this.ParcDeduInss.HeaderText = "Parcela_Deduzir";
            this.ParcDeduInss.Name = "ParcDeduInss";
            this.ParcDeduInss.ReadOnly = true;
            this.ParcDeduInss.Width = 216;
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
            dataGridViewCellStyle9.Format = "MM/yyyy";
            this.CompIrrf.DefaultCellStyle = dataGridViewCellStyle9;
            this.CompIrrf.HeaderText = "Competencia";
            this.CompIrrf.Name = "CompIrrf";
            this.CompIrrf.ReadOnly = true;
            this.CompIrrf.Width = 181;
            // 
            // LimiteIrrf
            // 
            this.LimiteIrrf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LimiteIrrf.DataPropertyName = "Limite";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            this.LimiteIrrf.DefaultCellStyle = dataGridViewCellStyle10;
            this.LimiteIrrf.HeaderText = "Limite";
            this.LimiteIrrf.Name = "LimiteIrrf";
            this.LimiteIrrf.ReadOnly = true;
            this.LimiteIrrf.Width = 103;
            // 
            // PorcIrrf
            // 
            this.PorcIrrf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PorcIrrf.DataPropertyName = "Porcentagem";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            this.PorcIrrf.DefaultCellStyle = dataGridViewCellStyle11;
            this.PorcIrrf.HeaderText = "Porcentagem";
            this.PorcIrrf.Name = "PorcIrrf";
            this.PorcIrrf.ReadOnly = true;
            this.PorcIrrf.Width = 182;
            // 
            // DescIrrf
            // 
            this.DescIrrf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DescIrrf.DataPropertyName = "Desconto";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            this.DescIrrf.DefaultCellStyle = dataGridViewCellStyle12;
            this.DescIrrf.HeaderText = "Desconto";
            this.DescIrrf.Name = "DescIrrf";
            this.DescIrrf.ReadOnly = true;
            this.DescIrrf.Width = 140;
            // 
            // LblInfoCalcProgr
            // 
            this.LblInfoCalcProgr.AutoSize = true;
            this.LblInfoCalcProgr.Location = new System.Drawing.Point(17, 432);
            this.LblInfoCalcProgr.Name = "LblInfoCalcProgr";
            this.LblInfoCalcProgr.Size = new System.Drawing.Size(31, 29);
            this.LblInfoCalcProgr.TabIndex = 7;
            this.LblInfoCalcProgr.Text = "...";
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
            this.LkLblProjetoGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LkLblProjetoGitHub_LinkClicked);
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
            this.LblInfTabelas.Size = new System.Drawing.Size(31, 29);
            this.LblInfTabelas.TabIndex = 12;
            this.LblInfTabelas.Text = "...";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nº Dependente";
            // 
            // TxtNumDep
            // 
            this.TxtNumDep.Location = new System.Drawing.Point(196, 82);
            this.TxtNumDep.Name = "TxtNumDep";
            this.TxtNumDep.Size = new System.Drawing.Size(73, 35);
            this.TxtNumDep.TabIndex = 15;
            this.TxtNumDep.Text = "0";
            this.TxtNumDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtNumDep.TextChanged += new System.EventHandler(this.TxtNumDep_TextChanged);
            this.TxtNumDep.Enter += new System.EventHandler(this.TxtNumDep_Enter);
            this.TxtNumDep.Leave += new System.EventHandler(this.TxtNumDep_Leave);
            // 
            // LkLblAtualizarTabelas
            // 
            this.LkLblAtualizarTabelas.AutoSize = true;
            this.LkLblAtualizarTabelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LkLblAtualizarTabelas.Location = new System.Drawing.Point(827, 432);
            this.LkLblAtualizarTabelas.Name = "LkLblAtualizarTabelas";
            this.LkLblAtualizarTabelas.Size = new System.Drawing.Size(113, 17);
            this.LkLblAtualizarTabelas.TabIndex = 16;
            this.LkLblAtualizarTabelas.TabStop = true;
            this.LkLblAtualizarTabelas.Text = "Atualizar tabelas";
            this.LkLblAtualizarTabelas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LkLblAtualizarTabelas_LinkClicked);
            // 
            // FrmPrincipalCalcInss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(954, 535);
            this.Controls.Add(this.LkLblAtualizarTabelas);
            this.Controls.Add(this.TxtNumDep);
            this.Controls.Add(this.label2);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.DataGridViewTextBoxColumn FaixaProgr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_FaixaProgr;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcProgr;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescontoProgr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNumDep;
        private System.Windows.Forms.LinkLabel LkLblAtualizarTabelas;
    }
}

