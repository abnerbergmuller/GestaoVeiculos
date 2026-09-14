namespace GestaoVeiculos.Views
{
    partial class FrmMenuPrincipal
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
            btnLogs = new Button();
            btnVeiculos = new Button();
            panel1 = new Panel();
            label1 = new Label();
            btnMarcas = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogs
            // 
            btnLogs.BackColor = Color.FromArgb(86, 89, 94);
            btnLogs.Font = new Font("Lucida Console", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogs.ForeColor = Color.White;
            btnLogs.Location = new Point(839, 409);
            btnLogs.Margin = new Padding(3, 4, 3, 4);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(162, 62);
            btnLogs.TabIndex = 66;
            btnLogs.Text = "Logs 🔍";
            btnLogs.UseVisualStyleBackColor = false;
            btnLogs.Click += btnLogs_Click;
            // 
            // btnVeiculos
            // 
            btnVeiculos.BackColor = Color.FromArgb(86, 89, 94);
            btnVeiculos.Font = new Font("Lucida Console", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVeiculos.ForeColor = Color.White;
            btnVeiculos.Location = new Point(566, 225);
            btnVeiculos.Margin = new Padding(3, 4, 3, 4);
            btnVeiculos.Name = "btnVeiculos";
            btnVeiculos.Size = new Size(239, 84);
            btnVeiculos.TabIndex = 65;
            btnVeiculos.Text = "Veículos";
            btnVeiculos.UseVisualStyleBackColor = false;
            btnVeiculos.Click += btnVeiculos_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1018, 115);
            panel1.TabIndex = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(327, 29);
            label1.Name = "label1";
            label1.Size = new Size(365, 56);
            label1.TabIndex = 0;
            label1.Text = "Menu Principal";
            // 
            // btnMarcas
            // 
            btnMarcas.BackColor = Color.FromArgb(86, 89, 94);
            btnMarcas.Font = new Font("Lucida Console", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMarcas.ForeColor = Color.White;
            btnMarcas.Location = new Point(208, 225);
            btnMarcas.Margin = new Padding(3, 4, 3, 4);
            btnMarcas.Name = "btnMarcas";
            btnMarcas.Size = new Size(239, 84);
            btnMarcas.TabIndex = 67;
            btnMarcas.Text = "Marcas";
            btnMarcas.UseVisualStyleBackColor = false;
            btnMarcas.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 65);
            label3.Location = new Point(373, 129);
            label3.Name = "label3";
            label3.Size = new Size(267, 25);
            label3.TabIndex = 68;
            label3.Text = "(Selecione uma tela de cadastro)";
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 484);
            Controls.Add(label3);
            Controls.Add(btnMarcas);
            Controls.Add(btnLogs);
            Controls.Add(btnVeiculos);
            Controls.Add(panel1);
            Name = "FrmMenuPrincipal";
            ShowIcon = false;
            Load += FrmMenuPrincipal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogs;
        private Button btnVeiculos;
        private Panel panel1;
        private Label label1;
        private Button btnMarcas;
        private Label label3;
    }
}