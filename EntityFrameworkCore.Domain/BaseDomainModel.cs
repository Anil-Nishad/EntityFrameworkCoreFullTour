using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCore.Domain;

public abstract class BaseDomainModel
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public bool IsDeleted { get; set; } = false;

    [ConcurrencyCheck]
    public Guid Version { get; set; }

    //Use in SQL SERVER to handle concurrency
    //[Timestamp]
    //public byte[]? RowVersion { get; set; }
}

