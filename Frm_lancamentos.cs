using System;
using System.Threading;
using System.Windows.Forms;

namespace ControleFinanceiro
{
    public partial class Frm_lancamentos : Form
    {
        public Frm_lancamentos()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                using (FrmUpdateLancamentos fr = new FrmUpdateLancamentos())
                {
                    fr.ShowDialog();
                }
                this.checkBox1.Checked = false;
            }
        }

        private void Frm_lancamentos_Load(object sender, EventArgs e)
        {
            ConexaoDataBase cn = new ConexaoDataBase();
            cn.Searche_Categoria(cbo_categoria);
            
        }

        private void btn_salvar_lancamento_Click(object sender, EventArgs e)
        {
            if (cbo_categoria.Text == string.Empty || txt_valor.Text == string.Empty)
            {
                MessageBox.Show("Preencha os Campos!", "Aviso!", MessageBoxButtons.OK);
                return;
            }

            ConexaoDataBase cn = new ConexaoDataBase();

            string categoria = cbo_categoria.Text;
            decimal valor = Convert.ToDecimal(txt_valor.Text);
            cn.Salvar_Lancamentos(categoria, valor);
            txt_valor.Clear();
            cbo_categoria.SelectedValue = string.Empty;
        }

        private void txt_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 57 || e.KeyChar < 44)
            {
                e.KeyChar = (char)0;
            }
        }

        private void Frm_lancamentos_FormClosed(object sender, FormClosedEventArgs e)
        {
            ConexaoDataBase cn = new ConexaoDataBase();
            cn.Soma_Anual();
            cn.Soma_diaria();

            using (frm_views fr = new frm_views())
            {
                Thread t = new Thread(() => Application.Run(new frm_views()));
                fr.lbl_gasto_anual.Text = string.Format("{0:C2}", cn.result_anual).ToString();
                fr.lbl_gasto_diario.Text = string.Format("{0:C2}", cn.result_diario).ToString();
                t.Start();
            }
        }
    }
}
