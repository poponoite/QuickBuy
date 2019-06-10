using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public int ProdutoId { get; set; }

        public override void validate()
        {
            if(Quantidade == 0)
            {
                AdicionarMensagem("Favor informa a quantidade !");
            }
        }
    }
}
