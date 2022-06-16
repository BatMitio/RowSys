using RowSys.Common.BusinessLayer.Entities.Abstract;

namespace RowSys.Common.BusinessLayer.Entities;

public class Discipline : Entity<int>
{
    public string Name { get; set; }
}