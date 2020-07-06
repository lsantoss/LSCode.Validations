using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class TamanhoArquivoGB : Notificadora
    {
        public string Tamanho { get; private set; }

        public TamanhoArquivoGB(string tamanhoEmBytes)
        {
            double tamanhoDouble = double.Parse(tamanhoEmBytes);

            // Bytes para KBytes
            tamanhoDouble = tamanhoDouble / 1024;

            // KBytes para MBytes
            tamanhoDouble = tamanhoDouble / 1024;

            // MBytes para GBytes
            tamanhoDouble = tamanhoDouble / 1024;

            Tamanho = tamanhoDouble.ToString("N1") + " GB";
        }

        public override string ToString()
        {
            return Tamanho;
        }
    }
}