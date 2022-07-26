using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UrbanGarden2._0.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
        }
        public static string Sname;
        public static int SKey;
        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        Models.Functions Con;

        protected void SaveBtn_Click1(object sender, EventArgs e)
        {
            if (AdminRadio.Checked)
            {
                if (EmailId.Value == "admin@gmail.com" && UserPasswordTb.Value == "admin")
                {
                    Response.Redirect("Admin/Sellers.aspx");
                    Session["id"] = EmailId.Value;
                }
                else
                {
                    infomsg.InnerText = "Invalid Admin";
                }
            }
            else
            {
                string Query = "select Sellid, SellName, SellEmail, SellPassword from SellerTb1 where SellEmail = '{0}' and SellPassword = '{1}'";
                Query = string.Format(Query, EmailId.Value, UserPasswordTb.Value);
                DataTable dt = Con.getData(Query);
                if (dt.Rows.Count == 0)
                {
                    infomsg.InnerText = "Invalid User";
                }
                else
                {
                    Sname = EmailId.Value;
                    SKey = Convert.ToInt32(dt.Rows[0][0].ToString());
                    Response.Redirect("Seller/Billing.aspx");
                    Session["id"] = EmailId.Value;
                    //Response.Redirect("Seller/Billin.aspx");
                }
            }
        }
    }
}