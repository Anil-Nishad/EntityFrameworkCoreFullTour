using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Domain;

public class Audit : BaseDomainModel
{
    public string? Action { get; set; }

    public string? TableName { get; set; }

    public DateTime DateTime { get; set; }

    public string? KeyValues { get; set; }

    public string? OldValues { get; set; }

    public string? NewValues { get; set; }
}
