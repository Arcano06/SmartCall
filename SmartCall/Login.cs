using BCrypt.Net;
using SmartCall.Forms;
using SmartCall.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using System.Runtime.InteropServices;


namespace SmartCall
{
    public partial class Login : Form
    {
        private Timer Update = new Timer();
        private Timer Update2 = new Timer();
        private bool Scala1, Scala2;
        private int _Font = 350;
        private Form formAtivo = null;
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

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Formulario_MouseDown_Para_Arrastar(object sender, MouseEventArgs e)
        {
            // Verifica se foi o botão esquerdo do mouse
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Libera a captura do mouse
                                  // Envia a mensagem para o Windows de que o botão esquerdo foi pressionado
                                  // na "barra de título" (HT_CAPTION)
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
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
            AbrirFormularioFilho(new FormVerUsuarios());
        }

        private void label8_Click(object sender, EventArgs e)
        {
            LB_TT.Text = "Novo Usuário";
            AbrirFormularioFilho(new FormAdicionarUsuario());
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            LB_TT.Text = " Editar Usuário";
            AbrirFormularioFilho(new FormEditarUsuario());
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            LB_TT.Text = "Eliminar Usuário";
            AbrirFormularioFilho(new FormDeletarUsuario());
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            LB_TT.Text = "Novo Usuário";
            AbrirFormularioFilho(new FormAdicionarUsuario());
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

        private void AbrirFormularioFilho(Form formularioFilho)
        {
            if (formAtivo != null && formAtivo.GetType() == formularioFilho.GetType())
            {
                formAtivo.BringToFront();
                formularioFilho.Dispose();
                return;
            }

            if (formAtivo != null)
            {
                formAtivo.Close();
            }

            formAtivo = formularioFilho;

            formAtivo.MdiParent = this;

            formAtivo.FormClosed += (s, args) => formAtivo = null;

            formAtivo.FormBorderStyle = FormBorderStyle.None;

            formAtivo.Dock = DockStyle.Fill;

            formAtivo.Show();
        }

        private void LB_FH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            LB_TT.Text = "Usuário";
            AbrirFormularioFilho(new FormVerUsuarios());
        }

        private void label10_Click(object sender, EventArgs e)
        {
            LB_TT.Text = "Eliminar Usuário";
            AbrirFormularioFilho(new FormDeletarUsuario());
        }

        private void label9_Click(object sender, EventArgs e)
        {
            LB_TT.Text = " Editar Usuário";
            AbrirFormularioFilho(new FormEditarUsuario());
        }

        protected override void WndProc(ref Message m)
        {
            // Mensagem do Windows: WM_NCHITTEST (Enviada quando o mouse se move)
            const int WM_NCHITTEST = 0x84;

            // Resultados do Hit Test (onde o mouse está)
            const int HTCLIENT = 1;     // Na área "cliente" (normal)
            const int HTLEFT = 10;      // Borda esquerda
            const int HTRIGHT = 11;     // Borda direita
            const int HTTOP = 12;       // Borda superior
            const int HTTOPLEFT = 13;   // Canto superior esquerdo
            const int HTTOPRIGHT = 14;  // Canto superior direito
            const int HTBOTTOM = 15;    // Borda inferior
            const int HTBOTTOMLEFT = 16;// Canto inferior esquerdo
            const int HTBOTTOMRIGHT = 17;// Canto inferior direito

            base.WndProc(ref m); // Processa a mensagem primeiro

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)
            {
                // Obtém as coordenadas do mouse em relação à tela
                Point screenPoint = new Point(m.LParam.ToInt32());
                // Converte para coordenadas em relação ao formulário
                Point clientPoint = this.PointToClient(screenPoint);

                // Define a "largura" da borda para redimensionar (ex: 10 pixels)
                int gripSize = 10;

                // Lógica para os 4 cantos
                if (clientPoint.X <= gripSize && clientPoint.Y <= gripSize)
                    m.Result = (IntPtr)HTTOPLEFT;
                else if (clientPoint.X >= this.ClientSize.Width - gripSize && clientPoint.Y <= gripSize)
                    m.Result = (IntPtr)HTTOPRIGHT;
                else if (clientPoint.X <= gripSize && clientPoint.Y >= this.ClientSize.Height - gripSize)
                    m.Result = (IntPtr)HTBOTTOMLEFT;
                else if (clientPoint.X >= this.ClientSize.Width - gripSize && clientPoint.Y >= this.ClientSize.Height - gripSize)
                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                // Lógica para as 4 bordas
                else if (clientPoint.X <= gripSize)
                    m.Result = (IntPtr)HTLEFT;
                else if (clientPoint.X >= this.ClientSize.Width - gripSize)
                    m.Result = (IntPtr)HTRIGHT;
                else if (clientPoint.Y <= gripSize)
                    m.Result = (IntPtr)HTTOP;
                else if (clientPoint.Y >= this.ClientSize.Height - gripSize)
                    m.Result = (IntPtr)HTBOTTOM;
            }
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            if (!Scala1 && !Scala2)
            {
                _Font = this.Width;
            }
        }
    }

}
