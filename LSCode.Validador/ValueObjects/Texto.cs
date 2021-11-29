using LSCode.Validador.ValidacoesNotificacoes;
using System;

namespace LSCode.Validador.ValueObjects
{
    /// <summary>Auxilia na utilização e validação de textos com tamanho máximo.</summary>
    public class Texto : Notificadora
    {
        /// <value>Texto.</value>
        public string Valor { get; private set; }

        /// <summary>Construtor da classe Texto.</summary>
        /// <param name="texto">Texto.</param>
        /// <param name="descritivo">Descritivo do texto.</param>
        /// <param name="tamanhoMaximo">Tamanho máximo do texto.</param>
        /// <returns>Cria uma instância da classe Texto.</returns>
        public Texto(string texto, string descritivo, int tamanhoMaximo)
        {
            try
            {
                Valor = texto;

                if (!string.IsNullOrWhiteSpace(Valor))
                    AddNotificacao(new ContratoValidacao().TamanhoMaximo(Valor, tamanhoMaximo, descritivo, $"{descritivo} deve conter no máximo {tamanhoMaximo} caracteres"));
                else
                    AddNotificacao(descritivo, $"{descritivo} não pode ser nulo ou vazio");
            }
            catch (Exception ex)
            {
                AddNotificacao(descritivo, $"Erro: {ex.Message}");
            }
        }

        /// <summary>Retorna texto.</summary>
        public override string ToString() => Valor;
    }
}