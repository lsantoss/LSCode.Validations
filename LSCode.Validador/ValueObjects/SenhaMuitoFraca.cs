using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    /// <summary>Auxilia na utilização e validação senhas.</summary>
    public class SenhaMuitoFraca : Notificadora
    {
        /// <value>Senha.</value>
        public string Valor { get; private set; }

        /// <summary>Construtor da classe SenhaMuitoFraca.</summary>
        /// <remarks> Deve conter pelo menos seis e no máximo quinze caracteres.</remarks>
        /// <param name="valor">Senha.</param>
        /// <returns> Cria uma instância da classe SenhaMuitoFraca.</returns>
        public SenhaMuitoFraca(string valor)
        {
            try
            {
                Valor = valor;

                if (Valor == null)
                {
                    AddNotificacao("SenhaMuitoFraca", "Senha não pode ser nula");
                }
                else
                {
                    AddNotificacao(new ContratoValidacao().EhVerdadeiro(QuantidadeCaracteres(Valor), "SenhaMuitoFraca", "Senha deve conter no mínimo 6 e no máximo 15 caracteres"));
                }
            }
            catch (Exception ex)
            {
                AddNotificacao("SenhaMuitoFraca", $@"Erro: {ex.Message}");
            }
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