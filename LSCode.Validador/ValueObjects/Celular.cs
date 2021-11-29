using LSCode.Validador.ValidacoesBooleanas;
using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    /// <summary>Auxilia na utilização, validação e formatação de números de celular.</summary>
    public class Celular : Notificadora
    {
        /// <value>Número do celular.</value>
        public string Valor { get; private set; }

        /// <summary>Construtor da classe Celular.</summary>
        /// <remarks>
        ///     Formatos válidos: 32988887777 ou 3298888-7777 ou (32)988887777 ou (32)98888-7777. <br></br>
        ///     Formato de saída: (32)98888-7777. <br></br>
        ///     Regex: ^(\(?)([0-9]{2})(\)?)[0-9]{5}-?[0-9]{4}$
        /// </remarks>
        /// <param name="valor">Número do celular.</param>
        /// <returns>Cria uma instância da classe Celular.</returns>
        public Celular(string valor)
        {
            try
            {
                Valor = valor;

                if (!string.IsNullOrWhiteSpace(Valor))
                {
                    if (ValidacaoBooleana.EhCelular(valor))
                        Valor = Formatar(valor);
                    else
                        AddNotificacao("Celular", "Celular inválido");
                }
                else
                    AddNotificacao("Celular", "Celular não pode ser nulo ou vazio");
            }
            catch (Exception ex)
            {
                AddNotificacao("Celular", $"Erro: {ex.Message}");
            }
        }

        /// <summary>Efetua formatação do número do celular.</summary>
        /// <param name="valor">Número do celular.</param>
        /// <returns>Número do celular no formato: (32)98888-7777.</returns>
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