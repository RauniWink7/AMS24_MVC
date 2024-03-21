using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMS2A.ClassObject
{
/// <summary>
/// <author>Rauni</author>
/// </summary>

    public abstract class Veiculo
    {
        public int Id {get; set;}
        public int Year {get; set;}
        public string? Modelo {get; set;}
        public string? color {get; set;}
        public string? Brand {get; set;}
    }
}