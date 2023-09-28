using System;
using System.Windows.Forms;

namespace ControleFinanceiro
{
    public partial class Frm_categorias : Form
    {
        public Frm_categorias()
        {
            InitializeComponent();
        }

        private void Frm_categorias_Load(object sender, EventArgs e)
        {
            this.txt_frm_categoria.CharacterCasing = CharacterCasing.Upper;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txt_frm_categoria.Text == "" || txt_frm_categoria.Text == string.Empty || txt_frm_categoria.TextLength < 4)
            {
                MessageBox.Show("O campo categoria é obrigatório, ou quantidade de caractere não permitida", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ConexaoDataBase cn = new ConexaoDataBase();
            string value = txt_frm_categoria.Text;
            cn.salvar_Categoria(value);
            txt_frm_categoria.ResetText();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                using (FrmDeleteCategoria fr = new FrmDeleteCategoria())
                {
                    fr.ShowDialog();
                    checkBox1.Checked = false;
                }
            }
        }
    }
}
