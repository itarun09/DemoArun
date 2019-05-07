using Demo.BO;
using Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DL
{
   public class ItemDetails: IItemDetails
    {
        private DemoTestEntities _DBContext;

        public ItemDetails()
        {
            _DBContext = new DemoTestEntities();
        }
        public bool SaveItem(string itemname, string itemdescription)
        {
            bool result = false;
           
            try
            {
                ItemList objentity = new ItemList();
                objentity.ItemName = itemname;
                objentity.ItemDescription = itemdescription;
                objentity.CreatedDate = DateTime.Now;
                objentity.ItemStatus = true;
                _DBContext.ItemLists.Add(objentity);
                _DBContext.SaveChanges();
                result = true;
            }
            catch(Exception ex)
            {

            }
            return result;

        }

        public List<ItemListEntity> GetItemList()
        {
            List<ItemListEntity> objList = new List<ItemListEntity>();

            try
            {
                objList = (from P in _DBContext.ItemLists
                           select new ItemListEntity
                           {
                               ItemId = P.ItemId,
                               ItemName=P.ItemName,
                               ItemDesc=P.ItemDescription,
                               Status = (P.ItemStatus == true)?"Active":"InActive",
                               CreatedDate=P.CreatedDate

                           }
                         ).ToList();
            }
            catch (Exception ex)
            {

            }
            return objList;

        }
    }
}
