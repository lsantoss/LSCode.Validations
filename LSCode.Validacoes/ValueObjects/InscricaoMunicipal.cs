using LSCode.Validacoes.ValidacoesNotificacoes;

namespace LSCode.Validacoes.ValueObjects
{
    public class InscricaoMunicipal : Notificadora
    {
        public string Valor { get; private set; }

        public InscricaoMunicipal(string valor)
        {
            this.Valor = valor;
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}