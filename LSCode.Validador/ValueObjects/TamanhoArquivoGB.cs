using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    public class TamanhoArquivoGB : Notificadora
    {
        public string Valor { get; private set; }

        public TamanhoArquivoGB(string valorEmBytes)
        {
            try
            {
                Valor = valorEmBytes;

                if (Valor == null)
                {
                    AddNotificacao("TamanhoArquivoGB", "Conteúdo não pode ser nulo");
                }
                else
                {
                    double tamanho = double.Parse(Valor);

                    // Bytes para KBytes
                    tamanho /= 1024;

                    // KBytes para MBytes
                    tamanho /= 1024;

                    // MBytes para GBytes
                    tamanho /= 1024;

                    Valor = tamanho.ToString("N1") + " GB";
                }
            }
            catch (Exception ex)
            {
                AddNotificacao("TamanhoArquivoGB", $@"Erro: {ex.Message}");
            }
        }

        public override string ToString() => Valor;
    }
}