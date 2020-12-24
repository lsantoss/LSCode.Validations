using LSCode.Validador.ValidacoesBooleanas;
using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    /// <summary>Auxilia na utilização e validação senhas.</summary>
    public class SenhaMedia : Notificadora
    {
        /// <value>Senha.</value>
        public string Valor { get; private set; }

        /// <summary>Construtor da classe SenhaMedia.</summary>
        /// <remarks> Deve conter pelo menos seis e no máximo quinze caracteres; Uma letra maiúscula; Uma letra minúscula; Um número.</remarks>
        /// <param name="valor">Senha.</param>
        /// <returns> Cria uma instância da classe SenhaMedia.</returns>
        public SenhaMedia(string valor)
        {
            try
            {
                Valor = valor;

                if (Valor == null)
                {
                    AddNotificacao("SenhaMedia", "Senha não pode ser nula");
                }
                else
                {
                    Validar(Valor);
                }
            }
            catch (Exception ex)
            {
                AddNotificacao("SenhaMedia", $@"Erro: {ex.Message}");
            }
        }

        /// <summary>Efetua validação da senha.</summary>
        /// <param name="valor">Senha.</param>
        /// <returns>True caso válido ou False caso inválido.</returns>
        /// <exception cref="Exception">Erro ao validar senha.</exception>
        private void Validar(string valor)
        {
            if (!QuantidadeCaracteres(valor))
                AddNotificacao("SenhaMedia", "Senha deve conter no mínimo 6 e no máximo 15 caracteres");

            if (!ValidacaoBooleana.ContemLetraMaiuscula(valor))
                AddNotificacao("SenhaMedia", "Senha deve conter no mínimo 1 letra maíuscula");

            if (!ValidacaoBooleana.ContemLetraMinuscula(valor))
                AddNotificacao("SenhaMedia", "Senha deve conter no mínimo 1 letra minúscula");

            if (!ValidacaoBooleana.ContemNumero(valor))
                AddNotificacao("SenhaMedia", "Senha deve conter no mínimo 1 número");
        }

        /// <summary>Efetua validação se a senha possui pelo menos seis e no máximo quinze caracteres.</summary>
        /// <param name="valor">Senha.</param>
        /// <returns>True caso válido ou False caso inválido.</returns>
        /// <exception cref="Exception">Erro ao validar senha.</exception>
        private bool QuantidadeCaracteres(string valor) => valor.Length >= 6 && valor.Length <= 15;

        /// <summary>Retorna senha.</summary>
        public override string ToString() => Valor;
    }
}