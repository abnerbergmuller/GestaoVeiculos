using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GestaoVeiculos.Models;
using GestaoVeiculos.Views.Interfaces;

namespace GestaoVeiculos.Views
{
    public partial class FrmLog : Form, ILogView
    {
        public FrmLog()
        {
            InitializeComponent();
        }

        public event EventHandler FormLoad;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTelaLogs_Load(object sender, EventArgs e)
        {
            FormLoad?.Invoke(this, EventArgs.Empty);
        }

        public void ListarLogs(IEnumerable<LogTransacao> logTransacao, IEnumerable<LogErro> logErro)
        {
            dgvLogTransacao.DataSource = logTransacao;
            dgvLogErro.DataSource = logErro;
            dgvLogErro.Columns[0].FillWeight = 30;
        }
    }
}
