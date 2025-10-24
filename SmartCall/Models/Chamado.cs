using System;
using System.Collections.Generic;

namespace SmartCall.Models;

public partial class Chamado
{
    public int Id { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Categoria { get; set; }

    public string? Descricao { get; set; }

    public int Status { get; set; }

    public int CriadorId { get; set; }

    public int? TecnicoResponsavelId { get; set; }

    public DateTime CriadoEm { get; set; }

    public virtual ICollection<ChamadoMessage> ChamadoMessages { get; set; } = new List<ChamadoMessage>();
}
