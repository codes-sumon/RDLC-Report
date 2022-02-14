using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Create_items.AppCode
{
    public class createItemInfo
    {

        public createItemInfo()
        {
            //
            // TODO: Add constructor logic here
            //
        }



        public createItemInfo(DataRow dr)
        {
            if (dr["id"].ToString() != String.Empty)
            {
                this.ID = dr["id"].ToString();
            }
            if (dr["itemCode"].ToString() != String.Empty)
            {
                this.itemCode = dr["itemCode"].ToString();
            }
            if (dr["itemName"].ToString() != String.Empty)
            {
                this.itemFulName = dr["itemName"].ToString();
            }
            if (dr["itemShortName"].ToString() != String.Empty)
            {
                this.itemShortName = dr["itemShortName"].ToString();
            }
            if (dr["SizeID"].ToString() != String.Empty)
            {
                this.sizeID = dr["SizeID"].ToString();
            }
            if (dr["CategoryID"].ToString() != String.Empty)
            {
                this.CatagryID = dr["CategoryID"].ToString();
            }
            if (dr["subCategoryID"].ToString() != String.Empty)
            {
                this.subCatagoryID = dr["subCategoryID"].ToString();
            }
        }

        public string itemCode { get; set; }
        public string itemFulName { get; set; }
        public string itemShortName { get; set; }
        public string ID { get; set; }


        public string sizeID { get; set; }

        public string subCatagoryID { get; set; }

        public string CatagryID { get; set; }
    }

}