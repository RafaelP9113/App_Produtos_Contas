using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace contas_fornecedores_produto
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }
   

        private void button1_Click(object sender, EventArgs e)
        {
            string strCon = @"server=127.0.0.1;user id=root;Pwd=rafa04102001;persistsecurityinfo=True;database=db_infos";
            MySqlConnection cn = new MySqlConnection(strCon);
            cn.Open();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = cn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "insert into info_produtos values (0,'" + txtProduto.Text + "', '" + txtFornecedor.Text + "', " + txtValor.Text + ")";
            comm.ExecuteNonQuery();
            comm.Connection.Close();
            MessageBox.Show("Dados gravados com sucesso !");
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmProdutos_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormProdutos = null;
        }
    }
}
