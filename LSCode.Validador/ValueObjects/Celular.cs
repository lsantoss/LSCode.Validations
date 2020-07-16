using LSCode.Validador.ValidacoesNotificacoes;
using System;
using System.Text.RegularExpressions;

namespace LSCode.Validador.ValueObjects
{
    public class Celular : Notificadora
    {
        public string Valor { get; private set; }

        public Celular(string valor)
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
                    bool valido = Validar(valor);

                    if (valido)
                        Valor = Formatar(valor);

                    AddNotificacao(new ContratoValidacao().EhVerdadeiro(valido, "Celular", "Celular inválido"));
                }
            }
            catch (Exception ex)
            {
                AddNotificacao("Celular", $@"Erro: {ex.Message}");
            }
        }

        private bool Validar(string valor) => Regex.IsMatch(valor, @"^(\(?)([0-9]{2})(\)?)[0-9]{5}-?[0-9]{4}$");

        private string Formatar(string valor)
        {
            if (valor.Length == 14)
            {
                return valor;
            }
            else
            {
                valor = valor.Trim();
                valor = valor.Replace("(", "").Replace(")", "").Replace("-", "");
                valor = Convert.ToUInt64(valor).ToString(@"\(00\)00000\-0000");
                return valor;
            }
        }

        public override string ToString() => Valor;
    }
}