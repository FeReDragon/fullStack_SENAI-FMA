using System;
using System.Collections.Generic;

namespace pizzaria33.Models;

public partial class Status
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; } = new List<Pedido>();
}
