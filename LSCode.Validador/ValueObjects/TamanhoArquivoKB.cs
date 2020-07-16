using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    public class TamanhoArquivoKB : Notificadora
    {
        public string Valor { get; private set; }

        public TamanhoArquivoKB(string valorEmBytes)
        {
            try
            {
                Valor = valorEmBytes;

                if (Valor == null)
                {
                    AddNotificacao("TamanhoArquivoKB", "Conteúdo não pode ser nulo");
                }
                else
                {
                    double tamanho = double.Parse(valorEmBytes);

                    // Bytes para KBytes
                    tamanho /= 1024;

                    Valor = tamanho.ToString("N0") + " KB";
                }                
            }
            catch (Exception ex)
            {
                AddNotificacao("TamanhoArquivoKB", $@"Erro: {ex.Message}");
            }
        }

        public override string ToString() => Valor;
    }
}