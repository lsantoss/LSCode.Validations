using LSCode.Validador.ValidacoesNotificacoes;
using System;
using System.Text.RegularExpressions;

namespace LSCode.Validador.ValueObjects
{
    public class SenhaForte : Notificadora
    {
        public string Valor { get; private set; }

        public SenhaForte(string valor)
        {
            try
            {
                Valor = valor;

                if (Valor == null)
                {
                    AddNotificacao("SenhaForte", "Senha não pode ser nula");
                }
                else
                {
                    Validar(Valor);
                }
            }
            catch (Exception ex)
            {
                AddNotificacao("SenhaForte", $@"Erro: {ex.Message}");
            }
        }

        private void Validar(string valor)
        {
            if (!QuantidadeCaracteres(valor))
                AddNotificacao("SenhaForte", "Senha deve conter no mínimo 8 e no máximo 15 caracteres");

            if (!ContemLetraMaiuscula(valor))
                AddNotificacao("SenhaForte", "Senha deve conter no mínimo 1 letra maíuscula");

            if (!ContemLetraMinuscula(valor))
                AddNotificacao("SenhaForte", "Senha deve conter no mínimo 1 letra minúscula");

            if (!ContemNumero(valor))
                AddNotificacao("SenhaForte", "Senha deve conter no mínimo 1 número");

            if (!ContemCaracteresEspeciais(valor))
                AddNotificacao("SenhaForte", "Senha deve conter no mínimo 1 caracter especial");
        }

        private bool QuantidadeCaracteres(string valor) => valor.Length >= 8 && valor.Length <= 15;

        private bool ContemLetraMaiuscula(string valor) => Regex.IsMatch(valor, @"[A-Z]+");

        private bool ContemLetraMinuscula(string valor) => Regex.IsMatch(valor, @"[a-z]+");

        private bool ContemNumero(string valor) => Regex.IsMatch(valor, @"[0-9]+");

        private bool ContemCaracteresEspeciais(string valor) => Regex.IsMatch(valor, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

        public override string ToString() => Valor;
    }
}