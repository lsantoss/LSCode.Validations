using LSCode.Validador.ValidacoesNotificacoes;
using System;
using System.Text.RegularExpressions;

namespace LSCode.Validador.ValueObjects
{
    /// <summary>Auxilia na utilização e validação senhas.</summary>
    public class SenhaFraca : Notificadora
    {
        /// <value>Senha.</value>
        public string Valor { get; private set; }

        /// <summary>Construtor da classe SenhaFraca.</summary>
        /// <remarks> Deve conter pelo menos seis e no máximo quinze caracteres; Uma letra; Um número.</remarks>
        /// <param name="valor">Senha.</param>
        /// <returns> Cria uma instância da classe SenhaFraca.</returns>
        public SenhaFraca(string valor)
        {
            try
            {
                Valor = valor;

                if (Valor == null)
                {
                    AddNotificacao("SenhaFraca", "Senha não pode ser nula");
                }
                else
                {
                    Validar(Valor);
                }
            }
            catch (Exception ex)
            {
                AddNotificacao("SenhaFraca", $@"Erro: {ex.Message}");
            }
        }

        /// <summary>Efetua validação da senha.</summary>
        /// <param name="valor">Senha.</param>
        /// <returns>True caso válido ou False caso inválido.</returns>
        /// <exception cref="Exception">Erro ao validar senha.</exception>
        private void Validar(string valor)
        {
            if(!QuantidadeCaracteres(valor))
                AddNotificacao("SenhaFraca", "Senha deve conter no mínimo 6 e no máximo 15 caracteres");

            if (!ContemLetra(valor))
                AddNotificacao("SenhaFraca", "Senha deve conter no mínimo 1 letra maíuscula ou minúscula");

            if (!ContemNumero(valor))
                AddNotificacao("SenhaFraca", "Senha deve conter no mínimo 1 número");
        }

        /// <summary>Efetua validação se a senha possui pelo menos seis e no máximo quinze caracteres.</summary>
        /// <param name="valor">Senha.</param>
        /// <returns>True caso válido ou False caso inválido.</returns>
        /// <exception cref="Exception">Erro ao validar senha.</exception>
        private bool QuantidadeCaracteres(string valor) => valor.Length >= 6 && valor.Length <= 15;

        /// <summary>Efetua validação se a senha possui pelo menos uma letra.</summary>
        /// <param name="valor">Senha.</param>
        /// <returns>True caso válido ou False caso inválido.</returns>
        /// <exception cref="Exception">Erro ao validar senha.</exception>
        private bool ContemLetra(string valor) => Regex.IsMatch(valor, @"[a-z]+|[A-Z]+");

        /// <summary>Efetua validação se a senha possui pelo menos um número.</summary>
        /// <param name="valor">Senha.</param>
        /// <returns>True caso válido ou False caso inválido.</returns>
        /// <exception cref="Exception">Erro ao validar senha.</exception>
        private bool ContemNumero(string valor) => Regex.IsMatch(valor, @"[0-9]+");

        /// <summary>Retorna senha.</summary>
        public override string ToString() => Valor;
    }
}