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
        /// <param name="valorEmBytes">Tamanho do arquivo em Bytes.</param>
        /// <returns> Cria uma instância da classe TamanhoArquivoKB.</returns>
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

        /// <summary>Retorna número do celular.</summary>
        public override string ToString() => Valor;
    }
}