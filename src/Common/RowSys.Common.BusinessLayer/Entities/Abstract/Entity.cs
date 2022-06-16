using System.ComponentModel.DataAnnotations;

namespace RowSys.Common.BusinessLayer.Entities.Abstract;

public abstract class Entity<T>
{
    [Key]
    public T Id { get; set; }
}