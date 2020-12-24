using LSCode.Validador.ValidacoesBooleanas;
using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    /// <summary>Auxilia na utilização, validação e formatação de números de CNPJ.</summary>
    public class CNPJ : Notificadora
    {
        /// <value>Número do CNPJ.</value>
        public string Valor { get; private set; }

        /// <summary>Construtor da classe CNPJ.</summary>
        /// <param name="valor">Número do CNPJ.</param>
        /// <returns> Cria uma instância da classe CNPJ.</returns>
        public CNPJ(string valor)
        {
            try
            {
                Valor = valor;

                if (Valor == null)
                {
                    AddNotificacao("CNPJ", "CNPJ não pode ser nulo");
                }
                else
                {
                    bool valido = ValidacaoBooleana.EhCNPJ(valor);

                    if (valido)
                        Valor = Formatar(valor);

                    AddNotificacao(new ContratoValidacao().EhVerdadeiro(valido, "CNPJ", "CNPJ inválido"));
                }
            }
            catch (Exception ex)
            {
                AddNotificacao("CNPJ", $@"Erro: {ex.Message}");
            }
        }

        /// <summary>Efetua formatação do número do CNPJ.</summary>
        /// <param name="valor">Número do CNPJ.</param>
        /// <returns>Número do CNPJ no formato: 00.000.000/0000-00.</returns>
        /// <exception cref="Exception">Erro ao formatar número do CNPJ.</exception>
        private string Formatar(string valor)
        {
            valor = valor.Trim();
            valor = valor.Replace(".", "").Replace("-", "").Replace("/", "");
            valor = Convert.ToUInt64(valor).ToString(@"00\.000\.000\/0000\-00");
            return valor;
        }

        /// <summary>Retorna número do CNPJ.</summary>
        public override string ToString() => Valor;
    }
}