using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    /// <summary>Auxilia na utilização, validação e formatação de tamanho de arquivos em GB.</summary>
    public class TamanhoArquivoGB : Notificadora
    {
        /// <value>Tamanho do arquivo em GB.</value>
        public string Valor { get; private set; }

        /// <summary>Construtor da classe TamanhoArquivoGB.</summary>
        /// <remarks>
        ///     Formatos de entrada: 1675037245,44. <br></br>
        ///     Formato de saída: 1,56 GB.
        /// </remarks>
        /// <param name="valorEmBytes">Tamanho do arquivo em Bytes (somente números).</param>
        /// <returns>Cria uma instância da classe TamanhoArquivoGB.</returns>
        public TamanhoArquivoGB(string valorEmBytes)
        {
            try
            {
                Valor = valorEmBytes;

                if (!string.IsNullOrWhiteSpace(Valor))
                {
                    var tamanho = decimal.Parse(Valor);

                    // Bytes para KBytes
                    tamanho /= 1024;

                    // KBytes para MBytes
                    tamanho /= 1024;

                    // MBytes para GBytes
                    tamanho /= 1024;

                    Valor = $"{tamanho:N2} GB";
                }
                else
                    AddNotificacao("TamanhoArquivoGB", "Conteúdo não pode ser nulo ou vazio");
            }
            catch (Exception ex)
            {
                AddNotificacao("TamanhoArquivoGB", $"Erro: {ex.Message}");
            }
        }

        /// <summary>Retorna o tamnho do arquivo em GigaBytes.</summary>
        public override string ToString() => Valor;
    }
}