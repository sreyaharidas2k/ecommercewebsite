using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ecommercewebsite
{
    public partial class Login1 : System.Web.UI.Page
    {
        concls obj = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select count(Reg_Id) from Login_tb where Username='" + TextBox1.Text + "'and password='" + TextBox2.Text + "'";
            string id = obj.fn_scalar(sel);
            if (id == "1")
            {
                string selid = "select Reg_Id from Login_tb where Username='" + TextBox1.Text + "'and password='" + TextBox2.Text + "'";
                SqlDataReader dr = obj.fn_reader(selid);
                int getid = 0;
                while (dr.Read())
                {
                    getid = Convert.ToInt32(dr["Reg_Id"].ToString());
                }
                Session["uid"] = getid;

                string str = "select Log_Type from Login_tb where Username='" + TextBox1.Text + "'and password='" + TextBox2.Text + "'";
                string logtype = obj.fn_scalar(str);
                if (logtype == "Admin")
                {
                    Response.Redirect("adminhome.aspx");
                }
                else if (logtype == "User")
                {
                    Response.Redirect("userhome.aspx");
                }
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "invalid user";
            }
            

           
        }
    }
}