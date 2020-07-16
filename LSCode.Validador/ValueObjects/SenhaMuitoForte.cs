using LSCode.Validador.ValidacoesNotificacoes;
using System;
using System.Text.RegularExpressions;

namespace LSCode.Validador.ValueObjects
{
    public class SenhaMuitoForte : Notificadora
    {
        public string Valor { get; private set; }

        public SenhaMuitoForte(string valor)
        {
            try
            {
                Valor = valor;

                if (Valor == null)
                {
                    AddNotificacao("SenhaMuitoForte", "Senha não pode ser nula");
                }
                else
                {
                    Validar(Valor);
                }
            }
            catch (Exception ex)
            {
                AddNotificacao("SenhaMuitoForte", $@"Erro: {ex.Message}");
            }
        }

        private void Validar(string valor)
        {
            if (!QuantidadeCaracteres(valor))
                AddNotificacao("SenhaMuitoForte", "Senha deve conter no mínimo 10 e no máximo 15 caracteres");

            if (!ContemLetraMaiuscula(valor))
                AddNotificacao("SenhaMuitoForte", "Senha deve conter no mínimo 2 letras maíusculas");

            if (!ContemLetraMinuscula(valor))
                AddNotificacao("SenhaMuitoForte", "Senha deve conter no mínimo 2 letras minúsculas");

            if (!ContemNumero(valor))
                AddNotificacao("SenhaMuitoForte", "Senha deve conter no mínimo 2 números");

            if (!ContemCaracteresEspeciais(valor))
                AddNotificacao("SenhaMuitoForte", "Senha deve conter no mínimo 2 caracteres especiais");
        }

        private bool QuantidadeCaracteres(string valor) => valor.Length >= 10 && valor.Length <= 15;

        private bool ContemLetraMaiuscula(string valor) => Regex.IsMatch(valor, @"[A-Z{2}]");

        private bool ContemLetraMinuscula(string valor) => Regex.IsMatch(valor, @"[a-z{2}]");

        private bool ContemNumero(string valor) => Regex.IsMatch(valor, @"[0-9{2}]");

        private bool ContemCaracteresEspeciais(string valor) => Regex.IsMatch(valor, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-{2}]");

        public override string ToString() => Valor;
    }
}