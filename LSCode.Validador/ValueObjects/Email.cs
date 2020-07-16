using LSCode.Validador.ValidacoesNotificacoes;
using System;
using System.Text.RegularExpressions;

namespace LSCode.Validador.ValueObjects
{
    public class Email : Notificadora
    {
        public string Valor { get; private set; }

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
                    AddNotificacao(new ContratoValidacao().EhVerdadeiro(Validar(Valor), "Email", "Email inválido"));
                }
            }
            catch (Exception ex)
            {
                AddNotificacao("Email", $@"Erro: {ex.Message}");
            }
        }

        private bool Validar(string valor) => Regex.IsMatch(valor, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");

        public override string ToString() => Valor;
    }
}