using System.Collections.Generic;
using System.Linq;

namespace LSCode.Validador.ValidacoesNotificacoes
{
    /// <summary>Auxilia no gerenciamento de notificações.</summary>
    public class Notificadora
    {
        /// <value>Indica se é inválido.</value>
        public bool Invalido { get; private set; }

        /// <value>Indica se é válido.</value>
        public bool Valido { get; private set; }

        /// <value>Lista de notificações.</value>
        public IReadOnlyCollection<Notificacao> Notificacoes => _notificacoes.ToList();
        private readonly IList<Notificacao> _notificacoes;

        /// <summary>Construtor da classe Notificadora.</summary>
        /// <returns> Cria uma instância da classe Notificadora.</returns>
        protected Notificadora()
        {
            _notificacoes = new List<Notificacao>();
            Invalido = false;
            Valido = true;
        }

        /// <summary>Adiciona uma notificação.</summary>
        /// <param name="propriedade">Propriedade da notificação.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        public void AddNotificacao(string propriedade, string mensagem)
        {
            _notificacoes.Add(new Notificacao(propriedade, mensagem));
            Invalido = true;
            Valido = false;
        }

        /// <summary>Adiciona uma notificação.</summary>
        /// <param name="notificacao">Notificação.</param>
        public void AddNotificacao(Notificacao notificacao)
        {
            _notificacoes.Add(notificacao);
            Invalido = true;
            Valido = false;
        }

        /// <summary>Adiciona uma lista de notificações.</summary>
        /// <param name="notificacoes">Lista de notificações.</param>
        public void AddNotificacao(IReadOnlyCollection<Notificacao> notificacoes)
        {
            if (notificacoes != null && notificacoes.Count > 0)
            {
                foreach (var notificacao in notificacoes)
                {
                    _notificacoes.Add(notificacao);
                    Invalido = true;
                    Valido = false;
                }
            }
        }

        /// <summary>Adiciona uma lista de notificações.</summary>
        /// <param name="notificacoes">Lista de notificações.</param>
        public void AddNotificacao(IList<Notificacao> notificacoes)
        {
            if (notificacoes != null && notificacoes.Count > 0)
            {
                foreach (var notificacao in notificacoes)
                {
                    _notificacoes.Add(notificacao);
                    Invalido = true;
                    Valido = false;
                }
            }
        }

        /// <summary>Adiciona uma lista de notificações.</summary>
        /// <param name="notificacoes">Lista de notificações.</param>
        public void AddNotificacao(ICollection<Notificacao> notificacoes)
        {
            if (notificacoes != null && notificacoes.Count > 0)
            {
                foreach (var notificacao in notificacoes)
                {
                    _notificacoes.Add(notificacao);
                    Invalido = true;
                    Valido = false;
                }
            }
        }

        /// <summary>Adiciona uma notificadora.</summary>
        /// <param name="notificadora">Notificadora.</param>
        public void AddNotificacao(Notificadora notificadora)
        {
            if (notificadora != null && notificadora.Notificacoes != null && notificadora.Notificacoes.Count > 0)
            {
                foreach (var notificacao in notificadora.Notificacoes)
                {
                    _notificacoes.Add(notificacao);
                    Invalido = true;
                    Valido = false;
                }
            }
        }

        /// <summary>Adiciona uma lista de notificadoras.</summary>
        /// <param name="notificadoras">Notificadoras.</param>
        public void AddNotificacao(params Notificadora[] notificadoras)
        {
            if (notificadoras != null && notificadoras.Count() > 0)
            {
                foreach (var notificadora in notificadoras)
                {
                    if (notificadora != null && notificadora.Notificacoes.Count > 0)
                    {
                        foreach (var notificacao in notificadora.Notificacoes)
                        {
                            _notificacoes.Add(notificacao);
                            Invalido = true;
                            Valido = false;
                        }
                    }
                }
            }
        }

        /// <summary>Retorna lista de notificações.</summary>
        protected virtual IEnumerable<Notificacao> ObterNotificacoes()
        {
            return Notificacoes;
        }
    }
}