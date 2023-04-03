using System;
using System.Collections.Generic;

namespace pizzaria33.Models;

public partial class Pizza
{
    public int Id { get; set; }

    public int IdMassa { get; set; }

    public int IdBorda { get; set; }

    public virtual Borda IdBordaNavigation { get; set; } = null!;

    public virtual Massa IdMassaNavigation { get; set; } = null!;

    public virtual ICollection<Pedido> IdPedidos { get; } = new List<Pedido>();

    public virtual ICollection<Sabore> IdSabors { get; } = new List<Sabore>();
}
