namespace SmartCall.Forms
{
    partial class FormEditarUsuario
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
            panelBusca = new Panel();
            btnBuscar = new Button();
            txtBusca = new TextBox();
            lblBusca = new Label();
            panelEdicao = new Panel();
            btnSalvarEdicao = new Button();
            cmbCargo = new ComboBox();
            lblCargo = new Label();
            txtNovaSenha = new TextBox();
            lblSenha = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            panelBusca.SuspendLayout();
            panelEdicao.SuspendLayout();
            SuspendLayout();
            // 
            // panelBusca
            // 
            panelBusca.Controls.Add(btnBuscar);
            panelBusca.Controls.Add(txtBusca);
            panelBusca.Controls.Add(lblBusca);
            panelBusca.Dock = DockStyle.Top;
            panelBusca.Location = new Point(0, 0);
            panelBusca.Name = "panelBusca";
            panelBusca.Size = new Size(758, 60);
            panelBusca.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(543, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(156, 37);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(227, 20);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(249, 23);
            txtBusca.TabIndex = 1;
            // 
            // lblBusca
            // 
            lblBusca.AutoSize = true;
            lblBusca.Location = new Point(12, 23);
            lblBusca.Name = "lblBusca";
            lblBusca.Size = new Size(134, 15);
            lblBusca.TabIndex = 0;
            lblBusca.Text = "Buscar por ID ou E-mail:";
            // 
            // panelEdicao
            // 
            panelEdicao.Controls.Add(btnSalvarEdicao);
            panelEdicao.Controls.Add(cmbCargo);
            panelEdicao.Controls.Add(lblCargo);
            panelEdicao.Controls.Add(txtNovaSenha);
            panelEdicao.Controls.Add(lblSenha);
            panelEdicao.Controls.Add(txtEmail);
            panelEdicao.Controls.Add(lblEmail);
            panelEdicao.Controls.Add(txtNome);
            panelEdicao.Controls.Add(lblNome);
            panelEdicao.Dock = DockStyle.Fill;
            panelEdicao.Enabled = false;
            panelEdicao.Location = new Point(0, 60);
            panelEdicao.Name = "panelEdicao";
            panelEdicao.Size = new Size(758, 312);
            panelEdicao.TabIndex = 1;
            // 
            // btnSalvarEdicao
            // 
            btnSalvarEdicao.Location = new Point(422, 109);
            btnSalvarEdicao.Name = "btnSalvarEdicao";
            btnSalvarEdicao.Size = new Size(179, 90);
            btnSalvarEdicao.TabIndex = 17;
            btnSalvarEdicao.Text = "Salvar Alterações";
            btnSalvarEdicao.UseVisualStyleBackColor = true;
            btnSalvarEdicao.Click += btnSalvarEdicao_Click;
            // 
            // cmbCargo
            // 
            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Location = new Point(157, 246);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(121, 23);
            cmbCargo.TabIndex = 16;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(157, 216);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(42, 15);
            lblCargo.TabIndex = 15;
            lblCargo.Text = "Cargo:";
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(157, 176);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(132, 23);
            txtNovaSenha.TabIndex = 14;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(157, 147);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 13;
            lblSenha.Text = "Senha:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(157, 109);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(132, 23);
            txtEmail.TabIndex = 12;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(157, 80);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "E-mail:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(157, 44);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(132, 23);
            txtNome.TabIndex = 10;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(157, 15);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 9;
            lblNome.Text = "Nome:";
            // 
            // FormEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 372);
            Controls.Add(panelEdicao);
            Controls.Add(panelBusca);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditarUsuario";
            Text = "FormEditarUsuario";
            Load += FormEditarUsuario_Load;
            panelBusca.ResumeLayout(false);
            panelBusca.PerformLayout();
            panelEdicao.ResumeLayout(false);
            panelEdicao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBusca;
        private Button btnBuscar;
        private TextBox txtBusca;
        private Label lblBusca;
        private Panel panelEdicao;
        private Button btnSalvarEdicao;
        private ComboBox cmbCargo;
        private Label lblCargo;
        private TextBox txtNovaSenha;
        private Label lblSenha;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtNome;
        private Label lblNome;
    }
}