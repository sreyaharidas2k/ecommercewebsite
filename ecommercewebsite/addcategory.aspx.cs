using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ecommercewebsite
{
    public partial class addcategory : System.Web.UI.Page
    {
        concls obj = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/photos/addcategory/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));

            string ins = "insert into Category_tb values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + p + "','Active')";
            int insert= obj.fn_nonquery(ins);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("editcategory.aspx");
        }
    }
}