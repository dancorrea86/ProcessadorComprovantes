using ProcessadorComprovantes.Application.MoveFiles;
using System.Windows.Forms;

namespace FileProcessor.WindowsForms
{
    public partial class FormGerenciador : Form
    {

        public FormGerenciador()
        {
            InitializeComponent();
        }

        private void FormGerenciador_Load(object sender, EventArgs e)
        {
            InitializeOpenFileDialog();
        }


        private void BtnArquivos_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.ofdArquivos.ShowDialog();

            foreach (string file in ofdArquivos.FileNames)
            {
                MoveFileUseCase.Renomear(file);
            }
        }

        private void InitializeOpenFileDialog()
        {
            ofdArquivos.Multiselect = true;
            ofdArquivos.Filter = "PDF Files|*.pdf";
            ofdArquivos.Title = "Selecione os arquivos PDF";
        }


    }
}
