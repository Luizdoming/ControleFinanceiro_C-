namespace ControleFinanceiro
{
    partial class FrmDeleteCategoria
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
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.list_view_DeletarCategoria = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_deletar_categoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.guna2ControlBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(186, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // list_view_DeletarCategoria
            // 
            this.list_view_DeletarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.list_view_DeletarCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_view_DeletarCategoria.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Categoria});
            this.list_view_DeletarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.list_view_DeletarCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_view_DeletarCategoria.ForeColor = System.Drawing.Color.DimGray;
            this.list_view_DeletarCategoria.FullRowSelect = true;
            this.list_view_DeletarCategoria.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_view_DeletarCategoria.HideSelection = false;
            this.list_view_DeletarCategoria.Location = new System.Drawing.Point(7, 30);
            this.list_view_DeletarCategoria.MultiSelect = false;
            this.list_view_DeletarCategoria.Name = "list_view_DeletarCategoria";
            this.list_view_DeletarCategoria.Size = new System.Drawing.Size(216, 232);
            this.list_view_DeletarCategoria.TabIndex = 1;
            this.list_view_DeletarCategoria.UseCompatibleStateImageBehavior = false;
            this.list_view_DeletarCategoria.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 1;
            // 
            // Categoria
            // 
            this.Categoria.Text = "Categoria";
            this.Categoria.Width = 180;
            // 
            // btn_deletar_categoria
            // 
            this.btn_deletar_categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(62)))), ((int)(((byte)(249)))));
            this.btn_deletar_categoria.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar_categoria.ForeColor = System.Drawing.Color.White;
            this.btn_deletar_categoria.Location = new System.Drawing.Point(4, 268);
            this.btn_deletar_categoria.Name = "btn_deletar_categoria";
            this.btn_deletar_categoria.Size = new System.Drawing.Size(75, 35);
            this.btn_deletar_categoria.TabIndex = 2;
            this.btn_deletar_categoria.Text = "Deletar";
            this.btn_deletar_categoria.UseVisualStyleBackColor = false;
            this.btn_deletar_categoria.Click += new System.EventHandler(this.btn_deletar_categoria_Click);
            // 
            // FrmDeleteCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(230, 308);
            this.Controls.Add(this.btn_deletar_categoria);
            this.Controls.Add(this.list_view_DeletarCategoria);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDeleteCategoria";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmDeleteCategoria";
            this.Load += new System.EventHandler(this.FrmDeleteCategoria_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Categoria;
        private System.Windows.Forms.Button btn_deletar_categoria;
        public System.Windows.Forms.ListView list_view_DeletarCategoria;
    }
}