using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    public class Descricao1000Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao1000Caracteres(string valor, string descritivo)
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
                    AddNotificacao(new ContratoValidacao().TamanhoMaximo(Valor, 1000, descritivo, "Conteúdo superior à 1000 caracteres"));
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