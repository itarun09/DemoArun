using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BO
{
    public class ItemListEntity
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemDesc { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
