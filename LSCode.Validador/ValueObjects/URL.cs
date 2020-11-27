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
        /// <returns> Cria uma instância da classe URL.</returns>
        public URL(string valor)
        {
            try
            {
                Valor = valor;

                if (Valor == null)
                {
                    AddNotificacao("Celular", "Celular não pode ser nulo");
                }
                else
                {
                    AddNotificacao(new ContratoValidacao().EhVerdadeiro(Validar(Valor), "URL", "URL inválida"));
                }
            }
            catch (Exception ex)
            {
                AddNotificacao("URL", $@"Erro: {ex.Message}");
            }
        }

        /// <summary>Efetua validação da url.</summary>
        /// <param name="valor">URL.</param>
        /// <returns>True caso válido ou False caso inválido.</returns>
        /// <exception cref="Exception">Erro ao validar url.</exception>
        private bool Validar(string valor) => Uri.IsWellFormedUriString(valor, UriKind.Absolute);

        /// <summary>Retorna número do celular.</summary>
        public override string ToString() => Valor;
    }
}