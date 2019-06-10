using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagensValidacao { get; set; }
        public List<string> MensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }

        }
        public abstract void validate();

        public bool EhValido
        {
            get { return !MensagemValidacao.Any(); }
        }

        public void LimparMensagem()
        {
            MensagemValidacao.Clear();
        }
        public void AdicionarMensagem(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }

    }
}
