using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class TamanhoArquivoMB : Notificadora
    {
        public string Valor { get; private set; }

        public TamanhoArquivoMB(string valorEmBytes)
        {
            double tamanho = double.Parse(valorEmBytes);

            // Bytes para KBytes
            tamanho /= 1024;

            // KBytes para MBytes
            tamanho /= 1024;

            Valor = tamanho.ToString("N1") + " MB";
        }

        public override string ToString() => Valor;
    }
}