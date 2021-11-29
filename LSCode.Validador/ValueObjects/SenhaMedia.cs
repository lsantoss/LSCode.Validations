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
        /// <remarks>Deve conter pelo menos seis e no máximo quinze caracteres; Uma letra maiúscula; Uma letra minúscula; Um número.</remarks>
        /// <param name="valor">Senha.</param>
        /// <returns>Cria uma instância da classe SenhaMedia.</returns>
        public SenhaMedia(string valor)
        {
            try
            {
                Valor = valor;

                if (!string.IsNullOrWhiteSpace(Valor))
                {
                    AddNotificacao(new ContratoValidacao().TamanhoMinimo(valor, 6, "SenhaMedia", "Senha deve conter no mínimo 6 caracteres"));
                    AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 15, "SenhaMedia", "Senha deve conter no máximo 15 caracteres"));
                    AddNotificacao(new ContratoValidacao().ContemLetraMaiuscula(valor, "SenhaMedia", "Senha deve conter no mínimo 1 letra maíuscula"));
                    AddNotificacao(new ContratoValidacao().ContemLetraMinuscula(valor, "SenhaMedia", "Senha deve conter no mínimo 1 letra minúscula"));
                    AddNotificacao(new ContratoValidacao().ContemNumero(valor, "SenhaMedia", "Senha deve conter no mínimo 1 número"));
                }
                else
                    AddNotificacao("SenhaMedia", "Senha não pode ser nula ou vazia");
            }
            catch (Exception ex)
            {
                AddNotificacao("SenhaMedia", $"Erro: {ex.Message}");
            }
        }

        /// <summary>Retorna senha.</summary>
        public override string ToString() => Valor;
    }
}