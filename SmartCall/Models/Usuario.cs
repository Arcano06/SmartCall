using System;
using System.Collections.Generic;

namespace SmartCall.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string NomeCompleto { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string SenhaHash { get; set; } = null!;

    public int Cargo { get; set; }
}
