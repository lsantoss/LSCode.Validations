using LSCode.Validador.ValidacoesNotificacoes;
using System;
using System.Text.RegularExpressions;

namespace LSCode.Validador.ValueObjects
{
    public class Telefone : Notificadora
    {
        public string Valor { get; private set; }

        public Telefone(string valor)
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

                    AddNotificacao(new ContratoValidacao().EhVerdadeiro(valido, "Telefone", "Telefone inválido"));
                }                
            }
            catch (Exception ex)
            {
                AddNotificacao("Telefone", $@"Erro: {ex.Message}");
            }
        }

        private bool Validar(string valor) => Regex.IsMatch(valor, @"^(\(?)([0-9]{2})(\)?)[0-9]{4}-?[0-9]{4}$");

        private string Formatar(string valor)
        {
            if(valor.Length == 13) {
                return valor;
            }
            else
            {
                valor = valor.Trim();
                valor = valor.Replace("(", "").Replace(")", "").Replace("-", "");
                valor = Convert.ToUInt64(valor).ToString(@"\(00\)0000\-0000");
                return valor;
            }
        }

        public override string ToString() => Valor;
    }
}