using System;
using System.Collections.Generic;

namespace pizzaria33.Models;

public partial class Borda
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Pizza> Pizzas { get; } = new List<Pizza>();
}
