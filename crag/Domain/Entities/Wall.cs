using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crag.Domain.Entities;
public class Wall
{
    public Guid WallId { get; set; }
    public Guid CragId { get; set; }
    public string Name { get; set; }
    public DateTime Created { get; set; }
    public string Description { get; set; }
    public string Approach { get; set; }
}