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
        /// <param name="valorEmBytes">Tamanho do arquivo em Bytes.</param>
        /// <returns> Cria uma instância da classe TamanhoArquivoTB.</returns>
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

        /// <summary>Retorna número do celular.</summary>
        public override string ToString() => Valor;
    }
}