using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    public class TamanhoArquivoMB : Notificadora
    {
        public string Valor { get; private set; }

        public TamanhoArquivoMB(string valorEmBytes)
        {
            try
            {
                Valor = valorEmBytes;

                if (Valor == null)
                {
                    AddNotificacao("TamanhoArquivoMB", "Conteúdo não pode ser nulo");
                }
                else
                {
                    double tamanho = double.Parse(valorEmBytes);

                    // Bytes para KBytes
                    tamanho /= 1024;

                    // KBytes para MBytes
                    tamanho /= 1024;

                    Valor = tamanho.ToString("N1") + " MB";
                }
            }
            catch (Exception ex)
            {
                AddNotificacao("TamanhoArquivoMB", $@"Erro: {ex.Message}");
            }
        }

        public override string ToString() => Valor;
    }
}