using LSCode.Validador.ValidacoesBooleanas;
using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    /// <summary>Auxilia na utilização, validação e formatação de números de CEP.</summary>
    public class CEP : Notificadora
    {
        /// <value>Número do CEP.</value>
        public string Valor { get; private set; }

        /// <summary>Construtor da classe CEP.</summary>
        /// <remarks>
        ///     Formatos válidos: 37123-500 ou 37123500. <br></br>
        ///     Formato de saída: 37123-500. <br></br>
        ///     Regex: ^\d{5}\-?\d{3}$
        /// </remarks>
        /// <param name="valor">Número do CEP.</param>
        /// <returns>Cria uma instância da classe CEP.</returns>
        public CEP(string valor)
        {
            try
            {
                Valor = valor;

                if (!string.IsNullOrWhiteSpace(Valor))
                {
                    if (ValidacaoBooleana.EhCEP(valor))
                        Valor = Formatar(valor);
                    else
                        AddNotificacao("CEP", "CEP inválido");
                }
                else
                    AddNotificacao("CEP", "CEP não pode ser nulo ou vazio");
            }
            catch (Exception ex)
            {
                AddNotificacao("CEP", $"Erro: {ex.Message}");
            }
        }

        /// <summary>Efetua formatação do número do CEP.</summary>
        /// <param name="valor">Número do CEP.</param>
        /// <returns>Número do CEP no formato: 37123-500.</returns>
        /// <exception cref="Exception">Erro ao formatar número do CEP.</exception>
        private string Formatar(string valor) => valor.Length == 9 ? valor : Convert.ToUInt64(valor).ToString(@"00000\-000");

        /// <summary>Retorna número do CEP.</summary>
        public override string ToString() => Valor;
    }
}