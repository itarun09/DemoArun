using Demo.BO;
using Demo.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BL
{
  public  class ItemDetailsBL:IItemDetailsBL
    {
        private ItemDetails _ItemDetails;
        public ItemDetailsBL()
        {
            _ItemDetails = new ItemDetails();            


        }
        public bool SaveItem(string itemname, string itemdescription)
        {
            bool result = false;

            try
            {
                return _ItemDetails.SaveItem(itemname, itemdescription);
            }
            catch (Exception ex)
            {

            }
            return result;

        }

        public List<ItemListEntity> GetItemList()
        { 
            try
            {
                return _ItemDetails.GetItemList();
            }
            catch (Exception ex)
            {

            }
            return null;
           

        }
    }
}
