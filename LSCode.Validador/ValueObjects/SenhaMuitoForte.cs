using LSCode.Validador.ValidacoesBooleanas;
using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    /// <summary>Auxilia na utilização e validação senhas.</summary>
    public class SenhaMuitoForte : Notificadora
    {
        /// <value>Senha.</value>
        public string Valor { get; private set; }

        /// <summary>Construtor da classe SenhaMuitoForte.</summary>
        /// <remarks> Deve conter pelo menos dez e no máximo quinze caracteres; Uma letra maiúscula; Uma letra minúscula; Um número; Um caracter especial.</remarks>
        /// <param name="valor">Senha.</param>
        /// <returns> Cria uma instância da classe SenhaMuitoForte.</returns>
        public SenhaMuitoForte(string valor)
        {
            try
            {
                Valor = valor;

                if (Valor == null)
                {
                    AddNotificacao("SenhaMuitoForte", "Senha não pode ser nula");
                }
                else
                {
                    Validar(Valor);
                }
            }
            catch (Exception ex)
            {
                AddNotificacao("SenhaMuitoForte", $@"Erro: {ex.Message}");
            }
        }

        /// <summary>Efetua validação da senha.</summary>
        /// <param name="valor">Senha.</param>
        /// <returns>True caso válido ou False caso inválido.</returns>
        /// <exception cref="Exception">Erro ao validar senha.</exception>
        private void Validar(string valor)
        {
            if (!QuantidadeCaracteres(valor))
                AddNotificacao("SenhaMuitoForte", "Senha deve conter no mínimo 10 e no máximo 15 caracteres");

            if (!ValidacaoBooleana.ContemLetraMaiuscula(valor))
                AddNotificacao("SenhaMuitoForte", "Senha deve conter no mínimo 2 letras maíusculas");

            if (!ValidacaoBooleana.ContemLetraMinuscula(valor))
                AddNotificacao("SenhaMuitoForte", "Senha deve conter no mínimo 2 letras minúsculas");

            if (!ValidacaoBooleana.ContemNumero(valor))
                AddNotificacao("SenhaMuitoForte", "Senha deve conter no mínimo 2 números");

            if (!ValidacaoBooleana.ContemCaracteresEspeciais(valor))
                AddNotificacao("SenhaMuitoForte", "Senha deve conter no mínimo 2 caracteres especiais");
        }

        /// <summary>Efetua validação se a senha possui pelo menos dez e no máximo quinze caracteres.</summary>
        /// <param name="valor">Senha.</param>
        /// <returns>True caso válido ou False caso inválido.</returns>
        /// <exception cref="Exception">Erro ao validar senha.</exception>
        private bool QuantidadeCaracteres(string valor) => valor.Length >= 10 && valor.Length <= 15;

        /// <summary>Retorna senha.</summary>
        public override string ToString() => Valor;
    }
}