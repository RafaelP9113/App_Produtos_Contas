using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contas_fornecedores_produto
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }



        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (MeusFormularios.FormContas == null)
            {
                MeusFormularios.FormContas = new FrmContas();

                MeusFormularios.FormContas.Show();
                MeusFormularios.FormContas.Focus();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (MeusFormularios.FormProdutos == null)
            {
                MeusFormularios.FormProdutos = new FrmProdutos();

                MeusFormularios.FormProdutos.Show();
                MeusFormularios.FormProdutos.Focus();
            }
        }
    }
}
