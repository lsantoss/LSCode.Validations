using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    public class Texto : Notificadora
    {
        public string Valor { get; private set; }

        public Texto(string texto, string descritivo, int tamanhoMaximo)
        {
            try
            {
                Valor = texto;

                if (Valor == null)
                {
                    AddNotificacao(descritivo, $@"{descritivo} não pode ser nulo");
                }
                else
                {
                    AddNotificacao(new ContratoValidacao().TamanhoMaximo(Valor, tamanhoMaximo, descritivo, $@"{descritivo} deve conter no máximo {tamanhoMaximo} caracteres"));
                }
            }
            catch (Exception ex)
            {
                AddNotificacao(descritivo, $@"Erro: {ex.Message}");
            }
        }

        public override string ToString() => Valor;
    }
}