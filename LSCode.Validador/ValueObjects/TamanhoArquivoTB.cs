using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    /// <summary>Auxilia na utilização, validação e formatação de tamanho de arquivos em TB.</summary>
    public class TamanhoArquivoTB : Notificadora
    {
        /// <value>Tamanho do arquivo em TB.</value>
        public string Valor { get; private set; }

        /// <summary>Construtor da classe TamanhoArquivoTB.</summary>
        /// <remarks>
        ///     Formatos de entrada: 1715238139330,56. <br></br>
        ///     Formato de saída: 1,56 GB.
        /// </remarks>
        /// <param name="valorEmBytes">Tamanho do arquivo em Bytes (somente números).</param>
        /// <returns>Cria uma instância da classe TamanhoArquivoTB.</returns>
        public TamanhoArquivoTB(string valorEmBytes)
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

                    // MBytes para GBytes
                    tamanho /= 1024;

                    // GBytes para TBytes
                    tamanho /= 1024;

                    Valor = $"{tamanho:N2} TB";
                }
                else
                    AddNotificacao("TamanhoArquivoTB", "Conteúdo não pode ser nulo ou vazio");
            }
            catch (Exception ex)
            {
                AddNotificacao("TamanhoArquivoTB", $"Erro: {ex.Message}");
            }
        }

        /// <summary>Retorna o tamnho do arquivo em TeraBytes.</summary>
        public override string ToString() => Valor;
    }
}