using System;
using System.Collections.Generic;

namespace pizzaria33.Models;

public partial class Pedido
{
    public int Id { get; set; }

    public DateOnly Data { get; set; }

    public string FormaPagamento { get; set; } = null!;

    public string EnderecoEntrega { get; set; } = null!;

    public int IdStatus { get; set; }

    public virtual Status IdStatusNavigation { get; set; } = null!;

    public virtual ICollection<Pizza> IdPizzas { get; } = new List<Pizza>();
}
