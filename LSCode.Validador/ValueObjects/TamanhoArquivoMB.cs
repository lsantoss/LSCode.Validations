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
        /// <remarks>
        ///     Formatos de entrada: 1635778,56. <br></br>
        ///     Formato de saída: 1,56 GB.
        /// </remarks>
        /// <param name="valorEmBytes">Tamanho do arquivo em Bytes (somente números).</param>
        /// <returns>Cria uma instância da classe TamanhoArquivoMB.</returns>
        public TamanhoArquivoMB(string valorEmBytes)
        {
            try
            {
                Valor = valorEmBytes;

                if (!string.IsNullOrWhiteSpace(Valor))
                {
                    var tamanho = decimal.Parse(valorEmBytes);

                    // Bytes para KBytes
                    tamanho /= 1024;

                    // KBytes para MBytes
                    tamanho /= 1024;

                    Valor = $"{tamanho:N2} MB";
                }
                else
                    AddNotificacao("TamanhoArquivoMB", "Conteúdo não pode ser nulo ou vazio");
            }
            catch (Exception ex)
            {
                AddNotificacao("TamanhoArquivoMB", $"Erro: {ex.Message}");
            }
        }

        /// <summary>Retorna o tamnho do arquivo em MegaBytes.</summary>
        public override string ToString() => Valor;
    }
}