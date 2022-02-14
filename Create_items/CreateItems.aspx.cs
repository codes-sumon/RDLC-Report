using Create_items.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Create_items
{
    public partial class Create_Items : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(!IsPostBack)
            {
                cleaarFild();
                LoadAllDroupDownList();
            }
        }

        private void cleaarFild()
        {
            txtItemCode.Text=txtID.Text = txtItemFullName.Text = txtItemShortName.Text =  "";
            ddlSize.SelectedIndex = ddlCatagory.SelectedIndex = ddlSubCatagory.SelectedIndex = -1;
            btnDelete.Visible = false;
            btnSubmit.Text = "Save Item";
            txtID.Text = "";
            DataTable dt = createItemManager.ShowItem();
            itemGridView.DataSource = dt;
            itemGridView.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            createItemInfo acreateItemInfo = createItemManager.getItemInfoDetails(txtID.Text);
            if (acreateItemInfo != null)
            {

                acreateItemInfo.itemCode = txtItemCode.Text;
                acreateItemInfo.itemFulName = txtItemFullName.Text;
                acreateItemInfo.itemShortName = txtItemShortName.Text;
                acreateItemInfo.sizeID = ddlSize.SelectedValue;
                acreateItemInfo.CatagryID = ddlCatagory.SelectedValue;
                acreateItemInfo.subCatagoryID = ddlSubCatagory.SelectedValue;

                int flag = createItemManager.updateItem(acreateItemInfo);
                if (flag == 1)
                {
                    cleaarFild();
                }
                else
                {

                }

            }
            else
            {
                acreateItemInfo = new createItemInfo();

                acreateItemInfo.itemCode = txtItemCode.Text;
                acreateItemInfo.itemFulName = txtItemFullName.Text;
                acreateItemInfo.itemShortName = txtItemShortName.Text;
                acreateItemInfo.sizeID = ddlSize.SelectedValue;
                acreateItemInfo.CatagryID = ddlCatagory.SelectedValue;
                acreateItemInfo.subCatagoryID = ddlSubCatagory.SelectedValue;
 
                createItemManager.saveItemInfo(acreateItemInfo);
                cleaarFild();
            }
              
        }


        protected void itemGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mstid = itemGridView.SelectedRow.Cells[1].Text;
            createItemInfo info = createItemManager.getItemInfoDetails(mstid);

            if(info != null)
            {
                txtID.Text = info.ID;
                txtItemCode.Text = info.itemCode;
                txtItemFullName.Text = info.itemFulName;
                txtItemShortName.Text = info.itemShortName;
                ddlSize.SelectedValue = info.sizeID;
                ddlCatagory.SelectedValue = info.CatagryID;
                ddlSubCatagory.SelectedValue = info.subCatagoryID;

                btnDelete.Visible = true;
                btnSubmit.Text = "Update Items";
            }

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != null)
            {
                createItemInfo acreateItemInfo = createItemManager.getItemInfoDetails(txtID.Text);
                if (acreateItemInfo != null)
                {

                    int flag = createItemManager.DeleteItemInfo(acreateItemInfo);
                    if (flag == 1)
                    {
                        cleaarFild();
                       
                    }
                    else
                    {

                    }

                }
                txtID.Text = null;
            }
        }


        public void LoadAllDroupDownList()
        {
            //Load Size Dropdown list
            ddlSize.DataSource = createItemManager.GetSize("C");
            ddlSize.DataValueField = "ID";
            ddlSize.DataTextField = "Name";
            ddlSize.DataBind();
            ddlSize.Items.Insert(0, "Select Size");
            ddlSize.SelectedIndex = -1;


            //Load Catagory Dropdown list
            ddlCatagory.DataSource = createItemManager.GetCatagory("C");
            ddlCatagory.DataValueField = "ID";
            ddlCatagory.DataTextField = "Name";
            ddlCatagory.DataBind();
            ddlCatagory.Items.Insert(0, "Select Catagory");
            ddlCatagory.SelectedIndex = -1;
        }

        protected void ddlCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlSubCatagory.Enabled = true;

            if (ddlCatagory.SelectedValue != "" && ddlCatagory.SelectedValue != null)
            {
                string catagoryID = ddlCatagory.SelectedValue;

                ddlSubCatagory.DataSource = createItemManager.GetSubCatagory(catagoryID);
                ddlSubCatagory.DataValueField = "ID";
                ddlSubCatagory.DataTextField = "Name";
                ddlSubCatagory.DataBind();
                ddlSubCatagory.Items.Insert(0, "Select Sub Catagory");
                ddlSubCatagory.SelectedIndex = -1;
            }

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            cleaarFild();
        }

    }
}

