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
    public partial class adminviewfeedback : System.Web.UI.Page
    {
        concls obj = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                fn_grid();
            }
        }

        public void fn_grid()
        {
            string sel = "Select * from  Feedback_tb ";
            DataSet ds = obj.fn_dataset(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }


        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            int getid = Convert.ToInt32(e.CommandArgument);
            Session["fid"] = getid;

            string userid = "select User_Id from Feedback_tb where Feedback_Id=" + getid + "";
            SqlDataReader dr = obj.fn_reader(userid);
            int usid;
            while(dr.Read())
            {
                usid =Convert.ToInt32( dr["User_Id"].ToString());
                Session["uid"] = usid;
            }
    
            Response.Redirect("adminreplyfeedback.aspx");
        }
    }
    
}