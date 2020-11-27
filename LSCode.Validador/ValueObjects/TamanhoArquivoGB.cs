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
        /// <param name="valorEmBytes">Tamanho do arquivo em Bytes.</param>
        /// <returns> Cria uma instância da classe TamanhoArquivoGB.</returns>
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

        /// <summary>Retorna número do celular.</summary>
        public override string ToString() => Valor;
    }
}