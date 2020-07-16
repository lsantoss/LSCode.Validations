using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    public class CNPJ : Notificadora
    {
        public string Valor { get; private set; }

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

        private string Formatar(string valor)
        {
            valor = valor.Trim();
            valor = valor.Replace(".", "").Replace("-", "").Replace("/", "");
            valor = Convert.ToUInt64(valor).ToString(@"00\.000\.000\/0000\-00");
            return valor;
        }

        public override string ToString() => Valor;
    }
}