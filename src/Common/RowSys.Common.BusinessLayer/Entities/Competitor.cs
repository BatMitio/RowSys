using RowSys.Common.BusinessLayer.Entities.Abstract;

namespace RowSys.Common.BusinessLayer.Entities;

public class Competitor : Entity<int>
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public Team Team { get; set; }
}