namespace ControleFinanceiro
{
    partial class frm_views
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_att_view_lancamentos = new System.Windows.Forms.Button();
            this.btn_form_lancamentos = new System.Windows.Forms.Button();
            this.btn_form_categoria = new System.Windows.Forms.Button();
            this.data_filtro = new System.Windows.Forms.DateTimePicker();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CircleProgressBar2 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.img_user = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgv_dados = new System.Windows.Forms.DataGridView();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_gasto_total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_saudacao = new System.Windows.Forms.Label();
            this.lblNome_usuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_gasto_mensal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_gasto_diario = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_gasto_anual = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_Valores_selecionados = new System.Windows.Forms.Label();
            this.guna2CircleProgressBar2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_user)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "LD System";
            // 
            // btn_att_view_lancamentos
            // 
            this.btn_att_view_lancamentos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_att_view_lancamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_att_view_lancamentos.FlatAppearance.BorderSize = 0;
            this.btn_att_view_lancamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(199)))), ((int)(((byte)(111)))));
            this.btn_att_view_lancamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(199)))), ((int)(((byte)(111)))));
            this.btn_att_view_lancamentos.Image = global::ControleFinanceiro.Properties.Resources.icons8_available_updates_32;
            this.btn_att_view_lancamentos.Location = new System.Drawing.Point(426, 143);
            this.btn_att_view_lancamentos.Name = "btn_att_view_lancamentos";
            this.btn_att_view_lancamentos.Size = new System.Drawing.Size(54, 41);
            this.btn_att_view_lancamentos.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btn_att_view_lancamentos, "Atualiza os Itens da Lista");
            this.btn_att_view_lancamentos.UseVisualStyleBackColor = true;
            this.btn_att_view_lancamentos.Click += new System.EventHandler(this.btn_att_view_lancamentos_Click);
            // 
            // btn_form_lancamentos
            // 
            this.btn_form_lancamentos.BackColor = System.Drawing.Color.Transparent;
            this.btn_form_lancamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_form_lancamentos.Image = global::ControleFinanceiro.Properties.Resources.icons8_add_dollar_32;
            this.btn_form_lancamentos.Location = new System.Drawing.Point(542, 143);
            this.btn_form_lancamentos.Name = "btn_form_lancamentos";
            this.btn_form_lancamentos.Size = new System.Drawing.Size(54, 41);
            this.btn_form_lancamentos.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btn_form_lancamentos, "Novo Registro");
            this.btn_form_lancamentos.UseVisualStyleBackColor = false;
            this.btn_form_lancamentos.Click += new System.EventHandler(this.btn_form_lancamentos_Click);
            // 
            // btn_form_categoria
            // 
            this.btn_form_categoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_form_categoria.Image = global::ControleFinanceiro.Properties.Resources.icons8_add_to_database;
            this.btn_form_categoria.Location = new System.Drawing.Point(484, 143);
            this.btn_form_categoria.Name = "btn_form_categoria";
            this.btn_form_categoria.Size = new System.Drawing.Size(54, 41);
            this.btn_form_categoria.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btn_form_categoria, "Adcionar nova categoria");
            this.btn_form_categoria.UseVisualStyleBackColor = true;
            this.btn_form_categoria.Click += new System.EventHandler(this.btn_form_categoria_Click);
            // 
            // data_filtro
            // 
            this.data_filtro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_filtro.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_filtro.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(62)))), ((int)(((byte)(249)))));
            this.data_filtro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.data_filtro.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_filtro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_filtro.Location = new System.Drawing.Point(309, 158);
            this.data_filtro.Name = "data_filtro";
            this.data_filtro.Size = new System.Drawing.Size(112, 25);
            this.data_filtro.TabIndex = 11;
            this.toolTip1.SetToolTip(this.data_filtro, "Selecione uma data para realizar um filtro por mês");
            this.data_filtro.ValueChanged += new System.EventHandler(this.data_filtro_ValueChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2CircleProgressBar2
            // 
            this.guna2CircleProgressBar2.AnimationSpeed = 0.3F;
            this.guna2CircleProgressBar2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleProgressBar2.Controls.Add(this.img_user);
            this.guna2CircleProgressBar2.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleProgressBar2.FillThickness = 6;
            this.guna2CircleProgressBar2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBar2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar2.Location = new System.Drawing.Point(4, 3);
            this.guna2CircleProgressBar2.Minimum = 0;
            this.guna2CircleProgressBar2.Name = "guna2CircleProgressBar2";
            this.guna2CircleProgressBar2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.guna2CircleProgressBar2.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.guna2CircleProgressBar2.ProgressThickness = 7;
            this.guna2CircleProgressBar2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar2.Size = new System.Drawing.Size(176, 176);
            this.guna2CircleProgressBar2.TabIndex = 1;
            this.guna2CircleProgressBar2.Text = "guna2CircleProgressBar2";
            this.guna2CircleProgressBar2.Value = 90;
            // 
            // img_user
            // 
            this.img_user.Image = global::ControleFinanceiro.Properties.Resources.luiz;
            this.img_user.ImageRotate = 0F;
            this.img_user.Location = new System.Drawing.Point(15, 13);
            this.img_user.Name = "img_user";
            this.img_user.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.img_user.Size = new System.Drawing.Size(146, 149);
            this.img_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_user.TabIndex = 1;
            this.img_user.TabStop = false;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(62)))), ((int)(((byte)(249)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(568, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(36, 31);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.guna2Panel1.BorderRadius = 25;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.guna2Panel1.Controls.Add(this.dgv_dados);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(13, 194);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(583, 320);
            this.guna2Panel1.TabIndex = 3;
            // 
            // dgv_dados
            // 
            this.dgv_dados.AllowUserToAddRows = false;
            this.dgv_dados.AllowUserToDeleteRows = false;
            this.dgv_dados.AllowUserToResizeColumns = false;
            this.dgv_dados.AllowUserToResizeRows = false;
            this.dgv_dados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.dgv_dados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_dados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_dados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(62)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_dados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_dados.ColumnHeadersHeight = 38;
            this.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_dados.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(199)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_dados.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_dados.GridColor = System.Drawing.Color.White;
            this.dgv_dados.Location = new System.Drawing.Point(12, 9);
            this.dgv_dados.Name = "dgv_dados";
            this.dgv_dados.ReadOnly = true;
            this.dgv_dados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_dados.RowHeadersVisible = false;
            this.dgv_dados.RowHeadersWidth = 35;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(62)))), ((int)(((byte)(249)))));
            this.dgv_dados.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgv_dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dados.ShowCellToolTips = false;
            this.dgv_dados.Size = new System.Drawing.Size(559, 302);
            this.dgv_dados.TabIndex = 0;
            this.dgv_dados.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_dados_MouseClick);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(62)))), ((int)(((byte)(249)))));
            this.guna2Panel2.Controls.Add(this.lbl_Valores_selecionados);
            this.guna2Panel2.Controls.Add(this.data_filtro);
            this.guna2Panel2.Controls.Add(this.btn_form_lancamentos);
            this.guna2Panel2.Controls.Add(this.btn_form_categoria);
            this.guna2Panel2.Controls.Add(this.btn_att_view_lancamentos);
            this.guna2Panel2.Controls.Add(this.lbl_gasto_total);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.lbl_saudacao);
            this.guna2Panel2.Controls.Add(this.lblNome_usuario);
            this.guna2Panel2.Controls.Add(this.guna2CircleProgressBar2);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(608, 188);
            this.guna2Panel2.TabIndex = 4;
            // 
            // lbl_gasto_total
            // 
            this.lbl_gasto_total.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gasto_total.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_gasto_total.Location = new System.Drawing.Point(429, 60);
            this.lbl_gasto_total.Name = "lbl_gasto_total";
            this.lbl_gasto_total.Size = new System.Drawing.Size(167, 32);
            this.lbl_gasto_total.TabIndex = 7;
            this.lbl_gasto_total.Text = "R$ ";
            this.lbl_gasto_total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(424, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(4, 56);
            this.label2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(431, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gasto total ";
            // 
            // lbl_saudacao
            // 
            this.lbl_saudacao.AutoSize = true;
            this.lbl_saudacao.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saudacao.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_saudacao.Location = new System.Drawing.Point(185, 37);
            this.lbl_saudacao.Name = "lbl_saudacao";
            this.lbl_saudacao.Size = new System.Drawing.Size(72, 20);
            this.lbl_saudacao.TabIndex = 4;
            this.lbl_saudacao.Text = "Bom Dia!";
            // 
            // lblNome_usuario
            // 
            this.lblNome_usuario.AutoSize = true;
            this.lblNome_usuario.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome_usuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNome_usuario.Location = new System.Drawing.Point(184, 61);
            this.lblNome_usuario.Name = "lblNome_usuario";
            this.lblNome_usuario.Size = new System.Drawing.Size(134, 29);
            this.lblNome_usuario.TabIndex = 3;
            this.lblNome_usuario.Text = "Name User";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(62)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(5, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(4, 65);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(62)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(6, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(4, 65);
            this.label4.TabIndex = 5;
            this.label4.Text = "label3";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(62)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(6, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(4, 65);
            this.label5.TabIndex = 5;
            this.label5.Text = "label3";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderRadius = 15;
            this.guna2Panel3.Controls.Add(this.lbl_gasto_mensal);
            this.guna2Panel3.Controls.Add(this.label6);
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(12, 530);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(181, 80);
            this.guna2Panel3.TabIndex = 6;
            // 
            // lbl_gasto_mensal
            // 
            this.lbl_gasto_mensal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_gasto_mensal.BackColor = System.Drawing.Color.White;
            this.lbl_gasto_mensal.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gasto_mensal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_gasto_mensal.Location = new System.Drawing.Point(13, 38);
            this.lbl_gasto_mensal.Name = "lbl_gasto_mensal";
            this.lbl_gasto_mensal.Size = new System.Drawing.Size(164, 37);
            this.lbl_gasto_mensal.TabIndex = 7;
            this.lbl_gasto_mensal.Text = "R$ 00,00";
            this.lbl_gasto_mensal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(16, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Gasto Mensal";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderRadius = 15;
            this.guna2Panel4.Controls.Add(this.lbl_gasto_diario);
            this.guna2Panel4.Controls.Add(this.label8);
            this.guna2Panel4.Controls.Add(this.label5);
            this.guna2Panel4.FillColor = System.Drawing.Color.White;
            this.guna2Panel4.Location = new System.Drawing.Point(414, 530);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(181, 80);
            this.guna2Panel4.TabIndex = 6;
            // 
            // lbl_gasto_diario
            // 
            this.lbl_gasto_diario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_gasto_diario.BackColor = System.Drawing.Color.White;
            this.lbl_gasto_diario.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gasto_diario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_gasto_diario.Location = new System.Drawing.Point(12, 38);
            this.lbl_gasto_diario.Name = "lbl_gasto_diario";
            this.lbl_gasto_diario.Size = new System.Drawing.Size(164, 37);
            this.lbl_gasto_diario.TabIndex = 7;
            this.lbl_gasto_diario.Text = "R$ 00,00";
            this.lbl_gasto_diario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(14, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Gasto Diario";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BorderRadius = 15;
            this.guna2Panel5.Controls.Add(this.lbl_gasto_anual);
            this.guna2Panel5.Controls.Add(this.label9);
            this.guna2Panel5.Controls.Add(this.label4);
            this.guna2Panel5.FillColor = System.Drawing.Color.White;
            this.guna2Panel5.Location = new System.Drawing.Point(213, 530);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(181, 80);
            this.guna2Panel5.TabIndex = 6;
            // 
            // lbl_gasto_anual
            // 
            this.lbl_gasto_anual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_gasto_anual.BackColor = System.Drawing.Color.White;
            this.lbl_gasto_anual.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gasto_anual.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_gasto_anual.Location = new System.Drawing.Point(14, 38);
            this.lbl_gasto_anual.Name = "lbl_gasto_anual";
            this.lbl_gasto_anual.Size = new System.Drawing.Size(164, 37);
            this.lbl_gasto_anual.TabIndex = 7;
            this.lbl_gasto_anual.Text = "R$ 00,00";
            this.lbl_gasto_anual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(14, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 22);
            this.label9.TabIndex = 7;
            this.label9.Text = "Gasto Anual";
            // 
            // lbl_Valores_selecionados
            // 
            this.lbl_Valores_selecionados.AutoSize = true;
            this.lbl_Valores_selecionados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Valores_selecionados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Valores_selecionados.Location = new System.Drawing.Point(423, 116);
            this.lbl_Valores_selecionados.Name = "lbl_Valores_selecionados";
            this.lbl_Valores_selecionados.Size = new System.Drawing.Size(34, 16);
            this.lbl_Valores_selecionados.TabIndex = 12;
            this.lbl_Valores_selecionados.Text = "R$...";
            // 
            // frm_views
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(608, 623);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_views";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_views_Load);
            this.guna2CircleProgressBar2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_user)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox img_user;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lbl_saudacao;
        private System.Windows.Forms.Label lblNome_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_gasto_total;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DataGridView dgv_dados;
        private System.Windows.Forms.Button btn_att_view_lancamentos;
        private System.Windows.Forms.Button btn_form_categoria;
        private System.Windows.Forms.Button btn_form_lancamentos;
        public System.Windows.Forms.Label lbl_gasto_mensal;
        public System.Windows.Forms.Label lbl_gasto_diario;
        public System.Windows.Forms.Label lbl_gasto_anual;
        private System.Windows.Forms.DateTimePicker data_filtro;
        private System.Windows.Forms.Label lbl_Valores_selecionados;
    }
}

