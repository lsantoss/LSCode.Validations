using LSCode.Validador.ValidacoesNotificacoes;
using System;
using System.Text.RegularExpressions;

namespace LSCode.Validador.ValueObjects
{
    /// <summary>Auxilia na utilização, validação e formatação de números de CEP.</summary>
    public class CEP : Notificadora
    {
        /// <value>Número do CEP.</value>
        public string Valor { get; private set; }

        /// <summary>Construtor da classe CEP.</summary>
        /// <remarks> Formatos esperados: 37123-500 ou 37123500.</remarks>
        /// <param name="valor">Número do CEP.</param>
        /// <returns> Cria uma instância da classe CEP.</returns>
        public CEP(string valor)
        {
            try
            {
                Valor = valor;

                if (Valor == null)
                {
                    AddNotificacao("CEP", "CEP não pode ser nulo");
                }
                else
                {
                    bool valido = Validar(valor);

                    if (valido)
                        Valor = Formatar(valor);

                    AddNotificacao(new ContratoValidacao().EhVerdadeiro(valido, "CEP", "CEP inválido"));
                }
            }
            catch (Exception ex)
            {
                AddNotificacao("CEP", $@"Erro: {ex.Message}");
            }
        }

        /// <summary>Efetua validação do número do CEP.</summary>
        /// <param name="valor">Número do CEP.</param>
        /// <returns>True caso válido ou False caso inválido.</returns>
        /// <exception cref="Exception">Erro ao validar número do CEP.</exception>
        private bool Validar(string valor) => Regex.IsMatch(valor, @"^\d{5}\-?\d{3}$");

        /// <summary>Efetua formatação do número do CEP.</summary>
        /// <param name="valor">Número do CEP.</param>
        /// <returns>Número do CEP no formato: 37123-500.</returns>
        /// <exception cref="Exception">Erro ao formatar número do CEP.</exception>
        private string Formatar(string valor) => valor.Length == 9 ? valor : Convert.ToUInt64(valor).ToString(@"00000\-000");

        /// <summary>Retorna número do CEP.</summary>
        public override string ToString() => Valor;
    }
}