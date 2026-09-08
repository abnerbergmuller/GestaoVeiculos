namespace GestaoVeiculos.Views
{
    partial class FrmCadastroMarca
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
            panel1 = new Panel();
            label1 = new Label();
            btnExcluir = new Button();
            btnAdicionar = new Button();
            tabMarcas = new DataGridView();
            groupBox1 = new GroupBox();
            button1 = new Button();
            txtNome = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            btnEditar = new Button();
            btnVoltar = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabMarcas).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            panel1.Size = new Size(1349, 115);
            panel1.TabIndex = 18;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(428, 29);
            label1.Name = "label1";
            label1.Size = new Size(485, 56);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de marcas";
            label1.Click += label1_Click_1;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(217, 71, 31);
            btnExcluir.Font = new Font("Lucida Console", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(42, 285);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(230, 62);
            btnExcluir.TabIndex = 44;
            btnExcluir.Text = "EXCLUIR ❌";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(217, 71, 31);
            btnAdicionar.Font = new Font("Lucida Console", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(42, 195);
            btnAdicionar.Margin = new Padding(3, 4, 3, 4);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(230, 62);
            btnAdicionar.TabIndex = 43;
            btnAdicionar.Text = "ADICIONAR ✔";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click_1;
            // 
            // tabMarcas
            // 
            tabMarcas.AllowUserToResizeColumns = false;
            tabMarcas.AllowUserToResizeRows = false;
            tabMarcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabMarcas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tabMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 254);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            tabMarcas.DefaultCellStyle = dataGridViewCellStyle1;
            tabMarcas.EditMode = DataGridViewEditMode.EditProgrammatically;
            tabMarcas.Location = new Point(668, 144);
            tabMarcas.Margin = new Padding(3, 4, 3, 4);
            tabMarcas.Name = "tabMarcas";
            tabMarcas.ReadOnly = true;
            tabMarcas.RowHeadersVisible = false;
            tabMarcas.RowHeadersWidth = 62;
            tabMarcas.RowTemplate.Height = 28;
            tabMarcas.Size = new Size(658, 443);
            tabMarcas.TabIndex = 45;
            tabMarcas.CellContentClick += tabMarcas_CellContentClick;
            tabMarcas.CellContentDoubleClick += tabMarcas_CellContentDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtId);
            groupBox1.ForeColor = Color.FromArgb(64, 64, 65);
            groupBox1.Location = new Point(23, 396);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(618, 191);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            groupBox1.Text = "*Digite o código da marca para editar e excluir.";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(86, 89, 94);
            button1.Font = new Font("Lucida Console", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(247, 62);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(111, 36);
            button1.TabIndex = 52;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.Window;
            txtNome.Location = new Point(104, 127);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(371, 31);
            txtNome.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 65);
            label4.Location = new Point(18, 65);
            label4.Name = "label4";
            label4.Size = new Size(72, 22);
            label4.TabIndex = 36;
            label4.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 65);
            label2.Location = new Point(18, 132);
            label2.Name = "label2";
            label2.Size = new Size(62, 22);
            label2.TabIndex = 38;
            label2.Text = "Nome:";
            // 
            // txtId
            // 
            txtId.Location = new Point(104, 62);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(108, 31);
            txtId.TabIndex = 37;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(217, 71, 31);
            btnEditar.Font = new Font("Lucida Console", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(379, 195);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(230, 62);
            btnEditar.TabIndex = 49;
            btnEditar.Text = "EDITAR ✏️";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(86, 89, 94);
            btnVoltar.Font = new Font("Lucida Console", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(379, 285);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(230, 62);
            btnVoltar.TabIndex = 50;
            btnVoltar.Text = "Voltar ao menu ↩️";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 65);
            label3.Location = new Point(668, 594);
            label3.Name = "label3";
            label3.Size = new Size(338, 21);
            label3.TabIndex = 51;
            label3.Text = "*Clique duas vezes na coluna que deseja alterar";
            // 
            // FrmCadastroMarca
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 631);
            Controls.Add(label3);
            Controls.Add(btnVoltar);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(tabMarcas);
            Controls.Add(groupBox1);
            Controls.Add(btnAdicionar);
            Controls.Add(panel1);
            Name = "FrmCadastroMarca";
            Padding = new Padding(3, 24, 3, 3);
            ShowIcon = false;
            Load += FrmCadastroMarca_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabMarcas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnExcluir;
        private Button btnAdicionar;
        private DataGridView tabMarcas;
        private GroupBox groupBox1;
        private TextBox txtNome;
        private Label label4;
        private Label label2;
        private TextBox txtId;
        private Button btnEditar;
        private Button btnVoltar;
        private Label label3;
        private Button button1;
    }
}