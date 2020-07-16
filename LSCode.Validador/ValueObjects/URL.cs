using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    public class URL : Notificadora
    {
        public string Valor { get; private set; }

        public URL(string valor)
        {
            try
            {
                Valor = valor;

                if (Valor == null)
                {
                    AddNotificacao("Celular", "Celular não pode ser nulo");
                }
                else
                {
                    AddNotificacao(new ContratoValidacao().EhVerdadeiro(Validar(Valor), "URL", "URL inválida"));
                }
            }
            catch (Exception ex)
            {
                AddNotificacao("URL", $@"Erro: {ex.Message}");
            }
        }

        private bool Validar(string valor) => Uri.IsWellFormedUriString(valor, UriKind.Absolute);

        public override string ToString() => Valor;
    }
}