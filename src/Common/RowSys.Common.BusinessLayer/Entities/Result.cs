using System.ComponentModel.DataAnnotations;
using RowSys.Common.BusinessLayer.Entities.Abstract;

namespace RowSys.Common.BusinessLayer.Entities;

public class Result : Entity<int>
{
    [Required]
    public Competitor Competitor { get; set; }
    [Required]
    public Competition Competition { get; set; }
    [Required]
    public Discipline Discipline { get; set; }
    public double? Time { get; set; }
}