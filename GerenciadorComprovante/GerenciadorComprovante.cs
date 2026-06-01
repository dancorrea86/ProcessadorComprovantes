namespace GerenciadorComprovante
{
    public class GerenciadorComprovante
    {
        // Representação da entidade Conta
        public class Conta
        {
            public string Descricao { get; set; }
            public string Data { get; set; }
            public string Caminho { get; set; }

            public Conta(string descricao, string data, string caminho)
            {
                Descricao = descricao;
                Data = data;
                Caminho = caminho;
            }
        }

        public class MoveArquivos
        {
            private string _pastaOrigem;
            private string _pastaDestino;
            private string[] _listaArquivos;

            public MoveArquivos(string pastaOrigem, string pastaDestino = null)
            {
                _pastaOrigem = pastaOrigem;
                // Se destino for nulo, usa o diretório atual (como os.getcwd)
                _pastaDestino = pastaDestino ?? Directory.GetCurrentDirectory();

                if (Directory.Exists(pastaDestino))
                    _listaArquivos = Directory.GetFiles(_pastaOrigem);
                else
                    _listaArquivos = new string[0];
            }

            public void Main()
            {
                SepararArquivosPasta();
            }

            public void SepararArquivosPasta()
            {
                List<string> listaArquivosParaMover = new List<string>();

                MoverArquivosFisicos(listaArquivosParaMover);
            }

            private void MoverArquivosFisicos(List<string> listaArquivosParaMover)
            {
                Console.WriteLine("Movendo Arquivos...");
                foreach (string arquivo in listaArquivosParaMover)
                {
                    MostrarLog(arquivo);
                    CriarPastaSeNaoExistir(arquivo);

                    string origem = CriarCaminhoPastaOrigem(arquivo);
                    string destino = CriarCaminhoPastaDestino(arquivo);

                    try
                    {
                        if (File.Exists(destino)) File.Delete(destino); // Evita erro se já existir
                        File.Move(origem, destino);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro ao mover {arquivo}: {ex.Message}");
                    }
                }
            }

            private void MostrarLog(string arquivo)
            {
                Console.WriteLine(Path.Combine(_pastaOrigem, arquivo));
            }

            private void CriarPastaSeNaoExistir(string arquivo)
            {
                string ano = arquivo.Substring(0, 4);
                string anoMes = arquivo.Substring(0, 7);
                string caminhoFinal = Path.Combine(_pastaDestino, ano, anoMes);

                if (!Directory.Exists(caminhoFinal))
                {
                    Directory.CreateDirectory(caminhoFinal);
                }
            }

            private string CriarCaminhoPastaOrigem(string arquivo) => Path.Combine(_pastaOrigem, arquivo);

            private string CriarCaminhoPastaDestino(string arquivo)
            {
                string ano = arquivo.Substring(0, 4);
                string anoMes = arquivo.Substring(0, 7);
                return Path.Combine(_pastaDestino, ano, anoMes, arquivo);
            }
        }
    }
}
