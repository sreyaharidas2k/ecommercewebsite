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
    public partial class addproduct : System.Web.UI.Page
    {
        concls obj = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string sel = "select Cat_Id,Cat_Name from Category_tb";
                DataSet s = obj.fn_dataset(sel);
                DropDownList1.DataSource = s;
                DropDownList1.DataTextField = "Cat_Name";
                DropDownList1.DataValueField = "Cat_Id";
                DropDownList1.DataBind();
            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/photos/addproduct/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));

            string ins = "insert into Product_tb values("+DropDownList1.SelectedItem.Value+",'" + TextBox1.Text + "','" + TextBox2.Text + "','" +TextBox3.Text+ "','" + p + "','"+TextBox4.Text+"','In Stock')";
            int insert = obj.fn_nonquery(ins);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("editproduct.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}