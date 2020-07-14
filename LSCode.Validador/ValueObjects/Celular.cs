using LSCode.Validador.ValidacoesNotificacoes;
using System;
using System.Text.RegularExpressions;

namespace LSCode.Validador.ValueObjects
{
    public class Celular : Notificadora
    {
        public string Valor { get; private set; }

        public Celular(string valor)
        {
            bool valido = Validar(valor);

            if (valido)
                Valor = Formatar(valor);

            AddNotificacao(new ContratoValidacao().EhVerdadeiro(valido, "Celular", "Celular inválido"));
        }

        public bool Validar(string celular) => Regex.IsMatch(celular, @"^(\(?)([0-9]{2})(\)?)[0-9]{5}-?[0-9]{4}$");

        private string Formatar(string celular)
        {
            if (celular.Length == 14)
            {
                return celular;
            }
            else
            {
                celular = celular.Trim();
                celular = celular.Replace("(", "").Replace(")", "").Replace("-", "");
                celular = Convert.ToUInt64(celular).ToString(@"\(00\)00000\-0000");
                return celular;
            }
        }

        public override string ToString() => Valor;
    }
}