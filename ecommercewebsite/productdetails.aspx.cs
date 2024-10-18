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
    public partial class productdetails : System.Web.UI.Page
    {
        concls obj = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string sel = "select * from Product_tb where Product_Id=" + Session["proid"] + "";
                SqlDataReader dr = obj.fn_reader(sel);
                while (dr.Read())
                {
                     string price= dr["Product_Price"].ToString();
                    price = price.TrimStart('$');
                    Session["price"] = price;
                    Image1.ImageUrl = dr["Product_Image"].ToString();
                    Label1.Text = dr["Product_Name"].ToString();
                    Label2.Text = dr["Product_Price"].ToString();
                    Label3.Text = dr["Product_Desc"].ToString();
                }
            }
     
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "select max(Cart_Id) from Cart_tb";
            string id = obj.fn_scalar(s);
            int reg_id = 0;
            if (id == "")
            {
                reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(id);
                reg_id = newregid + 1;
               
            }
            int quantity = Convert.ToInt32(TextBox1.Text);
            decimal price = Convert.ToDecimal(Session["price"]);
            decimal totalprice = price * quantity;
            string ins = "insert into Cart_tb values(" + reg_id + "," + Session["uid"] + "," + Session["proid"] + "," + quantity + ","+"$"+totalprice+",'" + DateTime.Now.ToString("MM/dd/yyyy") + "')";
            int i = obj.fn_nonquery(ins);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("userhome.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewcart.aspx");
        }
    }
}