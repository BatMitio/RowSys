using RowSys.Common.BusinessLayer.Entities.Abstract;

namespace RowSys.Common.BusinessLayer.Entities;

public class Competition : Entity<int>
{
    public string Name { get; set; }
    public DateTime Date { get; set; }
}