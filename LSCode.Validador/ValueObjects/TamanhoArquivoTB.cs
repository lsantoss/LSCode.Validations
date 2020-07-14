using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class TamanhoArquivoTB : Notificadora
    {
        public string Valor { get; private set; }

        public TamanhoArquivoTB(string valorEmBytes)
        {
            double tamanho = double.Parse(valorEmBytes);

            // Bytes para KBytes
            tamanho /= 1024;

            // KBytes para MBytes
            tamanho /= 1024;

            // MBytes para GBytes
            tamanho /= 1024;

            // GBytes para TBytes
            tamanho /= 1024;

            Valor = tamanho.ToString("N1") + " TB";
        }

        public override string ToString() => Valor;
    }
}