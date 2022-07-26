using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UrbanGarden2._0.View.Admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            getCategories();
            ShowProducts();
        }

        private void getCategories()
        {
            string Query = "Select *from CategoryTb1";
            CategoryCb.DataTextField = Con.getData(Query).Columns["CatName"].ToString();
            CategoryCb.DataValueField = Con.getData(Query).Columns["CatId"].ToString();
            CategoryCb.DataSource = Con.getData(Query);
            CategoryCb.DataBind();
        }

        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        private void ShowProducts()
        {
            string Query = "select *from ProductTb1";
            ProductGV.DataSource = Con.getData(Query);
            ProductGV.DataBind();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PNameTb.Value == "" || CategoryCb.DataTextField == "" || PriceTb.Value == "" || ProductQtyTb.Value == "")
                {
                    ErrMsg.InnerHtml = "please complete all the fields";
                }
                else
                {
                    string PName = PNameTb.Value;
                    string PrCat = CategoryCb.SelectedValue;
                    string Price = PriceTb.Value;
                    string Qty = ProductQtyTb.Value;

                    string query = "insert into ProductTb1 values('{0}','{1}','{2}','{3}')";
                    query = string.Format(query, PName, PrCat, Price, Qty);
                    Con.SetData(query);
                    ShowProducts();
                    ErrMsg.InnerText = "Product added successfully";
                }
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PNameTb.Value == "" || CategoryCb.DataTextField == "" || PriceTb.Value == "" || ProductQtyTb.Value == "")
                {
                    ErrMsg.InnerHtml = "please complete all the fields";
                }
                else
                {
                    string PName = PNameTb.Value;
                    string PrCat = CategoryCb.SelectedValue;
                    string Price = PriceTb.Value;
                    string Qty = ProductQtyTb.Value;

                    string Query = "update ProductTb1 set PrName = '{0}', PrCat = '{1}', PrPrice = '{2}', PrQty = '{3}' where PrId = {4}";
                    Query = string.Format(Query, PName, PrCat, Price, Qty, ProductGV.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowProducts();
                    ErrMsg.InnerText = "Product Updated Successfully";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PNameTb.Value == "")
                {
                    ErrMsg.InnerText = "Please complete all the fields";
                }
                else
                {
                    string Query = "delete from ProductTb1 where PrId = {0}";
                    Query = string.Format(Query, ProductGV.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowProducts();
                    ErrMsg.InnerText = "Product Deleted Successfully";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }
        int Key = 0;
        protected void ProductGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            PNameTb.Value = ProductGV.SelectedRow.Cells[2].Text;
            CategoryCb.SelectedValue = ProductGV.SelectedRow.Cells[3].Text;
            PriceTb.Value = ProductGV.SelectedRow.Cells[4].Text;
            ProductQtyTb.Value = ProductGV.SelectedRow.Cells[5].Text;
            
            if (PNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ProductGV.SelectedRow.Cells[1].Text);
            }
        }
    }
}