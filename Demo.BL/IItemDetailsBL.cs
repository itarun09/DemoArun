using Demo.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BL
{
    public interface IItemDetailsBL
    {
        bool SaveItem(string itemname, string itemdescription);
        List<ItemListEntity> GetItemList();
    }
}
