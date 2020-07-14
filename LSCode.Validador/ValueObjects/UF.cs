using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class UF : Notificadora
    {
        public string Valor { get; private set; }

        public UF(string valor)
        {
            Valor = valor;

            AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 2, "UF", "UF superior à 2 caracteres"));
        }

        private bool Validar(string uf)
        {
            uf = uf.Trim();
            uf = uf.ToUpper();

            if (uf == "RO" || uf == "AC" || uf == "AM" || uf == "RR" || uf == "PA" || uf == "AP" || uf == "TO" || uf == "MA" || uf == "PI" ||
                uf == "CE" || uf == "RN" || uf == "PB" || uf == "PE" || uf == "AL" || uf == "SE" || uf == "BA" || uf == "MG" || uf == "ES" ||
                uf == "RJ" || uf == "SP" || uf == "PR" || uf == "SC" || uf == "RS" || uf == "MS" || uf == "MT" || uf == "GO" || uf == "DF")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString() => Valor;
    }
}