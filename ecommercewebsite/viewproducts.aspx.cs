using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ecommercewebsite
{
    public partial class viewproducts : System.Web.UI.Page
    {
        concls obj = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string sel = "select * from Product_tb where Cat_Id=" + Session["catid"] + "";
                DataSet ds = obj.fn_dataset(sel);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
           
        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            int getid = Convert.ToInt32(e.CommandArgument);
            Session["proid"] = getid;

             Response.Redirect("productdetails.aspx");
        }
    }
}