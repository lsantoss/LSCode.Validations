using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    public class Descricao2500Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao2500Caracteres(string valor, string descritivo)
        {
            try
            {
                Valor = valor;

                if (Valor == null)
                {
                    AddNotificacao(descritivo, "Conteúdo não pode ser nulo");
                }
                else
                {
                    AddNotificacao(new ContratoValidacao().TamanhoMaximo(Valor, 2500, descritivo, "Conteúdo superior à 2500 caracteres"));
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