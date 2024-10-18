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
    public partial class editproduct : System.Web.UI.Page
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
            string sel = "select * from Product_tb";
            DataSet ds = obj.fn_dataset(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            fn_grid();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            fn_grid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);

            TextBox prodname = (TextBox)GridView1.Rows[i].Cells[2].Controls[0];
            TextBox proddesc = (TextBox)GridView1.Rows[i].Cells[3].Controls[0];
            TextBox prodprice = (TextBox)GridView1.Rows[i].Cells[4].Controls[0];
            TextBox prodstock = (TextBox)GridView1.Rows[i].Cells[5].Controls[0];
            TextBox prodstatus = (TextBox)GridView1.Rows[i].Cells[7].Controls[0];

            string update = "update Product_tb set Product_Name='" + prodname.Text + "',Product_Desc='"+ proddesc.Text + "',Product_Price='"+prodprice.Text+"',Product_Stock='"+prodstock.Text+"',Product_Status='" + prodstatus.Text + "'";
            int up = obj.fn_nonquery(update);

            GridView1.EditIndex = -1;
            fn_grid();
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow rw = GridView1.Rows[e.NewSelectedIndex];
            Session["uid"] = rw.Cells[2].Text;
            Image1.ImageUrl = rw.Cells[7].Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/photos/addproduct/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));

            string up = "update Product_tb set Product_Image='" + p + "' where Product_Id=" + Session["uid"] + "";
            int upd = obj.fn_nonquery(up);
            if (upd == 1)
            {
                Label2.Visible = true;
                Label2.Text = "edited successfully";
            }
        }
    }
}