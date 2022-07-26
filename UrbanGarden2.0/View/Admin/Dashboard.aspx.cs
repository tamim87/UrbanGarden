using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UrbanGarden2._0.View.Admin
{
    public partial class Dashboard : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            GetProducts();
            GetCategory();
            //Soldsum();
            GetSellers();
            getSeller();
        }
        private void getSeller()
        {
            string Query = "Select *from SellerTb1";
            SellerCb.DataTextField = Con.getData(Query).Columns["SellName"].ToString();
            SellerCb.DataValueField = Con.getData(Query).Columns["SellId"].ToString();
            SellerCb.DataSource = Con.getData(Query);
            SellerCb.DataBind();
        }
        private void GetProducts()
        {
            string Query = "Select Count(*) from ProductTb1";
            PNumTb.InnerText= Con.getData(Query).Rows[0][0].ToString();
            //CategoryCb.DataValueField = Con.getData(Query).Columns["CatId"].ToString();
            //PNumTb.DataSource = Con.getData(Query);
            PNumTb.DataBind();
        }
        private void GetCategory()
        {
            string Query = "Select Count(*) CategoryTb1";
            CatNumTb.InnerText = Con.getData(Query).Rows[0][0].ToString();
            CatNumTb.DataBind();
        }
        private void GetSellers()
        {
            string Query = "Select Count(*) SellerTb1";
            SellNumTb.InnerText = Con.getData(Query).Rows[0][0].ToString();
            SellNumTb.DataBind();
        }

        private void Soldsum()
        {
            string Query = "Select Sum(Amount) from BillTb1";
            FinanceTb.InnerText = "Taka " + Con.getData(Query).Rows[0][0].ToString();
            FinanceTb.DataBind();
        }
        private void Soldsumbyseller()
        {
            string Query = "Select Sum(Amount) from BillTb1 where Seller= "+SellerCb.DataValueField+" ";
            TotalTb.InnerText = "Taka " + Con.getData(Query).Rows[0][0].ToString();
            TotalTb.DataBind();
        }

        protected void SellerCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Soldsumbyseller();
        }
    }
}