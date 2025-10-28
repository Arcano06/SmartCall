namespace SmartCall.Forms
{
    partial class FormAdicionarUsuario
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
            label1 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            txtSenha = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cmbCargo = new ComboBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 37);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(137, 66);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(132, 23);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(137, 131);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(132, 23);
            txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 102);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "E-mail:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(137, 198);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(132, 23);
            txtSenha.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 169);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Senha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 238);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 6;
            label4.Text = "Cargo:";
            // 
            // cmbCargo
            // 
            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Location = new Point(137, 268);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(121, 23);
            cmbCargo.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(402, 131);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(179, 90);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar novo usuário";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormAdicionarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 350);
            Controls.Add(btnSalvar);
            Controls.Add(cmbCargo);
            Controls.Add(label4);
            Controls.Add(txtSenha);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdicionarUsuario";
            Text = "FormAdicionarUsuario";
            Load += FormAdicionarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtSenha;
        private Label label3;
        private Label label4;
        private ComboBox cmbCargo;
        private Button btnSalvar;
    }
}