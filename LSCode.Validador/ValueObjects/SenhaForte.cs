using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    /// <summary>Auxilia na utilização e validação senhas.</summary>
    public class SenhaForte : Notificadora
    {
        /// <value>Senha.</value>
        public string Valor { get; private set; }

        /// <summary>Construtor da classe SenhaForte.</summary>
        /// <remarks>Deve conter pelo menos oito e no máximo quinze caracteres; Uma letra maiúscula; Uma letra minúscula; Um número; Um caracter especial.</remarks>
        /// <param name="valor">Senha.</param>
        /// <returns>Cria uma instância da classe SenhaForte.</returns>
        public SenhaForte(string valor)
        {
            try
            {
                Valor = valor;

                if (!string.IsNullOrWhiteSpace(Valor))
                {
                    AddNotificacao(new ContratoValidacao().TamanhoMinimo(valor, 8, "SenhaForte", "Senha deve conter no mínimo 8 caracteres"));
                    AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 15, "SenhaForte", "Senha deve conter no máximo 15 caracteres"));
                    AddNotificacao(new ContratoValidacao().ContemLetraMaiuscula(valor, "SenhaForte", "Senha deve conter no mínimo 1 letra maíuscula"));
                    AddNotificacao(new ContratoValidacao().ContemLetraMinuscula(valor, "SenhaForte", "Senha deve conter no mínimo 1 letra minúscula"));
                    AddNotificacao(new ContratoValidacao().ContemNumero(valor, "SenhaForte", "Senha deve conter no mínimo 1 número"));
                    AddNotificacao(new ContratoValidacao().ContemCaracteresEspeciais(valor, "SenhaForte", "Senha deve conter no mínimo 1 caracter especial"));
                }
                else
                    AddNotificacao("SenhaForte", "Senha não pode ser nula ou vazia");
            }
            catch (Exception ex)
            {
                AddNotificacao("SenhaForte", $"Erro: {ex.Message}");
            }
        }

        /// <summary>Retorna senha.</summary>
        public override string ToString() => Valor;
    }
}