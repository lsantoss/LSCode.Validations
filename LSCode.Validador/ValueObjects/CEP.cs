using LSCode.Validador.ValidacoesNotificacoes;
using System;
using System.Text.RegularExpressions;

namespace LSCode.Validador.ValueObjects
{
    public class CEP : Notificadora
    {
        public string Valor { get; private set; }

        public CEP(string valor)
        {
            bool valido = Validar(valor);

            if (valido)
                Valor = Formatar(valor);

            AddNotificacao(new ContratoValidacao().EhVerdadeiro(valido, "CEP", "CEP inválido."));
        }

        private bool Validar(string cep) => Regex.IsMatch(cep, @"^\d{5}\-?\d{3}$");

        private string Formatar(string cep) => cep.Length == 9 ? cep : Convert.ToUInt64(cep).ToString(@"00000\-000");

        public override string ToString() => Valor;
    }
}