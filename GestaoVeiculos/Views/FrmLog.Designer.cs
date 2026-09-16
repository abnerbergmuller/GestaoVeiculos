namespace GestaoVeiculos.Views
{
    partial class FrmLog
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvLogTransacao = new DataGridView();
            dgvLogErro = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLogTransacao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLogErro).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvLogTransacao
            // 
            dgvLogTransacao.AllowUserToResizeColumns = false;
            dgvLogTransacao.AllowUserToResizeRows = false;
            dgvLogTransacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLogTransacao.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLogTransacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 254);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvLogTransacao.DefaultCellStyle = dataGridViewCellStyle1;
            dgvLogTransacao.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvLogTransacao.Location = new Point(12, 146);
            dgvLogTransacao.Margin = new Padding(3, 4, 3, 4);
            dgvLogTransacao.Name = "dgvLogTransacao";
            dgvLogTransacao.ReadOnly = true;
            dgvLogTransacao.RowHeadersVisible = false;
            dgvLogTransacao.RowHeadersWidth = 62;
            dgvLogTransacao.RowTemplate.Height = 28;
            dgvLogTransacao.Size = new Size(697, 508);
            dgvLogTransacao.TabIndex = 57;
            // 
            // dgvLogErro
            // 
            dgvLogErro.AllowUserToResizeColumns = false;
            dgvLogErro.AllowUserToResizeRows = false;
            dgvLogErro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLogErro.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLogErro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 254);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLogErro.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLogErro.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvLogErro.Location = new Point(730, 146);
            dgvLogErro.Margin = new Padding(3, 4, 3, 4);
            dgvLogErro.Name = "dgvLogErro";
            dgvLogErro.ReadOnly = true;
            dgvLogErro.RowHeadersVisible = false;
            dgvLogErro.RowHeadersWidth = 62;
            dgvLogErro.RowTemplate.Height = 28;
            dgvLogErro.Size = new Size(708, 508);
            dgvLogErro.TabIndex = 58;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(34, 18);
            label1.Name = "label1";
            label1.Size = new Size(448, 56);
            label1.TabIndex = 0;
            label1.Text = "Logs de transação";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 71, 31);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(99, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(516, 92);
            panel1.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 18);
            label2.Name = "label2";
            label2.Size = new Size(314, 56);
            label2.TabIndex = 0;
            label2.Text = "Logs de erro";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(217, 71, 31);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(901, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(372, 92);
            panel2.TabIndex = 60;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(86, 89, 94);
            btnVoltar.Font = new Font("Lucida Console", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(1208, 677);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(230, 62);
            btnVoltar.TabIndex = 61;
            btnVoltar.Text = "Voltar ao menu ↩️";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FrmLog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1450, 752);
            Controls.Add(btnVoltar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvLogErro);
            Controls.Add(dgvLogTransacao);
            Name = "FrmLog";
            ShowIcon = false;
            Load += FrmTelaLogs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLogTransacao).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLogErro).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLogTransacao;
        private DataGridView dgvLogErro;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Button btnVoltar;
    }
}