using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ControleFinanceiro
{
    public partial class frm_views : Form
    {
        public frm_views()
        {
            InitializeComponent();
        }

        private void frm_views_Load(object sender, System.EventArgs e)
        {
            ConexaoDataBase cn = new ConexaoDataBase();

            DateTime data = DateTime.UtcNow;
            int mes = data.Month;

            string sql = "SELECT Data, Categoria, Valor FROM lancamentos WHERE MONTH(Data) =" + mes;
            cn.Search_Month_Atual(mes, sql, dgv_dados);
            lbl_gasto_mensal.Text = String.Format("{0:C2}", cn.results).ToString();

            // realizar a consulta trazendo a soma de gasto do dia atual
            cn.Soma_diaria();
            lbl_gasto_diario.Text = String.Format("{0:C2}", cn.result_diario).ToString();

            // realizando a consulta para retornar o valor da soma anual
            cn.Soma_Anual();
            lbl_gasto_anual.Text = String.Format("{0:C2}", cn.result_anual).ToString();

            cn.Soma_total();
            lbl_gasto_total.Text = String.Format("{0:C2}", cn.results).ToString();


            //Formantado a coluna de valor para o estilo de moeda
            dgv_dados.Columns["Valor"].DefaultCellStyle.Format = "C";

            //Alinhamento das colunas
            //dgv_dados.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //dgv_dados.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //dgv_dados.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv_dados.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv_dados.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void btn_att_view_lancamentos_Click(object sender, EventArgs e)
        {
            ConexaoDataBase cn = new ConexaoDataBase();
            string sql = "SELECT Data, Categoria, Valor FROM lancamentos ORDER BY Valor ASC";
            cn.Prencher_DataGridview(sql, dgv_dados);
            dgv_dados.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv_dados.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            SomargastoTotal();
        }

        private void btn_form_lancamentos_Click(object sender, EventArgs e)
        {
            using (Frm_lancamentos fr = new Frm_lancamentos())
            {
                fr.ShowDialog();
            }
            Close();
        }

        private void btn_form_categoria_Click(object sender, EventArgs e)
        {
            using (Frm_categorias fr = new Frm_categorias())
            {
                fr.ShowDialog();
            }
        }

        public void SomargastoTotal()
        {
            double valor = 0;

            foreach (DataGridViewRow lin in dgv_dados.Rows)
            {
                valor += Convert.ToDouble(lin.Cells[2].Value);
            }

            lbl_gasto_total.Text = String.Format("{0:C2}", valor).ToString();
        }

        private void data_filtro_ValueChanged(object sender, EventArgs e)
        {
            ConexaoDataBase cn = new ConexaoDataBase();

            try
            {
                int month;
                DateTime dateTime = data_filtro.Value;
                month = dateTime.Month;

                string sql = "SELECT Data, Categoria, Valor FROM lancamentos WHERE MONTH(Data) =" + month;
                cn.Search_Month_Atual(month, sql, dgv_dados);
                dgv_dados.Columns["Valor"].DefaultCellStyle.Format = "C";
                lbl_gasto_mensal.Text = String.Format("{0:C2}", cn.results).ToString();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao Buscar os dados pelo filtro de data " + ex.Message);
            }
            finally { cn.Desconectar(); }
        }
    }
}
