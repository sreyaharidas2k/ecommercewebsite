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
    public partial class userfeedback : System.Web.UI.Page
    {
        concls obj = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ins = "insert into Feedback_tb values(" + Session["uid"] + ",'" + TextBox1.Text + "','',0)";
            int insert = obj.fn_nonquery(ins);
        }
    }
}