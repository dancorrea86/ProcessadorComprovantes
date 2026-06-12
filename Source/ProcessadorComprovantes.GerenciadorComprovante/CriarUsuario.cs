using ProcessadorComprovantes.Application.Usuarios;
using ProcessadorComprovantes.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProcessadorComprovantes.GerenciadorComprovante
{
    public partial class formCreateUser : Form
    {
        private readonly CreateUserUseCase _createUserUseCase;

        public formCreateUser()
        {
            InitializeComponent();
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            var pasta = txtPasta.Text;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(pasta))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var service = new CreateUserUseCase(new JsonUsuarioRepository());
                service.Executar(nome, pasta);
                MessageBox.Show("Usuário criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
