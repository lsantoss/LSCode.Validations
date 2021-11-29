using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    /// <summary>Auxilia na utilização e validação de URLs.</summary>
    public class URL : Notificadora
    {
        /// <value>URL.</value>
        public string Valor { get; private set; }

        /// <summary>Construtor da classe URL.</summary>
        /// <param name="valor">URL.</param>
        /// <returns>Cria uma instância da classe URL.</returns>
        public URL(string valor)
        {
            try
            {
                Valor = valor;

                if (!string.IsNullOrWhiteSpace(Valor))
                    AddNotificacao(new ContratoValidacao().EhUrl(Valor, "URL", "URL inválida"));
                else
                    AddNotificacao("URL", "URL não pode ser nula ou vazia");
            }
            catch (Exception ex)
            {
                AddNotificacao("URL", $"Erro: {ex.Message}");
            }
        }

        /// <summary>Retorna a url.</summary>
        public override string ToString() => Valor;
    }
}