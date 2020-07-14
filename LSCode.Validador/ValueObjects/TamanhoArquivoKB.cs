using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class TamanhoArquivoKB : Notificadora
    {
        public string Valor { get; private set; }

        public TamanhoArquivoKB(string valorEmBytes)
        {
            double tamanho = double.Parse(valorEmBytes);

            // Bytes para KBytes
            tamanho /= 1024;

            Valor = tamanho.ToString("N0") + " KB";
        }

        public override string ToString() => Valor;
    }
}