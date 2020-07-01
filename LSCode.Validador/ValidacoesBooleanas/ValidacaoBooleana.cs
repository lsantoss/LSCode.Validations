using System;
using System.Text.RegularExpressions;

namespace LSCode.Validador.ValidacoesBooleanas
{
    public static class ValidacaoBooleana
    {
        public static bool EhIgual(sbyte valor, sbyte valorComparado) => valor == valorComparado;
        public static bool EhIgual(sbyte valor, byte valorComparado) => valor == valorComparado;
        public static bool EhIgual(sbyte valor, short valorComparado) => valor == valorComparado;
        public static bool EhIgual(sbyte valor, ushort valorComparado) => valor == valorComparado;
        public static bool EhIgual(sbyte valor, int valorComparado) => valor == valorComparado;
        public static bool EhIgual(sbyte valor, uint valorComparado) => valor == valorComparado;
        public static bool EhIgual(sbyte valor, long valorComparado) => valor == valorComparado;
        public static bool EhIgual(sbyte valor, ulong valorComparado) => valor < 0 ? false : (ulong)valor == valorComparado;
        public static bool EhIgual(sbyte valor, float valorComparado) => (float)valor == valorComparado;
        public static bool EhIgual(sbyte valor, double valorComparado) => (double)valor == valorComparado;
        public static bool EhIgual(sbyte valor, decimal valorComparado) => (decimal)valor == valorComparado;



        public static bool EhIgual(byte valor, sbyte valorComparado) => valor == valorComparado;
        public static bool EhIgual(byte valor, byte valorComparado) => valor == valorComparado;
        public static bool EhIgual(byte valor, short valorComparado) => valor == valorComparado;
        public static bool EhIgual(byte valor, ushort valorComparado) => valor == valorComparado;
        public static bool EhIgual(byte valor, int valorComparado) => valor == valorComparado;
        public static bool EhIgual(byte valor, uint valorComparado) => valor == valorComparado;
        public static bool EhIgual(byte valor, long valorComparado) => valor == valorComparado;
        public static bool EhIgual(byte valor, ulong valorComparado) => valor == valorComparado;
        public static bool EhIgual(byte valor, float valorComparado) => (float)valor == valorComparado;
        public static bool EhIgual(byte valor, double valorComparado) => (double)valor == valorComparado;
        public static bool EhIgual(byte valor, decimal valorComparado) => (decimal)valor == valorComparado;



        public static bool EhIgual(short valor, sbyte valorComparado) => valor == valorComparado;
        public static bool EhIgual(short valor, byte valorComparado) => valor == valorComparado;
        public static bool EhIgual(short valor, short valorComparado) => valor == valorComparado;
        public static bool EhIgual(short valor, ushort valorComparado) => valor == valorComparado;
        public static bool EhIgual(short valor, int valorComparado) => valor == valorComparado;
        public static bool EhIgual(short valor, uint valorComparado) => valor == valorComparado;
        public static bool EhIgual(short valor, long valorComparado) => valor == valorComparado;
        public static bool EhIgual(short valor, ulong valorComparado) => valor < 0 ? false : (ulong)valor == valorComparado;
        public static bool EhIgual(short valor, float valorComparado) => (float)valor == valorComparado;
        public static bool EhIgual(short valor, double valorComparado) => (double)valor == valorComparado;
        public static bool EhIgual(short valor, decimal valorComparado) => (decimal)valor == valorComparado;



        public static bool EhIgual(ushort valor, sbyte valorComparado) => valor == valorComparado;
        public static bool EhIgual(ushort valor, byte valorComparado) => valor == valorComparado;
        public static bool EhIgual(ushort valor, short valorComparado) => valor == valorComparado;
        public static bool EhIgual(ushort valor, ushort valorComparado) => valor == valorComparado;
        public static bool EhIgual(ushort valor, int valorComparado) => valor == valorComparado;
        public static bool EhIgual(ushort valor, uint valorComparado) => valor == valorComparado;
        public static bool EhIgual(ushort valor, long valorComparado) => valor == valorComparado;
        public static bool EhIgual(ushort valor, ulong valorComparado) => valor == valorComparado;
        public static bool EhIgual(ushort valor, float valorComparado) => (float)valor == valorComparado;
        public static bool EhIgual(ushort valor, double valorComparado) => (double)valor == valorComparado;
        public static bool EhIgual(ushort valor, decimal valorComparado) => (decimal)valor == valorComparado;



