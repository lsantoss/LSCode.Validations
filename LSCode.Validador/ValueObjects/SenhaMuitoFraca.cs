using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    public class SenhaMuitoFraca : Notificadora
    {
        public string Valor { get; private set; }

        public SenhaMuitoFraca(string valor)
        {
            try
            {
                Valor = valor;

                if (Valor == null)
                {
                    AddNotificacao("SenhaMuitoFraca", "Senha não pode ser nula");
                }
                else
                {
                    AddNotificacao(new ContratoValidacao().EhVerdadeiro(QuantidadeCaracteres(Valor), "SenhaMuitoFraca", "Senha deve conter no mínimo 6 e no máximo 15 caracteres"));
                }
            }
            catch (Exception ex)
            {
                AddNotificacao("SenhaMuitoFraca", $@"Erro: {ex.Message}");
            }
        }

        private bool QuantidadeCaracteres(string valor) => valor.Length >= 6 && valor.Length <= 15;

        public override string ToString() => Valor;
    }
}