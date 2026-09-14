using GestaoVeiculos.Models;
using GestaoVeiculos.Presenters;
using GestaoVeiculos.Views.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestaoVeiculos.Views
{

    public partial class FrmCadastroMarca : Form, IMarcaView
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Id
        {
            get
            {
                int result;
                int.TryParse(txtId.Text, out result);
                return result;
            }
            set => txtId.Text = value.ToString();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Nome { get => txtNome.Text.Trim(); set => txtNome.Text = value.Trim(); }

        public event EventHandler ClickBtnCadastrar;
        public event EventHandler ClickBtnEditar;
        public event EventHandler ClickBtnExcluir;
        public event EventHandler FormLoad;

        public void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
        }

        public void ListarMarcas(IEnumerable<Marca> marcas)
        {
            dgvMarcas.DataSource = marcas;
        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        public FrmCadastroMarca()
        {
            InitializeComponent();
        }


        private void FrmCadastroMarca_Load(object sender, EventArgs e)
        {
            FormLoad?.Invoke(this, EventArgs.Empty);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            ClickBtnCadastrar?.Invoke(this, EventArgs.Empty);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ClickBtnEditar?.Invoke(this, EventArgs.Empty);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ClickBtnExcluir?.Invoke(this, EventArgs.Empty);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtId.Clear();
        }

        private void dgvMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMarcas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvMarcas.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvMarcas.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
