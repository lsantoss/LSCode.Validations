using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    /// <summary>Auxilia na utilização, validação e formatação de tamanho de arquivos em KB.</summary>
    public class TamanhoArquivoKB : Notificadora
    {
        /// <value>Tamanho do arquivo em KB.</value>
        public string Valor { get; private set; }

        /// <summary>Construtor da classe TamanhoArquivoKB.</summary>
        /// <remarks>
        ///     Formatos de entrada: 1597,44. <br></br>
        ///     Formato de saída: 1,56 GB.
        /// </remarks>
        /// <param name="valorEmBytes">Tamanho do arquivo em Bytes (somente números).</param>
        /// <returns>Cria uma instância da classe TamanhoArquivoKB.</returns>
        public TamanhoArquivoKB(string valorEmBytes)
        {
            try
            {
                Valor = valorEmBytes;

                if (!string.IsNullOrWhiteSpace(Valor))
                {
                    var tamanho = decimal.Parse(valorEmBytes);

                    // Bytes para KBytes
                    tamanho /= 1024;

                    Valor = $"{tamanho:N2} KB";
                }
                else
                    AddNotificacao("TamanhoArquivoKB", "Conteúdo não pode ser nulo ou vazio");
            }
            catch (Exception ex)
            {
                AddNotificacao("TamanhoArquivoKB", $"Erro: {ex.Message}");
            }
        }

        /// <summary>Retorna o tamnho do arquivo em KiloBytes.</summary>
        public override string ToString() => Valor;
    }
}