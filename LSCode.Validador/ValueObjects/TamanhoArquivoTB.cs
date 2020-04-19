using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class TamanhoArquivoTB : Notificadora
    {
        public string Tamanho { get; private set; }

        public TamanhoArquivoTB(string tamanhoEmBytes)
        {
            double tamanhoDouble = double.Parse(tamanhoEmBytes);

            // Bytes para KBytes
            tamanhoDouble = tamanhoDouble / 1024;

            // KBytes para MBytes
            tamanhoDouble = tamanhoDouble / 1024;

            // MBytes para GBytes
            tamanhoDouble = tamanhoDouble / 1024;

            // GBytes para TBytes
            tamanhoDouble = tamanhoDouble / 1024;

            this.Tamanho = tamanhoDouble.ToString("N1") + " TB";
        }

        public override string ToString()
        {
            return this.Tamanho;
        }
    }
}