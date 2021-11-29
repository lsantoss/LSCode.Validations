using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    /// <summary>Auxilia na utilização e validação senhas.</summary>
    public class SenhaFraca : Notificadora
    {
        /// <value>Senha.</value>
        public string Valor { get; private set; }

        /// <summary>Construtor da classe SenhaFraca.</summary>
        /// <remarks>Deve conter pelo menos seis e no máximo quinze caracteres; Uma letra; Um número.</remarks>
        /// <param name="valor">Senha.</param>
        /// <returns>Cria uma instância da classe SenhaFraca.</returns>
        public SenhaFraca(string valor)
        {
            try
            {
                Valor = valor;

                if (!string.IsNullOrWhiteSpace(Valor))
                {
                    AddNotificacao(new ContratoValidacao().TamanhoMinimo(valor, 6, "SenhaFraca", "Senha deve conter no mínimo 6 caracteres"));
                    AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 15, "SenhaFraca", "Senha deve conter no máximo 15 caracteres"));
                    AddNotificacao(new ContratoValidacao().ContemLetra(valor, "SenhaFraca", "Senha deve conter no mínimo 1 letra maíuscula ou minúscula"));
                    AddNotificacao(new ContratoValidacao().ContemNumero(valor, "SenhaFraca", "Senha deve conter no mínimo 1 número"));
                }
                else
                    AddNotificacao("SenhaFraca", "Senha não pode ser nula ou vazia");
            }
            catch (Exception ex)
            {
                AddNotificacao("SenhaFraca", $"Erro: {ex.Message}");
            }
        }

        /// <summary>Retorna senha.</summary>
        public override string ToString() => Valor;
    }
}