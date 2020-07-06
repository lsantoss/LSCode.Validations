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

            AddNotificacao(new ContratoValidacao().EhVerdadeiro(valido, "CEP", "CEP inválido. Formato esperado XXXXX-XXX."));
        }

        public bool Validar(string cep) => Regex.IsMatch(cep, @"^\d{5}\-?\d{3}$");

        public string Formatar(string valor) => valor.Length == 8 ? Convert.ToUInt64(valor).ToString(@"00000\-000") : valor;

        public override string ToString() => Valor;
    }
}