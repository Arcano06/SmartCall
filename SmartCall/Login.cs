using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using System.Data.SqlClient;
using SmartCall.Models;
using BCrypt.Net;


namespace SmartCall
{
    public partial class Login : Form
    {
        private Timer Update = new Timer();
        private Timer Update2 = new Timer();
        private bool Scala1, Scala2;
        private int _Font = 350;
        public Login()
        {
            InitializeComponent();
            Scala1 = false;
            Scala2 = false;
            Update.Enabled = true;
            Update.Tick += Update_Tick;
            Update.Start();
            //Update2
            Update2.Interval = 1;
            Update2.Tick += Update2_Tick;
            this.Size = new Size(_Font, 700);
        }

        private void Update2_Tick(object? sender, EventArgs e)
        {
            F_Scala();
        }

        private void Update_Tick(object? sender, EventArgs e)
        {
            F_LB_TT();
        }

        private bool ValidarLogin()
        {
            // 1. Pegue os dados dos TextBoxes (com .Trim())
            string usuario = txtUsuario.Text.Trim(); // <<< MUDE AQUI (seu TextBox de email/usuario)
            string senha = txtSenha.Text.Trim();     // <<< MUDE AQUI (seu TextBox de senha)

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, preencha o usuário e a senha.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                // 2. Conecte ao banco usando o Contexto do EF
                using (var db = new MeuProjetoDbContext())
                {
                    // 3. PRIMEIRO: Encontre o usuário APENAS pelo email
                    //    (Usando .ToLower() para garantir)
                    var usuarioDoBanco = db.Usuarios
                        .FirstOrDefault(u => u.Email.ToLower() == usuario.ToLower());

                    // 4. Verifique se o usuário existe
                    if (usuarioDoBanco == null)
                    {
                        // Não encontrou o usuário (Email errado)
                        MessageBox.Show("Usuário ou senha incorretos.", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    // 5. SEGUNDO: Verifique a senha usando BCrypt.Verify
                    //    Isso compara a "senha" (texto puro) com o "usuarioDoBanco.SenhaHash" (o hash $2a$...)

                    bool senhaCorreta;
                    try
                    {
                        // A classe se chama "BCrypt" e o método "Verify"
                        senhaCorreta = BCrypt.Net.BCrypt.Verify(senha, usuarioDoBanco.SenhaHash);
                    }
                    catch (Exception ex)
                    {
                        // Isso pode falhar se a senha no banco estiver em formato inválido
                        MessageBox.Show("Erro ao verificar o hash da senha: " + ex.Message, "Erro de Hash", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }


                    if (!senhaCorreta)
                    {
                        // Senha errada
                        MessageBox.Show("Usuário ou senha incorretos.", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    // 6. TERCEIRO: Verifique o Cargo (ex: 2 = Admin)
                    if (usuarioDoBanco.Cargo == 2)
                    {
                        return true; // SUCESSO! É admin e a senha está correta.
                    }
                    else
                    {
                        // Não é admin
                        MessageBox.Show("Você não tem permissão de Administrador para acessar.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostra qualquer erro de conexão ou de consulta
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BT_Tasks_Click(object sender, EventArgs e)
        {
            if (BT_Tasks.Text == "Login")
            {
                if (ValidarLogin())
                {
                    Scala1 = true;
            Update2.Enabled = true;
            Update2.Start();
                }
                    else
                    {
                        // Falha no login ou permissão. A função ValidarLogin()
                        // já exibiu a mensagem de erro específica.
                    }
                }
                else
                {
                    // Aqui você pode adicionar a lógica para "Atualizar", "Deletar", "Adicionar"
                    // quando implementar essas funções.
                    // Por exemplo:
                    // if (BT_Tasks.Text == "Adicionar") { ... }
                }
        }

        private void PI_FH_Click(object sender, EventArgs e)
        {
            Scala2 = true;
            Update2.Enabled = true;
            Update2.Start();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            LB_TT.Text = "Usuário";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            LB_TT.Text = " Editar Usuário";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            LB_TT.Text = "Eliminar Usuário";
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            LB_TT.Text = "Novo Usuário";
        }



        public void F_LB_TT()
        {
            switch (LB_TT.Text)
            {
                case "Login":
                    BT_Tasks.Show();
                    BT_Tasks.Text = "Logar";
                    break;

                case " Editar Usuário":
                    BT_Tasks.Show();
                    BT_Tasks.Text = "Atualizar";
                    break;

                case "Eliminar Usuário":
                    BT_Tasks.Show();
                    BT_Tasks.Text = "Deletar";
                    break;

                case "Novo Usuário":
                    BT_Tasks.Show();
                    BT_Tasks.Text = "Adicionar";
                    break;

                case "Usuário":
                    BT_Tasks.Hide();
                    BT_Tasks.Text = "";
                    break;
            }
        }

        public void F_Scala()
        {
            if (Scala1)
            {
                if (_Font < 1204)
                {
                    this.CenterToScreen();
                    _Font += 10;
                    if (_Font >= 1204)
                    {
                        _Font = 1204;
                    }

                    this.Size = new Size(_Font, 700);
                }
                else
                {
                    Scala1 = false;
                    Update2.Enabled = false;
                    Update2.Start();
                    LB_TT.Text = "Usuário";
                    LB_TT.Hide();
                }
            }

            ///Scala --
            ///


            if (Scala2)
            {
                if (_Font > 350)
                {
                    this.CenterToScreen();
                    _Font -= 10;
                    if (_Font <= 350)
                    {
                        _Font = 350;
                    }

                    this.Size = new Size(_Font, 700);  
                    if (_Font <= 350)
                    {
                        this.Close();
                    }
                }
                else
                {
                    Scala2 = false;
                    Update2.Enabled = false;
                    Update2.Start();
                    LB_TT.Text = "Usuário";
                    LB_TT.Hide();
                }
            }

        }

        private void LB_FH_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
