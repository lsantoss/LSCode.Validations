using LSCode.Validacoes.ValidacoesNotificacoes;
using System.Text.RegularExpressions;

namespace LSCode.Validacoes.ValueObjects
{
    public class URL : Notificadora
    {
        public string Valor { get; private set; }

        public URL(string valor)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao().EhVerdadeiro(Validar(Valor), "URL", "URL inválida"));
        }

        public bool Validar(string homePage)
        {
            string textoMinusculo = homePage.ToLower();

            if (textoMinusculo == homePage)
            {
                if (Regex.IsMatch(homePage, @"^((http)|(https)|(ftp)):\/\/([\- \w]+\.)+\w{2,3}(\/ [%\-\w]+(\.\w{2,})?)*$"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}