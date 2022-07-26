using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UrbanGarden2._0.View.Admin
{
    public partial class Sellers : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowSellers();
        }
        //
        public override void VerifyRenderingInServerForm(Control control)
        {
            
        }

        private void ShowSellers()
        {
            string Query = "select *from SellerTb1";
            SellerGV.DataSource = Con.getData(Query);
            SellerGV.DataBind();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sellerPassTb.Value == "" || SEmailTb.Value == "" || SNameTb.Value == "" || PhoneTb.Value == "" || SellAddressTb.Value == "")
                {
                    ErrMsg.InnerText = "Please complete all the fields";
                }
                else
                {
                    string SName = SNameTb.Value;
                    string SEmail = SEmailTb.Value;
                    string Password = sellerPassTb.Value;
                    string Phone = PhoneTb.Value;
                    string Address = SellAddressTb.Value;

                    string Query = "insert into SellerTb1 values('{0}','{1}','{2}','{3}','{4}')";
                    Query = string.Format(Query, SName, SEmail, Password, Phone, Address);
                    Con.SetData(Query);
                    ShowSellers();
                    ErrMsg.InnerText = "Seller Added Successfully";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }

        int Key = 0;
        protected void SellerGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            SNameTb.Value = SellerGV.SelectedRow.Cells[2].Text;
            SEmailTb.Value = SellerGV.SelectedRow.Cells[3].Text;
            sellerPassTb.Value = SellerGV.SelectedRow.Cells[4].Text;
            PhoneTb.Value = SellerGV.SelectedRow.Cells[5].Text;
            SellAddressTb.Value = SellerGV.SelectedRow.Cells[6].Text;
            if (SNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(SellerGV.SelectedRow.Cells[1].Text);
            }

        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sellerPassTb.Value == "" || SEmailTb.Value == "" || SNameTb.Value == "" || PhoneTb.Value == "" || SellAddressTb.Value == "")
                {
                    ErrMsg.InnerText = "Please complete all the fields";
                }
                else
                {
                    string SName = SNameTb.Value;
                    string SEmail = SEmailTb.Value;
                    string Password = sellerPassTb.Value;
                    string Phone = PhoneTb.Value;
                    string Address = SellAddressTb.Value;

                    string Query = "update SellerTb1 set Sellname = '{0}', SellEmail = '{1}', SellPassword = '{2}', SellPhone = '{3}', SellAddress = '{4}' where SellId = {5}";
                    Query = string.Format(Query, SName, SEmail, Password, Phone, Address, Convert.ToInt32(SellerGV.SelectedRow.Cells[1].Text));
                    Con.SetData(Query);
                    ShowSellers();
                    ErrMsg.InnerText = "Info Updated Successfully";
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
                if (sellerPassTb.Value == "" || SEmailTb.Value == "" || SNameTb.Value == "" || PhoneTb.Value == "" || SellAddressTb.Value == "")
                {
                    ErrMsg.InnerText = "Please complete all the fields";
                }
                else
                {
                    string SName = SNameTb.Value;
                    string SEmail = SEmailTb.Value;
                    string Password = sellerPassTb.Value;
                    string Phone = PhoneTb.Value;
                    string Address = SellAddressTb.Value;

                    string Query = "delete from SellerTb1 where Sellid = {0}";
                    Query = string.Format(Query, SellerGV.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowSellers();
                    ErrMsg.InnerText = "Seller Deleted Successfully";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }


    }
}