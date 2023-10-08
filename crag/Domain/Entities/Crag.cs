using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crag.Domain.Entities;
public class Crag
{
    public Guid CragId { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string Name { get; set; }
    public DateTime Created { get; set; }
    public string Description { get; set; }
    public string Approach { get; set; }
}