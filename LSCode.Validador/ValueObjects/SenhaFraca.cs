using LSCode.Validador.ValidacoesNotificacoes;
using System;
using System.Text.RegularExpressions;

namespace LSCode.Validador.ValueObjects
{
    public class SenhaFraca : Notificadora
    {
        public string Valor { get; private set; }

        public SenhaFraca(string valor)
        {
            try
            {
                Valor = valor;

                if (Valor == null)
                {
                    AddNotificacao("SenhaFraca", "Senha não pode ser nula");
                }
                else
                {
                    Validar(Valor);
                }
            }
            catch (Exception ex)
            {
                AddNotificacao("SenhaFraca", $@"Erro: {ex.Message}");
            }
        }

        private void Validar(string valor)
        {
            if(!QuantidadeCaracteres(valor))
                AddNotificacao("SenhaFraca", "Senha deve conter no mínimo 6 e no máximo 15 caracteres");

            if (!ContemLetra(valor))
                AddNotificacao("SenhaFraca", "Senha deve conter no mínimo 1 letra maíuscula ou minúscula");

            if (!ContemNumero(valor))
                AddNotificacao("SenhaFraca", "Senha deve conter no mínimo 1 número");
        }

        private bool QuantidadeCaracteres(string valor) => valor.Length >= 6 && valor.Length <= 15;

        private bool ContemLetra(string valor) => Regex.IsMatch(valor, @"[a-z]+|[A-Z]+");

        private bool ContemNumero(string valor) => Regex.IsMatch(valor, @"[0-9]+");

        public override string ToString() => Valor;
    }
}