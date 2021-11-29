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
        /// <remarks>Deve conter pelo menos seis e no máximo quinze caracteres.</remarks>
        /// <param name="valor">Senha.</param>
        /// <returns>Cria uma instância da classe SenhaMuitoFraca.</returns>
        public SenhaMuitoFraca(string valor)
        {
            try
            {
                Valor = valor;

                if (!string.IsNullOrWhiteSpace(Valor))
                {
                    AddNotificacao(new ContratoValidacao().TamanhoMinimo(valor, 6, "SenhaMuitoFraca", "Senha deve conter no mínimo 6 caracteres"));
                    AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 15, "SenhaMuitoFraca", "Senha deve conter no máximo 15 caracteres"));
                }
                else
                    AddNotificacao("SenhaMuitoFraca", "Senha não pode ser nula ou vazia");
            }
            catch (Exception ex)
            {
                AddNotificacao("SenhaMuitoFraca", $"Erro: {ex.Message}");
            }
        }

        /// <summary>Retorna senha.</summary>
        public override string ToString() => Valor;
    }
}