using LSCode.Validador.ValidacoesNotificacoes;
using System;
using System.Text.RegularExpressions;

namespace LSCode.Validador.ValueObjects
{
    public class SenhaMedia : Notificadora
    {
        public string Valor { get; private set; }

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

        private void Validar(string valor)
        {
            if (!QuantidadeCaracteres(valor))
                AddNotificacao("SenhaMedia", "Senha deve conter no mínimo 6 e no máximo 15 caracteres");

            if (!ContemLetraMaiuscula(valor))
                AddNotificacao("SenhaMedia", "Senha deve conter no mínimo 1 letra maíuscula");

            if (!ContemLetraMinuscula(valor))
                AddNotificacao("SenhaMedia", "Senha deve conter no mínimo 1 letra minúscula");

            if (!ContemNumero(valor))
                AddNotificacao("SenhaMedia", "Senha deve conter no mínimo 1 número");
        }

        private bool QuantidadeCaracteres(string valor) => valor.Length >= 6 && valor.Length <= 15;

        private bool ContemLetraMaiuscula(string valor) => Regex.IsMatch(valor, @"[A-Z]+");

        private bool ContemLetraMinuscula(string valor) => Regex.IsMatch(valor, @"[a-z]+");

        private bool ContemNumero(string valor) => Regex.IsMatch(valor, @"[0-9]+");

        public override string ToString() => Valor;
    }
}
