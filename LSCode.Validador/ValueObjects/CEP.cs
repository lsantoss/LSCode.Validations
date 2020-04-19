﻿using LSCode.Validador.ValidacoesNotificacoes;
using System.Text.RegularExpressions;

namespace LSCode.Validador.ValueObjects
{
    public class CEP : Notificadora
    {
        public string Valor { get; private set; }

        public CEP(string valor)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao().EhVerdadeiro(Validar(Valor), "CEP", "CEP inválido"));
        }

        public bool Validar(string cep)
        {
            return Regex.IsMatch(cep, @"^\d{5}\-?\d{3}$");
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}