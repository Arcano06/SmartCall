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
    public partial class FormDeletarUsuario : Form
    {

        private Usuario usuarioParaDeletar;

        public FormDeletarUsuario()
        {
            InitializeComponent();
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
                    usuarioParaDeletar = db.Usuarios.FirstOrDefault(u =>
                        u.Id.ToString() == busca ||
                        u.Email.ToLower() == busca.ToLower()
                    );

                    if (usuarioParaDeletar != null)
                    {
                        lblUsuarioEncontrado.Text = $"Nome: {usuarioParaDeletar.NomeCompleto} | E-mail: {usuarioParaDeletar.Email}";

                        btnDeletarConfirmar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado.", "Busca Falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        lblUsuarioEncontrado.Text = "(Nenhum usuário selecionado)";
                        btnDeletarConfirmar.Enabled = false;
                        usuarioParaDeletar = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeletarConfirmar_Click(object sender, EventArgs e)
        {
            if (usuarioParaDeletar == null) return;

            var confirmacao = MessageBox.Show(
                $"Você tem certeza absoluta que deseja deletar permanentemente o usuário:\n\n" +
                $"{usuarioParaDeletar.NomeCompleto} ({usuarioParaDeletar.Email})\n\n" +
                $"Esta ação não pode ser desfeita.",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacao == DialogResult.No)
            {
                return;
            }

            try
            {

                using (var db = new MeuProjetoDbContext())
                {
                    var usuarioNoDb = db.Usuarios.Find(usuarioParaDeletar.Id);

                    if (usuarioNoDb != null)
                    {
                        db.Usuarios.Remove(usuarioNoDb);
                        db.SaveChanges();

                        MessageBox.Show("Usuário deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtBusca.Clear();
                        lblUsuarioEncontrado.Text = "(Nenhum usuário selecionado)";
                        btnDeletarConfirmar.Enabled = false;
                        usuarioParaDeletar = null;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível encontrar o usuário no banco para deletar. Tente buscar novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
