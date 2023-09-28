namespace ControleFinanceiro
{
    partial class Frm_lancamentos
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
            this.components = new System.ComponentModel.Container();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btn_salvar_lancamento = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txt_valor = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbo_categoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(229, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(38, 21);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // btn_salvar_lancamento
            // 
            this.btn_salvar_lancamento.BorderRadius = 5;
            this.btn_salvar_lancamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar_lancamento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_salvar_lancamento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_salvar_lancamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_salvar_lancamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_salvar_lancamento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(62)))), ((int)(((byte)(249)))));
            this.btn_salvar_lancamento.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar_lancamento.ForeColor = System.Drawing.Color.White;
            this.btn_salvar_lancamento.Location = new System.Drawing.Point(24, 213);
            this.btn_salvar_lancamento.Name = "btn_salvar_lancamento";
            this.btn_salvar_lancamento.Size = new System.Drawing.Size(223, 45);
            this.btn_salvar_lancamento.TabIndex = 1;
            this.btn_salvar_lancamento.Text = "Salvar";
            this.btn_salvar_lancamento.Click += new System.EventHandler(this.btn_salvar_lancamento_Click);
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txt_valor
            // 
            this.txt_valor.BackColor = System.Drawing.Color.LightGray;
            this.txt_valor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(62)))), ((int)(((byte)(249)))));
            this.txt_valor.BorderRadius = 5;
            this.txt_valor.BorderThickness = 2;
            this.txt_valor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_valor.DefaultText = "";
            this.txt_valor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_valor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_valor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_valor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_valor.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_valor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_valor.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_valor.Location = new System.Drawing.Point(13, 90);
            this.txt_valor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_valor.MaxLength = 12;
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.PasswordChar = '\0';
            this.txt_valor.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_valor.PlaceholderText = "Digite o Valor R$";
            this.txt_valor.SelectedText = "";
            this.txt_valor.Size = new System.Drawing.Size(244, 41);
            this.txt_valor.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_valor.TabIndex = 3;
            this.txt_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_KeyPress);
            // 
            // cbo_categoria
            // 
            this.cbo_categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.cbo_categoria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(62)))), ((int)(((byte)(249)))));
            this.cbo_categoria.BorderThickness = 2;
            this.cbo_categoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_categoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_categoria.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_categoria.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_categoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_categoria.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_categoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_categoria.ItemHeight = 30;
            this.cbo_categoria.Location = new System.Drawing.Point(12, 47);
            this.cbo_categoria.Name = "cbo_categoria";
            this.cbo_categoria.Size = new System.Drawing.Size(246, 36);
            this.cbo_categoria.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecione uma Categoria";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(16, 159);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 22);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Editar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Frm_lancamentos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(270, 265);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_categoria);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.btn_salvar_lancamento);
            this.Controls.Add(this.guna2ControlBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_lancamentos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_lancamentos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_lancamentos_FormClosed);
            this.Load += new System.EventHandler(this.Frm_lancamentos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button btn_salvar_lancamento;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_categoria;
        private Guna.UI2.WinForms.Guna2TextBox txt_valor;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}