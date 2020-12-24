using LSCode.Validador.ValidacoesBooleanas;
using LSCode.Validador.ValidacoesNotificacoes;
using System;
using System.Text.RegularExpressions;

namespace LSCode.Validador.ValueObjects
{
    /// <summary>Auxilia na utilização e validação de emails.</summary>
    public class Email : Notificadora
    {
        /// <value>Endereço de email.</value>
        public string Valor { get; private set; }

        /// <summary>Construtor da classe Email.</summary>
        /// <param name="valor">Endereço de email.</param>
        /// <returns> Cria uma instância da classe Email.</returns>
        public Email(string valor)
        {
            try
            {
                Valor = valor;

                if (Valor == null)
                {
                    AddNotificacao("Email", "Email não pode ser nulo");
                }
                else
                {
                    bool valido = ValidacaoBooleana.EhEmail(valor);
                    AddNotificacao(new ContratoValidacao().EhVerdadeiro(valido, "Email", "Email inválido"));
                }
            }
            catch (Exception ex)
            {
                AddNotificacao("Email", $@"Erro: {ex.Message}");
            }
        }
                
        /// <summary>Retorna endereço de email.</summary>
        public override string ToString() => Valor;
    }
}