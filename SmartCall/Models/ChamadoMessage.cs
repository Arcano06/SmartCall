using System;
using System.Collections.Generic;

namespace SmartCall.Models;

public partial class ChamadoMessage
{
    public int Id { get; set; }

    public int ChamadoId { get; set; }

    public int AutorId { get; set; }

    public string Conteudo { get; set; } = null!;

    public DateTime CriadoEm { get; set; }

    public virtual Chamado Chamado { get; set; } = null!;
}
