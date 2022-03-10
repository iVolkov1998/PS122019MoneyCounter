using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public int Amount { get; set; }
        public string ShortName { get; set; }

        public int BackpackId { get; set; }
        public Backpack Backpack { get; set; }

    }
}