        public static bool EhIgual(int valor, sbyte valorComparado) => valor == valorComparado;
        public static bool EhIgual(int valor, byte valorComparado) => valor == valorComparado;
        public static bool EhIgual(int valor, short valorComparado) => valor == valorComparado;
        public static bool EhIgual(int valor, ushort valorComparado) => valor == valorComparado;
        public static bool EhIgual(int valor, int valorComparado) => valor == valorComparado;
        public static bool EhIgual(int valor, uint valorComparado) => valor == valorComparado;
        public static bool EhIgual(int valor, long valorComparado) => valor == valorComparado;
        public static bool EhIgual(int valor, ulong valorComparado) => valor < 0 ? false : (ulong)valor == valorComparado;
        public static bool EhIgual(int valor, float valorComparado) => (float)valor == valorComparado;
        public static bool EhIgual(int valor, double valorComparado) => (double)valor == valorComparado;
        public static bool EhIgual(int valor, decimal valorComparado) => (decimal)valor == valorComparado;



        public static bool EhIgual(uint valor, sbyte valorComparado) => valor == valorComparado;
        public static bool EhIgual(uint valor, byte valorComparado) => valor == valorComparado;
        public static bool EhIgual(uint valor, short valorComparado) => valor == valorComparado;
        public static bool EhIgual(uint valor, ushort valorComparado) => valor == valorComparado;
        public static bool EhIgual(uint valor, int valorComparado) => valor == valorComparado;
        public static bool EhIgual(uint valor, uint valorComparado) => valor == valorComparado;
        public static bool EhIgual(uint valor, long valorComparado) => valor == valorComparado;
        public static bool EhIgual(uint valor, ulong valorComparado) => valor == valorComparado;
        public static bool EhIgual(uint valor, float valorComparado) => (float)valor == valorComparado;
        public static bool EhIgual(uint valor, double valorComparado) => (double)valor == valorComparado;
        public static bool EhIgual(uint valor, decimal valorComparado) => (decimal)valor == valorComparado;



        public static bool EhIgual(long valor, sbyte valorComparado) => valor == valorComparado;
        public static bool EhIgual(long valor, byte valorComparado) => valor == valorComparado;
        public static bool EhIgual(long valor, short valorComparado) => valor == valorComparado;
        public static bool EhIgual(long valor, ushort valorComparado) => valor == valorComparado;
        public static bool EhIgual(long valor, int valorComparado) => valor == valorComparado;
        public static bool EhIgual(long valor, uint valorComparado) => valor == valorComparado;
        public static bool EhIgual(long valor, long valorComparado) => valor == valorComparado;
        public static bool EhIgual(long valor, ulong valorComparado) => valor < 0 ? false : (ulong)valor == valorComparado;
        public static bool EhIgual(long valor, float valorComparado) => (float)valor == valorComparado;
        public static bool EhIgual(long valor, double valorComparado) => (double)valor == valorComparado;
        public static bool EhIgual(long valor, decimal valorComparado) => (decimal)valor == valorComparado;



        public static bool EhIgual(ulong valor, sbyte valorComparado) => valorComparado < 0 ? false : valor == (ulong)valorComparado;
        public static bool EhIgual(ulong valor, byte valorComparado) => valor == valorComparado;
        public static bool EhIgual(ulong valor, short valorComparado) => valorComparado < 0 ? false : valor == (ulong)valorComparado;
        public static bool EhIgual(ulong valor, ushort valorComparado) => valor == valorComparado;
        public static bool EhIgual(ulong valor, int valorComparado) => valorComparado < 0 ? false : valor == (ulong)valorComparado;
        public static bool EhIgual(ulong valor, uint valorComparado) => valor == valorComparado;
        public static bool EhIgual(ulong valor, long valorComparado) => valorComparado < 0 ? false : valor == (ulong)valorComparado;
        public static bool EhIgual(ulong valor, ulong valorComparado) => valor == valorComparado;
        public static bool EhIgual(ulong valor, float valorComparado) => (float)valor == valorComparado;
        public static bool EhIgual(ulong valor, double valorComparado) => (double)valor == valorComparado;
        public static bool EhIgual(ulong valor, decimal valorComparado) => (decimal)valor == valorComparado;



        public static bool EhIgual(float valor, sbyte valorComparado) => valor == valorComparado;
        public static bool EhIgual(float valor, byte valorComparado) => valor == valorComparado;
        public static bool EhIgual(float valor, short valorComparado) => valor == valorComparado;
        public static bool EhIgual(float valor, ushort valorComparado) => valor == valorComparado;
        public static bool EhIgual(float valor, int valorComparado) => valor == valorComparado;
        public static bool EhIgual(float valor, uint valorComparado) => valor == valorComparado;
        public static bool EhIgual(float valor, long valorComparado) => valor == valorComparado;
        public static bool EhIgual(float valor, ulong valorComparado) => valor < 0 ? false : (ulong)valor == valorComparado;
        public static bool EhIgual(float valor, float valorComparado) => valor == valorComparado;
        public static bool EhIgual(float valor, double valorComparado) => (double)valor == valorComparado;
        public static bool EhIgual(float valor, decimal valorComparado) => (decimal)valor == valorComparado;



