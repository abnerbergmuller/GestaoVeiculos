namespace GestaoVeiculos.Views
{
    partial class FrmCadastroVeiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label3 = new Label();
            btnVoltar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            dgvVeiculos = new DataGridView();
            groupBox1 = new GroupBox();
            cbTipoVeiculo = new ComboBox();
            label8 = new Label();
            mskPlaca = new MaskedTextBox();
            cbMarca = new ComboBox();
            mskAno = new MaskedTextBox();
            label7 = new Label();
            label6 = new Label();
            txtModelo = new TextBox();
            label5 = new Label();
            btnLimparTudo = new Button();
            label4 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            btnAdicionar = new Button();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVeiculos).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 65);
            label3.Location = new Point(669, 659);
            label3.Name = "label3";
            label3.Size = new Size(326, 21);
            label3.TabIndex = 59;
            label3.Text = "*Clique duas vezes na linha que deseja alterar";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(86, 89, 94);
            btnVoltar.Font = new Font("Lucida Console", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(380, 270);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(230, 62);
            btnVoltar.TabIndex = 58;
            btnVoltar.Text = "Voltar ao menu ↩️";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(217, 71, 31);
            btnEditar.Font = new Font("Lucida Console", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(380, 180);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(230, 62);
            btnEditar.TabIndex = 57;
            btnEditar.Text = "EDITAR ✏️";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(217, 71, 31);
            btnExcluir.Font = new Font("Lucida Console", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(43, 270);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(230, 62);
            btnExcluir.TabIndex = 54;
            btnExcluir.Text = "EXCLUIR ❌";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dgvVeiculos
            // 
            dgvVeiculos.AllowUserToResizeColumns = false;
            dgvVeiculos.AllowUserToResizeRows = false;
            dgvVeiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVeiculos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvVeiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 254);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvVeiculos.DefaultCellStyle = dataGridViewCellStyle1;
            dgvVeiculos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvVeiculos.Location = new Point(669, 145);
            dgvVeiculos.Margin = new Padding(3, 4, 3, 4);
            dgvVeiculos.Name = "dgvVeiculos";
            dgvVeiculos.ReadOnly = true;
            dgvVeiculos.RowHeadersVisible = false;
            dgvVeiculos.RowHeadersWidth = 62;
            dgvVeiculos.RowTemplate.Height = 28;
            dgvVeiculos.Size = new Size(712, 508);
            dgvVeiculos.TabIndex = 56;
            dgvVeiculos.CellContentClick += dgvMarcas_CellContentClick;
            dgvVeiculos.CellContentDoubleClick += dgvVeiculos_CellContentDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Left;
            groupBox1.Controls.Add(cbTipoVeiculo);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(mskPlaca);
            groupBox1.Controls.Add(cbMarca);
            groupBox1.Controls.Add(mskAno);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnLimparTudo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtId);
            groupBox1.ForeColor = Color.FromArgb(64, 64, 65);
            groupBox1.Location = new Point(24, 370);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(618, 283);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "*Digite o código do veículo para editar e excluir.";
            // 
            // cbTipoVeiculo
            // 
            cbTipoVeiculo.Anchor = AnchorStyles.None;
            cbTipoVeiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoVeiculo.FormattingEnabled = true;
            cbTipoVeiculo.Items.AddRange(new object[] { "Carro", "Moto" });
            cbTipoVeiculo.Location = new Point(370, 108);
            cbTipoVeiculo.Name = "cbTipoVeiculo";
            cbTipoVeiculo.Size = new Size(117, 33);
            cbTipoVeiculo.TabIndex = 64;
            cbTipoVeiculo.SelectedIndexChanged += cbTipoVeiculo_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 64, 65);
            label8.Location = new Point(216, 113);
            label8.Name = "label8";
            label8.Size = new Size(137, 22);
            label8.TabIndex = 63;
            label8.Text = "Tipo de veículo:";
            // 
            // mskPlaca
            // 
            mskPlaca.Anchor = AnchorStyles.None;
            mskPlaca.HidePromptOnLeave = true;
            mskPlaca.Location = new Point(104, 108);
            mskPlaca.Mask = ">LLL0L00";
            mskPlaca.Name = "mskPlaca";
            mskPlaca.Size = new Size(91, 31);
            mskPlaca.TabIndex = 62;
            mskPlaca.TextAlign = HorizontalAlignment.Center;
            // 
            // cbMarca
            // 
            cbMarca.Anchor = AnchorStyles.None;
            cbMarca.FormattingEnabled = true;
            cbMarca.Location = new Point(285, 226);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(128, 33);
            cbMarca.TabIndex = 61;
            // 
            // mskAno
            // 
            mskAno.Anchor = AnchorStyles.None;
            mskAno.HidePromptOnLeave = true;
            mskAno.Location = new Point(104, 228);
            mskAno.Mask = "0000";
            mskAno.Name = "mskAno";
            mskAno.Size = new Size(60, 31);
            mskAno.TabIndex = 60;
            mskAno.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 64, 65);
            label7.Location = new Point(204, 233);
            label7.Name = "label7";
            label7.Size = new Size(64, 22);
            label7.TabIndex = 57;
            label7.Text = "Marca:";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 65);
            label6.Location = new Point(33, 233);
            label6.Name = "label6";
            label6.Size = new Size(47, 22);
            label6.TabIndex = 55;
            label6.Text = "Ano:";
            // 
            // txtModelo
            // 
            txtModelo.Anchor = AnchorStyles.None;
            txtModelo.BackColor = SystemColors.Window;
            txtModelo.Location = new Point(104, 168);
            txtModelo.Margin = new Padding(3, 4, 3, 4);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(371, 31);
            txtModelo.TabIndex = 54;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 64, 65);
            label5.Location = new Point(18, 173);
            label5.Name = "label5";
            label5.Size = new Size(73, 22);
            label5.TabIndex = 53;
            label5.Text = "Modelo:";
            // 
            // btnLimparTudo
            // 
            btnLimparTudo.Anchor = AnchorStyles.None;
            btnLimparTudo.BackColor = Color.FromArgb(86, 89, 94);
            btnLimparTudo.Font = new Font("Lucida Console", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimparTudo.ForeColor = Color.White;
            btnLimparTudo.Location = new Point(247, 50);
            btnLimparTudo.Margin = new Padding(3, 4, 3, 4);
            btnLimparTudo.Name = "btnLimparTudo";
            btnLimparTudo.Size = new Size(141, 36);
            btnLimparTudo.TabIndex = 52;
            btnLimparTudo.Text = "Limpar tudo";
            btnLimparTudo.UseVisualStyleBackColor = false;
            btnLimparTudo.Click += btnLimparTudo_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 65);
            label4.Location = new Point(18, 54);
            label4.Name = "label4";
            label4.Size = new Size(72, 22);
            label4.TabIndex = 36;
            label4.Text = "Código:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 65);
            label2.Location = new Point(20, 113);
            label2.Name = "label2";
            label2.Size = new Size(60, 22);
            label2.TabIndex = 38;
            label2.Text = "Placa:";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.None;
            txtId.Location = new Point(104, 50);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(108, 31);
            txtId.TabIndex = 37;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(217, 71, 31);
            btnAdicionar.Font = new Font("Lucida Console", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(43, 180);
            btnAdicionar.Margin = new Padding(3, 4, 3, 4);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(230, 62);
            btnAdicionar.TabIndex = 53;
            btnAdicionar.Text = "ADICIONAR ✔";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(217, 71, 31);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1398, 115);
            panel1.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(446, 29);
            label1.Name = "label1";
            label1.Size = new Size(507, 56);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de veículos";
            // 
            // FrmCadastroVeiculo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 692);
            Controls.Add(label3);
            Controls.Add(btnVoltar);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(dgvVeiculos);
            Controls.Add(groupBox1);
            Controls.Add(btnAdicionar);
            Controls.Add(panel1);
            Name = "FrmCadastroVeiculo";
            ShowIcon = false;
            Load += FrmCadastroVeiculo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVeiculos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btnVoltar;
        private Button btnEditar;
        private Button btnExcluir;
        private DataGridView dgvVeiculos;
        private GroupBox groupBox1;
        private Button btnLimparTudo;
        private Label label4;
        private Label label2;
        private TextBox txtId;
        private Button btnAdicionar;
        private Panel panel1;
        private Label label1;
        private TextBox txtModelo;
        private Label label5;
        private Label label6;
        private Label label7;
        private MaskedTextBox mskAno;
        private ComboBox cbMarca;
        private MaskedTextBox mskPlaca;
        private ComboBox cbTipoVeiculo;
        private Label label8;
    }
}