using LSCode.Validador.ValidacoesNotificacoes;
using System;
using System.Text.RegularExpressions;

namespace LSCode.Validador.ValueObjects
{
    /// <summary>Auxilia na utilização e validação senhas.</summary>
    public class SenhaForte : Notificadora
    {
        /// <value>Senha.</value>
        public string Valor { get; private set; }

        /// <summary>Construtor da classe SenhaForte.</summary>
        /// <remarks> Deve conter pelo menos oito e no máximo quinze caracteres; Uma letra maiúscula; Uma letra minúscula; Um número; Um caracter especial.</remarks>
        /// <param name="valor">Senha.</param>
        /// <returns> Cria uma instância da classe SenhaForte.</returns>
        public SenhaForte(string valor)
        {
            try
            {
                Valor = valor;

                if (Valor == null)
                {
                    AddNotificacao("SenhaForte", "Senha não pode ser nula");
                }
                else
                {
                    Validar(Valor);
                }
            }
            catch (Exception ex)
            {
                AddNotificacao("SenhaForte", $@"Erro: {ex.Message}");
            }
        }

        /// <summary>Efetua validação da senha.</summary>
        /// <param name="valor">Senha.</param>
        /// <returns>True caso válido ou False caso inválido.</returns>
        /// <exception cref="Exception">Erro ao validar senha.</exception>
        private void Validar(string valor)
        {
            if (!QuantidadeCaracteres(valor))
                AddNotificacao("SenhaForte", "Senha deve conter no mínimo 8 e no máximo 15 caracteres");

            if (!ContemLetraMaiuscula(valor))
                AddNotificacao("SenhaForte", "Senha deve conter no mínimo 1 letra maíuscula");

            if (!ContemLetraMinuscula(valor))
                AddNotificacao("SenhaForte", "Senha deve conter no mínimo 1 letra minúscula");

            if (!ContemNumero(valor))
                AddNotificacao("SenhaForte", "Senha deve conter no mínimo 1 número");

            if (!ContemCaracteresEspeciais(valor))
                AddNotificacao("SenhaForte", "Senha deve conter no mínimo 1 caracter especial");
        }

        /// <summary>Efetua validação se a senha possui pelo menos oito e no máximo quinze caracteres.</summary>
        /// <param name="valor">Senha.</param>
        /// <returns>True caso válido ou False caso inválido.</returns>
        /// <exception cref="Exception">Erro ao validar senha.</exception>
        private bool QuantidadeCaracteres(string valor) => valor.Length >= 8 && valor.Length <= 15;

        /// <summary>Efetua validação se a senha possui pelo menos uma letra maiúscula.</summary>
        /// <param name="valor">Senha.</param>
        /// <returns>True caso válido ou False caso inválido.</returns>
        /// <exception cref="Exception">Erro ao validar senha.</exception>
        private bool ContemLetraMaiuscula(string valor) => Regex.IsMatch(valor, @"[A-Z]+");

        /// <summary>Efetua validação se a senha possui pelo menos uma letra minúscula.</summary>
        /// <param name="valor">Senha.</param>
        /// <returns>True caso válido ou False caso inválido.</returns>
        /// <exception cref="Exception">Erro ao validar senha.</exception>
        private bool ContemLetraMinuscula(string valor) => Regex.IsMatch(valor, @"[a-z]+");

        /// <summary>Efetua validação se a senha possui pelo menos um número.</summary>
        /// <param name="valor">Senha.</param>
        /// <returns>True caso válido ou False caso inválido.</returns>
        /// <exception cref="Exception">Erro ao validar senha.</exception>
        private bool ContemNumero(string valor) => Regex.IsMatch(valor, @"[0-9]+");

        /// <summary>Efetua validação se a senha possui pelo menos um caracter especial.</summary>
        /// <param name="valor">Senha.</param>
        /// <returns>True caso válido ou False caso inválido.</returns>
        /// <exception cref="Exception">Erro ao validar senha.</exception>
        private bool ContemCaracteresEspeciais(string valor) => Regex.IsMatch(valor, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

        /// <summary>Retorna senha.</summary>
        public override string ToString() => Valor;
    }
}