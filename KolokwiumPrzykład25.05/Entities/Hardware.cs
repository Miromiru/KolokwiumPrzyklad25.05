using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumPrzykład25._05.Entities
{
    public class Hardware
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CompanyId { get; set; }
        public int Year { get; set; }
        public string Price { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
    }
}
