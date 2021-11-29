using LSCode.Validador.ValidacoesBooleanas;
using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    /// <summary>Auxilia na utilização, validação e formatação de números de CPF.</summary>
    public class CPF : Notificadora
	{
		/// <value>Número do CPF.</value>
		public string Valor { get; private set; }

        /// <summary>Construtor da classe CPF.</summary>
        /// <remarks>
        ///     Formatos válidos: CPF com ou sem máscara. <br></br>
        ///     Formato de saída: 000.000.000-00.
        /// </remarks>
        /// <param name="valor">Número do CPF.</param>
        /// <returns>Cria uma instância da classe CPF.</returns>
        public CPF(string valor)
        {
            try
            {
                Valor = valor;

                if (!string.IsNullOrWhiteSpace(Valor))
                {
                    if (ValidacaoBooleana.EhCPF(valor))
                        Valor = Formatar(valor);
                    else
                        AddNotificacao("CPF", "CPF inválido");
                }
                else
                    AddNotificacao("CPF", "CPF não pode ser nulo ou vazio");
            }
            catch (Exception ex)
            {
                AddNotificacao("CPF", $"Erro: {ex.Message}");
            }
        }

		/// <summary>Efetua formatação do número do CPF.</summary>
		/// <param name="valor">Número do CPF.</param>
		/// <returns>Número do CPF no formato: 000.000.000-00.</returns>
		/// <exception cref="Exception">Erro ao formatar número do CPF.</exception>
		private string Formatar(string valor)
		{
            if (valor.Length == 14)
            {
                return valor;
            }
            else
            {
                valor = valor.Trim();
                valor = valor.Replace(".", "").Replace("-", "").Replace("/", "");
                valor = Convert.ToUInt64(valor).ToString(@"000\.000\.000\-00");
                return valor;
            }
		}

		/// <summary>Retorna número do CPF.</summary>
		public override string ToString() => Valor;
    }
}