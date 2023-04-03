using System;
using System.Collections.Generic;

namespace pizzaria33.Models;

public partial class Massa
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public decimal Preco { get; set; }

    public string Tamanho { get; set; } = null!;

    public virtual ICollection<Pizza> Pizzas { get; } = new List<Pizza>();
}
