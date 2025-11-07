namespace SmartCall.Forms
{
    partial class FormDeletarUsuario
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
            btnBuscar = new Button();
            txtBusca = new TextBox();
            lblBuscaInfo = new Label();
            lblInfoEncontrado = new Label();
            lblUsuarioEncontrado = new Label();
            btnDeletarConfirmar = new Button();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(572, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(156, 37);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(256, 32);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(249, 23);
            txtBusca.TabIndex = 4;
            // 
            // lblBuscaInfo
            // 
            lblBuscaInfo.AutoSize = true;
            lblBuscaInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscaInfo.Location = new Point(41, 35);
            lblBuscaInfo.Name = "lblBuscaInfo";
            lblBuscaInfo.Size = new Size(176, 21);
            lblBuscaInfo.TabIndex = 3;
            lblBuscaInfo.Text = "Buscar por ID ou E-mail:";
            // 
            // lblInfoEncontrado
            // 
            lblInfoEncontrado.AutoSize = true;
            lblInfoEncontrado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoEncontrado.Location = new Point(41, 125);
            lblInfoEncontrado.Name = "lblInfoEncontrado";
            lblInfoEncontrado.Size = new Size(205, 25);
            lblInfoEncontrado.TabIndex = 6;
            lblInfoEncontrado.Text = "Usuário a ser deletado:";
            // 
            // lblUsuarioEncontrado
            // 
            lblUsuarioEncontrado.AutoSize = true;
            lblUsuarioEncontrado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarioEncontrado.Location = new Point(41, 158);
            lblUsuarioEncontrado.Name = "lblUsuarioEncontrado";
            lblUsuarioEncontrado.Size = new Size(246, 21);
            lblUsuarioEncontrado.TabIndex = 7;
            lblUsuarioEncontrado.Text = "(Nenhum usuário selecionado)";
            // 
            // btnDeletarConfirmar
            // 
            btnDeletarConfirmar.BackColor = Color.Red;
            btnDeletarConfirmar.Enabled = false;
            btnDeletarConfirmar.Location = new Point(41, 199);
            btnDeletarConfirmar.Name = "btnDeletarConfirmar";
            btnDeletarConfirmar.Size = new Size(313, 58);
            btnDeletarConfirmar.TabIndex = 8;
            btnDeletarConfirmar.Text = "DELETAR PERMANENTEMENTE";
            btnDeletarConfirmar.UseVisualStyleBackColor = false;
            btnDeletarConfirmar.Click += btnDeletarConfirmar_Click;
            // 
            // FormDeletarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 370);
            Controls.Add(btnDeletarConfirmar);
            Controls.Add(lblUsuarioEncontrado);
            Controls.Add(lblInfoEncontrado);
            Controls.Add(btnBuscar);
            Controls.Add(txtBusca);
            Controls.Add(lblBuscaInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDeletarUsuario";
            Text = "FormDeletarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private TextBox txtBusca;
        private Label lblBuscaInfo;
        private Label lblInfoEncontrado;
        private Label lblUsuarioEncontrado;
        private Button btnDeletarConfirmar;
    }
}