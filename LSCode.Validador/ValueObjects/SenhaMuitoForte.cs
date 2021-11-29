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
        /// <remarks>Deve conter pelo menos dez e no máximo quinze caracteres; Uma letra maiúscula; Uma letra minúscula; Um número; Um caracter especial.</remarks>
        /// <param name="valor">Senha.</param>
        /// <returns>Cria uma instância da classe SenhaMuitoForte.</returns>
        public SenhaMuitoForte(string valor)
        {
            try
            {
                Valor = valor;

                if (!string.IsNullOrWhiteSpace(Valor))
                {
                    AddNotificacao(new ContratoValidacao().TamanhoMinimo(valor, 10, "SenhaMuitoForte", "Senha deve conter no mínimo 10 caracteres"));
                    AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 15, "SenhaMuitoForte", "Senha deve conter no máximo 15 caracteres"));
                    AddNotificacao(new ContratoValidacao().ContemLetraMaiuscula(valor, "SenhaMuitoForte", "Senha deve conter no mínimo 1 letra maíuscula"));
                    AddNotificacao(new ContratoValidacao().ContemLetraMinuscula(valor, "SenhaMuitoForte", "Senha deve conter no mínimo 1 letra minúscula"));
                    AddNotificacao(new ContratoValidacao().ContemNumero(valor, "SenhaMuitoForte", "Senha deve conter no mínimo 1 número"));
                    AddNotificacao(new ContratoValidacao().ContemCaracteresEspeciais(valor, "SenhaMuitoForte", "Senha deve conter no mínimo 1 caracter especial"));
                }
                else
                    AddNotificacao("SenhaMuitoForte", "Senha não pode ser nula ou vazia");
            }
            catch (Exception ex)
            {
                AddNotificacao("SenhaMuitoForte", $"Erro: {ex.Message}");
            }
        }

        /// <summary>Retorna senha.</summary>
        public override string ToString() => Valor;
    }
}