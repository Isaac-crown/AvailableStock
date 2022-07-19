using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks
{
    internal class Goods
    {

        
        

        public Goods()
        {

        }

        public int Id { get; set; }
        public string? Name { get; set; }    
        public int AvailableGoods { get; set; }

        public int Restock { get; set; }

        public int Sales { get; set; }
    }
}
