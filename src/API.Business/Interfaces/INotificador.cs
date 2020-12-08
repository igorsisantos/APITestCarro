using System;
using System.Collections.Generic;
using System.Text;
using API.Business.Notificacoes;

namespace API.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
