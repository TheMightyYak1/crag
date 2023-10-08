using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crag.Domain.Enums;

namespace crag.Domain.Entities;
public class Route
{
    public Guid RouteId { get; set; }
    public string Name { get; set; }
    public RouteType Type { get; set; }
    public int Grade { get; set; }
    public int Height { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }

}