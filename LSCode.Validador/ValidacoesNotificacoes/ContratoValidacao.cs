using LSCode.Validador.ValidacoesBooleanas;
using System;

namespace LSCode.Validador.ValidacoesNotificacoes
{
    /// <summary>Oferece validações e notificações caso exista inconsistências nas validações.</summary>
    public class ContratoValidacao : Notificadora
    {
        /// <summary>Construtor da classe ContratoValidacao.</summary>
        /// <returns> Cria uma instância da classe ContratoValidacao.</returns>
        public ContratoValidacao() { }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(sbyte valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(sbyte valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(sbyte valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(sbyte valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(sbyte valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(sbyte valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(sbyte valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(sbyte valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(sbyte valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(sbyte valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(byte valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(byte valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(byte valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(byte valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(byte valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(byte valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(byte valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(byte valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(byte valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(byte valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(byte valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(short valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(short valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(short valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(short valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(short valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(short valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(short valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(short valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(short valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(short valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(short valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(ushort valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(ushort valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(ushort valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(ushort valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(ushort valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(ushort valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(ushort valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(ushort valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(ushort valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(ushort valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(ushort valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(int valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(int valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(int valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(int valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(int valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(int valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(int valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(int valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(int valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(int valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(int valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(uint valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(uint valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(uint valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(uint valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(uint valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(uint valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(uint valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(uint valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(uint valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(uint valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(uint valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(long valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(long valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(long valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(long valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(long valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(long valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(long valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(long valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(long valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(long valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(long valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(ulong valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(ulong valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(ulong valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(ulong valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(ulong valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(ulong valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(ulong valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(ulong valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(ulong valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(ulong valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(ulong valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(float valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(float valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(float valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(float valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(float valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(float valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(float valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(float valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(float valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(float valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(float valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(double valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(double valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(double valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(double valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(double valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(double valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(double valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(double valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(double valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(double valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(double valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(decimal valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(decimal valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(decimal valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(decimal valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(decimal valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(decimal valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(decimal valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(decimal valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(decimal valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(decimal valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(decimal valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(bool valor, bool valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(string valor, string valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(string valor, Guid valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(Guid valor, Guid valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(Guid valor, string valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(object valor, object valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são iguais.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhIgual(DateTime valor, DateTime valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(sbyte valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(sbyte valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(sbyte valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(sbyte valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(sbyte valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(sbyte valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(sbyte valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(sbyte valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(sbyte valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(sbyte valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(sbyte valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(byte valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(byte valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(byte valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(byte valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(byte valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(byte valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(byte valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(byte valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(byte valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(byte valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(byte valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(short valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(short valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(short valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(short valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(short valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(short valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(short valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(short valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(short valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(short valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(short valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(ushort valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(ushort valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(ushort valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(ushort valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(ushort valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(ushort valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(ushort valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(ushort valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(ushort valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(ushort valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(ushort valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(int valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(int valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(int valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(int valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(int valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(int valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(int valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(int valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(int valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(int valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(int valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(uint valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(uint valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(uint valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(uint valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(uint valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(uint valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(uint valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(uint valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(uint valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(uint valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(uint valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(long valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(long valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(long valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(long valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(long valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(long valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(long valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(long valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(long valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(long valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(long valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(ulong valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(ulong valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(ulong valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(ulong valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(ulong valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(ulong valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(ulong valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(ulong valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(ulong valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(ulong valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(ulong valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(float valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(float valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(float valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(float valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(float valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(float valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(float valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(float valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(float valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(float valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(float valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(double valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(double valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(double valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(double valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(double valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(double valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(double valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(double valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(double valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(double valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(double valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(decimal valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(decimal valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(decimal valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(decimal valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(decimal valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(decimal valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(decimal valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(decimal valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(decimal valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(decimal valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(decimal valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(bool valor, bool valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(string valor, string valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(string valor, Guid valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(Guid valor, Guid valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(Guid valor, string valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(object valor, object valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se dois valores são diferentes.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiferente(DateTime valor, DateTime valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiferente(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(sbyte valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(sbyte valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(sbyte valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(sbyte valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(sbyte valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(sbyte valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(sbyte valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(sbyte valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(sbyte valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(sbyte valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(sbyte valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(byte valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(byte valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(byte valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(byte valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(byte valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(byte valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(byte valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(byte valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(byte valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(byte valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(byte valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(short valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(short valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(short valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(short valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(short valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(short valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(short valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(short valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(short valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(short valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(short valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(ushort valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(ushort valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(ushort valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(ushort valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(ushort valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(ushort valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(ushort valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(ushort valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(ushort valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(ushort valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(ushort valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(int valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(int valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(int valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(int valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(int valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(int valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(int valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(int valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(int valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(int valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(int valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(uint valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(uint valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(uint valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(uint valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(uint valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(uint valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(uint valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(uint valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(uint valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(uint valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(uint valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(long valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(long valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(long valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(long valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(long valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(long valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(long valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(long valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(long valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(long valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(long valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(ulong valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(ulong valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(ulong valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(ulong valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(ulong valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(ulong valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(ulong valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(ulong valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(ulong valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(ulong valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(ulong valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(float valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(float valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(float valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(float valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(float valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(float valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(float valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(float valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(float valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(float valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(float valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(double valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(double valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(double valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(double valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(double valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(double valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(double valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(double valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(double valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(double valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(double valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(decimal valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(decimal valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(decimal valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(decimal valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(decimal valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(decimal valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(decimal valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(decimal valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(decimal valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(decimal valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(decimal valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaiorOuIgual(DateTime valor, DateTime valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaiorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(sbyte valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(sbyte valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(sbyte valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(sbyte valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(sbyte valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(sbyte valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(sbyte valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(sbyte valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(sbyte valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(sbyte valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(sbyte valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(byte valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(byte valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(byte valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(byte valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(byte valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(byte valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(byte valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(byte valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(byte valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(byte valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(byte valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(short valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(short valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(short valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(short valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(short valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(short valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(short valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(short valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(short valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(short valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(short valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(ushort valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(ushort valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(ushort valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(ushort valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(ushort valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(ushort valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(ushort valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(ushort valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(ushort valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(ushort valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(ushort valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(int valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(int valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(int valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(int valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(int valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(int valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(int valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(int valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(int valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(int valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(int valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(uint valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(uint valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(uint valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(uint valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(uint valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(uint valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(uint valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(uint valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(uint valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(uint valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(uint valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(long valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(long valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(long valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(long valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(long valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(long valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(long valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(long valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(long valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(long valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(long valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(ulong valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(ulong valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(ulong valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(ulong valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(ulong valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(ulong valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(ulong valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(ulong valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(ulong valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(ulong valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(ulong valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(float valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(float valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(float valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(float valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(float valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(float valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(float valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(float valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(float valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(float valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(float valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(double valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(double valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(double valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(double valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(double valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(double valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(double valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(double valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(double valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(double valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(double valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(decimal valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(decimal valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(decimal valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(decimal valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(decimal valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(decimal valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(decimal valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(decimal valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(decimal valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(decimal valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(decimal valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é maior do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMaior(DateTime valor, DateTime valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMaior(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(sbyte valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(sbyte valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(sbyte valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(sbyte valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(sbyte valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(sbyte valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(sbyte valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(sbyte valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(sbyte valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(sbyte valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(sbyte valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(byte valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(byte valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(byte valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(byte valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(byte valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(byte valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(byte valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(byte valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(byte valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(byte valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(byte valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(short valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(short valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(short valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(short valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(short valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(short valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(short valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(short valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(short valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(short valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(short valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(ushort valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(ushort valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(ushort valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(ushort valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(ushort valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(ushort valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(ushort valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(ushort valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(ushort valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(ushort valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(ushort valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(int valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(int valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(int valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(int valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(int valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(int valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(int valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(int valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(int valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(int valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(int valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(uint valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(uint valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(uint valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(uint valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(uint valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(uint valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(uint valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(uint valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(uint valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(uint valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(uint valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(long valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(long valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(long valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(long valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(long valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(long valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(long valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(long valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(long valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(long valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(long valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(ulong valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(ulong valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(ulong valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(ulong valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(ulong valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(ulong valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(ulong valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(ulong valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(ulong valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(ulong valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(ulong valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(float valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(float valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(float valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(float valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(float valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(float valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(float valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(float valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(float valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(float valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(float valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(double valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(double valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(double valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(double valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(double valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(double valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(double valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(double valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(double valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(double valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(double valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(decimal valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(decimal valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(decimal valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(decimal valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(decimal valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(decimal valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(decimal valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(decimal valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(decimal valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(decimal valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(decimal valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor ou igual do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenorOuIgual(DateTime valor, DateTime valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenorOuIgual(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(sbyte valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(sbyte valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(sbyte valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(sbyte valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(sbyte valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(sbyte valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(sbyte valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(sbyte valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(sbyte valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(sbyte valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(sbyte valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(byte valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(byte valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(byte valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(byte valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(byte valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(byte valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(byte valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(byte valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(byte valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(byte valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(byte valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(short valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(short valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(short valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(short valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(short valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(short valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(short valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(short valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(short valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(short valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(short valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(ushort valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(ushort valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(ushort valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(ushort valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(ushort valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(ushort valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(ushort valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(ushort valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(ushort valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(ushort valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(ushort valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(int valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(int valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(int valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(int valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(int valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(int valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(int valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(int valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(int valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(int valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(int valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(uint valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(uint valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(uint valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(uint valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(uint valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(uint valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(uint valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(uint valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(uint valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(uint valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(uint valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(long valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(long valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(long valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(long valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(long valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(long valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(long valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(long valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(long valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(long valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(long valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(ulong valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(ulong valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(ulong valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(ulong valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(ulong valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(ulong valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(ulong valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(ulong valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(ulong valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(ulong valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(ulong valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(float valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(float valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(float valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(float valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(float valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(float valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(float valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(float valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(float valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(float valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(float valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(double valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(double valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(double valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(double valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(double valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(double valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(double valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(double valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(double valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(double valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(double valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(decimal valor, sbyte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(decimal valor, byte valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(decimal valor, short valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(decimal valor, ushort valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(decimal valor, int valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(decimal valor, uint valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(decimal valor, long valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(decimal valor, ulong valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(decimal valor, float valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(decimal valor, double valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(decimal valor, decimal valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é menor do que o valor comparado.</summary>
        /// <param name="valor">Primeiro valor que será comparado.</param>
        /// <param name="valorComparado">Segundo valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhMenor(DateTime valor, DateTime valorComparado, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhMenor(valor, valorComparado)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é falso.</summary>
        /// <param name="valor">Valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhFalso(bool valor, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhFalso(valor)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é verdadeiro.</summary>
        /// <param name="valor">Valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhVerdadeiro(bool valor, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhVerdadeiro(valor)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é nulo.</summary>
        /// <param name="valor">Valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhNulo(object valor, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhNulo(valor)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é não nulo.</summary>
        /// <param name="valor">Valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao NaoEhNulo(object valor, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.NaoEhNulo(valor)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor é nulo ou vazio.</summary>
        /// <param name="valor">Valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhNuloOuVazio(string valor, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhNuloOuVazio(valor)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor não é nulo ou vazio.</summary>
        /// <param name="valor">Valor que será comparado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao NaoEhNuloOuVazio(string valor, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.NaoEhNuloOuVazio(valor)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o valor contém um trecho de um texto.</summary>
        /// <param name="valor">Texto principal.</param>
        /// <param name="texto">Texto que será verificado se está contido no texto principal.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao Contem(string valor, string texto, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.Contem(valor, texto)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o tamanho do texto é igual ao tamanho esperado.</summary>
        /// <param name="valor">Texto.</param>
        /// <param name="tamanho">Tamanho esperado para o texto.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao TamanhoIgual(string valor, int tamanho, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.TamanhoIgual(valor, tamanho)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o tamanho do texto é diferente ao tamanho esperado.</summary>
        /// <param name="valor">Texto.</param>
        /// <param name="tamanho">Tamanho não esperado para o texto.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao TamanhoDiferente(string valor, int tamanho, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.TamanhoDiferente(valor, tamanho)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o tamanho máximo do texto foi atingido.</summary>
        /// <param name="valor">Texto.</param>
        /// <param name="tamanhoMaximo">Tamanho máximo esperado para o texto.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao TamanhoMaximo(string valor, int tamanhoMaximo, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.TamanhoMaximo(valor, tamanhoMaximo)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o tamanho mínimo do texto foi atingido.</summary>
        /// <param name="valor">Texto.</param>
        /// <param name="tamanhoMinimo">Tamanho mínimo esperado para o texto.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao TamanhoMinimo(string valor, int tamanhoMinimo, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.TamanhoMinimo(valor, tamanhoMinimo)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se a url é válida.</summary>
        /// <param name="valor">URL que será validada.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhUrl(string valor, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhUrl(valor)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se a url é válida ou vazia.</summary>
        /// <param name="valor">URL que será validada.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhUrlOuVazio(string valor, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhUrlOuVazio(valor)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o email é válido.</summary>
        /// <param name="email">Email que será validado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhEmail(string email, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhEmail(email)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se o email é válido ou vazio.</summary>
        /// <param name="email">Email que será validado.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhEmailOrVazio(string email, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhEmailOrVazio(email)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se a data é um dia de semana.</summary>
        /// <param name="data">Data que será validada.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhDiaDeSemana(DateTime data, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhDiaDeSemana(data)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }

        /// <summary>Efetua validação se a data é um final de semana.</summary>
        /// <param name="data">Data que será validada.</param>
        /// <param name="propriedade">Descritivo da propriedade que está sendo comparada.</param>
        /// <param name="mensagem">Mensagem de notificação caso a validação não seja True.</param>
        /// <returns>Contrato de validação. Caso a validação não seja True conterá notificações.</returns>
        /// <exception cref="Exception">Erro durante a validação.</exception>
        public ContratoValidacao EhFinalDeSemana(DateTime data, string propriedade, string mensagem)
        {
            if (ValidacaoBooleana.EhFinalDeSemana(data)) { return new ContratoValidacao(); } else { ContratoValidacao contratoValidacao = new ContratoValidacao(); contratoValidacao.AddNotificacao(propriedade, mensagem); return contratoValidacao; }
        }
    }
}