using LSCode.Validador.ValidacoesNotificacoes;
using System.Text.RegularExpressions;

namespace LSCode.Validador.ValueObjects
{
    public class SenhaMuitoFraca : Notificadora
    {
        public string Valor { get; private set; }

        public SenhaMuitoFraca(string valor)
        {
            Valor = valor;

            AddNotificacao(new ContratoValidacao().EhVerdadeiro(Validar(Valor), "Senha Muito Fraca", "Senha deve conter no mínimo 6 e no máximo 20 caracteres"));
        }

        private bool Validar(string valor) => Regex.IsMatch(valor, @"^[\w\s]{6,20}$");

        public override string ToString() => Valor;
    }
}