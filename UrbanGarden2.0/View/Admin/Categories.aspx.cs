using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UrbanGarden2._0.View.Admin
{
    public partial class Categories : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowCategories();
        }

        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        private void ShowCategories()
        {
            string Query = "select *from CategoryTb1";
            CategoryGV.DataSource = Con.getaData(Query);
            CategoryGV.DataBind();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatNameTb.Value == "" || CatRemarkTb.Value == "")
                {
                    ErrMsg.InnerText = "Please complete all the fields";
                }
                else
                {
                    string CName = CatNameTb.Value;
                    string CRem = CatRemarkTb.Value;
                    
                    string Query = "insert into CategoryTb1 values('{0}','{1}')";
                    Query = string.Format(Query, CName, CRem);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.InnerText = "Category Added Successfully";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }
        
        protected void DeleteBtn_Click1(object sender, EventArgs e)
        {
            try
            {
                if (CatNameTb.Value == "")
                {
                    ErrMsg.InnerText = "Please complete all the fields";
                }
                else
                {
                    string CName = CatNameTb.Value;
                    
                    string Query = "delete from CategoryTb1 where CatId = {0}";
                    Query = string.Format(Query, CategoryGV.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.InnerText = "Category Deleted Successfully";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }

        int Key = 0;
        protected void CategoryGV_SelectedIndexChanged2(object sender, EventArgs e)
        {
            CatNameTb.Value = CategoryGV.SelectedRow.Cells[2].Text;
            CatRemarkTb.Value = CategoryGV.SelectedRow.Cells[3].Text;

            if (CatNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CategoryGV.SelectedRow.Cells[1].Text);
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (sellerPassTb.Value == "" || SEmailTb.Value == "" || SNameTb.Value == "" || PhoneTb.Value == "" || SellAddressTb.Value == "")
            //    {
            //        ErrMsg.InnerText = "Please complete all the fields";
            //    }
            //    else
            //    {
            //        string SName = SNameTb.Value;
            //        string SEmail = SEmailTb.Value;
            //        string Password = sellerPassTb.Value;
            //        string Phone = PhoneTb.Value;
            //        string Address = SellAddressTb.Value;

            //        string Query = "update SellerTb1 set Sellname = '{0}', SellEmail = '{1}', SellPassword = '{2}', SellPhone = '{3}', SellAddress = '{4}' where Sellid = {5}";
            //        Query = string.Format(Query, SName, SEmail, Password, Phone, Address, Convert.ToInt32(SellerGV.SelectedRow.Cells[1].Text));
            //        Con.SetData(Query);
            //        ShowSellers();
            //        ErrMsg.InnerText = "Category Updated Successfully";
            //    }
            //}
            //catch (Exception Ex)
            //{
            //    ErrMsg.InnerText = Ex.Message;
            //}
        }

        
    }
}