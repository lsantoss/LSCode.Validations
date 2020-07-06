using System;
using System.Text.RegularExpressions;

namespace LSCode.Validador.ValidacoesNotificacoes
{
    public class ContratoValidacao2 : Notificadora
    {
        public ContratoValidacao2() { }

        public ContratoValidacao2 EhIgual(float valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor == (float)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhIgual(int valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor == (int)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhIgual(decimal valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor == (decimal)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhIgual(double valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor == valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhIgual(float valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor == (float)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhIgual(double valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor == (double)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhIgual(double valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor == (double)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhIgual(double valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor == (double)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhIgual(float valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor == (float)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhIgual(int valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor == (int)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhIgual(int valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor == valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhIgual(decimal valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor == (decimal)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhIgual(decimal valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor == (decimal)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhIgual(decimal valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor == valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhIgual(int valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor == (int)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhIgual(float valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor == (float)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhIgual(string valor, string valorComparado, string propriedade, string mensagem)
        {
            if (valor == valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhIgual(Guid valor, Guid valorComparado, string propriedade, string mensagem)
        {
            if (valor == valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhIgual(object valor, object valorComparado, string propriedade, string mensagem)
        {
            if (valor == valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhDiferente(double valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor != valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhDiferente(float valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor != (float)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhDiferente(int valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor != (int)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhDiferente(int valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor != valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhDiferente(decimal valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor != (decimal)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhDiferente(int valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor != (int)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhDiferente(float valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor != (float)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhDiferente(decimal valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor != (decimal)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhDiferente(double valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor != (double)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhDiferente(double valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor != (double)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhDiferente(float valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor != valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhDiferente(int valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor != (int)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhDiferente(float valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor != (float)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhDiferente(double valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor != (double)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhDiferente(decimal valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor != (decimal)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhDiferente(decimal valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor != valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhDiferente(string valor, string valorComparado, string propriedade, string mensagem)
        {
            if (valor != valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhDiferente(Guid valor, Guid valorComparado, string propriedade, string mensagem)
        {
            if (valor != valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhDiferente(object valor, object valorComparado, string propriedade, string mensagem)
        {
            if (valor != valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 Contem(string valor, string texto, string propriedade, string mensagem)
        {
            if (valor.Contains(texto))
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 TamanhoIgual(string valor, int tamanho, string propriedade, string mensagem)
        {
            if (valor.Length == tamanho)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 TamanhoDiferente(string valor, int tamanho, string propriedade, string mensagem)
        {
            if (valor.Length != tamanho)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 TamanhoMaximo(string valor, int tamanhoMaximo, string propriedade, string mensagem)
        {
            if (valor.Length > tamanhoMaximo)
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
            else
            {
                return new ContratoValidacao2();
            }
        }

        public ContratoValidacao2 TamanhoMinimo(string valor, int tamanhoMinimo, string propriedade, string mensagem)
        {
            if (valor.Length < tamanhoMinimo)
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
            else
            {
                return new ContratoValidacao2();
            }
        }

        public ContratoValidacao2 EstaEntre(decimal valor, decimal inicio, decimal fim, string propriedade, string mensagem)
        {
            if ((valor > inicio) && (valor < fim))
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EstaEntre(int valor, int inicio, int fim, string propriedade, string mensagem)
        {
            if ((valor > inicio) && (valor < fim))
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EstaEntre(float valor, float inicio, float fim, string propriedade, string mensagem)
        {
            if ((valor > inicio) && (valor < fim))
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EstaEntre(double valor, double inicio, double fim, string propriedade, string mensagem)
        {
            if ((valor > inicio) && (valor < fim))
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EstaEntre(DateTime valor, DateTime inicio, DateTime fim, string propriedade, string mensagem)
        {
            if ((valor > inicio) && (valor < fim))
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhEmail(string email, string propriedade, string mensagem)
        {
            if (Regex.IsMatch(email, @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$"))
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhEmailOuVazio(string email, string propriedade, string mensagem)
        {
            if ((Regex.IsMatch(email, @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$")) || (email == ""))
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhFalso(bool valor, string propriedade, string mensagem)
        {
            if (valor == false)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhVerdadeiro(bool valor, string propriedade, string mensagem)
        {
            if (valor == true)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaiorOuIgual(decimal valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor >= valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaiorOuIgual(int valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor >= (int)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaiorOuIgual(float valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor >= (float)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaiorOuIgual(int valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor >= (int)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaiorOuIgual(int valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor >= valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaiorOuIgual(int valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor >= (int)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaiorOuIgual(float valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor >= valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaiorOuIgual(double valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor >= (double)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaiorOuIgual(double valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor >= (double)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaiorOuIgual(decimal valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor >= (decimal)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaiorOuIgual(float valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor >= (float)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaiorOuIgual(decimal valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor >= (decimal)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaiorOuIgual(double valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor >= valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaiorOuIgual(float valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor >= (float)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaiorOuIgual(decimal valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor >= (decimal)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaiorOuIgual(double valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor >= (double)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaiorOuIgual(DateTime valor, DateTime valorComparado, string propriedade, string mensagem)
        {
            if (valor >= valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaior(decimal valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor > (decimal)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaior(double valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor > (double)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaior(int valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor > valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaior(float valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor > (float)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaior(int valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor > (int)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaior(float valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor > (float)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaior(int valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor > (int)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaior(decimal valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor > valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaior(decimal valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor > (decimal)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaior(double valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor > (double)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaior(double valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor > valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaior(float valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor > (float)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaior(int valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor > (int)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaior(float valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor > valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaior(double valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor > (double)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaior(decimal valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor > (decimal)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMaior(DateTime valor, DateTime valorComparado, string propriedade, string mensagem)
        {
            if (valor > valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenorOuIgual(decimal valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor <= (decimal)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenorOuIgual(double valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor <= (double)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenorOuIgual(float valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor <= (float)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenorOuIgual(int valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor <= valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenorOuIgual(decimal valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor <= (decimal)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenorOuIgual(double valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor <= valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenorOuIgual(decimal valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor <= (decimal)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenorOuIgual(float valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor <= (float)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenorOuIgual(float valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor <= (float)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenorOuIgual(int valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor <= (int)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenorOuIgual(int valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor <= (int)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenorOuIgual(decimal valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor <= (decimal)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenorOuIgual(double valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor <= (double)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenorOuIgual(int valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor <= (int)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenorOuIgual(double valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor <= (double)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenorOuIgual(float valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor <= valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenorOuIgual(DateTime valor, DateTime valorComparado, string propriedade, string mensagem)
        {
            if (valor <= valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenor(decimal valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor < (decimal)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenor(float valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor < (float)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenor(decimal valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor < valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenor(double valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor < (double)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenor(float valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor < (float)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenor(int valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (valor < (int)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenor(decimal valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor < (decimal)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenor(double valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor < (double)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenor(int valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor < (int)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenor(float valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor < (float)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenor(int valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor < (int)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenor(double valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor < (double)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenor(int valor, double valorComparado, string propriedade, string mensagem)
        {
            if (valor < (int)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenor(double valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor < (double)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenor(float valor, float valorComparado, string propriedade, string mensagem)
        {
            if (valor < valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenor(decimal valor, int valorComparado, string propriedade, string mensagem)
        {
            if (valor < (decimal)valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhMenor(DateTime valor, DateTime valorComparado, string propriedade, string mensagem)
        {
            if (valor < valorComparado)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 NaoEhNulo(object valor, string propriedade, string mensagem)
        {
            if (valor != null)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 NaoEhNuloOuVazio(string valor, string propriedade, string mensagem)
        {
            if (valor != null && valor != "")
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhNulo(object valor, string propriedade, string mensagem)
        {
            if (valor == null)
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhNuloOuVazio(string valor, string propriedade, string mensagem)
        {
            if (valor == null && valor == "")
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhUrl(string valor, string propriedade, string mensagem)
        {
            if (Uri.IsWellFormedUriString(valor, UriKind.Absolute))
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }

        public ContratoValidacao2 EhUrlOuVazio(string valor, string propriedade, string mensagem)
        {
            if ((Uri.IsWellFormedUriString(valor, UriKind.Absolute)) || (valor == ""))
            {
                return new ContratoValidacao2();
            }
            else
            {
                ContratoValidacao2 contratoValidacao = new ContratoValidacao2();
                contratoValidacao.AddNotificacao(propriedade, mensagem);
                return contratoValidacao;
            }
        }
    }
}