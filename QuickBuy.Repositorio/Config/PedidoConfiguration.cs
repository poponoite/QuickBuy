using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.DataPedido);

            builder.Property(p => p.DataEntrega);

            builder.Property(p => p.CEP).
                    IsRequired().
                    HasMaxLength(10);
            builder.Property(p => p.Estado).
                    IsRequired().
                    HasMaxLength(2);
            builder.Property(p => p.Cidade).
                   IsRequired().
                   HasMaxLength(100);
            builder.Property(p => p.EnderecoCompleto).
                   IsRequired().
                   HasMaxLength(200);

            builder.Property(p => p.NumeroEndereco).
                   IsRequired();

            builder.Property(p => p.FormaPagamento);

            builder.Property(p => p.UsuarioId)
                   .IsRequired();

            //builder.Property(p => p.FormaPagamentoId);
            // builder.Property(p => p.ItensPedido);

        }
    }
}
