using LSCode.Validador.ValidacoesNotificacoes;
using System;
using System.Text.RegularExpressions;

namespace LSCode.Validador.ValueObjects
{
    /// <summary>Auxilia na utilização, validação e formatação de números de celular.</summary>
    public class Celular : Notificadora
    {
        /// <value>Número do celular.</value>
        public string Valor { get; private set; }

        /// <summary>Construtor da classe Celular.</summary>
        /// <remarks> Formatos esperados: 3298888-7777 ou 32988887777.</remarks>
        /// <param name="valor">Número do celular.</param>
        /// <returns> Cria uma instância da classe Celular.</returns>
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

        /// <summary>Efetua validação do número do celular.</summary>
        /// <param name="valor">Número do celular.</param>
        /// <returns>True caso válido ou False caso inválido.</returns>
        /// <exception cref="Exception">Erro ao validar número do celular.</exception>
        private bool Validar(string valor) => Regex.IsMatch(valor, @"^(\(?)([0-9]{2})(\)?)[0-9]{5}-?[0-9]{4}$");

        /// <summary>Efetua formatação do número do celular.</summary>
        /// <param name="valor">Número do celular.</param>
        /// <returns>Número do celular no formato: 3298888-7777.</returns>
        /// <exception cref="Exception">Erro ao formatar número do celular.</exception>
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

        /// <summary>Retorna número do celular.</summary>
        public override string ToString() => Valor;
    }
}