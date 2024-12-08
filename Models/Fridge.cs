using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeKoelkast.Models
{
    public class Fridge
    {
        public string Name { get; set; }
        public Dictionary<string, int> Inventory { get; set; }
    }
}