        public static bool EhIgual(double valor, sbyte valorComparado) => valor == valorComparado;
        public static bool EhIgual(double valor, byte valorComparado) => valor == valorComparado;
        public static bool EhIgual(double valor, short valorComparado) => valor == valorComparado;
        public static bool EhIgual(double valor, ushort valorComparado) => valor == valorComparado;
        public static bool EhIgual(double valor, int valorComparado) => valor == valorComparado;
        public static bool EhIgual(double valor, uint valorComparado) => valor == valorComparado;
        public static bool EhIgual(double valor, long valorComparado) => valor == valorComparado;
        public static bool EhIgual(double valor, ulong valorComparado) => valor < 0 ? false : (ulong)valor == valorComparado;
        public static bool EhIgual(double valor, float valorComparado) => (float)valor == valorComparado;
        public static bool EhIgual(double valor, double valorComparado) => valor == valorComparado;
        public static bool EhIgual(double valor, decimal valorComparado) => (decimal)valor == valorComparado;



        public static bool EhIgual(decimal valor, sbyte valorComparado) => valor == valorComparado;
        public static bool EhIgual(decimal valor, byte valorComparado) => valor == valorComparado;
        public static bool EhIgual(decimal valor, short valorComparado) => valor == valorComparado;
        public static bool EhIgual(decimal valor, ushort valorComparado) => valor == valorComparado;
        public static bool EhIgual(decimal valor, int valorComparado) => valor == valorComparado;
        public static bool EhIgual(decimal valor, uint valorComparado) => valor == valorComparado;
        public static bool EhIgual(decimal valor, long valorComparado) => valor == valorComparado;
        public static bool EhIgual(decimal valor, ulong valorComparado) => valor < 0 ? false : (ulong)valor == valorComparado;
        public static bool EhIgual(decimal valor, float valorComparado) => (float)valor == valorComparado;
        public static bool EhIgual(decimal valor, double valorComparado) => (double)valor == valorComparado;
        public static bool EhIgual(decimal valor, decimal valorComparado) => valor == valorComparado;



        public static bool EhIgual(bool valor, bool valorComparado) => valor == valorComparado ? true : false;
        public static bool EhIgual(string valor, string valorComparado) => valor == valorComparado ? true : false;
        public static bool EhIgual(string valor, Guid valorComparado) => valor == valorComparado.ToString() ? true : false;
        public static bool EhIgual(Guid valor, Guid valorComparado) => valor == valorComparado ? true : false;
        public static bool EhIgual(Guid valor, string valorComparado) => valor.ToString() == valorComparado ? true : false;
        public static bool EhIgual(object valor, object valorComparado) => valor.Equals(valorComparado);

























        public static bool EhDiferente(double valor, double valorComparado) => valor != valorComparado;

        public static bool EhDiferente(float valor, double valorComparado) => valor != (float)valorComparado;

        public static bool EhDiferente(int valor, double valorComparado) => valor != (int)valorComparado;

        public static bool EhDiferente(int valor, int valorComparado) => valor != valorComparado;

        public static bool EhDiferente(decimal valor, float valorComparado) => valor != (decimal)valorComparado;

        public static bool EhDiferente(int valor, decimal valorComparado) => valor != (int)valorComparado;

        public static bool EhDiferente(float valor, decimal valorComparado) => valor != (float)valorComparado;

        public static bool EhDiferente(decimal valor, double valorComparado) => valor != (decimal)valorComparado;

        public static bool EhDiferente(double valor, decimal valorComparado) => valor != (double)valorComparado;

        public static bool EhDiferente(double valor, float valorComparado) => valor != (double)valorComparado;

        public static bool EhDiferente(float valor, float valorComparado) => valor != valorComparado;

        public static bool EhDiferente(int valor, float valorComparado) => valor != (int)valorComparado;

        public static bool EhDiferente(float valor, int valorComparado) => valor != (float)valorComparado;

        public static bool EhDiferente(double valor, int valorComparado) => valor != (double)valorComparado;

        public static bool EhDiferente(decimal valor, int valorComparado) => valor != (decimal)valorComparado;

        public static bool EhDiferente(decimal valor, decimal valorComparado) => valor != valorComparado;

