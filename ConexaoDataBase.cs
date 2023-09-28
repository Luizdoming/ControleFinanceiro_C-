using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ControleFinanceiro
{
    public class ConexaoDataBase
    {
        //campos
        public double results { get; set; }
        public double result_diario { get; set; }
        public double result_anual { get; set; }

        //conecção online
        //string conection_string = "SERVER=dbtesteluiz.mysql.uhserver.com; DATABASE=dbtesteluiz; UID=luiz_teste; PWD=l270815**; PORT=";

        //conecção local
        string conection_string = "datasource=localhost; port=3306; username=root; password=270815**;database=dadosonline";

        //conector
        public MySqlConnection conexao;

        //Metodo para conectar ao banco de dados
        public void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(conection_string);
                conexao.Open();

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados " + e.Message);
                return;
            }
        }

        // metodo para o fechamento da conexao com o banco de dados
        public void Desconectar()
        {
            try
            {
                using (conexao = new MySqlConnection(conection_string))
                {
                    conexao.Close();
                    conexao.Dispose();
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erro ao fechar a conexão com obanco de dados " + e.Message);
            }
        }

        public void salvar_Categoria(string categoria)
        {
            try
            {
                //Iniciamos a conexão com banco de dados
                Conectar();

                string sql = "INSERT INTO categoria(Nome) VALUES(@Nome)";
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.CommandTimeout = 0;
                    cmd.Parameters.AddWithValue("@Nome", categoria);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Categoria adcionada.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erro ao salvar categoria", "Aviso!" + e.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public void Searche_Categoria(Guna.UI2.WinForms.Guna2ComboBox comboBox)
        {
            try
            {
                Conectar();

                string sql = "SELECT Nome FROM categoria";
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    MySqlDataReader dr = null;
                    dr = cmd.ExecuteReader();

                    //Limpando os itens do combobox
                    comboBox.Items.Clear();

                    while (dr.Read())
                    {
                        comboBox.Items.Add(dr.GetString(0).ToString());
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erro ao adcionar os dados dentro do combobox" + e.Message);
            }
            finally { Desconectar(); }
        }

        public void Salvar_Lancamentos(string categoria, decimal valor)
        {
            try
            {
                Conectar();
                string sql = "INSERT INTO lancamentos(Data, Categoria, Valor) VALUES(now(), @Categoria, @Valor)";
                /*  Diferente do Sqlite , para se adcionar uma data de maneira automatica usando 
                    o mysql usamos a função now() - 
                    no sqlite usamos a função Date()
                */

                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {

                    cmd.Parameters.AddWithValue("@Categoria", categoria);
                    cmd.Parameters.AddWithValue("@Valor", valor);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    cmd.Dispose();
                    MessageBox.Show("Lançamento realizado com sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erro ao adcionar novo lançamento" + e.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Desconectar();
            }
        }

        public void Prencher_DataGridview(string sql, DataGridView dgv)
        {
            try
            {
                Conectar();
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    MySqlDataAdapter data_adapter = new MySqlDataAdapter();
                    data_adapter.SelectCommand = cmd;
                    DataTable tb = new DataTable();
                    data_adapter.Fill(tb);
                    dgv.DataSource = tb;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erro ao adcionar os dados no dataGridview " + e.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Desconectar();
            }
        }

        public void Buscar_dados_Lisview(string sql, ListView listView)
        {
            try
            {
                Conectar();
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                MySqlDataReader dr = null;
                dr = cmd.ExecuteReader();

                ListViewItem item = new ListViewItem();
                listView.Items.Clear();
                int totalcolunas = dr.FieldCount;

                while (dr.Read())
                {
                    item = listView.Items.Add(dr["Id"].ToString()); ;
                    for (int i = 1; i < totalcolunas; i++)
                    {
                        item.SubItems.Add(dr.GetString(i));
                    }
                }
                cmd.Dispose();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erro ao Buscar os dados " + e.Message);
            }
            finally { Desconectar(); }
        }

        public void Deletar(int id, string sql)
        {
            try
            {
                Conectar();
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro deletado com sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erro ao deletar registro, verifique!" + e.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public void Search_Month_Atual(int mes, string sql, DataGridView dgv)
        {
            try
            {
                Conectar();
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv.DataSource = dt;

                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        results += Convert.ToDouble(row.Cells[2].Value);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao Buscar os dados" + ex.Message);
            }
            finally { Desconectar(); }
        }

        public void Soma_diaria()
        {
            try
            {
                Conectar();
                string sql = "SELECT SUM(Valor) as valor FROM lancamentos WHERE DATE(Data) = CURDATE()";
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    if (dr.IsDBNull(0))
                    {
                        return;
                    }
                    else { result_diario = dr.GetDouble(0); }
                }
            }
            catch (MySqlException e)
            {

                MessageBox.Show("Erro ao realizar a soma diaria" + "\n" + e.Message);
            }
            finally { Desconectar(); }
        }

        public void Soma_Anual()
        {
            try
            {
                Conectar();
                string sql = "SELECT SUM(Valor) as valor FROM lancamentos WHERE YEAR(Data)";
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    if (dr.IsDBNull(0))
                    {
                        return;
                    }
                    else
                    {
                        result_anual = dr.GetDouble(0);
                    }
                }

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erro ao realizar a soma anula" + "\n" + e.Message);
            }
            finally { Desconectar(); }
        }

        public void Soma_total()
        {
            try
            {
                Conectar();
                string sql = "SELECT SUM(Valor) as Soma From lancamentos";

                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    if (dr.IsDBNull(0)) { return; }
                    else
                    {
                        results = dr.GetDouble(0);
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erro ao realizar a soma geral" + "\n" + e.Message);
            }
            finally { Desconectar(); }
        }

        public void Update_lancamentos(int id, string sql)
        {
            try
            {
                Conectar();
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.CommandTimeout = 0;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro alterado com sucesso!");
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erro ao atualizar os dados" + "\n" + e.Message);
            }
            finally { Desconectar(); };
        }



    }//fim da class

}//fim name space

