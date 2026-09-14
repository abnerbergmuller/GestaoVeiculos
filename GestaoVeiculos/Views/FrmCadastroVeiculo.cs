using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GestaoVeiculos.DTOs;
using GestaoVeiculos.Models;
using GestaoVeiculos.Views.Interfaces;

namespace GestaoVeiculos.Views
{
    public partial class FrmCadastroVeiculo : Form, IVeiculoView
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
        public string Placa { get => mskPlaca.Text; set => mskPlaca.Text = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Modelo { get => txtModelo.Text.Trim(); set => txtModelo.Text = value.Trim(); }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int? Ano
        {
            get
            {
                int result;
                int.TryParse(mskAno.Text, out result);
                return result;
            }
            set => mskAno.Text = value.ToString();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int MarcaId
        {
            get
            {
                if (cbMarca.SelectedValue is int id)
                    return id;
                return 0;
            }
            set => cbMarca.SelectedValue = value.ToString();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TipoVeiculo { get => cbTipoVeiculo.Text; set => cbTipoVeiculo.Text = value; }

        public event EventHandler ClickBtnCadastrar;
        public event EventHandler ClickBtnEditar;
        public event EventHandler ClickBtnExcluir;
        public event EventHandler FormLoad;

        public void ListarVeiculos(IEnumerable<VeiculoDTO> veiculo)
        {
            dgvVeiculos.DataSource = veiculo;

            dgvVeiculos.Columns[0].FillWeight = 10;
            dgvVeiculos.Columns[1].FillWeight = 15;
            dgvVeiculos.Columns[2].FillWeight = 40;

            dgvVeiculos.Columns[3].FillWeight = 10;
            dgvVeiculos.Columns[4].FillWeight = 20;
            dgvVeiculos.Columns[4].HeaderText = "Marca";

            dgvVeiculos.Columns[5].FillWeight = 20;
            dgvVeiculos.Columns[5].HeaderText = "Tipo";
        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        public void LimparCampos()
        {
            txtId.Clear();
            mskPlaca.Clear();
            txtModelo.Clear();
            mskAno.Clear();
            cbMarca.SelectedIndex = -1;
        }

        public void AtivaCbTipoVeiculo()
        {
            cbTipoVeiculo.Enabled = true;
        }

        public void ExibirMarcas(IEnumerable<Marca> marca)
        {
            cbMarca.DataSource = marca.ToList();
            cbMarca.DisplayMember = "Nome";
            cbMarca.ValueMember = "Id";
            cbMarca.SelectedIndex = -1;
        }

        public FrmCadastroVeiculo()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmCadastroVeiculo_Load(object sender, EventArgs e)
        {
            FormLoad?.Invoke(this, EventArgs.Empty);
            LimparCampos();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbTipoVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
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

        private void dgvVeiculos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvVeiculos.CurrentRow.Cells[0].Value.ToString();
            mskPlaca.Text = dgvVeiculos.CurrentRow.Cells[1].Value.ToString();
            txtModelo.Text = dgvVeiculos.CurrentRow.Cells[2].Value.ToString();
            mskAno.Text = dgvVeiculos.CurrentRow.Cells[3].Value.ToString();
            cbMarca.Text = dgvVeiculos.CurrentRow.Cells[4].Value.ToString();
            cbTipoVeiculo.Text = dgvVeiculos.CurrentRow.Cells[5].Value.ToString();
            cbTipoVeiculo.Enabled = false;
        }

        private void btnLimparTudo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            AtivaCbTipoVeiculo();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
