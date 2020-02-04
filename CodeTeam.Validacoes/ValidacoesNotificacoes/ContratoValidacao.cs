using System;
using System.Text.RegularExpressions;

namespace CodeTeam.Validacoes.ValidacoesNotificacoes
{
    public class ContratoValidacao : Notificadora
    {
        public ContratoValidacao() { }

        public ContratoValidacao EhIgual(float valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor == (float)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhIgual(int valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor == (int)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhIgual(decimal valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor == (decimal)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhIgual(double valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor == valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhIgual(float valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor == (float)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhIgual(double valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor == (double)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhIgual(double valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor == (double)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhIgual(double valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor == (double)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhIgual(float valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor == (float)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhIgual(int valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor == (int)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhIgual(int valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor == valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhIgual(decimal valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor == (decimal)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhIgual(decimal valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor == (decimal)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhIgual(decimal valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor == valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhIgual(int valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor == (int)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhIgual(float valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor == (float)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhIgual(string valor, string valorComparado, string propriedade, string mensagem)
        {
            if (valor == valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao AreEquals(Guid valor, Guid valorComparado, string propriedade, string mensagem)
        {
            if (valor == valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhIgual(object valor, object valorComparado, string propriedade, string mensagem)
        {
            if (valor == valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhDiferente(double valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor != valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhDiferente(float valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor != (float)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhDiferente(int valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor != (int)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhDiferente(int valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor != valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhDiferente(decimal valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor != (decimal)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhDiferente(int valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor != (int)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhDiferente(float valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor != (float)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhDiferente(decimal valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor != (decimal)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhDiferente(double valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor != (double)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhDiferente(double valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor != (double)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhDiferente(float valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor != valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhDiferente(int valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor != (int)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhDiferente(float valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor != (float)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhDiferente(double valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor != (double)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhDiferente(decimal valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor != (decimal)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhDiferente(decimal valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor != valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhDiferente(string valor, string valorComparado, string propriedade, string mensagem)
        {
            if (valor != valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhDiferente(Guid valor, Guid valorComparado, string propriedade, string mensagem)
        {
            if (valor != valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhDiferente(object valor, object valorComparado, string propriedade, string mensagem)
        {
            if (valor != valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao Contains(string valor, string texto, string propriedade, string mensagem)
        {
            if (valor.Contains(texto))
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao TamanhoIgual(string valor, int tamanho, string propriedade, string mensagem)
        {
            if (valor.Length == tamanho)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao TamanhoDiferente(string valor, int tamanho, string propriedade, string mensagem)
        {
            if (valor.Length != tamanho)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao TamanhoMaximo(string valor, int tamanhoMaximo, string propriedade, string mensagem)
        {
            if (valor.Length > tamanhoMaximo)
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
            else
            {
                return new ContratoValidacao();
            }
        }

        public ContratoValidacao HasMinLen(string valor, int tamanhoMinimo, string propriedade, string mensagem)
        {
            if (valor.Length < tamanhoMinimo)
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
            else
            {
                return new ContratoValidacao();
            }
        }

        public ContratoValidacao EstaEntre(decimal valor, decimal inicio, decimal fim, string propriedade, string mensagem)
        {
            if ((valor > inicio) && (valor < fim))
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao IsBetween(int valor, int inicio, int fim, string propriedade, string mensagem)
        {
            if ((valor > inicio) && (valor < fim))
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao IsBetween(float valor, float inicio, float fim, string propriedade, string mensagem)
        {
            if ((valor > inicio) && (valor < fim))
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao IsBetween(double valor, double inicio, double fim, string propriedade, string mensagem)
        {
            if ((valor > inicio) && (valor < fim))
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao IsBetween(DateTime valor, DateTime inicio, DateTime fim, string propriedade, string mensagem)
        {
            if ((valor > inicio) && (valor < fim))
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhEmail(string email, string propriedade, string mensagem)
        {
            if (Regex.IsMatch(email, @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$"))
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhEmailOrEmpty(string email, string propriedade, string mensagem)
        {
            if ((Regex.IsMatch(email, @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$")) || (email == ""))
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhFalso(bool valor, string propriedade, string mensagem)
        {
            if (valor == false)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhVerdadeiro(bool valor, string propriedade, string mensagem)
        {
            if (valor == true)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaiorOuIgual(decimal valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor >= valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaiorOuIgual(int valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor >= (int)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaiorOuIgual(float valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor >= (float)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaiorOuIgual(int valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor >= (int)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaiorOuIgual(int valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor >= valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaiorOuIgual(int valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor >= (int)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaiorOuIgual(float valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor >= valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaiorOuIgual(double valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor >= (double)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaiorOuIgual(double valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor >= (double)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaiorOuIgual(decimal valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor >= (decimal)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaiorOuIgual(float valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor >= (float)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaiorOuIgual(decimal valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor >= (decimal)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaiorOuIgual(double valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor >= valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaiorOuIgual(float valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor >= (float)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaiorOuIgual(decimal valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor >= (decimal)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaiorOuIgual(double valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor >= (double)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaiorOuIgual(DateTime valor, DateTime valorComparado, string propriedade, string mensagem)
        {
            if (valor >= valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaior(decimal valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor > (decimal)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaior(double valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor > (double)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaior(int valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor > valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaior(float valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor > (float)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaior(int valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor > (int)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaior(float valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor > (float)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaior(int valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor > (int)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaior(decimal valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor > valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaior(decimal valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor > (decimal)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaior(double valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor > (double)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaior(double valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor > valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaior(float valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor > (float)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaior(int valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor > (int)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaior(float valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor > valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaior(double valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor > (double)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaior(decimal valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor > (decimal)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMaior(DateTime valor, DateTime valorComparado, string propriedade, string mensagem)
        {
            if (valor > valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenorOuIgual(decimal valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor <= (decimal)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenorOuIgual(double valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor <= (double)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenorOuIgual(float valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor <= (float)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenorOuIgual(int valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor <= valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenorOuIgual(decimal valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor <= (decimal)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenorOuIgual(double valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor <= valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenorOuIgual(decimal valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor <= (decimal)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenorOuIgual(float valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor <= (float)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenorOuIgual(float valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor <= (float)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenorOuIgual(int valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor <= (int)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenorOuIgual(int valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor <= (int)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenorOuIgual(decimal valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor <= (decimal)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenorOuIgual(double valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor <= (double)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenorOuIgual(int valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor <= (int)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenorOuIgual(double valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor <= (double)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenorOuIgual(float valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor <= valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenorOuIgual(DateTime valor, DateTime valorComparado, string propriedade, string mensagem)
        {
            if (valor <= valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenor(decimal valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor < (decimal)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenor(float valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor < (float)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenor(decimal valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor < valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenor(double valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor < (double)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenor(float valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor < (float)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenor(int valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor < (int)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenor(decimal valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor < (decimal)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenor(double valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor < (double)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenor(int valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor < (int)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenor(float valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor < (float)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenor(int valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor < (int)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenor(double valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor < (double)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenor(int valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor < (int)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenor(double valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor < (double)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenor(float valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor < valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenor(decimal valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor < (decimal)valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhMenor(DateTime valor, DateTime valorComparado, string propriedade, string mensagem)
        {
            if (valor < valorComparado)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao NaoEhNulo(object valor, string propriedade, string mensagem)
        {
            if (valor != null)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao NaoEhNuloOuVazio(string valor, string propriedade, string mensagem)
        {
            if (valor != null && valor != "")
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhNulo(object valor, string propriedade, string mensagem)
        {
            if (valor == null)
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao EhNuloOuVazio(string valor, string propriedade, string mensagem)
        {
            if (valor == null && valor == "")
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao IsUrl(string valor, string propriedade, string mensagem)
        {
            if (Uri.IsWellFormedUriString(valor, UriKind.Absolute))
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao IsUrlOrEmpty(string valor, string propriedade, string mensagem)
        {
            if ((Uri.IsWellFormedUriString(valor, UriKind.Absolute)) || (valor == ""))
            {
                return new ContratoValidacao();
            }
            else
            {
                ContratoValidacao contratoValidacao = new ContratoValidacao();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }
    }
}