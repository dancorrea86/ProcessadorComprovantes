using ProcessadorComprovantes.Application.Usuarios;
using ProcessadorComprovantes.Domain.Entities;
using ProcessadorComprovantes.GerenciadorComprovante;
using ProcessadorComprovantes.Infrastructure;
using System.Reflection.Metadata;
using static GerenciadorComprovante.GerenciadorComprovante;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GerenciadorComprovante
{
    public partial class FormPrincipal : Form
    {
        List<string> _arquivosSelecionados = new List<string>();
        Usuario _user;
        List<Usuario> _usuarios;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            var service = new CreateUserUseCase(new JsonUsuarioRepository());
            _usuarios = service.GetUsers();
            cmbCarregarUsuario.Items.Clear();
            cmbCarregarUsuario.Items.AddRange(_usuarios.Select(u => u.Nome).ToArray());
        }

        private void btnAbrirArquivos_Click(object sender, EventArgs e)
        {
            SelecionarArquivos();
        }

        private void SelecionarArquivos()
        {
            OpenFileDialog seletor = new OpenFileDialog();
            seletor.Multiselect = true;
            seletor.Title = "Selecione os arquivos para renomear";
            seletor.Filter = "Arquivos PDF (*.pdf)|*.pdf|Todos os arquivos (*.*)|*.*";
            _arquivosSelecionados = seletor.FileNames.ToList();

            if (seletor.ShowDialog() == DialogResult.OK)
            {
                _arquivosSelecionados = seletor.FileNames.ToList();
            }
        }

        private void RenomearArquivosSelecionados()
        {
            var contagemSucesso = 0;

            foreach (string caminhoCompleto in _arquivosSelecionados)
            {
                try
                {
                    DateTime dataCriacao = File.GetCreationTime(caminhoCompleto);
                    string diretorio = Path.GetDirectoryName(caminhoCompleto);
                    string nomeOriginal = Path.GetFileName(caminhoCompleto);

                    // Define o novo nome: yyyy-MM-dd - NomeOriginal.ext
                    string novoNome = $"{dataCriacao.ToString("yyyy-MM-hh")} - {nomeOriginal}";
                    string novoCaminhoCompleto = Path.Combine(diretorio, novoNome);

                    // Verifica se o arquivo já não existe para evitar erros
                    if (!File.Exists(novoCaminhoCompleto))
                    {
                        File.Move(caminhoCompleto, novoCaminhoCompleto);
                        contagemSucesso++;
                    }
                    else
                    {
                        MessageBox.Show($"O arquivo '{novoNome}' já existe.", "Aviso");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao renomear {Path.GetFileName(caminhoCompleto)}: {ex.Message}");
                }
            }

            MessageBox.Show($"{contagemSucesso} arquivo(s) renomeados com sucesso!", "Concluído");

        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            string unidadeGoogleDrive = ObterCaminhoGoogleDrive();

            string pastaDestino = @$"{_user.DiretorioRaiz}";



            foreach (var item in _arquivosSelecionados)
            {
                try
                {
                    MoveArquivos gerenciador = new MoveArquivos(item, pastaDestino);

                    gerenciador.Main();

                    MessageBox.Show("Processamento concluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro durante o processo: {ex.Message}", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public string ObterCaminhoGoogleDrive()
        {

            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                try
                {
                    if (drive.IsReady && drive.VolumeLabel.Contains("Google Drive"))
                    {
                        return drive.RootDirectory.FullName; // Retorna algo como "G:\"
                    }
                }
                catch (IOException)
                {

                    continue;
                }
            }

            return null; // Caso não encontre
        }

        private void btnCriarUsuario_Click(object sender, EventArgs e)
        {
            var formCriarUsuario = new formCreateUser();
            formCriarUsuario.ShowDialog();
        }

        private void cmbCarregarUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            _user = _usuarios.FirstOrDefault(u => u.Nome == cmbCarregarUsuario.SelectedItem.ToString());
        }

        private void btnRenomear_Click(object sender, EventArgs e)
        {
            RenomearArquivosSelecionados();
        }
    }
}
