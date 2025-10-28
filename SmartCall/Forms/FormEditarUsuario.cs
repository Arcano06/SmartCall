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
    public partial class FormEditarUsuario : Form
    {

        private Usuario usuarioParaEditar;

        public FormEditarUsuario()
        {
            InitializeComponent();
        }

        private void FormEditarUsuario_Load(object sender, EventArgs e)
        {

            cmbCargo.Items.Add("Usuário");
            cmbCargo.Items.Add("Técnico");     
            cmbCargo.Items.Add("Administrador");

            panelEdicao.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busca = txtBusca.Text.Trim();
            if (string.IsNullOrWhiteSpace(busca))
            {
                MessageBox.Show("Por favor, digite um ID ou E-mail para buscar.", "Busca Vazia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new MeuProjetoDbContext())
                {

                    usuarioParaEditar = db.Usuarios.FirstOrDefault(u =>
                        u.Id.ToString() == busca ||
                        u.Email.ToLower() == busca.ToLower()
                    );

                    if (usuarioParaEditar != null)
                    {
                        txtNome.Text = usuarioParaEditar.NomeCompleto;
                        txtEmail.Text = usuarioParaEditar.Email;
                        txtNovaSenha.Clear();

                        switch (usuarioParaEditar.Cargo)
                        {
                            case 1: 
                                cmbCargo.SelectedItem = "Técnico";
                                break;
                            case 2: 
                                cmbCargo.SelectedItem = "Administrador";
                                break;
                            default:
                                cmbCargo.SelectedItem = "Usuário";
                                break;
                        }

                        panelEdicao.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado.", "Busca Falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        panelEdicao.Enabled = false;
                        usuarioParaEditar = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvarEdicao_Click(object sender, EventArgs e)
        {
            if (usuarioParaEditar == null) return;

            string novoNome = txtNome.Text.Trim();
            string novoEmail = txtEmail.Text.Trim();
            string novaSenha = txtNovaSenha.Text.Trim();

            if (string.IsNullOrWhiteSpace(novoNome) || string.IsNullOrWhiteSpace(novoEmail))
            {
                MessageBox.Show("O nome e o e-mail não podem ficar vazios.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new MeuProjetoDbContext())
                {
                    if (db.Usuarios.Any(u => u.Email.ToLower() == novoEmail.ToLower() && u.Id != usuarioParaEditar.Id))
                    {
                        MessageBox.Show("Este e-mail já está sendo usado por outro usuário.", "E-mail Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var usuarioNoDb = db.Usuarios.Find(usuarioParaEditar.Id);
                    if (usuarioNoDb != null)
                    {
                        usuarioNoDb.NomeCompleto = novoNome;
                        usuarioNoDb.Email = novoEmail;

                        switch (cmbCargo.SelectedItem.ToString())
                        {
                            case "Técnico":
                                usuarioNoDb.Cargo = 1;
                                break;
                            case "Administrador":
                                usuarioNoDb.Cargo = 2;
                                break;
                            default:
                                usuarioNoDb.Cargo = 0;
                                break;
                        }

                        if (!string.IsNullOrWhiteSpace(novaSenha))
                        {

                            usuarioNoDb.SenhaHash = BCrypt.Net.BCrypt.HashPassword(novaSenha);
                        }

                        db.SaveChanges();
                        MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        panelEdicao.Enabled = false;
                        txtBusca.Clear();
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtNovaSenha.Clear();
                        usuarioParaEditar = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar alterações: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
