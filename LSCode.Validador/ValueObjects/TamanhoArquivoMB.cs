using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class TamanhoArquivoMB : Notificadora
    {
        public string Tamanho { get; private set; }

        public TamanhoArquivoMB(string tamanhoEmBytes)
        {
            double tamanhoDouble = double.Parse(tamanhoEmBytes);

            // Bytes para KBytes
            tamanhoDouble = tamanhoDouble / 1024;

            // KBytes para MBytes
            tamanhoDouble = tamanhoDouble / 1024;

            this.Tamanho = tamanhoDouble.ToString("N1") + " MB";
        }

        public override string ToString()
        {
            return this.Tamanho;
        }
    }
}