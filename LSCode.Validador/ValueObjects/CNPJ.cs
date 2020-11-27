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
                    bool valido = Validar(valor);

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

        /// <summary>Efetua validação do número do CNPJ.</summary>
        /// <param name="valor">Número do CNPJ.</param>
        /// <returns>True caso válido ou False caso inválido.</returns>
        /// <exception cref="Exception">Erro ao validar número do CNPJ.</exception>
        private bool Validar(string valor)
        {
            int[] mt1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mt2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma; int resto; string digito; string TempCNPJ;

            valor = valor.Trim();
            valor = valor.Replace(".", "").Replace("-", "").Replace("/", "");

            if (valor.Length != 14)
                return false;

            if (valor == "00000000000000" || valor == "11111111111111" ||
                valor == "22222222222222" || valor == "33333333333333" ||
                valor == "44444444444444" || valor == "55555555555555" ||
                valor == "66666666666666" || valor == "77777777777777" ||
                valor == "88888888888888" || valor == "99999999999999")
                return false;

            TempCNPJ = valor.Substring(0, 12);
            soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(TempCNPJ[i].ToString()) * mt1[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            TempCNPJ = TempCNPJ + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(TempCNPJ[i].ToString()) * mt2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();

            return valor.EndsWith(digito);
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