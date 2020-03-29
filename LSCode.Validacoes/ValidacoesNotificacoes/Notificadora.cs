using System.Collections.Generic;
using System.Linq;

namespace LSCode.Validacoes.ValidacoesNotificacoes
{
    public class Notificadora
    {
        public bool Invalido { get; private set; }
        public bool Valido { get; private set; }
        public IReadOnlyCollection<Notificacao> Notificacoes => _notificacoes.ToArray();
        private readonly IList<Notificacao> _notificacoes;

        protected Notificadora()
        {
            this._notificacoes = new List<Notificacao>();
            this.Invalido = false;
            this.Valido = true;
        }

        public void AddNotificacao(string propriedade, string mensagem)
        {
            Notificacao notificacao = new Notificacao(propriedade, mensagem);
            this._notificacoes.Add(notificacao);
            this.Invalido = true;
            this.Valido = false;
        }

        public void AddNotificacao(Notificacao notificacao)
        {
            this._notificacoes.Add(notificacao);
            this.Invalido = true;
            this.Valido = false;
        }

        public void AddNotificacao(IReadOnlyCollection<Notificacao> notificacoes)
        {
            if (notificacoes != null)
            {
                if (notificacoes.Count > 0)
                {
                    foreach (Notificacao notificacao in notificacoes)
                    {
                        this._notificacoes.Add(notificacao);
                        this.Invalido = true;
                        this.Valido = false;
                    }
                }
            }
        }

        public void AddNotificacao(IList<Notificacao> notificacoes)
        {
            if (notificacoes != null)
            {
                if (notificacoes.Count > 0)
                {
                    foreach (Notificacao notificacao in notificacoes)
                    {
                        this._notificacoes.Add(notificacao);
                        this.Invalido = true;
                        this.Valido = false;
                    }
                }
            }
        }

        public void AddNotificacao(ICollection<Notificacao> notificacoes)
        {
            if (notificacoes != null)
            {
                if (notificacoes.Count > 0)
                {
                    foreach (Notificacao notificacao in notificacoes)
                    {
                        this._notificacoes.Add(notificacao);
                        this.Invalido = true;
                        this.Valido = false;
                    }
                }
            }
        }

        public void AddNotificacao(Notificadora notificadora)
        {
            if (notificadora != null)
            {
                if (notificadora.Notificacoes != null)
                {
                    if (notificadora.Notificacoes.Count > 0)
                    {
                        foreach(Notificacao notificacao in notificadora.Notificacoes)
                        {
                            this._notificacoes.Add(notificacao);
                            this.Invalido = true;
                            this.Valido = false;
                        }
                    }
                }
            }
        }

        public void AddNotificacao(params Notificadora[] notificadoras)
        {
            if (notificadoras != null)
            {
                if (notificadoras.Count() > 0)
                {
                    foreach (Notificadora notificadora in notificadoras)
                    {
                        if (notificadora != null)
                        {
                            if (notificadora.Notificacoes.Count > 0)
                            {
                                foreach (Notificacao notificacao in notificadora.Notificacoes)
                                {
                                    this._notificacoes.Add(notificacao);
                                    this.Invalido = true;
                                    this.Valido = false;
                                }
                            }
                        }
                    }                    
                }
            }
        }

        protected virtual IEnumerable<Notificacao> Validacoes()
        {
            return this.Notificacoes;
        }
    }
}