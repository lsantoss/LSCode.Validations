using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    public class URL : Notificadora
    {
        public string Valor { get; private set; }

        public URL(string valor)
        {
            Valor = valor;

            AddNotificacao(new ContratoValidacao().EhVerdadeiro(Validar(Valor), "URL", "URL inválida"));
        }

        public bool Validar(string valor) => Uri.IsWellFormedUriString(valor, UriKind.Absolute);

        public override string ToString() => Valor;
    }
}