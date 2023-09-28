using System;
using System.Windows.Forms;

namespace ControleFinanceiro
{
    public partial class FrmUpdateLancamentos : Form
    {
        public FrmUpdateLancamentos()
        {
            InitializeComponent();
        }

        private void FrmUpdateLancamentos_Load(object sender, EventArgs e)
        {
            ConexaoDataBase cn = new ConexaoDataBase();
            ListViewItem item = new ListViewItem();

            /*
                Iremos usar um recurso de converão de datas - uma função nativa do mysql
                DATE_FORMAT('FORMATO', GET_FORMAT(DATE, 'O PAÍS'))
                outra maneira seria ->> DATE_FORMAT(Data, '%d/%m/%Y')
                %d -> REPRESENTA O DIA
                %m -> REPRESENTA O MÊS
                %Y -> REPRESENTA O ANO
            */

            string sql = "SELECT id, DATE_FORMAT(Data, '%d/%m/%Y') as Data, Categoria, Valor FROM lancamentos";
            cn.Buscar_dados_Lisview(sql, listview_update_lancamentos);

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 57 || e.KeyChar < 34)
            {
                e.KeyChar = (char)0;
            }
        }

        private void listview_update_lancamentos_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = listview_update_lancamentos.SelectedItems[0].SubItems[2].Text;
            textBox2.Text = listview_update_lancamentos.SelectedItems[0].SubItems[3].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
                {
                    MessageBox.Show("Existe campo vazio.", "Aviso!", MessageBoxButtons.OK);
                    return;
                }

                int id = int.Parse(listview_update_lancamentos.SelectedItems[0].SubItems[0].Text);
                string sql = "UPDATE lancamentos SET Categoria ='" + textBox1.Text + "', Valor =" + Convert.ToDouble(textBox2.Text) + " WHERE id=" + id;

                if (MessageBox.Show("Deseja Alterar ese registro ? ", "Aviso!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ConexaoDataBase cn = new ConexaoDataBase();
                    cn.Update_lancamentos(id, sql);
                    textBox1.Text = string.Empty; textBox2.Text = string.Empty;
                }
                else { return; }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecione um item para editar!" + "\n" + ex.Message);
                return;
            }
        }
    }
}
