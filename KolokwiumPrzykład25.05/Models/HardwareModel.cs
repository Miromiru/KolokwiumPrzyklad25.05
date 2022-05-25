using KolokwiumPrzykład25._05.Entities;
using KolokwiumPrzykład25._05.Service;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumPrzykład25._05.Models
{
    public class HardwareModel
    {
        public HardwareModel()
        {
            var temp = new HardwareServicecs().GetHardware();
            Companies = new SelectList(temp, "Id", "Name");
        }
        public SelectList Companies { get; set; }
        public Hardware Hardware { get; set; }
    }
}