        public static bool EhDiferente(string valor, string valorComparado) => valor != valorComparado;

        public static bool EhDiferente(Guid valor, Guid valorComparado) => valor != valorComparado;

        public static bool EhDiferente(object valor, object valorComparado) => valor != valorComparado ? true : true;

        public static bool Contem(string valor, string texto) => valor.Contains(texto);

        public static bool TamanhoIgual(string valor, int tamanho) => valor.Length == tamanho;

        public static bool TamanhoDiferente(string valor, int tamanho) => valor.Length != tamanho;

        public static bool TamanhoMaximo(string valor, int tamanhoMaximo) => valor.Length <= tamanhoMaximo;

        public static bool TamanhoMinimo(string valor, int tamanhoMinimo) => valor.Length >= tamanhoMinimo;

        public static bool EstaEntre(decimal valor, decimal inicio, decimal fim) => (valor > inicio) && (valor < fim);

        public static bool EstaEntre(int valor, int inicio, int fim) => (valor > inicio) && (valor < fim);

        public static bool EstaEntre(float valor, float inicio, float fim) => (valor > inicio) && (valor < fim);

        public static bool EstaEntre(double valor, double inicio, double fim) => (valor > inicio) && (valor < fim);

        public static bool EstaEntre(DateTime valor, DateTime inicio, DateTime fim) => (valor > inicio) && (valor < fim);

