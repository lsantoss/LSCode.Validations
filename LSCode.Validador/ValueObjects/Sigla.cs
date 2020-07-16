using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    public class Sigla : Notificadora
    {
        public string Valor { get; private set; }

        public Sigla(string valor)
        {
            try
            {
                Valor = valor;

                if (Valor == null)
                {
                    AddNotificacao("Sigla", "Sigla não pode ser nula");
                }
                else
                {
                    AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 3, "Sigla", "Sigla superior à 3 caracteres"));
                }
            }
            catch (Exception ex)
            {
                AddNotificacao("Sigla", $@"Erro: {ex.Message}");
            }
        }

        public override string ToString() => Valor;
    }
}