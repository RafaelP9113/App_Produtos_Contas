﻿using System;
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
    public partial class FrmContas : Form
    {
        public FrmContas()
        {
            InitializeComponent();
        }
        private void FrmContas_Load(object sender, EventArgs e)
        {

        }

        private void FrmContas_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormContas = null;
        }
    }
}
