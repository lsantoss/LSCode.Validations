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

        public static bool EhIgual(bool valor, bool valorComparado) => valor == valorComparado;
        public static bool EhIgual(string valor, string valorComparado) => valor == valorComparado;
        public static bool EhIgual(string valor, Guid valorComparado) => valor == valorComparado.ToString();
        public static bool EhIgual(Guid valor, Guid valorComparado) => valor == valorComparado;
        public static bool EhIgual(Guid valor, string valorComparado) => valor.ToString() == valorComparado;
        public static bool EhIgual(object valor, object valorComparado) => valor.Equals(valorComparado);
        public static bool EhIgual(DateTime valor, DateTime valorComparado) => valor == valorComparado;

        //========================================================================================================================================

        public static bool EhDiferente(sbyte valor, sbyte valorComparado) => valor != valorComparado;
        public static bool EhDiferente(sbyte valor, byte valorComparado) => valor != valorComparado;
        public static bool EhDiferente(sbyte valor, short valorComparado) => valor != valorComparado;
        public static bool EhDiferente(sbyte valor, ushort valorComparado) => valor != valorComparado;
        public static bool EhDiferente(sbyte valor, int valorComparado) => valor != valorComparado;
        public static bool EhDiferente(sbyte valor, uint valorComparado) => valor != valorComparado;
        public static bool EhDiferente(sbyte valor, long valorComparado) => valor != valorComparado;
        public static bool EhDiferente(sbyte valor, ulong valorComparado) => valor < 0 ? true : (ulong)valor != valorComparado;
        public static bool EhDiferente(sbyte valor, float valorComparado) => (float)valor != valorComparado;
        public static bool EhDiferente(sbyte valor, double valorComparado) => (double)valor != valorComparado;
        public static bool EhDiferente(sbyte valor, decimal valorComparado) => (decimal)valor != valorComparado;

        public static bool EhDiferente(byte valor, sbyte valorComparado) => valor != valorComparado;
        public static bool EhDiferente(byte valor, byte valorComparado) => valor != valorComparado;
        public static bool EhDiferente(byte valor, short valorComparado) => valor != valorComparado;
        public static bool EhDiferente(byte valor, ushort valorComparado) => valor != valorComparado;
        public static bool EhDiferente(byte valor, int valorComparado) => valor != valorComparado;
        public static bool EhDiferente(byte valor, uint valorComparado) => valor != valorComparado;
        public static bool EhDiferente(byte valor, long valorComparado) => valor != valorComparado;
        public static bool EhDiferente(byte valor, ulong valorComparado) => valor != valorComparado;
        public static bool EhDiferente(byte valor, float valorComparado) => (float)valor != valorComparado;
        public static bool EhDiferente(byte valor, double valorComparado) => (double)valor != valorComparado;
        public static bool EhDiferente(byte valor, decimal valorComparado) => (decimal)valor != valorComparado;

        public static bool EhDiferente(short valor, sbyte valorComparado) => valor != valorComparado;
        public static bool EhDiferente(short valor, byte valorComparado) => valor != valorComparado;
        public static bool EhDiferente(short valor, short valorComparado) => valor != valorComparado;
        public static bool EhDiferente(short valor, ushort valorComparado) => valor != valorComparado;
        public static bool EhDiferente(short valor, int valorComparado) => valor != valorComparado;
        public static bool EhDiferente(short valor, uint valorComparado) => valor != valorComparado;
        public static bool EhDiferente(short valor, long valorComparado) => valor != valorComparado;
        public static bool EhDiferente(short valor, ulong valorComparado) => valor < 0 ? true : (ulong)valor != valorComparado;
        public static bool EhDiferente(short valor, float valorComparado) => (float)valor != valorComparado;
        public static bool EhDiferente(short valor, double valorComparado) => (double)valor != valorComparado;
        public static bool EhDiferente(short valor, decimal valorComparado) => (decimal)valor != valorComparado;

        public static bool EhDiferente(ushort valor, sbyte valorComparado) => valor != valorComparado;
        public static bool EhDiferente(ushort valor, byte valorComparado) => valor != valorComparado;
        public static bool EhDiferente(ushort valor, short valorComparado) => valor != valorComparado;
        public static bool EhDiferente(ushort valor, ushort valorComparado) => valor != valorComparado;
        public static bool EhDiferente(ushort valor, int valorComparado) => valor != valorComparado;
        public static bool EhDiferente(ushort valor, uint valorComparado) => valor != valorComparado;
        public static bool EhDiferente(ushort valor, long valorComparado) => valor != valorComparado;
        public static bool EhDiferente(ushort valor, ulong valorComparado) => valor != valorComparado;
        public static bool EhDiferente(ushort valor, float valorComparado) => (float)valor != valorComparado;
        public static bool EhDiferente(ushort valor, double valorComparado) => (double)valor != valorComparado;
        public static bool EhDiferente(ushort valor, decimal valorComparado) => (decimal)valor != valorComparado;

        public static bool EhDiferente(int valor, sbyte valorComparado) => valor != valorComparado;
        public static bool EhDiferente(int valor, byte valorComparado) => valor != valorComparado;
        public static bool EhDiferente(int valor, short valorComparado) => valor != valorComparado;
        public static bool EhDiferente(int valor, ushort valorComparado) => valor != valorComparado;
        public static bool EhDiferente(int valor, int valorComparado) => valor != valorComparado;
        public static bool EhDiferente(int valor, uint valorComparado) => valor != valorComparado;
        public static bool EhDiferente(int valor, long valorComparado) => valor != valorComparado;
        public static bool EhDiferente(int valor, ulong valorComparado) => valor < 0 ? true : (ulong)valor != valorComparado;
        public static bool EhDiferente(int valor, float valorComparado) => (float)valor != valorComparado;
        public static bool EhDiferente(int valor, double valorComparado) => (double)valor != valorComparado;
        public static bool EhDiferente(int valor, decimal valorComparado) => (decimal)valor != valorComparado;

        public static bool EhDiferente(uint valor, sbyte valorComparado) => valor != valorComparado;
        public static bool EhDiferente(uint valor, byte valorComparado) => valor != valorComparado;
        public static bool EhDiferente(uint valor, short valorComparado) => valor != valorComparado;
        public static bool EhDiferente(uint valor, ushort valorComparado) => valor != valorComparado;
        public static bool EhDiferente(uint valor, int valorComparado) => valor != valorComparado;
        public static bool EhDiferente(uint valor, uint valorComparado) => valor != valorComparado;
        public static bool EhDiferente(uint valor, long valorComparado) => valor != valorComparado;
        public static bool EhDiferente(uint valor, ulong valorComparado) => valor != valorComparado;
        public static bool EhDiferente(uint valor, float valorComparado) => (float)valor != valorComparado;
        public static bool EhDiferente(uint valor, double valorComparado) => (double)valor != valorComparado;
        public static bool EhDiferente(uint valor, decimal valorComparado) => (decimal)valor != valorComparado;

        public static bool EhDiferente(long valor, sbyte valorComparado) => valor != valorComparado;
        public static bool EhDiferente(long valor, byte valorComparado) => valor != valorComparado;
        public static bool EhDiferente(long valor, short valorComparado) => valor != valorComparado;
        public static bool EhDiferente(long valor, ushort valorComparado) => valor != valorComparado;
        public static bool EhDiferente(long valor, int valorComparado) => valor != valorComparado;
        public static bool EhDiferente(long valor, uint valorComparado) => valor != valorComparado;
        public static bool EhDiferente(long valor, long valorComparado) => valor != valorComparado;
        public static bool EhDiferente(long valor, ulong valorComparado) => valor < 0 ? true : (ulong)valor != valorComparado;
        public static bool EhDiferente(long valor, float valorComparado) => (float)valor != valorComparado;
        public static bool EhDiferente(long valor, double valorComparado) => (double)valor != valorComparado;
        public static bool EhDiferente(long valor, decimal valorComparado) => (decimal)valor != valorComparado;

        public static bool EhDiferente(ulong valor, sbyte valorComparado) => valorComparado < 0 ? true : valor != (ulong)valorComparado;
        public static bool EhDiferente(ulong valor, byte valorComparado) => valor != valorComparado;
        public static bool EhDiferente(ulong valor, short valorComparado) => valorComparado < 0 ? true : valor != (ulong)valorComparado;
        public static bool EhDiferente(ulong valor, ushort valorComparado) => valor != valorComparado;
        public static bool EhDiferente(ulong valor, int valorComparado) => valorComparado < 0 ? true : valor != (ulong)valorComparado;
        public static bool EhDiferente(ulong valor, uint valorComparado) => valor != valorComparado;
        public static bool EhDiferente(ulong valor, long valorComparado) => valorComparado < 0 ? true : valor != (ulong)valorComparado;
        public static bool EhDiferente(ulong valor, ulong valorComparado) => valor != valorComparado;
        public static bool EhDiferente(ulong valor, float valorComparado) => (float)valor != valorComparado;
        public static bool EhDiferente(ulong valor, double valorComparado) => (double)valor != valorComparado;
        public static bool EhDiferente(ulong valor, decimal valorComparado) => (decimal)valor != valorComparado;

        public static bool EhDiferente(float valor, sbyte valorComparado) => valor != valorComparado;
        public static bool EhDiferente(float valor, byte valorComparado) => valor != valorComparado;
        public static bool EhDiferente(float valor, short valorComparado) => valor != valorComparado;
        public static bool EhDiferente(float valor, ushort valorComparado) => valor != valorComparado;
        public static bool EhDiferente(float valor, int valorComparado) => valor != valorComparado;
        public static bool EhDiferente(float valor, uint valorComparado) => valor != valorComparado;
        public static bool EhDiferente(float valor, long valorComparado) => valor != valorComparado;
        public static bool EhDiferente(float valor, ulong valorComparado) => valor < 0 ? true : (ulong)valor != valorComparado;
        public static bool EhDiferente(float valor, float valorComparado) => valor != valorComparado;
        public static bool EhDiferente(float valor, double valorComparado) => (double)valor != valorComparado;
        public static bool EhDiferente(float valor, decimal valorComparado) => (decimal)valor != valorComparado;

        public static bool EhDiferente(double valor, sbyte valorComparado) => valor != valorComparado;
        public static bool EhDiferente(double valor, byte valorComparado) => valor != valorComparado;
        public static bool EhDiferente(double valor, short valorComparado) => valor != valorComparado;
        public static bool EhDiferente(double valor, ushort valorComparado) => valor != valorComparado;
        public static bool EhDiferente(double valor, int valorComparado) => valor != valorComparado;
        public static bool EhDiferente(double valor, uint valorComparado) => valor != valorComparado;
        public static bool EhDiferente(double valor, long valorComparado) => valor != valorComparado;
        public static bool EhDiferente(double valor, ulong valorComparado) => valor < 0 ? true : (ulong)valor != valorComparado;
        public static bool EhDiferente(double valor, float valorComparado) => (float)valor != valorComparado;
        public static bool EhDiferente(double valor, double valorComparado) => valor != valorComparado;
        public static bool EhDiferente(double valor, decimal valorComparado) => (decimal)valor != valorComparado;

        public static bool EhDiferente(decimal valor, sbyte valorComparado) => valor != valorComparado;
        public static bool EhDiferente(decimal valor, byte valorComparado) => valor != valorComparado;
        public static bool EhDiferente(decimal valor, short valorComparado) => valor != valorComparado;
        public static bool EhDiferente(decimal valor, ushort valorComparado) => valor != valorComparado;
        public static bool EhDiferente(decimal valor, int valorComparado) => valor != valorComparado;
        public static bool EhDiferente(decimal valor, uint valorComparado) => valor != valorComparado;
        public static bool EhDiferente(decimal valor, long valorComparado) => valor != valorComparado;
        public static bool EhDiferente(decimal valor, ulong valorComparado) => valor < 0 ? true : (ulong)valor != valorComparado;
        public static bool EhDiferente(decimal valor, float valorComparado) => (float)valor != valorComparado;
        public static bool EhDiferente(decimal valor, double valorComparado) => (double)valor != valorComparado;
        public static bool EhDiferente(decimal valor, decimal valorComparado) => valor != valorComparado;

        public static bool EhDiferente(bool valor, bool valorComparado) => valor != valorComparado;
        public static bool EhDiferente(string valor, string valorComparado) => valor != valorComparado;
        public static bool EhDiferente(string valor, Guid valorComparado) => valor != valorComparado.ToString();
        public static bool EhDiferente(Guid valor, Guid valorComparado) => valor != valorComparado;
        public static bool EhDiferente(Guid valor, string valorComparado) => valor.ToString() != valorComparado;
        public static bool EhDiferente(object valor, object valorComparado) => !valor.Equals(valorComparado);
        public static bool EhDiferente(DateTime valor, DateTime valorComparado) => valor != valorComparado;

        //========================================================================================================================================

        public static bool EhMaiorOuIgual(sbyte valor, sbyte valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(sbyte valor, byte valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(sbyte valor, short valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(sbyte valor, ushort valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(sbyte valor, int valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(sbyte valor, uint valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(sbyte valor, long valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(sbyte valor, ulong valorComparado) => valor < 0 ? false : (ulong)valor >= valorComparado;
        public static bool EhMaiorOuIgual(sbyte valor, float valorComparado) => (float)valor >= valorComparado;
        public static bool EhMaiorOuIgual(sbyte valor, double valorComparado) => (double)valor >= valorComparado;
        public static bool EhMaiorOuIgual(sbyte valor, decimal valorComparado) => (decimal)valor >= valorComparado;

        public static bool EhMaiorOuIgual(byte valor, sbyte valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(byte valor, byte valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(byte valor, short valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(byte valor, ushort valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(byte valor, int valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(byte valor, uint valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(byte valor, long valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(byte valor, ulong valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(byte valor, float valorComparado) => (float)valor >= valorComparado;
        public static bool EhMaiorOuIgual(byte valor, double valorComparado) => (double)valor >= valorComparado;
        public static bool EhMaiorOuIgual(byte valor, decimal valorComparado) => (decimal)valor >= valorComparado;

        public static bool EhMaiorOuIgual(short valor, sbyte valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(short valor, byte valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(short valor, short valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(short valor, ushort valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(short valor, int valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(short valor, uint valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(short valor, long valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(short valor, ulong valorComparado) => valor < 0 ? false : (ulong)valor >= valorComparado;
        public static bool EhMaiorOuIgual(short valor, float valorComparado) => (float)valor >= valorComparado;
        public static bool EhMaiorOuIgual(short valor, double valorComparado) => (double)valor >= valorComparado;
        public static bool EhMaiorOuIgual(short valor, decimal valorComparado) => (decimal)valor >= valorComparado;

        public static bool EhMaiorOuIgual(ushort valor, sbyte valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(ushort valor, byte valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(ushort valor, short valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(ushort valor, ushort valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(ushort valor, int valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(ushort valor, uint valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(ushort valor, long valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(ushort valor, ulong valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(ushort valor, float valorComparado) => (float)valor >= valorComparado;
        public static bool EhMaiorOuIgual(ushort valor, double valorComparado) => (double)valor >= valorComparado;
        public static bool EhMaiorOuIgual(ushort valor, decimal valorComparado) => (decimal)valor >= valorComparado;

        public static bool EhMaiorOuIgual(int valor, sbyte valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(int valor, byte valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(int valor, short valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(int valor, ushort valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(int valor, int valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(int valor, uint valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(int valor, long valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(int valor, ulong valorComparado) => valor < 0 ? false : (ulong)valor >= valorComparado;
        public static bool EhMaiorOuIgual(int valor, float valorComparado) => (float)valor >= valorComparado;
        public static bool EhMaiorOuIgual(int valor, double valorComparado) => (double)valor >= valorComparado;
        public static bool EhMaiorOuIgual(int valor, decimal valorComparado) => (decimal)valor >= valorComparado;

        public static bool EhMaiorOuIgual(uint valor, sbyte valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(uint valor, byte valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(uint valor, short valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(uint valor, ushort valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(uint valor, int valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(uint valor, uint valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(uint valor, long valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(uint valor, ulong valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(uint valor, float valorComparado) => (float)valor >= valorComparado;
        public static bool EhMaiorOuIgual(uint valor, double valorComparado) => (double)valor >= valorComparado;
        public static bool EhMaiorOuIgual(uint valor, decimal valorComparado) => (decimal)valor >= valorComparado;

        public static bool EhMaiorOuIgual(long valor, sbyte valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(long valor, byte valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(long valor, short valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(long valor, ushort valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(long valor, int valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(long valor, uint valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(long valor, long valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(long valor, ulong valorComparado) => valor < 0 ? false : (ulong)valor >= valorComparado;
        public static bool EhMaiorOuIgual(long valor, float valorComparado) => (float)valor >= valorComparado;
        public static bool EhMaiorOuIgual(long valor, double valorComparado) => (double)valor >= valorComparado;
        public static bool EhMaiorOuIgual(long valor, decimal valorComparado) => (decimal)valor >= valorComparado;

        public static bool EhMaiorOuIgual(ulong valor, sbyte valorComparado) => valorComparado < 0 ? true : valor >= (ulong)valorComparado;
        public static bool EhMaiorOuIgual(ulong valor, byte valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(ulong valor, short valorComparado) => valorComparado < 0 ? true : valor >= (ulong)valorComparado;
        public static bool EhMaiorOuIgual(ulong valor, ushort valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(ulong valor, int valorComparado) => valorComparado < 0 ? true : valor >= (ulong)valorComparado;
        public static bool EhMaiorOuIgual(ulong valor, uint valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(ulong valor, long valorComparado) => valorComparado < 0 ? true : valor >= (ulong)valorComparado;
        public static bool EhMaiorOuIgual(ulong valor, ulong valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(ulong valor, float valorComparado) => (float)valor >= valorComparado;
        public static bool EhMaiorOuIgual(ulong valor, double valorComparado) => (double)valor >= valorComparado;
        public static bool EhMaiorOuIgual(ulong valor, decimal valorComparado) => (decimal)valor >= valorComparado;

        public static bool EhMaiorOuIgual(float valor, sbyte valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(float valor, byte valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(float valor, short valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(float valor, ushort valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(float valor, int valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(float valor, uint valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(float valor, long valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(float valor, ulong valorComparado) => valor < 0 ? false : (ulong)valor >= valorComparado;
        public static bool EhMaiorOuIgual(float valor, float valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(float valor, double valorComparado) => (double)valor >= valorComparado;
        public static bool EhMaiorOuIgual(float valor, decimal valorComparado) => (decimal)valor >= valorComparado;

        public static bool EhMaiorOuIgual(double valor, sbyte valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(double valor, byte valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(double valor, short valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(double valor, ushort valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(double valor, int valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(double valor, uint valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(double valor, long valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(double valor, ulong valorComparado) => valor < 0 ? false : (ulong)valor >= valorComparado;
        public static bool EhMaiorOuIgual(double valor, float valorComparado) => (float)valor >= valorComparado;
        public static bool EhMaiorOuIgual(double valor, double valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(double valor, decimal valorComparado) => (decimal)valor >= valorComparado;

        public static bool EhMaiorOuIgual(decimal valor, sbyte valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(decimal valor, byte valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(decimal valor, short valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(decimal valor, ushort valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(decimal valor, int valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(decimal valor, uint valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(decimal valor, long valorComparado) => valor >= valorComparado;
        public static bool EhMaiorOuIgual(decimal valor, ulong valorComparado) => valor < 0 ? false : (ulong)valor >= valorComparado;
        public static bool EhMaiorOuIgual(decimal valor, float valorComparado) => (float)valor >= valorComparado;
        public static bool EhMaiorOuIgual(decimal valor, double valorComparado) => (double)valor >= valorComparado;
        public static bool EhMaiorOuIgual(decimal valor, decimal valorComparado) => valor >= valorComparado;

        public static bool EhMaiorOuIgual(DateTime valor, DateTime valorComparado) => valor >= valorComparado;

        //========================================================================================================================================

        public static bool EhMaior(sbyte valor, sbyte valorComparado) => valor > valorComparado;
        public static bool EhMaior(sbyte valor, byte valorComparado) => valor > valorComparado;
        public static bool EhMaior(sbyte valor, short valorComparado) => valor > valorComparado;
        public static bool EhMaior(sbyte valor, ushort valorComparado) => valor > valorComparado;
        public static bool EhMaior(sbyte valor, int valorComparado) => valor > valorComparado;
        public static bool EhMaior(sbyte valor, uint valorComparado) => valor > valorComparado;
        public static bool EhMaior(sbyte valor, long valorComparado) => valor > valorComparado;
        public static bool EhMaior(sbyte valor, ulong valorComparado) => valor < 0 ? false : (ulong)valor > valorComparado;
        public static bool EhMaior(sbyte valor, float valorComparado) => (float)valor > valorComparado;
        public static bool EhMaior(sbyte valor, double valorComparado) => (double)valor > valorComparado;
        public static bool EhMaior(sbyte valor, decimal valorComparado) => (decimal)valor > valorComparado;

        public static bool EhMaior(byte valor, sbyte valorComparado) => valor > valorComparado;
        public static bool EhMaior(byte valor, byte valorComparado) => valor > valorComparado;
        public static bool EhMaior(byte valor, short valorComparado) => valor > valorComparado;
        public static bool EhMaior(byte valor, ushort valorComparado) => valor > valorComparado;
        public static bool EhMaior(byte valor, int valorComparado) => valor > valorComparado;
        public static bool EhMaior(byte valor, uint valorComparado) => valor > valorComparado;
        public static bool EhMaior(byte valor, long valorComparado) => valor > valorComparado;
        public static bool EhMaior(byte valor, ulong valorComparado) => valor > valorComparado;
        public static bool EhMaior(byte valor, float valorComparado) => (float)valor > valorComparado;
        public static bool EhMaior(byte valor, double valorComparado) => (double)valor > valorComparado;
        public static bool EhMaior(byte valor, decimal valorComparado) => (decimal)valor > valorComparado;

        public static bool EhMaior(short valor, sbyte valorComparado) => valor > valorComparado;
        public static bool EhMaior(short valor, byte valorComparado) => valor > valorComparado;
        public static bool EhMaior(short valor, short valorComparado) => valor > valorComparado;
        public static bool EhMaior(short valor, ushort valorComparado) => valor > valorComparado;
        public static bool EhMaior(short valor, int valorComparado) => valor > valorComparado;
        public static bool EhMaior(short valor, uint valorComparado) => valor > valorComparado;
        public static bool EhMaior(short valor, long valorComparado) => valor > valorComparado;
        public static bool EhMaior(short valor, ulong valorComparado) => valor < 0 ? false : (ulong)valor > valorComparado;
        public static bool EhMaior(short valor, float valorComparado) => (float)valor > valorComparado;
        public static bool EhMaior(short valor, double valorComparado) => (double)valor > valorComparado;
        public static bool EhMaior(short valor, decimal valorComparado) => (decimal)valor > valorComparado;

        public static bool EhMaior(ushort valor, sbyte valorComparado) => valor > valorComparado;
        public static bool EhMaior(ushort valor, byte valorComparado) => valor > valorComparado;
        public static bool EhMaior(ushort valor, short valorComparado) => valor > valorComparado;
        public static bool EhMaior(ushort valor, ushort valorComparado) => valor > valorComparado;
        public static bool EhMaior(ushort valor, int valorComparado) => valor > valorComparado;
        public static bool EhMaior(ushort valor, uint valorComparado) => valor > valorComparado;
        public static bool EhMaior(ushort valor, long valorComparado) => valor > valorComparado;
        public static bool EhMaior(ushort valor, ulong valorComparado) => valor > valorComparado;
        public static bool EhMaior(ushort valor, float valorComparado) => (float)valor > valorComparado;
        public static bool EhMaior(ushort valor, double valorComparado) => (double)valor > valorComparado;
        public static bool EhMaior(ushort valor, decimal valorComparado) => (decimal)valor > valorComparado;

        public static bool EhMaior(int valor, sbyte valorComparado) => valor > valorComparado;
        public static bool EhMaior(int valor, byte valorComparado) => valor > valorComparado;
        public static bool EhMaior(int valor, short valorComparado) => valor > valorComparado;
        public static bool EhMaior(int valor, ushort valorComparado) => valor > valorComparado;
        public static bool EhMaior(int valor, int valorComparado) => valor > valorComparado;
        public static bool EhMaior(int valor, uint valorComparado) => valor > valorComparado;
        public static bool EhMaior(int valor, long valorComparado) => valor > valorComparado;
        public static bool EhMaior(int valor, ulong valorComparado) => valor < 0 ? false : (ulong)valor > valorComparado;
        public static bool EhMaior(int valor, float valorComparado) => (float)valor > valorComparado;
        public static bool EhMaior(int valor, double valorComparado) => (double)valor > valorComparado;
        public static bool EhMaior(int valor, decimal valorComparado) => (decimal)valor > valorComparado;

        public static bool EhMaior(uint valor, sbyte valorComparado) => valor > valorComparado;
        public static bool EhMaior(uint valor, byte valorComparado) => valor > valorComparado;
        public static bool EhMaior(uint valor, short valorComparado) => valor > valorComparado;
        public static bool EhMaior(uint valor, ushort valorComparado) => valor > valorComparado;
        public static bool EhMaior(uint valor, int valorComparado) => valor > valorComparado;
        public static bool EhMaior(uint valor, uint valorComparado) => valor > valorComparado;
        public static bool EhMaior(uint valor, long valorComparado) => valor > valorComparado;
        public static bool EhMaior(uint valor, ulong valorComparado) => valor > valorComparado;
        public static bool EhMaior(uint valor, float valorComparado) => (float)valor > valorComparado;
        public static bool EhMaior(uint valor, double valorComparado) => (double)valor > valorComparado;
        public static bool EhMaior(uint valor, decimal valorComparado) => (decimal)valor > valorComparado;

        public static bool EhMaior(long valor, sbyte valorComparado) => valor > valorComparado;
        public static bool EhMaior(long valor, byte valorComparado) => valor > valorComparado;
        public static bool EhMaior(long valor, short valorComparado) => valor > valorComparado;
        public static bool EhMaior(long valor, ushort valorComparado) => valor > valorComparado;
        public static bool EhMaior(long valor, int valorComparado) => valor > valorComparado;
        public static bool EhMaior(long valor, uint valorComparado) => valor > valorComparado;
        public static bool EhMaior(long valor, long valorComparado) => valor > valorComparado;
        public static bool EhMaior(long valor, ulong valorComparado) => valor < 0 ? false : (ulong)valor > valorComparado;
        public static bool EhMaior(long valor, float valorComparado) => (float)valor > valorComparado;
        public static bool EhMaior(long valor, double valorComparado) => (double)valor > valorComparado;
        public static bool EhMaior(long valor, decimal valorComparado) => (decimal)valor > valorComparado;

        public static bool EhMaior(ulong valor, sbyte valorComparado) => valorComparado < 0 ? true : valor > (ulong)valorComparado;
        public static bool EhMaior(ulong valor, byte valorComparado) => valor > valorComparado;
        public static bool EhMaior(ulong valor, short valorComparado) => valorComparado < 0 ? true : valor > (ulong)valorComparado;
        public static bool EhMaior(ulong valor, ushort valorComparado) => valor > valorComparado;
        public static bool EhMaior(ulong valor, int valorComparado) => valorComparado < 0 ? true : valor > (ulong)valorComparado;
        public static bool EhMaior(ulong valor, uint valorComparado) => valor > valorComparado;
        public static bool EhMaior(ulong valor, long valorComparado) => valorComparado < 0 ? true : valor > (ulong)valorComparado;
        public static bool EhMaior(ulong valor, ulong valorComparado) => valor > valorComparado;
        public static bool EhMaior(ulong valor, float valorComparado) => (float)valor > valorComparado;
        public static bool EhMaior(ulong valor, double valorComparado) => (double)valor > valorComparado;
        public static bool EhMaior(ulong valor, decimal valorComparado) => (decimal)valor > valorComparado;

        public static bool EhMaior(float valor, sbyte valorComparado) => valor > valorComparado;
        public static bool EhMaior(float valor, byte valorComparado) => valor > valorComparado;
        public static bool EhMaior(float valor, short valorComparado) => valor > valorComparado;
        public static bool EhMaior(float valor, ushort valorComparado) => valor > valorComparado;
        public static bool EhMaior(float valor, int valorComparado) => valor > valorComparado;
        public static bool EhMaior(float valor, uint valorComparado) => valor > valorComparado;
        public static bool EhMaior(float valor, long valorComparado) => valor > valorComparado;
        public static bool EhMaior(float valor, ulong valorComparado) => valor < 0 ? false : (ulong)valor > valorComparado;
        public static bool EhMaior(float valor, float valorComparado) => valor > valorComparado;
        public static bool EhMaior(float valor, double valorComparado) => (double)valor > valorComparado;
        public static bool EhMaior(float valor, decimal valorComparado) => (decimal)valor > valorComparado;

        public static bool EhMaior(double valor, sbyte valorComparado) => valor > valorComparado;
        public static bool EhMaior(double valor, byte valorComparado) => valor > valorComparado;
        public static bool EhMaior(double valor, short valorComparado) => valor > valorComparado;
        public static bool EhMaior(double valor, ushort valorComparado) => valor > valorComparado;
        public static bool EhMaior(double valor, int valorComparado) => valor > valorComparado;
        public static bool EhMaior(double valor, uint valorComparado) => valor > valorComparado;
        public static bool EhMaior(double valor, long valorComparado) => valor > valorComparado;
        public static bool EhMaior(double valor, ulong valorComparado) => valor < 0 ? false : (ulong)valor > valorComparado;
        public static bool EhMaior(double valor, float valorComparado) => (float)valor > valorComparado;
        public static bool EhMaior(double valor, double valorComparado) => valor > valorComparado;
        public static bool EhMaior(double valor, decimal valorComparado) => (decimal)valor > valorComparado;

        public static bool EhMaior(decimal valor, sbyte valorComparado) => valor > valorComparado;
        public static bool EhMaior(decimal valor, byte valorComparado) => valor > valorComparado;
        public static bool EhMaior(decimal valor, short valorComparado) => valor > valorComparado;
        public static bool EhMaior(decimal valor, ushort valorComparado) => valor > valorComparado;
        public static bool EhMaior(decimal valor, int valorComparado) => valor > valorComparado;
        public static bool EhMaior(decimal valor, uint valorComparado) => valor > valorComparado;
        public static bool EhMaior(decimal valor, long valorComparado) => valor > valorComparado;
        public static bool EhMaior(decimal valor, ulong valorComparado) => valor < 0 ? false : (ulong)valor > valorComparado;
        public static bool EhMaior(decimal valor, float valorComparado) => (float)valor > valorComparado;
        public static bool EhMaior(decimal valor, double valorComparado) => (double)valor > valorComparado;
        public static bool EhMaior(decimal valor, decimal valorComparado) => valor > valorComparado;

        public static bool EhMaior(DateTime valor, DateTime valorComparado) => valor > valorComparado;

        //========================================================================================================================================

        public static bool EhMenorOuIgual(sbyte valor, sbyte valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(sbyte valor, byte valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(sbyte valor, short valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(sbyte valor, ushort valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(sbyte valor, int valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(sbyte valor, uint valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(sbyte valor, long valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(sbyte valor, ulong valorComparado) => valor < 0 ? true : (ulong)valor <= valorComparado;
        public static bool EhMenorOuIgual(sbyte valor, float valorComparado) => (float)valor <= valorComparado;
        public static bool EhMenorOuIgual(sbyte valor, double valorComparado) => (double)valor <= valorComparado;
        public static bool EhMenorOuIgual(sbyte valor, decimal valorComparado) => (decimal)valor <= valorComparado;

        public static bool EhMenorOuIgual(byte valor, sbyte valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(byte valor, byte valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(byte valor, short valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(byte valor, ushort valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(byte valor, int valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(byte valor, uint valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(byte valor, long valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(byte valor, ulong valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(byte valor, float valorComparado) => (float)valor <= valorComparado;
        public static bool EhMenorOuIgual(byte valor, double valorComparado) => (double)valor <= valorComparado;
        public static bool EhMenorOuIgual(byte valor, decimal valorComparado) => (decimal)valor <= valorComparado;

        public static bool EhMenorOuIgual(short valor, sbyte valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(short valor, byte valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(short valor, short valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(short valor, ushort valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(short valor, int valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(short valor, uint valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(short valor, long valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(short valor, ulong valorComparado) => valor < 0 ? true : (ulong)valor <= valorComparado;
        public static bool EhMenorOuIgual(short valor, float valorComparado) => (float)valor <= valorComparado;
        public static bool EhMenorOuIgual(short valor, double valorComparado) => (double)valor <= valorComparado;
        public static bool EhMenorOuIgual(short valor, decimal valorComparado) => (decimal)valor <= valorComparado;

        public static bool EhMenorOuIgual(ushort valor, sbyte valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(ushort valor, byte valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(ushort valor, short valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(ushort valor, ushort valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(ushort valor, int valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(ushort valor, uint valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(ushort valor, long valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(ushort valor, ulong valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(ushort valor, float valorComparado) => (float)valor <= valorComparado;
        public static bool EhMenorOuIgual(ushort valor, double valorComparado) => (double)valor <= valorComparado;
        public static bool EhMenorOuIgual(ushort valor, decimal valorComparado) => (decimal)valor <= valorComparado;

        public static bool EhMenorOuIgual(int valor, sbyte valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(int valor, byte valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(int valor, short valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(int valor, ushort valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(int valor, int valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(int valor, uint valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(int valor, long valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(int valor, ulong valorComparado) => valor < 0 ? true : (ulong)valor <= valorComparado;
        public static bool EhMenorOuIgual(int valor, float valorComparado) => (float)valor <= valorComparado;
        public static bool EhMenorOuIgual(int valor, double valorComparado) => (double)valor <= valorComparado;
        public static bool EhMenorOuIgual(int valor, decimal valorComparado) => (decimal)valor <= valorComparado;

        public static bool EhMenorOuIgual(uint valor, sbyte valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(uint valor, byte valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(uint valor, short valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(uint valor, ushort valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(uint valor, int valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(uint valor, uint valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(uint valor, long valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(uint valor, ulong valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(uint valor, float valorComparado) => (float)valor <= valorComparado;
        public static bool EhMenorOuIgual(uint valor, double valorComparado) => (double)valor <= valorComparado;
        public static bool EhMenorOuIgual(uint valor, decimal valorComparado) => (decimal)valor <= valorComparado;

        public static bool EhMenorOuIgual(long valor, sbyte valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(long valor, byte valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(long valor, short valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(long valor, ushort valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(long valor, int valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(long valor, uint valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(long valor, long valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(long valor, ulong valorComparado) => valor < 0 ? true : (ulong)valor <= valorComparado;
        public static bool EhMenorOuIgual(long valor, float valorComparado) => (float)valor <= valorComparado;
        public static bool EhMenorOuIgual(long valor, double valorComparado) => (double)valor <= valorComparado;
        public static bool EhMenorOuIgual(long valor, decimal valorComparado) => (decimal)valor <= valorComparado;

        public static bool EhMenorOuIgual(ulong valor, sbyte valorComparado) => valorComparado < 0 ? false : valor <= (ulong)valorComparado;
        public static bool EhMenorOuIgual(ulong valor, byte valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(ulong valor, short valorComparado) => valorComparado < 0 ? false : valor <= (ulong)valorComparado;
        public static bool EhMenorOuIgual(ulong valor, ushort valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(ulong valor, int valorComparado) => valorComparado < 0 ? false : valor <= (ulong)valorComparado;
        public static bool EhMenorOuIgual(ulong valor, uint valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(ulong valor, long valorComparado) => valorComparado < 0 ? false : valor <= (ulong)valorComparado;
        public static bool EhMenorOuIgual(ulong valor, ulong valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(ulong valor, float valorComparado) => (float)valor <= valorComparado;
        public static bool EhMenorOuIgual(ulong valor, double valorComparado) => (double)valor <= valorComparado;
        public static bool EhMenorOuIgual(ulong valor, decimal valorComparado) => (decimal)valor <= valorComparado;

        public static bool EhMenorOuIgual(float valor, sbyte valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(float valor, byte valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(float valor, short valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(float valor, ushort valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(float valor, int valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(float valor, uint valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(float valor, long valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(float valor, ulong valorComparado) => valor < 0 ? true : (ulong)valor <= valorComparado;
        public static bool EhMenorOuIgual(float valor, float valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(float valor, double valorComparado) => (double)valor <= valorComparado;
        public static bool EhMenorOuIgual(float valor, decimal valorComparado) => (decimal)valor <= valorComparado;

        public static bool EhMenorOuIgual(double valor, sbyte valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(double valor, byte valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(double valor, short valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(double valor, ushort valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(double valor, int valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(double valor, uint valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(double valor, long valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(double valor, ulong valorComparado) => valor < 0 ? true : (ulong)valor <= valorComparado;
        public static bool EhMenorOuIgual(double valor, float valorComparado) => (float)valor <= valorComparado;
        public static bool EhMenorOuIgual(double valor, double valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(double valor, decimal valorComparado) => (decimal)valor <= valorComparado;

        public static bool EhMenorOuIgual(decimal valor, sbyte valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(decimal valor, byte valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(decimal valor, short valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(decimal valor, ushort valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(decimal valor, int valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(decimal valor, uint valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(decimal valor, long valorComparado) => valor <= valorComparado;
        public static bool EhMenorOuIgual(decimal valor, ulong valorComparado) => valor < 0 ? true : (ulong)valor <= valorComparado;
        public static bool EhMenorOuIgual(decimal valor, float valorComparado) => (float)valor <= valorComparado;
        public static bool EhMenorOuIgual(decimal valor, double valorComparado) => (double)valor <= valorComparado;
        public static bool EhMenorOuIgual(decimal valor, decimal valorComparado) => valor <= valorComparado;

        public static bool EhMenorOuIgual(DateTime valor, DateTime valorComparado) => valor <= valorComparado;

        //========================================================================================================================================

        public static bool EhMenor(sbyte valor, sbyte valorComparado) => valor < valorComparado;
        public static bool EhMenor(sbyte valor, byte valorComparado) => valor < valorComparado;
        public static bool EhMenor(sbyte valor, short valorComparado) => valor < valorComparado;
        public static bool EhMenor(sbyte valor, ushort valorComparado) => valor < valorComparado;
        public static bool EhMenor(sbyte valor, int valorComparado) => valor < valorComparado;
        public static bool EhMenor(sbyte valor, uint valorComparado) => valor < valorComparado;
        public static bool EhMenor(sbyte valor, long valorComparado) => valor < valorComparado;
        public static bool EhMenor(sbyte valor, ulong valorComparado) => valor < 0 ? true : (ulong)valor < valorComparado;
        public static bool EhMenor(sbyte valor, float valorComparado) => (float)valor < valorComparado;
        public static bool EhMenor(sbyte valor, double valorComparado) => (double)valor < valorComparado;
        public static bool EhMenor(sbyte valor, decimal valorComparado) => (decimal)valor < valorComparado;

        public static bool EhMenor(byte valor, sbyte valorComparado) => valor < valorComparado;
        public static bool EhMenor(byte valor, byte valorComparado) => valor < valorComparado;
        public static bool EhMenor(byte valor, short valorComparado) => valor < valorComparado;
        public static bool EhMenor(byte valor, ushort valorComparado) => valor < valorComparado;
        public static bool EhMenor(byte valor, int valorComparado) => valor < valorComparado;
        public static bool EhMenor(byte valor, uint valorComparado) => valor < valorComparado;
        public static bool EhMenor(byte valor, long valorComparado) => valor < valorComparado;
        public static bool EhMenor(byte valor, ulong valorComparado) => valor < valorComparado;
        public static bool EhMenor(byte valor, float valorComparado) => (float)valor < valorComparado;
        public static bool EhMenor(byte valor, double valorComparado) => (double)valor < valorComparado;
        public static bool EhMenor(byte valor, decimal valorComparado) => (decimal)valor < valorComparado;

        public static bool EhMenor(short valor, sbyte valorComparado) => valor < valorComparado;
        public static bool EhMenor(short valor, byte valorComparado) => valor < valorComparado;
        public static bool EhMenor(short valor, short valorComparado) => valor < valorComparado;
        public static bool EhMenor(short valor, ushort valorComparado) => valor < valorComparado;
        public static bool EhMenor(short valor, int valorComparado) => valor < valorComparado;
        public static bool EhMenor(short valor, uint valorComparado) => valor < valorComparado;
        public static bool EhMenor(short valor, long valorComparado) => valor < valorComparado;
        public static bool EhMenor(short valor, ulong valorComparado) => valor < 0 ? true : (ulong)valor < valorComparado;
        public static bool EhMenor(short valor, float valorComparado) => (float)valor < valorComparado;
        public static bool EhMenor(short valor, double valorComparado) => (double)valor < valorComparado;
        public static bool EhMenor(short valor, decimal valorComparado) => (decimal)valor < valorComparado;

        public static bool EhMenor(ushort valor, sbyte valorComparado) => valor < valorComparado;
        public static bool EhMenor(ushort valor, byte valorComparado) => valor < valorComparado;
        public static bool EhMenor(ushort valor, short valorComparado) => valor < valorComparado;
        public static bool EhMenor(ushort valor, ushort valorComparado) => valor < valorComparado;
        public static bool EhMenor(ushort valor, int valorComparado) => valor < valorComparado;
        public static bool EhMenor(ushort valor, uint valorComparado) => valor < valorComparado;
        public static bool EhMenor(ushort valor, long valorComparado) => valor < valorComparado;
        public static bool EhMenor(ushort valor, ulong valorComparado) => valor < valorComparado;
        public static bool EhMenor(ushort valor, float valorComparado) => (float)valor < valorComparado;
        public static bool EhMenor(ushort valor, double valorComparado) => (double)valor < valorComparado;
        public static bool EhMenor(ushort valor, decimal valorComparado) => (decimal)valor < valorComparado;

        public static bool EhMenor(int valor, sbyte valorComparado) => valor < valorComparado;
        public static bool EhMenor(int valor, byte valorComparado) => valor < valorComparado;
        public static bool EhMenor(int valor, short valorComparado) => valor < valorComparado;
        public static bool EhMenor(int valor, ushort valorComparado) => valor < valorComparado;
        public static bool EhMenor(int valor, int valorComparado) => valor < valorComparado;
        public static bool EhMenor(int valor, uint valorComparado) => valor < valorComparado;
        public static bool EhMenor(int valor, long valorComparado) => valor < valorComparado;
        public static bool EhMenor(int valor, ulong valorComparado) => valor < 0 ? true : (ulong)valor < valorComparado;
        public static bool EhMenor(int valor, float valorComparado) => (float)valor < valorComparado;
        public static bool EhMenor(int valor, double valorComparado) => (double)valor < valorComparado;
        public static bool EhMenor(int valor, decimal valorComparado) => (decimal)valor < valorComparado;

        public static bool EhMenor(uint valor, sbyte valorComparado) => valor < valorComparado;
        public static bool EhMenor(uint valor, byte valorComparado) => valor < valorComparado;
        public static bool EhMenor(uint valor, short valorComparado) => valor < valorComparado;
        public static bool EhMenor(uint valor, ushort valorComparado) => valor < valorComparado;
        public static bool EhMenor(uint valor, int valorComparado) => valor < valorComparado;
        public static bool EhMenor(uint valor, uint valorComparado) => valor < valorComparado;
        public static bool EhMenor(uint valor, long valorComparado) => valor < valorComparado;
        public static bool EhMenor(uint valor, ulong valorComparado) => valor < valorComparado;
        public static bool EhMenor(uint valor, float valorComparado) => (float)valor < valorComparado;
        public static bool EhMenor(uint valor, double valorComparado) => (double)valor < valorComparado;
        public static bool EhMenor(uint valor, decimal valorComparado) => (decimal)valor < valorComparado;

        public static bool EhMenor(long valor, sbyte valorComparado) => valor < valorComparado;
        public static bool EhMenor(long valor, byte valorComparado) => valor < valorComparado;
        public static bool EhMenor(long valor, short valorComparado) => valor < valorComparado;
        public static bool EhMenor(long valor, ushort valorComparado) => valor < valorComparado;
        public static bool EhMenor(long valor, int valorComparado) => valor < valorComparado;
        public static bool EhMenor(long valor, uint valorComparado) => valor < valorComparado;
        public static bool EhMenor(long valor, long valorComparado) => valor < valorComparado;
        public static bool EhMenor(long valor, ulong valorComparado) => valor < 0 ? true : (ulong)valor < valorComparado;
        public static bool EhMenor(long valor, float valorComparado) => (float)valor < valorComparado;
        public static bool EhMenor(long valor, double valorComparado) => (double)valor < valorComparado;
        public static bool EhMenor(long valor, decimal valorComparado) => (decimal)valor < valorComparado;

        public static bool EhMenor(ulong valor, sbyte valorComparado) => valorComparado < 0 ? false : valor < (ulong)valorComparado;
        public static bool EhMenor(ulong valor, byte valorComparado) => valor < valorComparado;
        public static bool EhMenor(ulong valor, short valorComparado) => valorComparado < 0 ? false : valor < (ulong)valorComparado;
        public static bool EhMenor(ulong valor, ushort valorComparado) => valor < valorComparado;
        public static bool EhMenor(ulong valor, int valorComparado) => valorComparado < 0 ? false : valor < (ulong)valorComparado;
        public static bool EhMenor(ulong valor, uint valorComparado) => valor < valorComparado;
        public static bool EhMenor(ulong valor, long valorComparado) => valorComparado < 0 ? false : valor < (ulong)valorComparado;
        public static bool EhMenor(ulong valor, ulong valorComparado) => valor < valorComparado;
        public static bool EhMenor(ulong valor, float valorComparado) => (float)valor < valorComparado;
        public static bool EhMenor(ulong valor, double valorComparado) => (double)valor < valorComparado;
        public static bool EhMenor(ulong valor, decimal valorComparado) => (decimal)valor < valorComparado;

        public static bool EhMenor(float valor, sbyte valorComparado) => valor < valorComparado;
        public static bool EhMenor(float valor, byte valorComparado) => valor < valorComparado;
        public static bool EhMenor(float valor, short valorComparado) => valor < valorComparado;
        public static bool EhMenor(float valor, ushort valorComparado) => valor < valorComparado;
        public static bool EhMenor(float valor, int valorComparado) => valor < valorComparado;
        public static bool EhMenor(float valor, uint valorComparado) => valor < valorComparado;
        public static bool EhMenor(float valor, long valorComparado) => valor < valorComparado;
        public static bool EhMenor(float valor, ulong valorComparado) => valor < 0 ? true : (ulong)valor < valorComparado;
        public static bool EhMenor(float valor, float valorComparado) => valor < valorComparado;
        public static bool EhMenor(float valor, double valorComparado) => (double)valor < valorComparado;
        public static bool EhMenor(float valor, decimal valorComparado) => (decimal)valor < valorComparado;

        public static bool EhMenor(double valor, sbyte valorComparado) => valor < valorComparado;
        public static bool EhMenor(double valor, byte valorComparado) => valor < valorComparado;
        public static bool EhMenor(double valor, short valorComparado) => valor < valorComparado;
        public static bool EhMenor(double valor, ushort valorComparado) => valor < valorComparado;
        public static bool EhMenor(double valor, int valorComparado) => valor < valorComparado;
        public static bool EhMenor(double valor, uint valorComparado) => valor < valorComparado;
        public static bool EhMenor(double valor, long valorComparado) => valor < valorComparado;
        public static bool EhMenor(double valor, ulong valorComparado) => valor < 0 ? true : (ulong)valor < valorComparado;
        public static bool EhMenor(double valor, float valorComparado) => (float)valor < valorComparado;
        public static bool EhMenor(double valor, double valorComparado) => valor < valorComparado;
        public static bool EhMenor(double valor, decimal valorComparado) => (decimal)valor < valorComparado;

        public static bool EhMenor(decimal valor, sbyte valorComparado) => valor < valorComparado;
        public static bool EhMenor(decimal valor, byte valorComparado) => valor < valorComparado;
        public static bool EhMenor(decimal valor, short valorComparado) => valor < valorComparado;
        public static bool EhMenor(decimal valor, ushort valorComparado) => valor < valorComparado;
        public static bool EhMenor(decimal valor, int valorComparado) => valor < valorComparado;
        public static bool EhMenor(decimal valor, uint valorComparado) => valor < valorComparado;
        public static bool EhMenor(decimal valor, long valorComparado) => valor < valorComparado;
        public static bool EhMenor(decimal valor, ulong valorComparado) => valor < 0 ? true : (ulong)valor < valorComparado;
        public static bool EhMenor(decimal valor, float valorComparado) => (float)valor < valorComparado;
        public static bool EhMenor(decimal valor, double valorComparado) => (double)valor < valorComparado;
        public static bool EhMenor(decimal valor, decimal valorComparado) => valor < valorComparado;

        public static bool EhMenor(DateTime valor, DateTime valorComparado) => valor <= valorComparado;

        //========================================================================================================================================

        public static bool EhFalso(bool valor) => valor == false;
        public static bool EhVerdadeiro(bool valor) => valor == true;

        //========================================================================================================================================  

        public static bool EhNulo(object valor) => valor == null;
        public static bool NaoEhNulo(object valor) => valor != null;
        public static bool EhNuloOuVazio(string valor) => String.IsNullOrEmpty(valor);
        public static bool NaoEhNuloOuVazio(string valor) => !String.IsNullOrEmpty(valor);
        public static bool Contem(string valor, string texto) => valor != null && texto != null && valor.Contains(texto);
        public static bool TamanhoIgual(string valor, int tamanho) => valor != null && valor.Length == tamanho;
        public static bool TamanhoDiferente(string valor, int tamanho) => valor != null && valor.Length != tamanho;
        public static bool TamanhoMaximo(string valor, int tamanhoMaximo) => valor != null && valor.Length <= tamanhoMaximo;
        public static bool TamanhoMinimo(string valor, int tamanhoMinimo) => valor != null && valor.Length >= tamanhoMinimo;
        public static bool EhUrl(string valor) => Uri.IsWellFormedUriString(valor, UriKind.Absolute);
        public static bool EhUrlOuVazio(string valor) => (Uri.IsWellFormedUriString(valor, UriKind.Absolute)) || (valor == "");
        public static bool EhEmail(string email) => email != null && Regex.IsMatch(email, @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
        public static bool EhEmailOrVazio(string email) => email != null && (Regex.IsMatch(email, @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$") || (email == ""));
    }
}