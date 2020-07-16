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
            try
            {
                Valor = valor;

                if (Valor == null)
                {
                    AddNotificacao("CEP", "CEP não pode ser nulo");
                }
                else
                {
                    bool valido = Validar(valor);

                    if (valido)
                        Valor = Formatar(valor);

                    AddNotificacao(new ContratoValidacao().EhVerdadeiro(valido, "CEP", "CEP inválido"));
                }
            }
            catch (Exception ex)
            {
                AddNotificacao("CEP", $@"Erro: {ex.Message}");
            }
        }

        private bool Validar(string valor) => Regex.IsMatch(valor, @"^\d{5}\-?\d{3}$");

        private string Formatar(string valor) => valor.Length == 9 ? valor : Convert.ToUInt64(valor).ToString(@"00000\-000");

        public override string ToString() => Valor;
    }
}