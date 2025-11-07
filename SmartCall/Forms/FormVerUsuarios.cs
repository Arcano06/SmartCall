using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartCall.Models; // <-- ADICIONE ESTE (para o DbContext e Usuario)
using System.Linq;      // <-- ADICIONE ESTE (para .Select() e .ToList())

namespace SmartCall.Forms
{
    public partial class FormVerUsuarios : Form
    {
        public FormVerUsuarios()
        {
            InitializeComponent();
        }

        public void CarregarUsuarios()
        {
            try
            {
                using (var db = new MeuProjetoDbContext())
                {
                    var listaParaExibir = db.Usuarios
                        .Select(u => new
                        {
                            ID = u.Id,
                            Nome = u.NomeCompleto,
                            Email = u.Email,
                            Cargo = (u.Cargo == 2) ? "Administrador" :
                            (u.Cargo == 1) ? "Técnico" :
                                             "Usuário"
                        })
                        .ToList();

                    dgvUsuarios.DataSource = listaParaExibir;

                    if (dgvUsuarios.Columns.Count > 0)
                    {
                        dgvUsuarios.Columns["ID"].HeaderText = "ID";
                        dgvUsuarios.Columns["Nome"].HeaderText = "Nome Completo";
                        dgvUsuarios.Columns["Email"].HeaderText = "E-mail";
                        dgvUsuarios.Columns["Cargo"].HeaderText = "Nível de Acesso";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar usuários: " + ex.Message,
                                "Erro de Conexão",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void FormVerUsuarios_Load_1(object sender, EventArgs e)
        {
            {
                CarregarUsuarios();
            }
        }
    }
}