﻿using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string EnderecoCompleto { get; set; }

        public string NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }

        public virtual FormaPagamento FormaPagamento {get; set;}

        //Pedido deve ter pelo menos um pedido
        //ou muitos itens de pedidos
        public virtual ICollection<ItemPedido> ItensPedido { get; set; }
        

        public override void Validade()
        {
            LimparMensagensValidacao();

            if (ItensPedido.Any())
                AdicionarCritica("Crítica - Pedido não pode ficar sem item do pedido");

            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("Crítica - CEP deve estar preenchido");

        }
    }
}
