using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ControleFinanceiro
{
    public partial class FrmDeleteCategoria : Form
    {
        public FrmDeleteCategoria()
        {
            InitializeComponent();
        }

        private void FrmDeleteCategoria_Load(object sender, EventArgs e)
        {
            ConexaoDataBase cn = new ConexaoDataBase();
            string sql = "SELECT * FROM categoria";
            cn.Buscar_dados_Lisview(sql, list_view_DeletarCategoria);
        }

        private void btn_deletar_categoria_Click(object sender, EventArgs e)
        {
            ConexaoDataBase cn = new ConexaoDataBase();
            try
            {
                if (list_view_DeletarCategoria.FullRowSelect == true)
                {
                    int id = Convert.ToInt16(list_view_DeletarCategoria.SelectedItems[0].SubItems[0].Text);
                    string categoria = list_view_DeletarCategoria.SelectedItems[0].SubItems[1].Text;

                    if (MessageBox.Show(" Deseja deletar a categoria  ->  " + categoria, "Aviso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        string sql = "DELETE FROM categoria WHERE id=" + id;
                        cn.Deletar(id, sql);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um item para deletar ");
                return;
            }

            try
            {
                string sql = "SELECT * FROM categoria";
                cn.Buscar_dados_Lisview(sql, list_view_DeletarCategoria);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao Buscar os dados " + ex.Message);
                return;
            }
        }

    }
}
