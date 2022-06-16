using System.ComponentModel.DataAnnotations;
using RowSys.Common.BusinessLayer.Entities.Abstract;

namespace RowSys.Common.BusinessLayer.Entities;

public class Team : Entity<int>
{
    [Required]
    public string Name { get; set; }
}