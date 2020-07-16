using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    public class TamanhoArquivoTB : Notificadora
    {
        public string Valor { get; private set; }

        public TamanhoArquivoTB(string valorEmBytes)
        {
            try
            {
                Valor = valorEmBytes;

                if (Valor == null)
                {
                    AddNotificacao("TamanhoArquivoTB", "Conteúdo não pode ser nulo");
                }
                else
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
            }
            catch (Exception ex)
            {
                AddNotificacao("TamanhoArquivoTB", $@"Erro: {ex.Message}");
            }
        }

        public override string ToString() => Valor;
    }
}