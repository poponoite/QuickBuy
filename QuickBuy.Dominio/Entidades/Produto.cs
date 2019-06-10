using System;
namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Decimal Preco { get; set; }

        public override void validate()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarMensagem("O nome do produto deve ser informado");
            }
        }
    }
}
