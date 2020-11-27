using LSCode.Validador.ValidacoesNotificacoes;
using System;
using System.Text.RegularExpressions;

namespace LSCode.Validador.ValueObjects
{
    /// <summary>Auxilia na utilização, validação e formatação de números de telefone.</summary>
    public class Telefone : Notificadora
    {
        /// <value>Número do telefone.</value>
        public string Valor { get; private set; }

        /// <summary>Construtor da classe Telefone.</summary>
        /// <remarks> Formatos esperados: 323888-7777 ou 3238887777.</remarks>
        /// <param name="valor">Número do telefone.</param>
        /// <returns> Cria uma instância da classe Telefone.</returns>
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

        /// <summary>Efetua validação do número do telefone.</summary>
        /// <param name="valor">Número do telefone.</param>
        /// <returns>True caso válido ou False caso inválido.</returns>
        /// <exception cref="Exception">Erro ao validar número do telefone.</exception>
        private bool Validar(string valor) => Regex.IsMatch(valor, @"^(\(?)([0-9]{2})(\)?)[0-9]{4}-?[0-9]{4}$");

        /// <summary>Efetua formatação do número do telefone.</summary>
        /// <param name="valor">Número do telefone.</param>
        /// <returns>Número do telefone no formato: 323888-7777.</returns>
        /// <exception cref="Exception">Erro ao formatar número do telefone.</exception>
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

        /// <summary>Retorna número do telefone.</summary>
        public override string ToString() => Valor;
    }
}