        public static bool EhEmail(string email) => Regex.IsMatch(email, @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

        public static bool EhEmailOrVazio(string email) => (Regex.IsMatch(email, @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$")) || (email == "");

        public static bool EhFalso(bool valor) => valor == false;

        public static bool EhVerdadeiro(bool valor) => valor == true ? true : false;

        public static bool EhMaiorOuIgual(decimal valor, decimal valorComparado) => valor >= valorComparado;

        public static bool EhMaiorOuIgual(int valor, double valorComparado) => valor >= (int)valorComparado ? true : false;

        public static bool EhMaiorOuIgual(float valor, decimal valorComparado) => valor >= (float)valorComparado;

        public static bool EhMaiorOuIgual(int valor, decimal valorComparado) => valor >= (int)valorComparado;

        public static bool EhMaiorOuIgual(int valor, int valorComparado) => valor >= valorComparado;

        public static bool EhMaiorOuIgual(int valor, float valorComparado) => valor >= (int)valorComparado;

        public static bool EhMaiorOuIgual(float valor, float valorComparado) => valor >= valorComparado;

        public static bool EhMaiorOuIgual(double valor, float valorComparado) => valor >= (double)valorComparado;

        public static bool EhMaiorOuIgual(double valor, decimal valorComparado) => valor >= (double)valorComparado;

        public static bool EhMaiorOuIgual(decimal valor, float valorComparado) => valor >= (decimal)valorComparado;

        public static bool EhMaiorOuIgual(float valor, int valorComparado) => valor >= (float)valorComparado;

        public static bool EhMaiorOuIgual(decimal valor, double valorComparado) => valor >= (decimal)valorComparado;

        public static bool EhMaiorOuIgual(double valor, double valorComparado) => valor >= valorComparado;

        public static bool EhMaiorOuIgual(float valor, double valorComparado) => valor >= (float)valorComparado;

        public static bool EhMaiorOuIgual(decimal valor, int valorComparado) => valor >= (decimal)valorComparado;

        public static bool EhMaiorOuIgual(double valor, int valorComparado) => valor >= (double)valorComparado;

        public static bool EhMaiorOuIgual(DateTime valor, DateTime valorComparado) => valor >= valorComparado;

        public static bool EhMaior(decimal valor, int valorComparado) => valor > (decimal)valorComparado;

        public static bool EhMaior(double valor, int valorComparado) => valor > (double)valorComparado;

        public static bool EhMaior(int valor, int valorComparado) => valor > valorComparado;

        public static bool EhMaior(float valor, int valorComparado) => valor > (float)valorComparado;

        public static bool EhMaior(int valor, float valorComparado) => valor > (int)valorComparado;

        public static bool EhMaior(float valor, decimal valorComparado) => valor > (float)valorComparado;

        public static bool EhMaior(int valor, decimal valorComparado) => valor > (int)valorComparado;

        public static bool EhMaior(decimal valor, decimal valorComparado) => valor > valorComparado;

        public static bool EhMaior(decimal valor, double valorComparado) => valor > (decimal)valorComparado ? true : false;

        public static bool EhMaior(double valor, decimal valorComparado) => valor > (double)valorComparado;

        public static bool EhMaior(double valor, double valorComparado) => valor > valorComparado;

        public static bool EhMaior(float valor, double valorComparado) => valor > (float)valorComparado;

        public static bool EhMaior(int valor, double valorComparado) => valor > (int)valorComparado;

        public static bool EhMaior(float valor, float valorComparado) => valor > valorComparado;

        public static bool EhMaior(double valor, float valorComparado) => valor > (double)valorComparado;

        public static bool EhMaior(decimal valor, float valorComparado) => valor > (decimal)valorComparado;

        public static bool EhMaior(DateTime valor, DateTime valorComparado) => valor > valorComparado;

        public static bool EhMenorOuIgual(decimal valor, int valorComparado) => valor <= (decimal)valorComparado;

        public static bool EhMenorOuIgual(double valor, int valorComparado) => valor <= (double)valorComparado;

        public static bool EhMenorOuIgual(float valor, int valorComparado) => valor <= (float)valorComparado;

        public static bool EhMenorOuIgual(int valor, int valorComparado) => valor <= valorComparado;

        public static bool EhMenorOuIgual(decimal valor, double valorComparado) => valor <= (decimal)valorComparado;

        public static bool EhMenorOuIgual(double valor, double valorComparado) => valor <= valorComparado;

        public static bool EhMenorOuIgual(decimal valor, decimal valorComparado) => valor <= (decimal)valorComparado;

        public static bool EhMenorOuIgual(float valor, decimal valorComparado) => valor <= (float)valorComparado;

        public static bool EhMenorOuIgual(float valor, double valorComparado) => valor <= (float)valorComparado;

        public static bool EhMenorOuIgual(int valor, double valorComparado) => valor <= (int)valorComparado;

        public static bool EhMenorOuIgual(int valor, decimal valorComparado) => valor <= (int)valorComparado;

        public static bool EhMenorOuIgual(decimal valor, float valorComparado) => valor <= (decimal)valorComparado;

        public static bool EhMenorOuIgual(double valor, float valorComparado) => valor <= (double)valorComparado;

        public static bool EhMenorOuIgual(int valor, float valorComparado) => valor <= (int)valorComparado;

        public static bool EhMenorOuIgual(double valor, decimal valorComparado) => valor <= (double)valorComparado;

        public static bool EhMenorOuIgual(float valor, float valorComparado) => valor <= valorComparado;

        public static bool EhMenorOuIgual(DateTime valor, DateTime valorComparado) => valor <= valorComparado;

        public static bool EhMenor(decimal valor, float valorComparado) => valor < (decimal)valorComparado;

        public static bool EhMenor(float valor, int valorComparado) => valor < (float)valorComparado;

        public static bool EhMenor(decimal valor, decimal valorComparado) => valor < valorComparado;

        public static bool EhMenor(double valor, decimal valorComparado) => valor < (double)valorComparado;

        public static bool EhMenor(float valor, decimal valorComparado) => valor < (float)valorComparado;

        public static bool EhMenor(int valor, decimal valorComparado) => valor < (int)valorComparado;

        public static bool EhMenor(decimal valor, double valorComparado) => valor < (decimal)valorComparado;

        public static bool EhMenor(double valor, double valorComparado) => valor < (double)valorComparado;

        public static bool EhMenor(int valor, int valorComparado) => valor < (int)valorComparado;

        public static bool EhMenor(float valor, double valorComparado) => valor < (float)valorComparado ? true : false;

        public static bool EhMenor(int valor, float valorComparado) => valor < (int)valorComparado;

        public static bool EhMenor(double valor, int valorComparado) => valor < (double)valorComparado;

        public static bool EhMenor(int valor, double valorComparado) => valor < (int)valorComparado;

        public static bool EhMenor(double valor, float valorComparado) => valor < (double)valorComparado;

        public static bool EhMenor(float valor, float valorComparado) => valor < valorComparado;

        public static bool EhMenor(decimal valor, int valorComparado) => valor < (decimal)valorComparado;

        public static bool EhMenor(DateTime valor, DateTime valorComparado) => valor < valorComparado;

        public static bool NaoEhNulo(object valor) => valor != null;

        public static bool NaoEhNuloOuVazio(string valor) => valor != null && valor != "";

        public static bool EhNulo(object valor) => valor == null;

        public static bool EhNuloOuVazio(string valor) => valor == null && valor == "";

        public static bool EhUrl(string valor) => Uri.IsWellFormedUriString(valor, UriKind.Absolute);

        public static bool EhUrlOuVazio(string valor) => (Uri.IsWellFormedUriString(valor, UriKind.Absolute)) || (valor == "");
    }
}