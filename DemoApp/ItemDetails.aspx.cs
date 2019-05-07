using Demo.BL;
using Demo.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoApp
{
    public partial class ItemDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                BindData();
            }
        }

        protected void btncreate_Click(object sender, EventArgs e)
        {
            ItemDetailsBL objBL = new ItemDetailsBL();
            bool result = false;
            result= objBL.SaveItem(txtItem.Text.Trim(), txtDesc.Text.Trim());
            if (result) { lblmessage.Text = "Item Inserted"; BindData(); }
            else { lblmessage.Text = "Please try again"; }
        }

        public void BindData()
        {
            ItemDetailsBL objBL = new ItemDetailsBL();
            List<ItemListEntity> objList = new List<ItemListEntity>();
            objList = objBL.GetItemList();
            gridItem.DataSource = objList;
            gridItem.DataBind();


        }

        protected void gridItem_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gridItem.EditIndex = e.NewEditIndex;
            BindData();

        }

        protected void gridItem_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridItem.EditIndex = -1;
            BindData();
        }

        protected void gridItem_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int Itemid = Convert.ToInt32(gridItem.DataKeys[e.RowIndex].Value.ToString());
            TextBox txtcity = (TextBox)gridItem.Rows[e.RowIndex].FindControl("txtCustomerIdedit");
            TextBox txtDesignation = (TextBox)gridItem.Rows[e.RowIndex].FindControl("txtNameedit");
        }
    }
}