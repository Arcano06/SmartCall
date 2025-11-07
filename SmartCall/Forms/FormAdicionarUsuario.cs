using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartCall.Models; 
using System.Linq;

namespace SmartCall.Forms
{
    public partial class FormAdicionarUsuario : Form
    {
        public FormAdicionarUsuario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (cmbCargo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um cargo.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string cargoString = cmbCargo.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, preencha o nome, e-mail e senha.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new MeuProjetoDbContext())
                {
                    if (db.Usuarios.Any(u => u.Email.ToLower() == email.ToLower()))
                    {
                        MessageBox.Show("Este e-mail já está cadastrado.", "E-mail Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string senhaHash = BCrypt.Net.BCrypt.HashPassword(senha);


                    int cargoValor;
                    switch (cargoString)
                    {
                        case "Técnico":
                            cargoValor = 1;
                            break;
                        case "Administrador":
                            cargoValor = 2;
                            break;
                        default:
                            cargoValor = 0;
                            break;
                    }

                    var novoUsuario = new Usuario
                    {
                        NomeCompleto = nome,
                        Email = email,
                        SenhaHash = senhaHash,
                        Cargo = cargoValor
                    };


                    db.Usuarios.Add(novoUsuario);
                    db.SaveChanges();

                    MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txtNome.Clear();
                    txtEmail.Clear();
                    txtSenha.Clear();
                    cmbCargo.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar usuário: " + ex.Message, "Erro de Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAdicionarUsuario_Load(object sender, EventArgs e)
        {
            cmbCargo.Items.Add("Usuário");
            cmbCargo.Items.Add("Técnico");
            cmbCargo.Items.Add("Administrador");

            cmbCargo.SelectedIndex = 0;
        }
    }


}
