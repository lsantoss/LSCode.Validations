using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class TamanhoArquivoGB : Notificadora
    {
        public string Valor { get; private set; }

        public TamanhoArquivoGB(string valorEmBytes)
        {
            double tamanho = double.Parse(valorEmBytes);

            // Bytes para KBytes
            tamanho /= 1024;

            // KBytes para MBytes
            tamanho /= 1024;

            // MBytes para GBytes
            tamanho /= 1024;

            Valor = tamanho.ToString("N1") + " GB";
        }

        public override string ToString() => Valor;
    }
}