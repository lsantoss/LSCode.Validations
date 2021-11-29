using LSCode.Validador.ValidacoesBooleanas;
using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    /// <summary>Auxilia na utilização, validação e formatação de números de telefone.</summary>
    public class Telefone : Notificadora
    {
        /// <value>Número do telefone.</value>
        public string Valor { get; private set; }

        /// <summary>Construtor da classe Telefone.</summary>
        /// <remarks>
        ///     Formatos válidos: 3238887777 ou 323888-7777 ou (32)38887777 ou (32)3888-7777. <br></br>
        ///     Formato de saída: (32)3888-7777. <br></br>
        ///     Regex: ^(\(?)([0-9]{2})(\)?)[0-9]{4}-?[0-9]{4}$
        /// </remarks>
        /// <param name="valor">Número do telefone.</param>
        /// <returns>Cria uma instância da classe Telefone.</returns>
        public Telefone(string valor)
        {
            try
            {
                Valor = valor;

                if (!string.IsNullOrWhiteSpace(Valor))
                {
                    if (ValidacaoBooleana.EhTelefone(valor))
                        Valor = Formatar(valor);
                    else
                        AddNotificacao("Telefone", "Telefone inválido");
                }
                else
                    AddNotificacao("Telefone", "Telefone não pode ser nulo ou vazio");
            }
            catch (Exception ex)
            {
                AddNotificacao("Telefone", $"Erro: {ex.Message}");
            }
        }

        /// <summary>Efetua formatação do número do telefone.</summary>
        /// <param name="valor">Número do telefone.</param>
        /// <returns>Número do telefone no formato: (32)3888-7777.</returns>
        /// <exception cref="Exception">Erro ao formatar número do telefone.</exception>
        private string Formatar(string valor)
        {
            if(valor.Length == 13) {
                return valor;
            }
            else
            {
                valor = valor.Trim();
                valor = valor.Replace("(", "").Replace(")", "").Replace("-", "");
                valor = Convert.ToUInt64(valor).ToString(@"\(00\)0000\-0000");
                return valor;
            }
        }

        /// <summary>Retorna número do telefone.</summary>
        public override string ToString() => Valor;
    }
}