using System;
using System.Collections.Generic;

namespace pizzaria33.Models;

public partial class Sabore
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Pizza> IdPizzas { get; } = new List<Pizza>();
}
