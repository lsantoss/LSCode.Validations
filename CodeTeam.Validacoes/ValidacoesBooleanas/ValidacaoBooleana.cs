using System;
using System.Text.RegularExpressions;

namespace CodeTeam.Validacoes.ValidacoesBooleanas
{
    public class ValidacaoBooleana
    {
        public ValidacaoBooleana() { }

        public bool EhIgual(float valor, decimal valorComparado)
        {
            return valor == (float)valorComparado;
        }

        public bool EhIgual(int valor, decimal valorComparado)
        {
            return valor == (int)valorComparado;
        }

        public bool EhIgual(decimal valor, double valorComparado)
        {
            return valor == (decimal)valorComparado;
        }

        public bool EhIgual(double valor, double valorComparado)
        {
            return valor == valorComparado;
        }

        public bool EhIgual(float valor, double valorComparado)
        {
            return valor == (float)valorComparado;
        }

        public bool EhIgual(double valor, int valorComparado)
        {
            return valor == (double)valorComparado;
        }

        public bool EhIgual(double valor, decimal valorComparado)
        {
            return valor == (double)valorComparado;
        }

        public bool EhIgual(double valor, float valorComparado)
        {
            return valor == (double)valorComparado;
        }

        public bool EhIgual(float valor, float valorComparado)
        {
            return valor == (float)valorComparado;
        }

        public bool EhIgual(int valor, float valorComparado)
        {
            return valor == (int)valorComparado;
        }

        public bool EhIgual(int valor, int valorComparado)
        {
            return valor == valorComparado;
        }

        public bool EhIgual(decimal valor, int valorComparado)
        {
            return valor == (decimal)valorComparado;
        }

        public bool EhIgual(decimal valor, float valorComparado)
        {
            return valor == (decimal)valorComparado;
        }

        public bool EhIgual(decimal valor, decimal valorComparado)
        {
            return valor == valorComparado;
        }

        public bool EhIgual(int valor, double valorComparado)
        {
            return valor == (int)valorComparado;
        }

        public bool EhIgual(float valor, int valorComparado)
        {
            return valor == (float)valorComparado;
        }

        public bool EhIgual(string valor, string valorComparado)
        {
            return valor == valorComparado ? true : false;
        }

        public bool AreEquals(Guid valor, Guid valorComparado)
        {
            return valor == valorComparado ? true : false;
        }

        public bool EhIgual(object valor, object valorComparado)
        {
            return valor == valorComparado;
        }

        public bool EhDiferente(double valor, double valorComparado)
        {
            return valor != valorComparado;
        }

        public bool EhDiferente(float valor, double valorComparado)
        {
            return valor != (float)valorComparado;
        }

        public bool EhDiferente(int valor, double valorComparado)
        {
            return valor != (int)valorComparado;
        }

        public bool EhDiferente(int valor, int valorComparado)
        {
            return valor != valorComparado;
        }

        public bool EhDiferente(decimal valor, float valorComparado)
        {
            return valor != (decimal)valorComparado;
        }

        public bool EhDiferente(int valor, decimal valorComparado)
        {
            return valor != (int)valorComparado;
        }

        public bool EhDiferente(float valor, decimal valorComparado)
        {
            return valor != (float)valorComparado;
        }

        public bool EhDiferente(decimal valor, double valorComparado)
        {
            return valor != (decimal)valorComparado;
        }

        public bool EhDiferente(double valor, decimal valorComparado)
        {
            return valor != (double)valorComparado;
        }

        public bool EhDiferente(double valor, float valorComparado)
        {
            return valor != (double)valorComparado;
        }

        public bool EhDiferente(float valor, float valorComparado)
        {
            return valor != valorComparado;
        }

        public bool EhDiferente(int valor, float valorComparado)
        {
            return valor != (int)valorComparado;
        }

        public bool EhDiferente(float valor, int valorComparado)
        {
            return valor != (float)valorComparado;
        }

        public bool EhDiferente(double valor, int valorComparado)
        {
            return valor != (double)valorComparado;
        }

        public bool EhDiferente(decimal valor, int valorComparado)
        {
            return valor != (decimal)valorComparado;
        }

        public bool EhDiferente(decimal valor, decimal valorComparado)
        {
            return valor != valorComparado;
        }

        public bool EhDiferente(string valor, string valorComparado)
        {
            return valor != valorComparado;
        }

        public bool EhDiferente(Guid valor, Guid valorComparado)
        {
            return valor != valorComparado;
        }

        public bool EhDiferente(object valor, object valorComparado)
        {
            return valor != valorComparado ? true : true;
        }

        public bool Contains(string valor, string texto)
        {
            return valor.Contains(texto);
        }

        public bool TamanhoIgual(string valor, int tamanho)
        {
            return valor.Length == tamanho;
        }

        public bool TamanhoDiferente(string valor, int tamanho)
        {
            return valor.Length != tamanho;
        }

        public bool TamanhoMaximo(string valor, int tamanhoMaximo)
        {
            return valor.Length <= tamanhoMaximo;
        }

