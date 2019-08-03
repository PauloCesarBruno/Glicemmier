namespace Apresentacao_Usuario
{
    partial class frmManipularParametros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManipularParametros));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCorrecao = new System.Windows.Forms.DataGridView();
            this.IdCorrecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parametro_Minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parametro_Maximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antes_Cafe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antes_Almoco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antes_Lanche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antes_Jantar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antes_Ceia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblcabecalho = new System.Windows.Forms.Label();
            this.grpManipulacao = new System.Windows.Forms.GroupBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtBuscaDia = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblBuscaParametro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnInserir_Parametros = new System.Windows.Forms.Button();
            this.txtPmim = new System.Windows.Forms.TextBox();
            this.txtPmax = new System.Windows.Forms.TextBox();
            this.txtCafe = new System.Windows.Forms.TextBox();
            this.txtAlmoco = new System.Windows.Forms.TextBox();
            this.txtJantar = new System.Windows.Forms.TextBox();
            this.txtCeia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLanche = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrecao)).BeginInit();
            this.grpManipulacao.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(0, 1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(754, 100);
            this.panel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Glicemmier Verssão 1.0  ®";
            // 
            // dgvCorrecao
            // 
            this.dgvCorrecao.AllowUserToAddRows = false;
            this.dgvCorrecao.AllowUserToDeleteRows = false;
            this.dgvCorrecao.BackgroundColor = System.Drawing.Color.White;
            this.dgvCorrecao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorrecao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCorrecao,
            this.Parametro_Minimo,
            this.Parametro_Maximo,
            this.Antes_Cafe,
            this.Antes_Almoco,
            this.Antes_Lanche,
            this.Antes_Jantar,
            this.Antes_Ceia});
            this.dgvCorrecao.GridColor = System.Drawing.Color.Gray;
            this.dgvCorrecao.Location = new System.Drawing.Point(9, 129);
            this.dgvCorrecao.Name = "dgvCorrecao";
            this.dgvCorrecao.ReadOnly = true;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvCorrecao.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCorrecao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvCorrecao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCorrecao.Size = new System.Drawing.Size(394, 156);
            this.dgvCorrecao.TabIndex = 10001;
            this.dgvCorrecao.TabStop = false;
            this.dgvCorrecao.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCorrecao_CellEnter);
            // 
            // IdCorrecao
            // 
            this.IdCorrecao.DataPropertyName = "IdCorrecao";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdCorrecao.DefaultCellStyle = dataGridViewCellStyle1;
            this.IdCorrecao.HeaderText = "Código";
            this.IdCorrecao.Name = "IdCorrecao";
            this.IdCorrecao.ReadOnly = true;
            this.IdCorrecao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdCorrecao.Visible = false;
            this.IdCorrecao.Width = 50;
            // 
            // Parametro_Minimo
            // 
            this.Parametro_Minimo.DataPropertyName = "Parametro_Minimo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Lime;
            this.Parametro_Minimo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Parametro_Minimo.HeaderText = "P.Min.";
            this.Parametro_Minimo.Name = "Parametro_Minimo";
            this.Parametro_Minimo.ReadOnly = true;
            this.Parametro_Minimo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Parametro_Minimo.Width = 50;
            // 
            // Parametro_Maximo
            // 
            this.Parametro_Maximo.DataPropertyName = "Parametro_Maximo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.Parametro_Maximo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Parametro_Maximo.HeaderText = "P.Max.";
            this.Parametro_Maximo.Name = "Parametro_Maximo";
            this.Parametro_Maximo.ReadOnly = true;
            this.Parametro_Maximo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Parametro_Maximo.Width = 50;
            // 
            // Antes_Cafe
            // 
            this.Antes_Cafe.DataPropertyName = "Dose_Cafe";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Antes_Cafe.DefaultCellStyle = dataGridViewCellStyle4;
            this.Antes_Cafe.HeaderText = "Café";
            this.Antes_Cafe.Name = "Antes_Cafe";
            this.Antes_Cafe.ReadOnly = true;
            this.Antes_Cafe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Antes_Cafe.Width = 50;
            // 
            // Antes_Almoco
            // 
            this.Antes_Almoco.DataPropertyName = "Dose_Almoco";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Antes_Almoco.DefaultCellStyle = dataGridViewCellStyle5;
            this.Antes_Almoco.HeaderText = "Almoço";
            this.Antes_Almoco.Name = "Antes_Almoco";
            this.Antes_Almoco.ReadOnly = true;
            this.Antes_Almoco.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Antes_Almoco.Width = 50;
            // 
            // Antes_Lanche
            // 
            this.Antes_Lanche.DataPropertyName = "Dose_Lanche";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Antes_Lanche.DefaultCellStyle = dataGridViewCellStyle6;
            this.Antes_Lanche.HeaderText = "Lanche";
            this.Antes_Lanche.Name = "Antes_Lanche";
            this.Antes_Lanche.ReadOnly = true;
            this.Antes_Lanche.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Antes_Lanche.Width = 50;
            // 
            // Antes_Jantar
            // 
            this.Antes_Jantar.DataPropertyName = "Dose_Jantar";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Antes_Jantar.DefaultCellStyle = dataGridViewCellStyle7;
            this.Antes_Jantar.HeaderText = "Jantar";
            this.Antes_Jantar.Name = "Antes_Jantar";
            this.Antes_Jantar.ReadOnly = true;
            this.Antes_Jantar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Antes_Jantar.Width = 50;
            // 
            // Antes_Ceia
            // 
            this.Antes_Ceia.DataPropertyName = "Dose_Ceia";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Antes_Ceia.DefaultCellStyle = dataGridViewCellStyle8;
            this.Antes_Ceia.HeaderText = "Ceia";
            this.Antes_Ceia.Name = "Antes_Ceia";
            this.Antes_Ceia.ReadOnly = true;
            this.Antes_Ceia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Antes_Ceia.Width = 50;
            // 
            // lblcabecalho
            // 
            this.lblcabecalho.AutoSize = true;
            this.lblcabecalho.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcabecalho.Location = new System.Drawing.Point(5, 102);
            this.lblcabecalho.Name = "lblcabecalho";
            this.lblcabecalho.Size = new System.Drawing.Size(95, 24);
            this.lblcabecalho.TabIndex = 10002;
            this.lblcabecalho.Text = "Cabeçalho:";
            // 
            // grpManipulacao
            // 
            this.grpManipulacao.Controls.Add(this.btnAlterar);
            this.grpManipulacao.Controls.Add(this.btnSair);
            this.grpManipulacao.Controls.Add(this.btnImprimir);
            this.grpManipulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpManipulacao.ForeColor = System.Drawing.Color.Blue;
            this.grpManipulacao.Location = new System.Drawing.Point(421, 260);
            this.grpManipulacao.Name = "grpManipulacao";
            this.grpManipulacao.Size = new System.Drawing.Size(324, 90);
            this.grpManipulacao.TabIndex = 10003;
            this.grpManipulacao.TabStop = false;
            this.grpManipulacao.Text = "Botões de Manipulação:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAlterar.FlatAppearance.BorderSize = 2;
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.Black;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAlterar.Location = new System.Drawing.Point(8, 21);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(99, 54);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "&Alterar Parâmetros";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSair.FlatAppearance.BorderSize = 2;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.Location = new System.Drawing.Point(218, 21);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 54);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnImprimir.FlatAppearance.BorderSize = 2;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.Black;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnImprimir.Location = new System.Drawing.Point(113, 21);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(99, 54);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "&Imprimir Parametrôs";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtBuscaDia
            // 
            this.txtBuscaDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBuscaDia.Location = new System.Drawing.Point(450, 152);
            this.txtBuscaDia.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscaDia.Name = "txtBuscaDia";
            this.txtBuscaDia.Size = new System.Drawing.Size(49, 20);
            this.txtBuscaDia.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.Red;
            this.btnOk.Location = new System.Drawing.Point(503, 152);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(36, 21);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblBuscaParametro
            // 
            this.lblBuscaParametro.AutoSize = true;
            this.lblBuscaParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaParametro.ForeColor = System.Drawing.Color.Red;
            this.lblBuscaParametro.Location = new System.Drawing.Point(446, 135);
            this.lblBuscaParametro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscaParametro.Name = "lblBuscaParametro";
            this.lblBuscaParametro.Size = new System.Drawing.Size(175, 13);
            this.lblBuscaParametro.TabIndex = 30006;
            this.lblBuscaParametro.Text = "Busca P/ Parâmetro MÍNIMO:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(0, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 18);
            this.panel1.TabIndex = 70002;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Desenvolvido por Paulo Bruno ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(624, 135);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(99, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 70003;
            this.pictureBox3.TabStop = false;
            // 
            // btnInserir_Parametros
            // 
            this.btnInserir_Parametros.Enabled = false;
            this.btnInserir_Parametros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnInserir_Parametros.FlatAppearance.BorderSize = 2;
            this.btnInserir_Parametros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInserir_Parametros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir_Parametros.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir_Parametros.ForeColor = System.Drawing.Color.Blue;
            this.btnInserir_Parametros.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir_Parametros.Image")));
            this.btnInserir_Parametros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir_Parametros.Location = new System.Drawing.Point(9, 291);
            this.btnInserir_Parametros.Name = "btnInserir_Parametros";
            this.btnInserir_Parametros.Size = new System.Drawing.Size(394, 26);
            this.btnInserir_Parametros.TabIndex = 70005;
            this.btnInserir_Parametros.TabStop = false;
            this.btnInserir_Parametros.Text = "Inserir &Parâmetros";
            this.btnInserir_Parametros.UseVisualStyleBackColor = true;
            // 
            // txtPmim
            // 
            this.txtPmim.ForeColor = System.Drawing.Color.Lime;
            this.txtPmim.Location = new System.Drawing.Point(442, 226);
            this.txtPmim.Name = "txtPmim";
            this.txtPmim.Size = new System.Drawing.Size(36, 20);
            this.txtPmim.TabIndex = 70006;
            this.txtPmim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPmax
            // 
            this.txtPmax.ForeColor = System.Drawing.Color.Red;
            this.txtPmax.Location = new System.Drawing.Point(485, 227);
            this.txtPmax.Name = "txtPmax";
            this.txtPmax.Size = new System.Drawing.Size(36, 20);
            this.txtPmax.TabIndex = 70007;
            this.txtPmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCafe
            // 
            this.txtCafe.Location = new System.Drawing.Point(526, 227);
            this.txtCafe.Name = "txtCafe";
            this.txtCafe.Size = new System.Drawing.Size(36, 20);
            this.txtCafe.TabIndex = 70008;
            this.txtCafe.TabStop = false;
            this.txtCafe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAlmoco
            // 
            this.txtAlmoco.Location = new System.Drawing.Point(567, 227);
            this.txtAlmoco.Name = "txtAlmoco";
            this.txtAlmoco.Size = new System.Drawing.Size(36, 20);
            this.txtAlmoco.TabIndex = 70009;
            this.txtAlmoco.TabStop = false;
            this.txtAlmoco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtJantar
            // 
            this.txtJantar.Location = new System.Drawing.Point(649, 227);
            this.txtJantar.Name = "txtJantar";
            this.txtJantar.Size = new System.Drawing.Size(36, 20);
            this.txtJantar.TabIndex = 70010;
            this.txtJantar.TabStop = false;
            this.txtJantar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCeia
            // 
            this.txtCeia.Location = new System.Drawing.Point(690, 227);
            this.txtCeia.Name = "txtCeia";
            this.txtCeia.Size = new System.Drawing.Size(36, 20);
            this.txtCeia.TabIndex = 70011;
            this.txtCeia.TabStop = false;
            this.txtCeia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 70012;
            this.label2.Text = "P.Min.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 70013;
            this.label3.Text = "P.Max.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 70014;
            this.label4.Text = "Café";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(565, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 70015;
            this.label5.Text = "Almoço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(648, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 70016;
            this.label6.Text = "Jantar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(689, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 70017;
            this.label7.Text = "Ceia";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(442, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 10);
            this.panel2.TabIndex = 70018;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(605, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 70020;
            this.label8.Text = "Lanche";
            // 
            // txtLanche
            // 
            this.txtLanche.ForeColor = System.Drawing.Color.Black;
            this.txtLanche.Location = new System.Drawing.Point(608, 227);
            this.txtLanche.Name = "txtLanche";
            this.txtLanche.Size = new System.Drawing.Size(36, 20);
            this.txtLanche.TabIndex = 70019;
            this.txtLanche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLanche.TextChanged += new System.EventHandler(this.txtLanche_TextChanged);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAtualizar.FlatAppearance.BorderSize = 2;
            this.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.Blue;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(8, 320);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(395, 26);
            this.btnAtualizar.TabIndex = 70021;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Text = "A&tualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.ForeColor = System.Drawing.Color.Lime;
            this.txtCodigo.Location = new System.Drawing.Point(513, 171);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(36, 20);
            this.txtCodigo.TabIndex = 70022;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigo.Visible = false;
            // 
            // frmManipularParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 375);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLanche);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCeia);
            this.Controls.Add(this.txtJantar);
            this.Controls.Add(this.txtAlmoco);
            this.Controls.Add(this.txtCafe);
            this.Controls.Add(this.txtPmax);
            this.Controls.Add(this.txtPmim);
            this.Controls.Add(this.btnInserir_Parametros);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBuscaDia);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblBuscaParametro);
            this.Controls.Add(this.grpManipulacao);
            this.Controls.Add(this.lblcabecalho);
            this.Controls.Add(this.dgvCorrecao);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmManipularParametros";
            this.Text = "Alteração dos Parâmetros Glicêmicos";
            this.Load += new System.EventHandler(this.frmManipularParametros_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmManipularParametros_KeyDown);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrecao)).EndInit();
            this.grpManipulacao.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCorrecao;
        private System.Windows.Forms.Label lblcabecalho;
        private System.Windows.Forms.GroupBox grpManipulacao;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtBuscaDia;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblBuscaParametro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnInserir_Parametros;
        private System.Windows.Forms.TextBox txtPmim;
        private System.Windows.Forms.TextBox txtPmax;
        private System.Windows.Forms.TextBox txtCafe;
        private System.Windows.Forms.TextBox txtAlmoco;
        private System.Windows.Forms.TextBox txtJantar;
        private System.Windows.Forms.TextBox txtCeia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLanche;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCorrecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parametro_Minimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parametro_Maximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Antes_Cafe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Antes_Almoco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Antes_Lanche;
        private System.Windows.Forms.DataGridViewTextBoxColumn Antes_Jantar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Antes_Ceia;
        private System.Windows.Forms.Label label9;
    }
}