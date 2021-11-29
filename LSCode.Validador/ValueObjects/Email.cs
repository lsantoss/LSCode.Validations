using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    /// <summary>Auxilia na utilização e validação de e-mails.</summary>
    public class Email : Notificadora
    {
        /// <value>Endereço de e-mail.</value>
        public string Valor { get; private set; }

        /// <summary>Construtor da classe Email.</summary>
        /// <remarks>Formatos válidos: Formato padrão de e-mail.</remarks>
        /// <param name="valor">Endereço de e-mail.</param>
        /// <returns>Cria uma instância da classe Email.</returns>
        public Email(string valor)
        {
            try
            {
                Valor = valor;

                if (!string.IsNullOrWhiteSpace(Valor))
                {
                    AddNotificacao(new ContratoValidacao().EhEmail(valor, "Email", "Email inválido"));
                }
                else
                    AddNotificacao("Email", "Email não pode ser nulo ou vazio");
            }
            catch (Exception ex)
            {
                AddNotificacao("Email", $"Erro: {ex.Message}");
            }
        }
                
        /// <summary>Retorna endereço de e-mail.</summary>
        public override string ToString() => Valor;
    }
}