        public bool HasMinLen(string valor, int tamanhoMinimo)
        {
            return valor.Length >= tamanhoMinimo;
        }

        public bool EstaEntre(decimal valor, decimal inicio, decimal fim)
        {
            return (valor > inicio) && (valor < fim);
        }

        public bool IsBetween(int valor, int inicio, int fim)
        {
            return (valor > inicio) && (valor < fim);
        }

        public bool IsBetween(float valor, float inicio, float fim)
        {
            return (valor > inicio) && (valor < fim);
        }

        public bool IsBetween(double valor, double inicio, double fim)
        {
            return (valor > inicio) && (valor < fim);
        }

        public bool IsBetween(DateTime valor, DateTime inicio, DateTime fim)
        {
            return (valor > inicio) && (valor < fim);
        }

        public bool EhEmail(string email)
        {
            return Regex.IsMatch(email, @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
        }

        public bool EhEmailOrEmpty(string email)
        {
            return (Regex.IsMatch(email, @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$")) || (email == "");
        }

        public bool EhFalso(bool valor)
        {
            return valor == false;
        }

        public bool EhVerdadeiro(bool valor)
        {
            return valor == true ? true : false;
        }

        public bool EhMaiorOuIgual(decimal valor, decimal valorComparado)
        {
            return valor >= valorComparado;
        }

        public bool EhMaiorOuIgual(int valor, double valorComparado)
        {
            return valor >= (int)valorComparado ? true : false;
        }

        public bool EhMaiorOuIgual(float valor, decimal valorComparado)
        {
            return valor >= (float)valorComparado;
        }

        public bool EhMaiorOuIgual(int valor, decimal valorComparado)
        {
            return valor >= (int)valorComparado;
        }

        public bool EhMaiorOuIgual(int valor, int valorComparado)
        {
            return valor >= valorComparado;
        }

        public bool EhMaiorOuIgual(int valor, float valorComparado)
        {
            return valor >= (int)valorComparado;
        }

        public bool EhMaiorOuIgual(float valor, float valorComparado)
        {
            return valor >= valorComparado;
        }

        public bool EhMaiorOuIgual(double valor, float valorComparado)
        {
            return valor >= (double)valorComparado;
        }

        public bool EhMaiorOuIgual(double valor, decimal valorComparado)
        {
            return valor >= (double)valorComparado;
        }

        public bool EhMaiorOuIgual(decimal valor, float valorComparado)
        {
            return valor >= (decimal)valorComparado;
        }

        public bool EhMaiorOuIgual(float valor, int valorComparado)
        {
            return valor >= (float)valorComparado;
        }

        public bool EhMaiorOuIgual(decimal valor, double valorComparado)
        {
            return valor >= (decimal)valorComparado;
        }

        public bool EhMaiorOuIgual(double valor, double valorComparado)
        {
            return valor >= valorComparado;
        }

        public bool EhMaiorOuIgual(float valor, double valorComparado)
        {
            return valor >= (float)valorComparado;
        }

        public bool EhMaiorOuIgual(decimal valor, int valorComparado)
        {
            return valor >= (decimal)valorComparado;
        }

        public bool EhMaiorOuIgual(double valor, int valorComparado)
        {
            return valor >= (double)valorComparado;
        }

        public bool EhMaiorOuIgual(DateTime valor, DateTime valorComparado)
        {
            return valor >= valorComparado;
        }

        public bool EhMaior(decimal valor, int valorComparado)
        {
            return valor > (decimal)valorComparado;
        }

        public bool EhMaior(double valor, int valorComparado)
        {
            return valor > (double)valorComparado;
        }

        public bool EhMaior(int valor, int valorComparado)
        {
            return valor > valorComparado;
        }

        public bool EhMaior(float valor, int valorComparado)
        {
            return valor > (float)valorComparado;
        }

        public bool EhMaior(int valor, float valorComparado)
        {
            return valor > (int)valorComparado;
        }

        public bool EhMaior(float valor, decimal valorComparado)
        {
            return valor > (float)valorComparado;
        }

        public bool EhMaior(int valor, decimal valorComparado)
        {
            return valor > (int)valorComparado;
        }

        public bool EhMaior(decimal valor, decimal valorComparado)
        {
            return valor > valorComparado;
        }

        public bool EhMaior(decimal valor, double valorComparado)
        {
            return valor > (decimal)valorComparado ? true : false;
        }

        public bool EhMaior(double valor, decimal valorComparado)
        {
            return valor > (double)valorComparado;
        }

        public bool EhMaior(double valor, double valorComparado)
        {
            return valor > valorComparado;
        }

        public bool EhMaior(float valor, double valorComparado)
        {
            return valor > (float)valorComparado;
        }

        public bool EhMaior(int valor, double valorComparado)
        {
            return valor > (int)valorComparado;
        }

        public bool EhMaior(float valor, float valorComparado)
        {
            return valor > valorComparado;
        }

        public bool EhMaior(double valor, float valorComparado)
        {
            return valor > (double)valorComparado;
        }

        public bool EhMaior(decimal valor, float valorComparado)
        {
            return valor > (decimal)valorComparado;
        }

        public bool EhMaior(DateTime valor, DateTime valorComparado)
        {
            return valor > valorComparado;
        }

        public bool EhMenorOuIgual(decimal valor, int valorComparado)
        {
            return valor <= (decimal)valorComparado;
        }

        public bool EhMenorOuIgual(double valor, int valorComparado)
        {
            return valor <= (double)valorComparado;
        }

        public bool EhMenorOuIgual(float valor, int valorComparado)
        {
            return valor <= (float)valorComparado;
        }

        public bool EhMenorOuIgual(int valor, int valorComparado)
        {
            return valor <= valorComparado;
        }

        public bool EhMenorOuIgual(decimal valor, double valorComparado)
        {
            return valor <= (decimal)valorComparado;
        }

        public bool EhMenorOuIgual(double valor, double valorComparado)
        {
            return valor <= valorComparado;
        }

        public bool EhMenorOuIgual(decimal valor, decimal valorComparado)
        {
            return valor <= (decimal)valorComparado;
        }

        public bool EhMenorOuIgual(float valor, decimal valorComparado)
        {
            return valor <= (float)valorComparado;
        }

        public bool EhMenorOuIgual(float valor, double valorComparado)
        {
            return valor <= (float)valorComparado;
        }

        public bool EhMenorOuIgual(int valor, double valorComparado)
        {
            return valor <= (int)valorComparado;
        }

        public bool EhMenorOuIgual(int valor, decimal valorComparado)
        {
            return valor <= (int)valorComparado;
        }

        public bool EhMenorOuIgual(decimal valor, float valorComparado)
        {
            return valor <= (decimal)valorComparado;
        }

        public bool EhMenorOuIgual(double valor, float valorComparado)
        {
            return valor <= (double)valorComparado;
        }

        public bool EhMenorOuIgual(int valor, float valorComparado)
        {
            return valor <= (int)valorComparado;
        }

        public bool EhMenorOuIgual(double valor, decimal valorComparado)
        {
            return valor <= (double)valorComparado;
        }

        public bool EhMenorOuIgual(float valor, float valorComparado)
        {
            return valor <= valorComparado;
        }

        public bool EhMenorOuIgual(DateTime valor, DateTime valorComparado)
        {
            return valor <= valorComparado;
        }

        public bool EhMenor(decimal valor, float valorComparado)
        {
            return valor < (decimal)valorComparado;
        }

        public bool EhMenor(float valor, int valorComparado)
        {
            return valor < (float)valorComparado;
        }

        public bool EhMenor(decimal valor, decimal valorComparado)
        {
            return valor < valorComparado;
        }

        public bool EhMenor(double valor, decimal valorComparado)
        {
            return valor < (double)valorComparado;
        }

        public bool EhMenor(float valor, decimal valorComparado)
        {
            return valor < (float)valorComparado;
        }

        public bool EhMenor(int valor, decimal valorComparado)
        {
            return valor < (int)valorComparado;
        }

        public bool EhMenor(decimal valor, double valorComparado)
        {
            return valor < (decimal)valorComparado;
        }

        public bool EhMenor(double valor, double valorComparado)
        {
            return valor < (double)valorComparado;
        }

        public bool EhMenor(int valor, int valorComparado)
        {
            return valor < (int)valorComparado;
        }

        public bool EhMenor(float valor, double valorComparado)
        {
            return valor < (float)valorComparado ? true : false;
        }

        public bool EhMenor(int valor, float valorComparado)
        {
            return valor < (int)valorComparado;
        }

        public bool EhMenor(double valor, int valorComparado)
        {
            return valor < (double)valorComparado;
        }

        public bool EhMenor(int valor, double valorComparado)
        {
            return valor < (int)valorComparado;
        }

        public bool EhMenor(double valor, float valorComparado)
        {
            return valor < (double)valorComparado;
        }

        public bool EhMenor(float valor, float valorComparado)
        {
            return valor < valorComparado;
        }

        public bool EhMenor(decimal valor, int valorComparado)
        {
            return valor < (decimal)valorComparado;
        }

        public bool EhMenor(DateTime valor, DateTime valorComparado)
        {
            return valor < valorComparado;
        }

        public bool NaoEhNulo(object valor)
        {
            return valor != null;
        }

        public bool NaoEhNuloOuVazio(string valor)
        {
            return valor != null && valor != "";
        }

        public bool EhNulo(object valor)
        {
            return valor == null;
        }

        public bool EhNuloOuVazio(string valor)
        {
            return valor == null && valor == "";
        }

        public bool IsUrl(string valor)
        {
            return Uri.IsWellFormedUriString(valor, UriKind.Absolute);
        }

        public bool IsUrlOrEmpty(string valor)
        {
            return (Uri.IsWellFormedUriString(valor, UriKind.Absolute)) || (valor == "");
        }
    }
}