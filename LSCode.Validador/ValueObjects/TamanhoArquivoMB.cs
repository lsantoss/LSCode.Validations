using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    /// <summary>Auxilia na utilização, validação e formatação de tamanho de arquivos em MB.</summary>
    public class TamanhoArquivoMB : Notificadora
    {
        /// <value>Tamanho do arquivo em MB.</value>
        public string Valor { get; private set; }

        /// <summary>Construtor da classe TamanhoArquivoMB.</summary>
        /// <param name="valorEmBytes">Tamanho do arquivo em Bytes.</param>
        /// <returns> Cria uma instância da classe TamanhoArquivoMB.</returns>
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

        /// <summary>Retorna número do celular.</summary>
        public override string ToString() => Valor;
    }
}