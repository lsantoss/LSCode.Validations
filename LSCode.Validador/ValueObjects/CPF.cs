using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    public class CPF : Notificadora
    {
        public string Valor { get; private set; }

        public CPF(string valor)
        {
            try
            {
                Valor = valor;

                if (Valor == null)
                {
                    AddNotificacao("CPF", "CPF não pode ser nulo");
                }
                else
                {
                    bool valido = Validar(valor);

                    if (valido)
                        Valor = Formatar(valor);

                    AddNotificacao(new ContratoValidacao().EhVerdadeiro(valido, "CPF", "CPF inválido"));
                }
            }
            catch (Exception ex)
            {
                AddNotificacao("CPF", $@"Erro: {ex.Message}");
            }
        }

        private bool Validar(string valor)
        {
			valor = valor.Trim();
			valor = valor.Replace(".", "").Replace("-", "").Replace("/", "");

			if (valor == null)
			{
				return false;
			}

            int posicao = 0;
            int totalDigito1 = 0;
            int totalDigito2 = 0;
            int dv1 = 0;
            int dv2 = 0;

			bool digitosIdenticos = true;
            int ultimoDigito = -1;

			foreach (char c in valor)
			{
				if (char.IsDigit(c))
				{
                    int digito = c - '0';
					if (posicao != 0 && ultimoDigito != digito)
					{
						digitosIdenticos = false;
					}

					ultimoDigito = digito;
					if (posicao < 9)
					{
						totalDigito1 += digito * (10 - posicao);
						totalDigito2 += digito * (11 - posicao);
					}
					else if (posicao == 9)
					{
						dv1 = digito;
					}
					else if (posicao == 10)
					{
						dv2 = digito;
					}

					posicao++;
				}
			}

			if (posicao > 11)
			{
				return false;
			}

			if (digitosIdenticos)
			{
				return false;
			}

            int digito1 = totalDigito1 % 11;
			digito1 = digito1 < 2 ? 0 : 11 - digito1;

			if (dv1 != digito1)
			{
				return false;
			}

			totalDigito2 += digito1 * 2;
            int digito2 = totalDigito2 % 11;
			digito2 = digito2 < 2 ? 0 : 11 - digito2;

			return dv2 == digito2;
		}

        private string Formatar(string valor)
		{
			valor = valor.Trim();
			valor = valor.Replace(".", "").Replace("-", "").Replace("/", "");
			valor = Convert.ToUInt64(valor).ToString(@"000\.000\.000\-00");
			return valor;
		}

        public override string ToString() => Valor;
    }
}