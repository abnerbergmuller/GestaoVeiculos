using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GestaoVeiculos.Views.Interfaces;

namespace GestaoVeiculos.Views
{
    public partial class FrmMenuPrincipal : Form, IMenuPrincipalView
    {
        public event EventHandler ClickBtnLogs;
        public event EventHandler ClickBtnVeiculos;
        public event EventHandler ClickBtnMarcas;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }


        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ClickBtnMarcas?.Invoke(this, EventArgs.Empty);
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            ClickBtnVeiculos?.Invoke(this, EventArgs.Empty);
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            ClickBtnLogs?.Invoke(this, EventArgs.Empty);
        }
    }
}
