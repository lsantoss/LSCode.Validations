using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class UF : Notificadora
    {
        public string Valor { get; private set; }

        public UF(string valor)
        {
            Valor = valor;
                
            AddNotificacao(new ContratoValidacao().EhVerdadeiro(Validar(Valor), "UF", "UF não é válido"));

            AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 2, "UF", "UF superior à 2 caracteres"));
        }

        private bool Validar(string valor)
        {
            Valor = valor.Trim().ToUpper();

            return Valor == "RO" || Valor == "AC" || Valor == "AM" || Valor == "RR" || Valor == "PA" || Valor == "AP" || Valor == "TO" || Valor == "MA" || Valor == "PI" ||
                   Valor == "CE" || Valor == "RN" || Valor == "PB" || Valor == "PE" || Valor == "AL" || Valor == "SE" || Valor == "BA" || Valor == "MG" || Valor == "ES" ||
                   Valor == "RJ" || Valor == "SP" || Valor == "PR" || Valor == "SC" || Valor == "RS" || Valor == "MS" || Valor == "MT" || Valor == "GO" || Valor == "DF";
        }

        public override string ToString() => Valor;
    }
}